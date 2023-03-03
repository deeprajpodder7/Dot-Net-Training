using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public delegate void AmazonOrderDelivered(string s);
    public class AmazonDelegate
    {
        public static void sendEmail(string mail) {
            Console.WriteLine("Mail has been delivered to: " + mail);
        }
        public static void sendSms(string phoneNumber) {
            Console.WriteLine("Sms has been delivered to: " + phoneNumber);
        }
        public static  void sendWhatsApp(string whatsappNumber) {
            Console.WriteLine("Message has been delivered to: " + whatsappNumber);
        }

        public static void Main(string[] args)
        {
            AmazonOrderDelivered MailsentDel,SmsSentDel,WhatsappSentDel,MultiDel;
            MailsentDel = sendEmail;
            SmsSentDel = sendSms;
            WhatsappSentDel=sendWhatsApp; 
            MultiDel = MailsentDel+SmsSentDel+WhatsappSentDel;
            //MailsentDel("deep@gmail.com");
            //SmsSentDel("9123721390");
            //WhatsappSentDel("9123721390");

            MultiDel("9123721390");

            



        }

    }
}
