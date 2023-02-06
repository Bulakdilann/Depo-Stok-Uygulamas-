using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string FirmaAdi{ get; set; }
        [Required]
        [StringLength(15)]
        public string FirmaTuru{ get; set; }
        [StringLength(100)]
        public string Adres{ get; set; }
        [StringLength(15)]
        public string Telefon{ get; set; }
        [StringLength(20)]
        public string Email{ get; set; }
        [StringLength(30)]
        public string YetkiliKisi{ get; set; }
        [StringLength(100)]
        public string Aciklama { get; set; }
        [StringLength(15)]
        public string VergiNo { get; set; }
        [StringLength(16)]
        public string HesapNo { get; set; }

        public ICollection<StockOperation> StockOperations { get; set; }
    }
}
