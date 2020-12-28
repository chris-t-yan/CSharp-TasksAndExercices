using System;
using System.Collections.Generic;
using System.Text;

namespace _08Class_excercise02_SubscriptionModel
{
    public class MessageService
    {
        public void Send(object source, VideoEventArgs args)
        {
            Console.WriteLine($"MessageService: Video: {args.Video.Title} is encoded successfuly");
        }
    }
}
