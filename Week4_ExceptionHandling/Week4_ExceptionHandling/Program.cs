using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var input = int.Parse(Console.ReadLine());
                Console.WriteLine(SumOfIntegers(input));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            Console.WriteLine(DateTime.Now);

            Console.ReadKey(true);
        }

        static int SumOfIntegers(int integer)
        {

            var output = 0;

            if (integer <= 0) throw new UnderflowException();
            if (integer > 15) throw new TooBigException();

            foreach (var item in integer.ToString())
            {
                output += int.Parse(item.ToString()) ;
            }
            return output;


        }
    }
    
    [Serializable]
    public class UnderflowException : Exception
    {
        //<snippet>
        public UnderflowException() {}
        public UnderflowException(string message) : base(message) { }
        public UnderflowException(string message, Exception inner) : base(message, inner) { }
        protected UnderflowException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        //https://social.technet.microsoft.com/wiki/contents/articles/30509.c-setting-custom-messages-in-user-defined-exceptions.aspx
        public override string Message
        {
            get
            {
                return "Integer too small";
            }

        }
    }


    [Serializable]
    public class TooBigException : Exception
    {
        public TooBigException() { }
        public TooBigException(string message) : base(message) { }
        public TooBigException(string message, Exception inner) : base(message, inner) { }
        protected TooBigException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }


        public override string Message
        {
            get
            {
                return "Integer too big";
            }

        }
    }
}
