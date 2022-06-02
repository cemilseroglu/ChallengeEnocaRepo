using System.ComponentModel.DataAnnotations;

namespace Enoca.NET_Challenge.Models
{
    public class Ogrenci
    {
        [Key]
        public int OgrenciId { get; set; }
        [Required,MaxLength(50)]
        public string OgrenciAd { get; set; }
        [Required, MaxLength(100)]
        public string OgrenciSoyad { get; set; }
        [Required]
        public int OgrenciNo { get; set; }
        [Required,MaxLength(200)]
        public string FakulteAdi { get; set; }
        [Required, MaxLength(100)]
        public string BolumAdi { get; set; }
    }
}
