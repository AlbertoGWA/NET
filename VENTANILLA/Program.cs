using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VENTANILLA
{
    class ventanilla
    {
        private int generateAttentionTime()
        {
            Random rnd = new Random();
            return rnd.Next(5, 30);
        }
        static void Main(string[] args)
        {
        }
    }
}
