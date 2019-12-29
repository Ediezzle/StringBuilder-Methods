using System;
using System.Text;

namespace StringBuilderMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello ", 50);

            sb.Append("World!!");
            sb.AppendLine("Hello C#!");
            sb.AppendLine("This is new line.");
            Console.WriteLine(sb);

            StringBuilder amountMsg = new StringBuilder("Your total amount is ");
            amountMsg.AppendFormat("{0:C} ", 25);
            Console.WriteLine(amountMsg);

            sb = new StringBuilder("Hello World!!", 50);
            sb.Insert(5, " C#");
            Console.WriteLine(sb);

            sb = new StringBuilder("Hello World!!", 50);
            sb.Remove(6, 7);
            Console.WriteLine(sb);

            sb = new StringBuilder("Hello World!!", 50);
            sb.Replace("World", "C#");
            Console.WriteLine(sb);

            sb = new StringBuilder("Hello World!!");
            for (int i = 0; i < sb.Length; i++)
                Console.Write(sb[i]);
            Console.WriteLine();

            Console.WriteLine(());
        }
    }
}
