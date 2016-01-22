﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vixen.Sys;

namespace VixenModules.Preview.VixenPreview.Shapes.CustomProp
{
	public class Prop
	{

		private int _width;
		private int _height;

		public DataTable Data { get; set; }
		private DataGridView _dataGrid;
		public Prop()
		{
			Channels = new List<PropChannel>();
		}

		public Prop(DataGridView dataGrid, int width, int height)
		{

			_dataGrid = dataGrid;
			_width = width;
			_height = height;
			GenerateGrid();
		}

		public Prop(Prop obj)
		{

			this.Name = obj.Name;
			Channels = obj.Channels;
			this.Height = obj.Height;
			this.Width = obj.Width;
			GenerateGrid();

		}

		public void UpdateGrid(int height, int width)
		{
			_width = width;
			_height = height;
			GenerateGrid();
		}

		private void GenerateGrid()
		{
			if (Data == null) Data = new DataTable();
			while (Data.Rows.Count < _height)
			{
				Data.Rows.Add(Data.NewRow());
			}
			while (Data.Rows.Count > _height)
			{
				Data.Rows.RemoveAt(Data.Rows.Count - 1);
			}
			while (Data.Columns.Count < _width)
			{
				DataColumn column = new DataColumn();

				Data.Columns.Add();
			}
			while (Data.Columns.Count > _width)
			{
				Data.Columns.RemoveAt(Data.Columns.Count - 1);
			}

		}



		public static Prop FromFile(string fileName)
		{
			Prop output = new Prop();
			using (var fs = new FileStream(fileName, FileMode.Open))
			{
				using (var sr = new StreamReader(fs))
				{
					while (!sr.EndOfStream)
					{
						var line = sr.ReadLine();
						if (!string.IsNullOrWhiteSpace(line) && !line.StartsWith("#"))
						{
							var splits = line.Split(',');
							switch ((FileLineType)Convert.ToInt32(splits[0]))
							{
								case FileLineType.DefinitionRow:
									output.Height = Convert.ToInt32(splits[1]);
									output.Width = Convert.ToInt32(splits[2]);
									output.Name = splits[3] as string;
									output.GenerateGrid();
									break;
								case FileLineType.ChannelRow:
									var propChannel = new PropChannel();
									propChannel.ID = Convert.ToInt32(splits[1]);
									propChannel.Text = splits[2] as string;
									propChannel.ItemColor = new Common.Controls.ColorManagement.ColorModels.XYZ(Convert.ToInt32(splits[3]), Convert.ToInt32(splits[4]), Convert.ToInt32(splits[5]));

									output.Channels.Add(propChannel);
									break;

								case FileLineType.GridRow:
									int rowIndex = Convert.ToInt32(splits[1]) - 1;
									for (int i = 2; i < splits.Length; i++)
									{
										if (!string.IsNullOrWhiteSpace(splits[i] as string))
										{
											output.Data.Rows[rowIndex][i - 2] = Convert.ToInt32(splits[i]);
										}
									}
									break;
								default:
									break;
							}
						}
					}
				}
			}
			return output;
		}


		public void ToFile(string fileName)
		{
			using (var fs = new FileStream(fileName, FileMode.Create))
			{
				using (var sw = new StreamWriter(fs))
				{
					int channelCount = Channels == null ? 0 : Channels.Count();
					//Write File Definition First
					sw.WriteLine("#");
					sw.WriteLine("#File Definition:");
					sw.WriteLine("#{0},{1},{2},{3},{4}", (int)FileLineType.DefinitionRow, "Height", "Width", "Name", "ChannelCount");
					sw.WriteLine("#");
					sw.WriteLine("{0},{1},{2},{3},{4}", (int)FileLineType.DefinitionRow, Height, Width, Name, channelCount);
					//Write the Channel Information
					sw.WriteLine("#");
					sw.WriteLine("#Channel Definitions:");
					sw.WriteLine("#{0},{1},{2},{3},{4},{5}", (int)FileLineType.ChannelRow, "Channel ID", "Text", "ItemColor.X", "ItemColor.Y", "ItemColor.Z");

					if (Channels != null)
					{
						Channels.OrderBy(o => o.ID).ToList()
							   .ForEach(c =>
							   {
								   sw.WriteLine("{0},{1},{2},{3},{4},{5}", (int)FileLineType.ChannelRow, c.ID, c.Text, c.ItemColor.X, c.ItemColor.Y, c.ItemColor.Z);
							   });
					}
					sw.WriteLine("#");
					sw.WriteLine("#Column Definitions:");
					sw.WriteLine("#{0},{1},..... (One Column for each column in the Grid)", (int)FileLineType.GridRow, "Row Number");
					sw.WriteLine("#");
					if (Data != null)
					{

						foreach (DataRow row in Data.Rows)
						{
							sw.Write("{0},{1}", (int)FileLineType.GridRow, Data.Rows.IndexOf(row) + 1);
							for (int i = 0; i < Data.Columns.Count; i++)
							{
								sw.Write(",{0}", row[i]);
							}
							sw.WriteLine();
						}
					}
				}
			}

		}

		public enum FileLineType
		{
			DefinitionRow = 0,
			ChannelRow = 1,
			GridRow = 2
		}

		public DisplayItem ToDisplayItem()
		{
			//Theres got to be a better way to do this... LOL
			return (DisplayItem)PreviewTools.DeSerializeToDisplayItem(PreviewTools.SerializeToString(new PreviewCustomProp(new PreviewPoint(10, 10), null, 1, this)), typeof(DisplayItem));
		}



		public int Height
		{
			set { _height = value; }
			get { return (this._height); }
		}


		public int Width
		{
			set { this._width = value; }
			get { return (this._width); }
		}

		public string Name { get; set; }

		public List<PropChannel> Channels { get; set; }


		public int SelectedChannelId { get; set; }

		public string SelectedChannelName { get; set; }


	}
}
