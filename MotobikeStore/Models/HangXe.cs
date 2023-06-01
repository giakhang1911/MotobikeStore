using System.ComponentModel.DataAnnotations;

namespace MotobikeStore.Models
{
    public class HangXe
    {
        [Key]
        public int Id { get; set; }
        public string? hangxe { get; set; }
    }
}
