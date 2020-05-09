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
        public byte lengte { get; set; }
        

        /// <summary>
        /// breedte van het zwembad in meter
        /// </summary>
        public byte breedte { get; set; }
        

        /// <summary>
        /// diepte van het zwembad in meter
        /// </summary>
        public byte diepte { get; set; }

        /// <summary>
        /// het totale watervolume diepte*breedte*lengte
        /// </summary>
        public ushort Watervolume { get; }



        /// <summary></summary>
        public string VulZwembad()
        {
            throw new System.NotImplementedException();
        }
    }
}