using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z7
{
    class Program
    {
        static void Main(string[] args)
        {
            Zwembad zwembad = new Zwembad();
            rondZwembad RondZwembad = new rondZwembad();
            string watevolumetest;
            zwembad.lengte = 7;
            zwembad.breedte = 8;
            zwembad.diepte = 2;
            zwembad.Watervolume =(ushort)( zwembad.lengte * zwembad.breedte * zwembad.diepte);
            Console.WriteLine(zwembad.Watervolume);
            watevolumetest = Console.ReadLine();

            RondZwembad.diameter = 7;
            RondZwembad.diepte = 2;
            RondZwembad.watervolume = (ushort)(RondZwembad.diameter * RondZwembad.diameter * RondZwembad.diepte * 0.78);



        }
    }
}
