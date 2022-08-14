using System.ComponentModel.DataAnnotations;

namespace GetDoIt.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}