using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MvcSportsStore.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public DateTime ReleaseDate { get; set; }
        public string Catergory { get; set; }
        public decimal Price { get; set; }
    }
}
