using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_and_GIF_Splitter
{
	class SegmentHandler
	{
		Segment[,] segmentMatrix;
		ArrayList segmentList = new ArrayList();
		public int basex, basey, segsx, segsy, segnx, segny;
		public decimal segScale = 1;		
		public bool shouldDraw = true;

		public SegmentHandler(int bx, int by)
		{
			basex = bx;
			basey = by;
		}
		public SegmentHandler()
		{
		}

		public void drawAllSegments(System.Drawing.Graphics g)
		{
			if (!shouldDraw) return;
			if (g == null) return;
			foreach (Segment s in segmentList) 
				s.draw(g);
			
		}
		public void initSegments()
		{
			if (segnx * segny * segsx * segsy == 0) return;
			initSegments(segnx, segny, segsx, segsy);
		}
		public void initSegments(int amntx, int amnty, int sizex, int sizey)
		{
			segnx = amntx;
			segny = amnty;
			segsx = sizex;
			segsy = sizey;
			clearSegments();
			segmentMatrix = new Segment[amnty, amntx];
			for (int y = 0; y < amnty; y++)
			{
				for (int x = 0; x < amntx; x++)
				{
					int posx = (int)(basex + (sizex * x * segScale));
					int posy = (int)(basey + (sizey * y * segScale));
					segmentMatrix[y, x] = new Segment(posx, posy, (int) (sizex * segScale), (int)(sizey * segScale), true);
					segmentList.Add(segmentMatrix[y, x]);
				}
			}

		}

		public ArrayList getSegmentsReal()
		{
			ArrayList newlist = new ArrayList();
			foreach (Segment s in segmentList) {
				Segment convert = new 
					Segment(
					(int) ((s.x - basex) / segScale), 
					(int) ((s.y - basey) / segScale), 
					(int) (s.sx / segScale), 
					(int) (s.sy / segScale), 
					s.active);
				newlist.Add(convert);
			}

			return newlist;
		}

		public ArrayList getSegments()
		{
			return segmentList;
		}

		public void clearSegments()
		{
			segmentList.Clear();
			segmentMatrix = null;
		}

	}
}
