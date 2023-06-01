using System.ComponentModel.DataAnnotations;

namespace MotobikeStore.Models
{
    public class DongXe
    {
        [Key]
        public int Id { get; set; }
        public string? Dongxe { get; set; }
    }
}
