using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array

{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrNama = new string[3];
            arrNama[0] = ("erik");
            arrNama[1] = ("wely");
            arrNama[2] = ("sony");
            int[] arrNim = new int[3];
            arrNim[0] = 1234;
            arrNim[1] = 1235;
            arrNim[2] = 1236;
            int[] arrNilai = new int[3];
            arrNilai[0] = 75;
            arrNilai[1] = 80;
            arrNilai[2] = 95;

            Console.WriteLine("No." + "\t" + "Nim" + "\t" + "Nama" + "\t" + "Nilai");
            Console.WriteLine("=============================");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + 1 + "." + "\t" + arrNim[i] + "\t" + arrNama[i] + "\t" + arrNilai[i]);
            }
            Console.ReadKey();
        }
    }
}