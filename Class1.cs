using System;

namespace layer
{
    public class Hello
    {
        public static string hi() {
            string message = "hello from lambda layer";
            Console.Write(message);
            return message;
        }
    }
}
