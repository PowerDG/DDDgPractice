using System.ComponentModel.DataAnnotations;

namespace DgMission.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}