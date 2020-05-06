using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Z7
{
    public class Zwembad
    {
        /// <summary>
        /// dit is de lengte van het zwembad in meter
        /// </summary>
        public byte lengte
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// breedte van het zwembad in meter
        /// </summary>
        public byte breedte
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// diepte van het zwembad in meter
        /// </summary>
        public byte diepte
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// het watervolume
        /// </summary>
        public int Watervolum()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// de tijd die het zwembad nodig heeft om te vullen
        /// </summary>
        public string VulZwembad()
        {
            throw new System.NotImplementedException();
        }
    }
}