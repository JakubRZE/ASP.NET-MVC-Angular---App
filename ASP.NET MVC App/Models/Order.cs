using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_App.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}