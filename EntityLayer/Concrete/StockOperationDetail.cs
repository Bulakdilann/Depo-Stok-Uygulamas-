using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class StockOperationDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int StockOperationId { get; set; }
        [Required]
        public int ProductId { get; set; }
        public byte Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public StockOperation StockOperation { get; set; }
        public Product Product { get; set; }
    }
}
