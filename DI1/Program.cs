using System;

namespace DI1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ISender gsm = new RightelGsm();
            TextSedner sender = new TextSedner(gsm);
            sender.Send("tci","hi","0912");
           
            Console.ReadKey();

        }
    }


    public class TextSedner
    {

        ISender sender;
        public TextSedner(ISender sender)
        {
            this.sender = sender;
        }
        public  void Send(string gsmType,string text, string phone)
        {
            sender.Send(text, phone);
        }

    }

    //public static  class ServiceLocator
    //{
    //    private static  ISender sender;
    //    public static ISender SetLocation(string sender)
    //    {
    //        if (sender == "tci")
    //        {
    //            return new TciGsm();
    //        }
    //        return new MtnGsm();
    //    }


    //}

    public class MtnGsm:ISender
    {
        public void Send(string phone, string text)
        {
            Console.WriteLine("Send By MTN");
        }
    }
    public class TciGsm: ISender
    {
        public void Send(string phone,string text)
        {
            Console.WriteLine("Send By TCI");
        }
    }
    public class RightelGsm : ISender
    {
        public void Send(string phone, string text)
        {
            Console.WriteLine("Send By RightelGsm");
        }
    }



}
