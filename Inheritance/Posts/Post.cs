using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Posts
{
    public class Post
    {
        private static int currentPostId;

        protected int ID { get; set; }

        public string Title { get; set; }

        public string SendByUserName { get; set; }
  
        public bool IsPublic { get; set; }  

        public Post() {

            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUserName = "Petar";
        }
      //instance Constructor
        public Post(string title,bool isPublic,string sendByUserName)
        {
            this.ID =GetNextId();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUserName = sendByUserName;
        }

        protected int GetNextId()
        {
            return ++currentPostId;
        }

        public void Update (string title,bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} -{1} - by {2}",this.ID,this.Title,this.SendByUserName);
        }




    }
}
