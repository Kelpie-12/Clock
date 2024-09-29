using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System;

namespace Clock
{
	public class RoundButton : Button
	{
		private int borderSize = 0;
		private int borderRadius = 20;
		private Color borderColor = Color.PaleVioletRed;
		public int BorderSize
		{
			get { return borderSize; }
			set
			{
				borderSize = value;
				this.Invalidate();
			}
		}
		public int BorderRadius
		{
			get { return borderRadius; }
			set
			{
				borderRadius = value;
				this.Invalidate();
			}
		}
		public Color BorderColor
		{
			get { return borderColor; }
			set
			{
				borderColor = value;
				this.Invalidate();
			}
		}
		public Color BackgroundColor
		{
			get { return this.BackColor; }
			set { this.BackColor = value; }
		}
		public Color TextColor
		{
			get { return this.ForeColor; }
			set { this.ForeColor = value; }
		}
		public RoundButton()
		{
			this.FlatStyle = FlatStyle.Flat;
			this.FlatAppearance.BorderSize = 0;
			this.Size = new Size(150, 40);
			this.BackColor = Color.MediumSlateBlue;
			this.ForeColor = Color.White;
			this.Resize += new EventHandler(Button_Resize);
		}
		private void Button_Resize(object sender, EventArgs e)
		{
			if (borderRadius > this.Height)
				borderRadius = this.Height;
		}
		private GraphicsPath GetFigurePath(Rectangle rect, float radius)
		{
			GraphicsPath path = new GraphicsPath();
			float curveSize = radius * 2F;
			path.StartFigure();
			path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
			path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
			path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
			path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
			path.CloseFigure();
			return path;
		}
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);

			Rectangle rectSurface = this.ClientRectangle;
			Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
			int smoothSize = 2;
			if (borderSize > 0)
				smoothSize = borderSize;

			if (borderRadius > 2) //Rounded button
			{
				using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
				using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
				using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
				using (Pen penBorder = new Pen(borderColor, borderSize))
				{
					pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
					//Button surface
					this.Region = new Region(pathSurface);
					//Draw surface border for HD result
					pevent.Graphics.DrawPath(penSurface, pathSurface);

					//Button border                    
					if (borderSize >= 1)
						//Draw control border
						pevent.Graphics.DrawPath(penBorder, pathBorder);
				}
			}
			else //Normal button
			{
				pevent.Graphics.SmoothingMode = SmoothingMode.None;
				//Button surface
				this.Region = new Region(rectSurface);
				//Button border
				if (borderSize >= 1)
				{
					using (Pen penBorder = new Pen(borderColor, borderSize))
					{
						penBorder.Alignment = PenAlignment.Inset;
						pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
					}
				}
			}
		}
		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
		}

		private void Container_BackColorChanged(object sender, EventArgs e)
		{
			this.Invalidate();
		}
		//private StringFormat SF = new StringFormat();
		//private bool MouseEntered = false;
		//private bool MousePressed = false;
		//public int RoundSize { get; set; } = 50;
		//public RoundButton()
		//{			
		//	//FlatStyle=FlatStyle.Flat;
		//	//FlatAppearance.BorderSize = 0;

		//	SetStyle
		//		(				
		//		ControlStyles.AllPaintingInWmPaint |
		//		ControlStyles.OptimizedDoubleBuffer |
		//		ControlStyles.ResizeRedraw |
		//		ControlStyles.SupportsTransparentBackColor |
		//		ControlStyles.UserPaint,
		//		true
		//		);
		//	DoubleBuffered = true;

		//}
		//protected override void OnPaint(PaintEventArgs e)
		//{
		//	base.OnPaint(e);
		//	Graphics g = e.Graphics;
		//	g.Clear(Parent.BackColor);
		//	g.SmoothingMode = SmoothingMode.HighQuality;			

		//	Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
		//	if (RoundSize <= 0)
		//		RoundSize = 1;
		//	GraphicsPath rectGp = RoundedRectangle(rect, RoundSize);
		//	g.FillPath(new SolidBrush(BackColor), rectGp);
		//	g.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);
		//	g.DrawPath(new Pen(Color.FromArgb(255, 77, 77, 77)), rectGp);
		//	g.FillRectangle(new SolidBrush(BackColor), rect);
		//	g.DrawRectangle(new Pen(ForeColor, 5), rect);
		//}



		//protected override void OnMouseEnter(EventArgs e)
		//{
		//	base.OnMouseEnter(e);
		//	MouseEntered = true;

		//	Invalidate();
		//}
		//protected override void OnMouseLeave(EventArgs e)
		//{
		//	base.OnMouseLeave(e);
		//	MouseEntered = false;

		//	Invalidate();
		//}

		//GraphicsPath RoundedRectangle(Rectangle rect, int RoundSize)
		//{
		//	GraphicsPath gp = new GraphicsPath();
		//	gp.StartFigure();
		//	gp.AddArc(rect.X, rect.Y, RoundSize, RoundSize, 180, 90);
		//	gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y, RoundSize, RoundSize, 270, 90);
		//	gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 0, 90);
		//	gp.AddArc(rect.X, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 90, 90);

		//	gp.CloseFigure();

		//	return gp;
		//}
	}
}
