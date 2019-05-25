using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGround
{
    static public class RandomNumberCreator
    {
        static public int RandomNum(int first, int last)
        {
            Random random = new Random();
            int result;

            result = random.Next(first, last);
            
            return result;
        }
    }
}
