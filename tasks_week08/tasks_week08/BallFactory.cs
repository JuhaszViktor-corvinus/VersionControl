using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tasks_week08
{
    class BallFactory
    {
        public class BallFactor
        {
            public Ball CreateNew()
            {
                return new Ball();
            }
        }
    }
}
