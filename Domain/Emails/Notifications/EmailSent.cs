﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace  Domain.Emails.Notifications
{
    public class EmailSent : INotification
    {
        public int Id { get; set; }
    }
}
