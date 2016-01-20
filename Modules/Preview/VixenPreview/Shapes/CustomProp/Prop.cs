﻿using Polenter.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vixen.Sys;

namespace VixenModules.Preview.VixenPreview.Shapes.CustomProp
{
	public class Prop
	{
		private Panel _panel;
		private int _width;
		private int _height;
		public Square[,] Squares { get; set; }

		public Prop() { }

		public Prop(Panel panel, int width, int height)
		{

			_panel = panel;
			_width = width;
			_height = height;
			GenerateGrid();
		}

		public Prop(Panel panel, Prop obj)
		{
			_panel = panel;
			this.Name = obj.Name;
			Channels = obj.Channels;
			this.Height = obj.Height;
			this.Width = obj.Width;
			GenerateGrid(obj.Squares);

		}

		public void UpdateGrid(int height, int width)
		{
			_width = width;
			_height = height;
			GenerateGrid(this.Squares);
		}

		private void GenerateGrid(Square[,] squares = null)
		{
			Panel.Enabled = true;

			if (Squares != null)
				foreach (Square s in Squares)
				{
					s.RemoveEvents();
				}

			Panel.Controls.Clear();
			Panel.SuspendLayout();
			Panel.Parent.SuspendLayout();
			Squares = new Square[Width, Height];

			for (int x = 0; x < Width; x++)
			{
				for (int y = 0; y < Height; y++)
				{
					Square s;
					if (squares != null)
					{
						try  //For now brute force..eventually check to ensure the matrix has the requested value...
						{
							s = new Square(this, squares[x, y].X, squares[x, y].Y, squares[x, y].ChannelID);
						}
						catch (Exception)
						{
							s = new Square(this, x, y);
						}

					}
					else
						s = new Square(this, x, y);

					Squares[x, y] = s;
				}
			}

			Panel.ResumeLayout();
			Panel.Parent.ResumeLayout();
		}
		public static Prop FromFile(string fileName)
		{
			var serializer = new SharpSerializer();
			try
			{
				return serializer.Deserialize(fileName) as Prop;
			}
			catch
			{
			}
			return null;

		}


		public DisplayItem ToDisplayItem()
		{
			//Theres got to be a better way to do this... LOL
			return (DisplayItem)PreviewTools.DeSerializeToDisplayItem(PreviewTools.SerializeToString(new PreviewCustomProp(new PreviewPoint(10, 10), null, 1, this)), typeof(DisplayItem));
		}


		public List<Square> GetSelectedSquares()
		{
			int width = Squares.GetLength(0);
			int height = Squares.GetLength(1);
			List<Square> ret = new List<Square>(width * height);
			Parallel.For(0, width, a =>
			{
				Parallel.For(0, height, b =>
				{
					if (Squares[a, b].ChannelID > 0) ret.Add(Squares[a, b]);
				});
			});

			return ret.OrderBy(a => a.X).ThenBy(b => b.Y).ToList();
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

		public Panel Panel
		{
			get { return (this._panel); }
		}

		[ExcludeFromSerialization]
		public int SelectedChannelId { get; set; }

		[ExcludeFromSerialization]
		public string SelectedChannelName { get; set; }


	}
}
