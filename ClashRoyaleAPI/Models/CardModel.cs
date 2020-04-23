using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClashRoyaleAPI.Models
{
    public class CardModel
    {
        public decimal ID { get; set; }
        public string Name { get; set; }
        public decimal MaxLevel { get; set; }
        public string IconURL { get; set; }
    }
}