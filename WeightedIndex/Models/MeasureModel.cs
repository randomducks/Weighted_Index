using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DataAnnotationsExtensions;
using System.ComponentModel;

namespace WeightedIndex.Models
{
    public class MeasureModel
    {
        /// <summary>
        /// id of the measure
        /// </summary>
        [Required]
        public Guid id { get; set; }

        /// <summary>
        /// the name of the measure
        /// </summary>
        [Required]
        [Display(Name = "Name")]
        [StringLength(50,
            ErrorMessage = "{0} cannot be blank.",
            MinimumLength = 1)]
        public string name { get; set; }

        /// <summary>
        /// the measure's performance impact
        /// </summary>
        [Required]
        [Display(Name = "Performance Impact")]
        [Numeric(ErrorMessage = "{0} must be a number.")]
        [Range(1, 5, ErrorMessage = "{0} must be between 1 and 5")]
        public int performanceImpact { get; set; }

        [Required]
        [Display(Name = "Quick to Implement")]
        [Numeric(ErrorMessage = "{0} must be a number.")]
        [Range(1, 5, ErrorMessage = "{0} must be between 1 and 5")]
        public int quickToImplement { get; set; }

        /// <summary>
        /// calculates the score
        /// </summary>
        /// <returns></returns>
        public int score
        {
            get
            {
                return this.quickToImplement * this.performanceImpact;
            }
        }
    }
}