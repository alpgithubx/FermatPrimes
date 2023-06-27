using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermatAsalları {
    internal class Program {
        static void Main(string[] args) {
            for(int i = 0; i < 5; i++) {
                double j = Math.Pow(2,Math.Pow(2, i)) + 1;
                if(asal(Convert.ToInt32(j))) {
                    Console.WriteLine(j);
                } 
            }
            Console.ReadKey();
        }
        static bool asal(int i) {
            for (int b = 2; b < i; b++) {
                if (i % b == 0) {
                    return false;
                }
            }
            return true;
        }
    }
}
