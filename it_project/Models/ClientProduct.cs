using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace it_project.Models
{
    public class ClientProduct
    {
        public int ProductID { get; set; }
        public int ClientID { get; set; }
        public Product product { get; set; }
        public List<Client> clients { get; set; }
    }
}