﻿using System;


namespace EventHandlerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Encoder encoder = new Encoder();
            //MailService mailService = new MailService();
            //MessageService messageService = new MessageService();
            //encoder.EncoderEvent += mailService.Onceencode;
            //encoder.EncoderEvent += messageService.SendMssg;

            //encoder.Doencoding();
            ////Console.ReadLine();

            ////SystemCollections systemCollections = new SystemCollections();
            ////systemCollections.checkCollections();

            //SystemGenericCollections systemGenericCollections = new SystemGenericCollections();
            //systemGenericCollections.checkGenericCollections();
            //check check = new check();
            //check.Check();

            //AsynAwait asynAwait = new AsynAwait();
            //asynAwait.check();
            //NestedClass.Nested obj = new NestedClass.Nested();
            //obj.check();

            //Overriding overriding = new Overriding();
            //overriding.check();

            //string s = "Hello Extension Methods";
            //int i = s.WordCount();

            //Indexer indexer = new Indexer();
            //indexer[1] = 1;
            // Console.WriteLine(indexer[0]);

            //EmptyClass emptyClass = new EmptyClass();
            //Console.WriteLine(emptyClass);

            Generic generic = new Generic();
            generic.check();


            Console.ReadLine();
        }

    }

    class Encoder
    {
        public  delegate void OnecodingNotify(EventArgs eventArgs);
        public event OnecodingNotify EncoderEvent;
        public void Doencoding()
        {
            OnEncoded();
        }

        private void OnEncoded()
        {
            if(EncoderEvent!=null)
            {
                EncoderEvent(EventArgs.Empty);
            }
            
        }
    }
     class MailService
    {
       public  void Onceencode(EventArgs eventArgs )
        {
            Console.WriteLine("Sending MAi;");
        }
    }

    class MessageService
    {
        public void SendMssg(EventArgs eventArgs)
        {
            Console.WriteLine("Sending message");
        }
    }
}