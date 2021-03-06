﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace  Domain.Emails.Model.Entity
{
    /// <summary>
    /// Entity email object to represend db form of it
    /// </summary>
    public class Email
    {
        [Key]
        public int Id { get; set; }

        public string Recipients { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public string Sender { get; set; }

        public DateTime? SentOn { get; set; }
    }
}
