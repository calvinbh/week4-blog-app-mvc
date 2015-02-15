using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog_App_MVC.Models
{
    public class Post
    {
        public string Title {get; set;}
        public string Body { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int ID { get; set; }

        public List<string> Comment {get; set;}

        public Post(string title, string body, DateTime createdOn, string createdBy, int id, List<string> comment)
        {
            Title = title;
            Body = body;
            CreatedOn = createdOn;
            CreatedBy = createdBy;
            ID = id;
            Comment = comment;

        }

        public Post()
        { 
        }

    }
}