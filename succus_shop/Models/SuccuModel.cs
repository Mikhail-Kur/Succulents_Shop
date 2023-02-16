using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace succus_shop.Models
{
    public class SuccuModel   
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public bool IsAvialible { get; set; }
        public string Species { get; set; }
        public int Size { get; set; }

    }
}
