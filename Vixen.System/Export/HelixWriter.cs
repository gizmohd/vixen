﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Vixen.Module.Controller;
using Vixen.Sys;
using Vixen.Execution;
using Vixen.Commands;


namespace Vixen.Export
{
    public class HelixWriter : IExportWriter
    {
        private Vix2XMLData _xmlData;
        private Byte[] _periodData;
        private int _curPeriod;
        SequenceSessionData _sessionData;
        private FileStream _outfs = null;
        private int _adder;

        public int SeqPeriodTime { get; set; }
        
        public void WriteFileHeader()
        {

        }
        
        public void WriteFileFooter()
        {

        }

        public void OpenSession(SequenceSessionData sessionData)
        {

            _curPeriod = 0;
            _sessionData = sessionData; 
            try
            {
                _outfs = File.Create(_sessionData.OutFileName, _sessionData.ChannelNames.Count * 2, FileOptions.None);
            }
            catch (Exception )
            {
                _outfs = null;
                throw ;
            }
			_xmlData = new Vix2XMLData();
            _xmlData.Channels = new List<Vix2Channel>();

            _xmlData.Time = _sessionData.TimeMS.ToString();

            _xmlData.EventPeriodInMilliseconds = _sessionData.PeriodMS.ToString();

            _adder = 0;
            if (_sessionData.TimeMS % _sessionData.PeriodMS != 0)
            {
                _adder = 1;
            }

            _periodData = new Byte[sessionData.ChannelNames.Count * (_sessionData.NumPeriods + _adder)];

            _xmlData.MinimumLevel = "0";
            _xmlData.MaximumLevel = "255";
            _xmlData.AudioDevice = "-1";
            _xmlData.AudioVolume = "0";
            

        }

        public void WriteNextPeriodData(List<Byte> periodData)
        {
            int numPeriods =  _sessionData.NumPeriods + _adder;

            for (int j = 0; j < periodData.Count; j++)
            {
                _periodData[(j * numPeriods) + _curPeriod] = periodData[j];
            }

            _curPeriod++;
        }

        public void CloseSession()
        {
            int count = 0;
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = false;
            settings.IndentChars = "    ";
            settings.Indent = true;
            
            XmlWriter writer =  XmlWriter.Create(_outfs, settings);


            XmlSerializerNamespaces n = new XmlSerializerNamespaces();
            n.Add("", "");

            _xmlData.EventValues = Convert.ToBase64String(_periodData);

            Vix2Channel tempChannel;
 
            foreach (string channelName in _sessionData.ChannelNames)
            {
                tempChannel = new Vix2Channel() 
                { 
                    name = channelName, 
                    id = count, 
                    output = count, 
                    enabled = true, 
                    color = -1
                };
                count++;
                _xmlData.Channels.Add(tempChannel);
            }

            if (_sessionData.AudioFileName.Length > 0)
            {
                _xmlData.Audio = new Vix2Audio();
                _xmlData.Audio.filename = Path.GetFileName(_sessionData.AudioFileName);
                _xmlData.Audio.duration = _sessionData.PeriodMS.ToString();
                _xmlData.Audio.Value = _xmlData.Audio.filename;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(Vix2XMLData));
            serializer.Serialize(writer, _xmlData, n);
            

            try
            {
                _outfs.Close();
                _outfs = null;

            }
            catch (Exception )
            {
                _outfs = null;
                throw ;
            }

        }
        public string FileType
        {
            get
            {
                return "vix";
            }
        }

        public string FileTypeDescr
        {
            get
            {
                return "Helix File";
            }
        }
    }

}
