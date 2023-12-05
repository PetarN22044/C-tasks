using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Posts
{
    public class ImagePost : Post   
    {
        public string ImageUrl { get; set; }

        public ImagePost() 
        {
            
        }
        public ImagePost(string title,string sendByUserName,string imageUrl,bool isPublic)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.ImageUrl = imageUrl;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} -{1} - by {2} and url {3}", this.ID, this.Title, this.SendByUserName,this.ImageUrl);
        }

    }
}
