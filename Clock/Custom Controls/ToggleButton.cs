using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock.Custom_Controls
{
	public class ToggleButton:CheckBox
	{
		private Color onBackColor = Color.MediumSlateBlue;
		private Color onToggleColor = Color.WhiteSmoke;
		private Color offBackColor = Color.Gray;
		private Color offToggleColor = Color.Gainsboro;

		public Color OnBackColor { get => onBackColor; set => onBackColor = value; }
		public Color OnToggleColor { get => onToggleColor; set => onToggleColor = value; }
		public Color OffBackColor { get => offBackColor; set => offBackColor = value; }
		public Color OffToggleColor { get => offToggleColor; set => offToggleColor = value; }

		public ToggleButton()
        {
			MinimumSize = new Size(45, 22);
        }
		private GraphicsPath GetFigurePath()
		{
			int arcSize = Height - 1;
			Rectangle leftArc=new Rectangle(0,0,arcSize, arcSize);
			Rectangle rightArc = new Rectangle(Width-arcSize-2,0,arcSize, arcSize);	
			GraphicsPath path = new GraphicsPath();
			path.StartFigure();
			path.AddArc(leftArc, 90, 180);
			path.AddArc(rightArc, 270, 180);
			path.CloseFigure();
			return path;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			int toggleSize = Height - 5;
			e.Graphics.SmoothingMode= SmoothingMode.AntiAlias;
			e.Graphics.Clear(Parent.BackColor);
			if (Checked)
			{
				e.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());	
				e.Graphics.FillEllipse(new SolidBrush(onToggleColor),new Rectangle(Width-Height+1,2,toggleSize,toggleSize));			}
			else
			{
				e.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
				e.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));

			}
		}
	}
}
