using System.ComponentModel.DataAnnotations;

namespace GrandesTrabajos.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}