﻿using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using Vixen.Module;
using VixenModules.App.ColorGradients;
using VixenModules.App.Curves;
using VixenModules.Effect.Pixel;
using ZedGraph;

namespace VixenModules.Effect.Bars
{
	[DataContract]
	public class BarsData: ModuleDataModelBase
	{

		public BarsData()
		{
			Colors = new List<ColorGradient>{new ColorGradient(Color.Red), new ColorGradient(Color.Lime), new ColorGradient(Color.Blue)};
			Direction = BarDirection.Up;
			Speed = 5;
			Repeat = 1;
			FitToTime = true;
			LevelCurve = new Curve(new PointPairList(new[] { 0.0, 100.0 }, new[] { 100.0, 100.0 }));
			Orientation=StringOrientation.Vertical;
		}

		[DataMember]
		public List<ColorGradient> Colors { get; set; }

		[DataMember]
		public BarDirection Direction { get; set; }

		[DataMember]
		public int Speed { get; set; }

		[DataMember]
		public int Repeat { get; set; }

		[DataMember]
		public bool Highlight { get; set; }

		[DataMember]
		public bool Show3D { get; set; }

		[DataMember]
		public bool FitToTime { get; set; }

		[DataMember]
		public Curve LevelCurve { get; set; }

		[DataMember]
		public StringOrientation Orientation { get; set; }

		public override IModuleDataModel Clone()
		{
			BarsData result = new BarsData
			{
				Colors = Colors.ToList(),
				Direction = Direction,
				Speed = Speed,
				Repeat = Repeat,
				Orientation = Orientation,
				Show3D = Show3D,
				Highlight = Highlight,
				FitToTime = FitToTime
			};
			return result;
		}
	}
}
