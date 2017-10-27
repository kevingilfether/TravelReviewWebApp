using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelReviewWebApp.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        [MinLength(1),MaxLength(85), Display(Name ="Name")]
        public string Title { get; set; }
        [MinLength(1),MaxLength(500)]
        public string Content { get; set; }
        [Display(Name ="Date Published")]
        public DateTime PublishDate { get; set; }
        [Range(1,5)]
        public int Stars { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}