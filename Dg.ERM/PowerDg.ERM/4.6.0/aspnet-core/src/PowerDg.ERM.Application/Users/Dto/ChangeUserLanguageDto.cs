using System.ComponentModel.DataAnnotations;

namespace PowerDg.ERM.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}