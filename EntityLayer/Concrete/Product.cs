using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Adi { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [StringLength(15)]
        public string BarkodKodu { get; set; }
        public int StokMiktari { get; set; }
        public int UnitId { get; set; }
        public double BirimFiyat { get; set; }
        [Required]
        public int WarehouseId { get; set; } //depoıd
        [StringLength(5)]
        public string RafNo { get; set; } 
        public int MinStok { get; set; } 
        public int MaxStok { get; set; } 

        public Category Category { get; set; } 
        public Warehouse Warehouse { get; set; } 
        public Unit Unit { get; set; }

        public  ICollection<StockOperationDetail> StockOperationDetails { get; set; }
    }
}
