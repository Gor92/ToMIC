using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static List<string> EmailList()
        {
            List<string> str1 = new List<string>();
            string line = "";
            string file = "TextFile1.txt";
            StreamReader s = new StreamReader(file);
            while (s.EndOfStream == false)
            {

                line = s.ReadLine();
                if (line != null)
                {
                    string email = "";
                    int lt = line.IndexOf("<");
                    int gt = line.IndexOf(">");
                    email = line.Substring(lt + 1, gt - lt - 1);
                    str1.Add(email);
                }
            }
            s.Close();
            foreach (var item in str1)
            {
                Console.WriteLine(item);
            }
            return str1;
        }
        static List<string> FullName()
        {
            string line = "";
            string file = "TextFile1.txt";
            List<string> str = new List<string>();
            StreamReader s = new StreamReader(file);

            while (s.EndOfStream == false)
            {

                line = s.ReadLine();
                if (line != null)
                {

                    string fullname = "";

                    int lt = line.IndexOf("<");
                    int gt = line.IndexOf(">");
                    fullname = line.Substring(0, lt);


                    str.Add(fullname);
                }
            }
            s.Close();
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------");


            return str;
        }
        static void Main(string[] args)
        {
            FullName();
            EmailList();
        }
    }
}
