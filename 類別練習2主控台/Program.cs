using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 類別練習2主控台
{
     struct CoOrds
    {
        public int x, y;

        public CoOrds(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }

    struct Person
    {
        public string Name;
        public int Age;
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }
    }



        class Program
    {

        static void  FillArray(out int[] arr)
        {
          arr = new int[5] { 1,2,3,4,5};
        }

        static void Main(string[] args)
        {
           Students studente = new Students() { Name = "捷克", Grade = 3 };

            Console.WriteLine("學生姓名: {0} \n學生年級: {1}", studente.Name, studente.Grade);

            int[] arr;
            FillArray(out arr);

            Console.WriteLine("Array elements are:");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr: {0}", arr[i]);

            }

            
            
            Console.Write("請按任一鍵結束視窗");
            Console.ReadKey();

        }


        private static void ReadFile(string path)
        {

            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                    fs.Write(info, 0, info.Length);
                }

            }

            using (FileStream fr = File.OpenRead(path))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fr.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }
            }

        }
    }
}
