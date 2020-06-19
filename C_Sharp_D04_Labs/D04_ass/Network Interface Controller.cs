using System;
using System.Collections.Generic;
using System.Text;

namespace D04_ass
{
    class NetworkInterfaceController
    {
        ///9. Write a class that will be used by an FTP client Project  
        ///Your class is needed to fully describe the Network Card
        ///[Network Interface Controller(NIC)] for your machine
        ///[your machine have one and only one NIC card]. 
        ///Prevent the other classes from declaring 
        ///more than one object from NIC class.  
        ///NIC card must have these data: Manufacture, MAC Address,
        ///Type[Ethernet or token ring – use Enumeration here]…
        ///

        enum NIC_Type { Ethernet , TokenRing }
        string Manufacture;
        int MAC_Address;
        NIC_Type type;

        public static readonly NetworkInterfaceController controllerObj
            = new NetworkInterfaceController("Cisco", 50607080, NIC_Type.Ethernet);
               
        NetworkInterfaceController (string f , int c , NIC_Type type)
        {
            this.Manufacture = f;
            this.MAC_Address = c;
            this.type = type;
        }

    }
}
