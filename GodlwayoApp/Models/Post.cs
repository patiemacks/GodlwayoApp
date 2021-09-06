using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GodlwayoApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string PostCreated { get; set; }
        public string Image { get; set; }
        public DateTime DateCreated { get; set; }

        public Post()
        {

        }
    }
}
