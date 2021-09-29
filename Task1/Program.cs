using System;
using System.IO;

namespace IT1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader("C:\\Users\\User\\Desktop\\IT1\\Task1\\Input.txt"))
                {

                    String text = sr.ReadToEnd();
                    Char[] symbols = text.ToCharArray();

                    using (StreamWriter sw = new StreamWriter("C:\\Users\\User\\Desktop\\IT1\\Task1\\Output.txt", false))
                    {

                        for (int i = symbols.Length - 1; i >= 0; i--)
                        {
                            sw.Write(symbols[i]);
                        }
                    }
                }
                
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
