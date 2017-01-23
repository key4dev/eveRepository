using S22.Xmpp;
using S22.Xmpp.Client;
using S22.Xmpp.Extensions;
using S22.Xmpp.Im;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System;

  
 
namespace eve
{
     

    public class EveXmppManager
    {

        public bool connect()
        {
            XmppClient xmppClient = new XmppClient("192.168.168.73", "test", "test");
            xmppClient.Port = 5222;
            xmppClient.Connect();
            xmppClient.SetStatus(Availability.Online, null, 1);
            if (xmppClient.Connected == true)
            {
                return true;
            }
            return false;
        }
    }
}

