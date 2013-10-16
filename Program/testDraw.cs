using System;
using Cairo;
using System;

namespace Program
{
	public partial class testDraw : Window
	{
		public testDraw ()
		{
			DrawingArea darea = new DrawingArea ();
			Cairo.Context cr = Gdk.CairoHelper.Create (darea.GdkWindow);
			cr.Rectangle (0, 0, 300, 300);
			cr.Rectangle (0, 0, 0);
			cr.Fill ();
			cr.LineWidth = 1;
			cr.SetSourceRGB (0.7, 0.2, 0.0);

			int width, height;
			width = 50;
			height = 50;

			cr.Translate (width / 2, height / 2);
			cr.Arc (tmpX, tmpY, (width < height ? width : height) / 2 - 10, 0, 2);
			cr.StrokePreserve ();
			cr.SetSourceRGB (0.3, 0.4, 0.6);
			cr.Fill (); 
		}
	}
}

