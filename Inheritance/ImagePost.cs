using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    //ImagePost derived from Post and adds a property (ImageURL) and teo constructors
    internal class ImagePost: InheritanceC.Post
    {
        public string ImageURL { get; set; }
        public ImagePost() { }

        public ImagePost(string title, string sendbyUsername, string imageURL, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title; 
            this.SendByusername = sendbyUsername;
            this.IsPublic = isPublic;  

            // Propert ImageURL is a member of ImagePost, but not of InheritanceC.Post
            this.ImageURL = imageURL;   
        }
    }
}
