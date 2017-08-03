using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONPlaceholderClient.Basic.Models
{
    // This class will be used to Deserialize the JSON from the response.
    class Post
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string body { get; set; }    
    }
}
