using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string İmage { get; set; }   
        public DateTime UploadDate { get; set; }
        public bool Approval { get; set; }
        public bool HomePage { get; set; }
        public int CategoryId { get; set; }
    }
}