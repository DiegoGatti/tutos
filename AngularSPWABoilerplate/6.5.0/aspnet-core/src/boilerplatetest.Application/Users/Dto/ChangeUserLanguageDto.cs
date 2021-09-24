using System.ComponentModel.DataAnnotations;

namespace boilerplatetest.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}