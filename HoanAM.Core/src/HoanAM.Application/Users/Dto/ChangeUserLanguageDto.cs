using System.ComponentModel.DataAnnotations;

namespace HoanAM.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}