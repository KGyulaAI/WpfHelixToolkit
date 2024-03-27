using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHelixToolkit
{
    internal class Gyongyos
    {
        int x;
        int y;
        int z;
        int e;

        public Gyongyos(int x, int y, int z, int e)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.e = e;
        }

        public int X { get => x; }
        public int Y { get => y; }
        public int Z { get => z; }
        public int E { get => e; }
    }
}
