using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Warehouse
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string DepoAdi{ get; set; }

        [StringLength(100)]
        public string Aciklama{ get; set; }

         [StringLength(30)]
        public string DepoYetkilisi{ get; set; }

         [StringLength(15)]
        public string Telefon{ get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
