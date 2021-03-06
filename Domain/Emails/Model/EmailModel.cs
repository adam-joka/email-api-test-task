﻿using  Domain.Emails.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace  Domain.Emails.Model
{
    /// <summary>
    /// Email model to be used as data contract in email api
    /// </summary>
    public class EmailModel
    {
        public int Id { get; set; }

        public List<string> Recipients { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public string Sender { get; set; }

        public DateTime? SentOn { get; set; }

        public EmailStatus Status => SentOn == null ? EmailStatus.Pending : EmailStatus.Sent;
    }
}
