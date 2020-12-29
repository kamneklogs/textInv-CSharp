using System;
using System.IO;

namespace textInversorCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Reader myReader = new Reader();

            string text = myReader.readFile();

            System.Console.WriteLine(text);
        }
    }


    class Reader
    {
        string s { get; set; }

        StreamReader reader;


        public Reader()
        {
            reader = new StreamReader("t.txt");
        }


        public string readFile()
        {


            return reader.ReadLine();
        }





    }
}
