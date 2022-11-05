using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1
{
    public class Media
    {

        private int parentRate;

        public String Title { get; set; }

        public virtual void play()
        {
            Console.WriteLine($"Playing {Title}");
        }

        protected bool ThisContentIsCorrectForThisAge (int age)
        {
            if (age >= parentRate)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
        public override bool Equals(object obj)
        {
            var mediaObject = (Media)obj;
            if (mediaObject.Title == this.Title)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
