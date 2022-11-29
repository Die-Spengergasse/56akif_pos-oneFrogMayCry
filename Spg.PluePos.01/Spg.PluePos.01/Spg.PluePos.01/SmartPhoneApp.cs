using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spg.PluePos._01.Model;

namespace Spg.PluePos._01
{
    public class SmartPhoneApp : List<Post>
    {
        public string SmartPhoneId { get; set; } = string.Empty;

        public new void Add(Post post)
        {
            if (post is null)
                return;
            post.SmartPhone = this;
            base.Add(post);
        }

        public SmartPhoneApp(string smartPhoneId) 
        {
            SmartPhoneId= smartPhoneId;
        }

        public string ProcessPosts()
        {
            StringBuilder sb = new();

            foreach(Post post in this) 
            {
                sb.Append(post.ToString());
                sb.Append("/n");
            }
            return sb.ToString();
        }

        public int CalcRating()
        {
            int ratingSum = 0;

            foreach(Post post in this)
            {
                ratingSum += post.Rating;
            }

            return ratingSum;
        }

        public Post? this[string title]
        {
            get 
            {
                foreach(Post post in this) 
                {
                    if(post.Title.Equals(title))
                        return post;
                }
                return null;
            }
        }
    }
}
