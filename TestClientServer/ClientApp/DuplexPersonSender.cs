using Eneter.Messaging.EndPoints.TypedMessages;
using Eneter.Messaging.MessagingSystems.MessagingSystemBase;
using Eneter.Messaging.MessagingSystems.TcpMessagingSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    internal class DuplexPersonSender
    {
        private IDuplexTypedMessageSender<string, Person> myMessageSender;
        public delegate void ResponseMessage(object sender, string message);
        public event ResponseMessage OnResponseMessage;
        public void Openconnection()
        {
            // Create message sender sending request messages of type Person and receiving responses of type string.
            IDuplexTypedMessagesFactory aTypedMessagesFactory = new DuplexTypedMessagesFactory();
            myMessageSender = aTypedMessagesFactory.CreateDuplexTypedMessageSender<string, Person>();
            myMessageSender.ResponseReceived += OnResponseReceived;
            // Create messaging based on TCP.
            IMessagingSystemFactory aMessagingSystemFactory = new TcpMessagingSystemFactory();
            IDuplexOutputChannel anOutputChannel = aMessagingSystemFactory.CreateDuplexOutputChannel("tcp://127.0.0.1:8094/");
            // Attach output channel and be able to send messages and receive response messages.
            myMessageSender.AttachDuplexOutputChannel(anOutputChannel);
            
        }

        public bool isConnect()
        {
            return myMessageSender.IsDuplexOutputChannelAttached;
        }

        public void Close()
        {
            myMessageSender.DetachDuplexOutputChannel();
        }

        public void SendPersonalInfo(string name, int numberOfItems)
        {
            Person aPerson = new Person { Name = name, NumberofItem = numberOfItems };

            // Send the type Person.
            myMessageSender.SendRequestMessage(aPerson);
        }

        private void OnResponseReceived(object sender, TypedResponseReceivedEventArgs<string> e)
        {
            if (OnResponseMessage != null) OnResponseMessage(this, e.ResponseMessage);
        }

    }
}
