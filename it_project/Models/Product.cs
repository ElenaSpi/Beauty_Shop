using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace it_project.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name="Price")]
        public float Price { get; set; }
        [Required]
        public string Category { get; set; }

        [Required]
        public float Rating { get; set; }
        [Required]
        [Display(Name = "Image")]
        public string ImageURL { get; set; }

        public virtual ICollection<Client> clients { get; set; }
        public Product()
        {
            clients = new List<Client>();
        }
    }
}