using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Ad Soyad girilmesi zorunludur !")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Telefon girilmesi zorunludur !")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "E-posta girilmesi zorunludur !")]
        [EmailAddress(ErrorMessage = "Hatalı E-posta !")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Katılım durumu seçilmesi zorunludur !")]
        public bool? WillAttend { get; set; }
    }
}