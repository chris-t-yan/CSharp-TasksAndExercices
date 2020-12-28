using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _08Class_excercise02_SubscriptionModel
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class SomeOtherArgs
    {
        public int Number { get; set; }
    }
    public class VideoEncoder
    {
        //1. define delegate
        //2. define event based on that delegate
        //3. raise the event

        public delegate void VideoEncodeEventHandler(object source, VideoEventArgs args);
        public VideoEncodeEventHandler VideoEncodedEventHandler;

        //EventHandler - return type = void, (object sender, EventArgs args)
        //EventHandler<TEventArgs> - return type = void, (object sender, TEventArgs )
        public EventHandler EncodeVideo;
        public EventHandler<SomeOtherArgs> EncodeVideoGeneric;
        public void Encode (Video video)
        {
            //encoding implementation
            //MailService.Send()
            //MessageService.Send()
            //OnVideoEncoded()
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncodedEventHandler?.Invoke(this, new VideoEventArgs(){ Video = video });
        }
    }
}
