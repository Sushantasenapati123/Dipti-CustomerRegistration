﻿using CUSTOMERREGISTRATIONAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CUSTOMERREGISTRATIONAPI.Service
{
   public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
