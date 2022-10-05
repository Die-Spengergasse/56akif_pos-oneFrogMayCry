using System;

namespace ExProperties.App
{
    public class Rechteck
    {
        public int Laenge
        {
            get
            {
                return laenge;
            }
            set
            {
                laenge = (value >= 0 ? value : throw new ArgumentException("Ungültige Länge!"));
            }
        }
        private int laenge;

        public int Breite
        {
            get
            {
                return breite;
            }
            set
            {
                breite = (value >= 0 ? value : throw new ArgumentException("Ungültige Länge!"));
            }
        }
        private int breite;

        public int Flaeche
        {
            get
            {
                return Laenge * Breite;
            }
        }
    }
}
