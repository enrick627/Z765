using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Z7
{
    public class rondZwembad
    {
        

        /// <summary>
        /// de diameter van het zwembad
        /// </summary>
        public byte diameter
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// de diepte
        /// </summary>
        public byte diepte
        {
            get => default;
            set
            {
            }
        }
        /// <summary>
        /// het volume
        /// </summary>
        /// <returns></returns>
        public ushort watervolume
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// de tijd die nodig is om het zwembad te vullen
        /// </summary>
        /// <param name="tijd"></param>
        /// <returns>de tijd die het zwembad nodig heeft om te vullen</returns>
        public string Vulzwembad(int tijd)
        {
            bool Isgelukt = false;
            if (diepte > 0)
            {
                tijd = diepte * diameter / watervolume;
                Isgelukt = true;
            }
            return Isgelukt.ToString();

            
        }
    }
}