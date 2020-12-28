using System;
using System.Collections.Generic;
using System.Text;

namespace _08Class_excercise02_SubscriptionModel
{
    public class MailService
    {
        public void Send(object source, VideoEventArgs args)
        {
            Console.WriteLine($"MailService: Video: {args.Video.Title} is encoded successfuly");
        }
        public void Update(int num)
        {
            Console.WriteLine("something else");
        }
    }
}
