using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Z7
{
    public class Product
    {
        /// <summary>
        /// de naam van het product
        /// </summary>
        public string Naam
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// de prijs van het product
        /// </summary>
        public decimal Prijs
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// welk model zwembad is dit
        /// </summary>
        public string Model
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// RAL code van het zwembad
        /// </summary>
        public string Kleur
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// welk soort materiaal is het product
        /// </summary>
        public string Materiaal
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// de prijs berekent
        /// </summary>
        /// <param name="bedrag">het bedrag dat moet betaalt worden</param>
        public decimal BerekenVerkoopPrijs(decimal bedrag)
        {
            
            bool Isgelukt = false;
            if (Materiaal == "cement" )
            {
                bedrag = Prijs + Prijs / 100 * 10;
                Isgelukt = true;
            }
            if (Materiaal == "epoxy")
            {
                bedrag = Prijs + Prijs / 100 * 20;
                Isgelukt = true;
            }
            if (Materiaal == "polyester")
            {
                bedrag = Prijs + Prijs / 100 * 40;
                Isgelukt = true;
            }
            if (Materiaal == "polypropyleen")
            {
                bedrag = Prijs + Prijs / 100 * 40;
                Isgelukt = true;
            }
        }

        /// <summary>
        /// geeft alles weer
        /// </summary>
        public string Tostring()
        {
            throw new System.NotImplementedException();
        }
    }
}