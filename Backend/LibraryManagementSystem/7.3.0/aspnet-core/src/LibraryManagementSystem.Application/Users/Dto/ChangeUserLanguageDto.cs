using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}