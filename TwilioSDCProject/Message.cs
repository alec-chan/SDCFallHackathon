﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilioSDCProject
{
    public class Message
    {

        public string Body { get; set; }
        public DateTime Date { get; set; }

        public Message(string body)
        {
            this.Body = body;
            this.Date = DateTime.Now;
        }
    }
}
