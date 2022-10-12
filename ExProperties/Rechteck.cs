using System;

namespace ExProperties.App
{
    public class Rechteck
    {
        public int Laenge
        {
            get
            {
                return _laenge;
            }
            set
            {
                _laenge = (value >= 0 ? value : throw new ArgumentException("Ungültige Länge!"));
            }
        }
        private int _laenge;

        public int Breite
        {
            get
            {
                return _breite;
            }
            set
            {
                _breite = (value >= 0 ? value : throw new ArgumentException("Ungültige Länge!"));
            }
        }
        private int _breite;

        public int Flaeche
        {
            get
            {
                //direkt das backing-field verwenden
                return _laenge * _breite;
            }
        }
        // this exists
        // public int Flaeche => return _laenge * _breite;
    }
}
