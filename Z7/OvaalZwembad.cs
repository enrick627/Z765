using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Z7
{
    public class OvaalZwembad
    {
        /// <summary>
        /// het totale volume van het zwembad
        /// </summary>
        public ushort Watervolume { get; set; }
        

        /// <summary>
        /// de grote van de lange as
        /// </summary>
        public byte LangeAs { get; set; }
        

        /// <summary>
        /// de grote van de korte as
        /// </summary>
        public byte KorteAs { get; set; }
        
        
        /// <summary>
        /// de diepte van het zwembad
        /// </summary>
        public byte diepte { get; set; }
        

        /// <summary>
        /// de tijd die het zwembad nodig heeft om te vullen
        /// </summary>
        public string Vulzwembad()
        {
            throw new System.NotImplementedException();
        }
    }
}