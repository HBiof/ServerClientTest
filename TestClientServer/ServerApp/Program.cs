using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    class Program
    {        
        static void Main(string[] args)
        {
            try
            {
                DuplexPersonReceiver dplen = new DuplexPersonReceiver();
                dplen.OpenConnect();
                dplen.StartReceiving();                                             
                Console.WriteLine("connected");
                Console.ReadLine();
                dplen.StopReceiving();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
