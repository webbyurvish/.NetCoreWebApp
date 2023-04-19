﻿using System.ComponentModel.DataAnnotations;

namespace Gk.BookStore.Helpers
{
    public class MyCustomValidationAttribute : ValidationAttribute
    {
        public MyCustomValidationAttribute(string text)
        {
            Text = text;
        }

        public string Text { get; set; }

        protected override ValidationResult IsValid(object   value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string bookName = value.ToString();
                //if (bookName.Contains(Text))
                //{
                //    return ValidationResult.Success;
                //}

            }
            return new  ValidationResult(ErrorMessage?? "Bookname does not contain desired value ");
        }
    }
}
