using System.ComponentModel.DataAnnotations;

namespace dotnet-api.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}