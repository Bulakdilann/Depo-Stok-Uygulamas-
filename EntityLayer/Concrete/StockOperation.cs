using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class StockOperation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CompanyId { get; set; }
        [Required]
        [StringLength(20)]
        public string StockOperationType { get; set; }
        [Required]
        public DateTime OperationDate { get; set; }

        public ICollection<StockOperationDetail>stockOperationDetails{ get; set; }
        public Company Company { get; set; }
    }
}
