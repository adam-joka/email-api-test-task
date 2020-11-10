﻿using Codibly.Domain.Emails.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codibly.Domain.Emails.Data
{
    public class EmailsDataContext : DbContext
    {
        public EmailsDataContext(DbContextOptions<EmailsDataContext> options)
            : base(options) { }

        public DbSet<Email> Emails { get;set; }

    }
}