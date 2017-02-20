using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ElysianVintage.Models
{
    public class MailingListingModel
    {
        [Required]
        public string emailAddress { set; get; }

        [Required]
        public bool mailingList { set; get; }
    }
}