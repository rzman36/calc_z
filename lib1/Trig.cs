using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib1
{
    public class Trig
    {
        private string a;


        public Trig(string a)
        {
            this.a = a;

        }
        public string Rad()
        {

            double gradus = Convert.ToDouble(a);
            double radian = gradus * Math.PI / 180;
            return Convert.ToString(radian);
        }

        public string Sin()
        {
            double gradus = Convert.ToDouble(a);
            double radian = gradus * Math.PI / 180.0;
            return "" + Math.Sin(radian);

        }

        public string Cos()
        {
            double gradus = Convert.ToDouble(a);
            double radian = gradus * Math.PI / 180.0;
            return "" + Math.Cos(radian);

        }

    }
}
