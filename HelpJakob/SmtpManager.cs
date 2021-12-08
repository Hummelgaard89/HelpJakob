using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    public class SmtpManager 
    {
        HTMLConverter htmlconverter = new HTMLConverter();
        //Method to convert to HTML and send via the SMTP protocol.
        public void SendMessage(Message m, bool isHTML)
        {
            if (isHTML)
                m.Body = htmlconverter.ToHTML(m.Body);
            //Implement code to send via SMTP
        }
    }
}
