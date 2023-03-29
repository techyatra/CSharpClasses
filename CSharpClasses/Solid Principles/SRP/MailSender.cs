﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Solid_Principles.SRP
{
    internal class MailSender
    {
        public string EMailFrom { get; set; }
        public string EMailTo { get; set; }
        public string EMailSubject { get; set; }
        public string EMailBody { get; set; }
        public void SendEmail()
        {
            // Here we need to write the Code for sending the mail
        }
    }
}
