using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    public abstract class MessageManager
    {
        VMessageManager vMessage = new VMessageManager();
        SmtpManager smtp = new SmtpManager();
        //Method that determines which protocol to send message via, and then call a method to implement that protocol to send from.
        public void SendMessage(Message m, bool isHTML, MessageCarrier type)
        {
            if (type.Equals(MessageCarrier.Smtp))
            {
                smtp.SendMessage(m, isHTML);
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                vMessage.SendMessage(m, isHTML);
            }
        }
    }
}
