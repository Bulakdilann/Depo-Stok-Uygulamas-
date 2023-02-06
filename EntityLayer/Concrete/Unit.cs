using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Unit
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string BirimAdi { get; set; }

        [StringLength(100)]
        public string Aciklama { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
