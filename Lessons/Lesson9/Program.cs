using System;
using System.Collections.Generic;
using System.IO;

namespace Lesson9
{
    class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader("Example.txt");
            List<string> strings = new List<string>();
            string line;
            while((line = sr.ReadLine())!=null)
            {
                strings.Add(line);
            }  
            sr.Close();
            
            using (StreamWriter sw = new StreamWriter("Example.txt", true))
            {
                sw.WriteLine("То ли еще будет");
                sw.WriteLine("Ой-ой-ой.");
            }
            //StreamWriter sw = new StreamWriter("Example.txt",true);
            
            //sw.Close();
        }
    }
}
