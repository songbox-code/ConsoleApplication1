using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    enum name : byte
    {
        Chongchong,
        JiaHe,
        XiaoHuoJi
    }
    struct baby
    {
        public name babyName;
        public uint age;
    }

    class Program
    {
        //声明委托
        delegate double ProDelegate(double a, double b);
        static double Plus(double a,double b)
        {
            return a + b;
        }
        static double Minus(double a,double b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("The First app in Beginning C#");
            //Console.ReadKey();
            int i = 0;
            do
            {
                Console.WriteLine("{0}", i++);
            } while (i <= 10);
            //Console.ReadKey();

            name myname = name.JiaHe;
            baby baby1;
            baby1.babyName = myname;
            baby1.age = 1;
            Console.WriteLine("baby name is {0}", baby1.babyName);
            Console.WriteLine("baby name is {0}", (byte)baby1.babyName);
            Console.WriteLine("baby age is {0}", baby1.age);
            //Console.ReadKey();

            string str1 = "A string";
            char[] myChars = str1.ToCharArray();
            foreach (char character in myChars)
            {
                Console.WriteLine("{0}", character);
            }
            //Console.ReadKey();

            //委托
            ProDelegate process; //用声明的委托名在建立委托
            string input = Console.ReadLine();
            char[] separator = { ',' };
            string[] myWords = input.Split(separator);
            double a, b;
            a = Double.Parse(myWords[0]);
            b = Double.Parse(myWords[1]);
            //a = Convert.ToDouble(myWords[0]);

            string op = myWords[2].ToLower();
            if (op == "p") //感觉委托只是把通类型，同参数的函数统一成一个名了，方便调用而已
            {
                process = Plus;
            }
            else
            {
                process = Minus;
            }

            Console.WriteLine("Result:{0}", process(a, b));//最后还需要调用



            Console.ReadKey();
        }
    }



    
}
