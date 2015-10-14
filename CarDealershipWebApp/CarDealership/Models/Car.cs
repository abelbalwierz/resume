using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CarDealership.Models
{
    public class Car : IValidatableObject
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> CarErrors = new List<ValidationResult>();

            if (Make == null || Make == "")
            {
                CarErrors.Add(new ValidationResult("Must add a make of car", new string[] { "Make" }));
            }
            if (Model == null || Model == "")
            {
                CarErrors.Add(new ValidationResult("Must add a model of car", new string[] { "Model" }));
            }
            if (Title == null || Title == "")
            {
                CarErrors.Add(new ValidationResult("Must add a title", new string[] { "Title" }));
            }
            if (Price == null || Price > 1000000)
            {
                CarErrors.Add(new ValidationResult("Must add an asking price", new string[] { "Price" }));
            }
            if (Year == null || Year.Length != 4 ||  Year.Any(char.IsLetter))
            {
                CarErrors.Add(new ValidationResult("A valid four-digit model year is required", new string[] { "Year" }));
            }
            return CarErrors;
        }
        
    }
}