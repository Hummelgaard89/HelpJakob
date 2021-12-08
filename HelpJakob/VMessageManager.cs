﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    public class VMessageManager 
    {
        HTMLConverter htmlconverter = new HTMLConverter();
        //Method to convert to HTML and send via the Vmessage protocol.
        public void SendMessage(Message m, bool isHTML)
        {
                if (isHTML)
                    m.Body = htmlconverter.ToHTML(m.Body);
                //Implement code to send via VMessage
        }
    }
}
