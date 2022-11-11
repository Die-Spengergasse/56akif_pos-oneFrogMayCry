using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01.Model
{
    public abstract class Post
    {
        public string Title { get; }
        public DateTime Created { get; }

        public int Rating
        {
            get { return _rating; }
            set 
            { 
                if (value < 1 || value > 5) 
                    throw new ArgumentOutOfRangeException(paramName: "Rating", message: "Range muss zwischen 1 und 5 liegen!");
                _rating = value; 
            }
        }
        private int _rating;

        public abstract string Html { get; }
        //TODO
        public SmartPhoneApp SmartPhone { get; set; } = default!;
        public Post(string title, DateTime created) 
        { 
            if(title is null)
                throw new ArgumentNullException(paramName: "Titel",message: "Titel war NULL!");
            Title= title;
            Created = created;
        }

        public Post(string title) : this(title, DateTime.Now) { }

        public override string ToString()
        {
            return Html;
        }
    }
}
