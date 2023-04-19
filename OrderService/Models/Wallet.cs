using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Models
{
    public class Wallet
    {
        [Key]
        public string Username {get;set;}
        public decimal Cash {get;set;}
        public ICollection<Order> Orders {get;set;}// Relasi dengan kelas Order
    }
}