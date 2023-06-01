using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MotobikeStore.Models
{
    public class SanPham
    {
        [Key]
        public string? Id { get; set; }
        public string? Tenxe { get; set; }
        public string? Mieuta { get; set; }
        public string? ImageUrl { get; set; }
        public decimal gia { get; set; }
        public int soluong { get; set; }

        [ForeignKey("Category")]
        public int DongxeId { get; set;}

        public virtual DongXe? Dongxe { get; set; }
    }
}
