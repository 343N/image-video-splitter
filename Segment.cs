using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_and_GIF_Splitter
{
	class Segment
	{
		static Pen WHITE = new Pen(Color.White);
		static Pen RED = new Pen(Color.Red);
		static Pen BLACK = new Pen(Color.Black);
		static Pen TRANSPARENT_RED = new Pen(Color.FromArgb(80, 255, 255, 255));

		public int x, y, sx, sy;
		public bool active;
		public Segment(int posx, int posy, int sizex, int sizey, bool active)
		{
			this.x = posx;
			this.y = posy;

			this.sx = sizex;
			this.sy = sizey;

			this.active = active;
		}

		public void draw(Graphics g)
		{
			if (g == null) return;

			// g.DrawRectangle(WHITE, new Rectangle(x, y, sx, sy));
			g.DrawLine(WHITE, x, y, x, y + sy);				// | left
			g.DrawLine(WHITE, x + sx, y, x + sx, y + sy);   // | right
			g.DrawLine(WHITE, x, y, x + sx, y);				// --- top
			g.DrawLine(WHITE, x, y + sy, x + sx, y + sy);	// --- bottom

			if (!active)
			{
				g.DrawRectangle(TRANSPARENT_RED, new Rectangle(x, y, sx, sy));
				g.DrawLine(RED, x, y, x + sx, y + sy);
				g.DrawLine(RED, x + sx, y, x, y + sy);
			}

		}

	}
}
