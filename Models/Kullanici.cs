using System.ComponentModel.DataAnnotations;

namespace Enoca.NET_Challenge.Models
{
    public class Kullanici
    {
        [Key]
        public int KullaniciId { get; set; }
        [Required,MaxLength(50)]
        public string KullaniciAdi { get; set; }  
        [Required,MaxLength(100)]
        public string Sifre { get; set; }
    }
}
