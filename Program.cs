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



            System.Console.WriteLine(Inv.invString(text));
        }
    }

    class Inv
    {

        public static string invString(string s)
        {

            string input = s, output = "";


            for (int i = input.Length; i > 0; i--)
            {

                output = output + input[i - 1];

            }

            return output;
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
