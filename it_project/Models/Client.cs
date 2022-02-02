using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace it_project.Models
{
    public class Client
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name="Email Address")]
        public string Email { get; set; }
        [Required]
        [Range(18,99)]
        public int Age { get; set; }

        public virtual ICollection<Product> products { get; set; }

        public Client()
        {
            products = new List<Product>();
        }
    }
}