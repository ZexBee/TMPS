using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeBoxBuilder builder = new MakeBoxBuilder();

            builder.Length(2.5);
            builder.Width(5);
            builder.Height(4.25);
            builder.TextOnBox("Cadou pentru familia Botnaru");
            builder.Wrapped(true);
            builder.To("Alexandru Botnaru");

            MakeBox box = builder.Build();

            Console.ReadLine();
        }
    }
}
