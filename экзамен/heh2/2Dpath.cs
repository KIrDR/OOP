using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heh2
{
    [Serializable]
    public delegate void Ch(); 
    public class _2Dpath
    {
        public List<_2DPoint> path = new List<_2DPoint>();

        public event Ch Change; 

        public void ChandeHo()
        {
            Console.WriteLine("Вызов события");
            if( Change != null)
            {
                Change();
            }
        }

        public void Add(_2DPoint point)
        {
            path.Add(point);
        }

        public void Delete(_2DPoint point)
        {

            if (path.Count == 0)
            {
                throw new DeleteExсeption();
            }
            path.Remove(point);
        }

        public void Clear()
        {
            path.Clear();
        }

        public void CountPoint()
        {
            int s1 = 0;
            int s2 = 0;
            int s3 = 0;
            int s4 = 0;
            foreach(var n in path)
            {
                if (n.X >= 0 && n.Y >= 0) s1++;
                if (n.X <= 0 && n.Y >= 0) s2++;
                if (n.X <= 0 && n.Y <= 0) s3++;
                if (n.X >= 0 && n.Y <= 0) s4++;

            }
            Console.WriteLine($"В первой четверти {s1}");
            Console.WriteLine($"В 2 четверти {s2}");
            Console.WriteLine($"В 3 четверти {s3}");
            Console.WriteLine($"В 4 четверти {s4}");

        }

        public static bool operator ==(_2Dpath a,_2Dpath b)
        {
            int o = 0; 
            if (a.path.Count == b.path.Count)
            {

                for (int i = 0; i < a.path.Count; i++)
                {
                    if(a.path[i].X == b.path[i].X && a.path[i].Y == b.path[i].Y)
                    {
                        o++;
                    }

                }

            }
            if(o == a.path.Count)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator !=(_2Dpath a, _2Dpath b)
        {
            int o = 0;
            if (a.path.Count == b.path.Count)
            {

                for (int i = 0; i < a.path.Count; i++)
                {
                    if (a.path[i].X == b.path[i].X && a.path[i].Y == b.path[i].Y)
                    {
                        o++;
                    }

                }

            }
            if (o == a.path.Count)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
