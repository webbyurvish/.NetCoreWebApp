using System.ComponentModel.DataAnnotations;

namespace Gk.BookStore.Enums
{
    public enum LanguageEnum
    {
        [Display(Name = "Hindi language")]  
        Hindi = 10,
        [Display(Name = "English language")]

        English = 11,
        [Display(Name = "Gujarati language")]

        Gujarati = 12,
        [Display(Name = "German language")]
        German = 13,
        [Display(Name = "Dutch language")]
        Dutch = 14
    }
}
