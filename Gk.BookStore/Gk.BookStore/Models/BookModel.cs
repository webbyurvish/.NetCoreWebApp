using Gk.BookStore.Enums;
using Gk.BookStore.Helpers;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Gk.BookStore.Models
{
    public class BookModel
    {
        //[DataType(DataType.Date)]
        //[Display(Name="Choose Date")]
        //public string MyField { get; set; }

        public int Id { get; set; }

        [StringLength(100, MinimumLength = 5)]
        [RequiredAttribute(ErrorMessage = "Please Enter the title of your book")]

        public string? Title { get; set; }


        [RequiredAttribute(ErrorMessage = "Please Enter the Author name of your book")]
        public string? Author { get; set; }


        [StringLength(500, MinimumLength = 30)]
        public string? Description { get; set; }

        public string? Category { get; set; }


        [RequiredAttribute(ErrorMessage ="Please choose the language ")]
        public int LanguageId { get; set; }

        public string? Language { get; set; }

        [Required(ErrorMessage = "Please Enter the totalPages")]
        [Display(Name = "Total Pages of Book")]
        public int? TotalPages { get; set; }

        [Display(Name = "Choose the cover photo of your book")]
        [RequiredAttribute]
        public IFormFile CoverPhoto { get; set; }
        public string? CoverImageUrl { get; set; }

        [Display(Name = "Choose the gallery images of your book")]
        [RequiredAttribute]
        public IFormFileCollection? GalleryFiles { get; set; }

        public List<GalleryModel>? Gallery { get; set; }

        [Display(Name = "Upload your book in pdf format")]
        [RequiredAttribute]
        public IFormFile BookPdf { get; set; }
        public string? BookPdfUrl { get; set; }
    }
}
