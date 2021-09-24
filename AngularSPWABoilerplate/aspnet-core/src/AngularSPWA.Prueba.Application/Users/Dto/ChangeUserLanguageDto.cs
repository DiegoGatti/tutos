using System.ComponentModel.DataAnnotations;

namespace AngularSPWA.Prueba.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}