using System;

namespace ExProperties.App
{
    public class Lehrer
    {
        public string Vorname { get; set; } = string.Empty;
        public string? Zuname { get; set; }

        public decimal? Bruttogehalt 
        { 
            get
            {
                return _bruttogehalt;
            }
            set
            {
                _bruttogehalt ??= value;
            }
        }
        private decimal? _bruttogehalt;

        public string? Kuerzel
        {
            get
            {
                return Zuname?.Substring(0, 3).ToUpper() ?? string.Empty;
                //return Zuname?[..3].ToUpper() ?? string.Empty; //why?
            }
        }

        public decimal Nettogehalt
        {
            get
            {
                return Bruttogehalt * 0.8M ?? 0M;
            }
        }
    }
}
