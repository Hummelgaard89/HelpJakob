using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    public class MessageSender
    {
        //Method to call from main.
        public void SendMessage(MessageManager sm ,Message m, bool isHTML, MessageCarrier type)
        {
            sm.SendMessage(m, isHTML, type);
        }
    }
}
