using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace u23594561Prac1_test_.Models
{
	public class PersonModel
    {//Quick property - type "prop" press tab x2
        //Complete the property details
        //This is the "Model" of "data source"

        [Display(Name = "STUDENT NUMBER")] //Add as decorator
        public string StudentNumber { get; set; }

        [Display(Name = "NAME")] //Add as decorator
        public string FirstName { get; set; }

        [Display(Name = "SURNAME")] //Add as decorator
        public string SurName { get; set; }

        [Display(Name = "EMAIL ADDRESS")] //Add as decorator
        // [Required(ErrorMessage = "Name is mandatory")]=> Example of manditory decorator
        public string EmailAddress { get; set; }
    }
}