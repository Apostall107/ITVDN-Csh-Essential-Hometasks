using System;

namespace EssentialI_ITVDN_09
{

    public delegate void MyDelegate(int first, int second, int third);

    delegate T Calculate<T>(T a ,T b);

    delegate int CalculateAVG_adder();
    delegate void CalculateAVG(CalculateAVG_adder[] x);




    class Program
    {

        static int GetRandom()
        {
            return new Random().Next(100);
        }
        static void Main(string[] args)
        {
            ExDeviderV2.AdditionalEx();

            MyDelegate my_delegate = delegate (int first, int second, int third)
            {
                Console.WriteLine("AVG:" + (first + second + third) / 3);
            };

            my_delegate.Invoke(1, 2, 3);



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ExDeviderV2.Ex2();
            Calculate<double> calculate = null;


            Console.WriteLine("enter 1st number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter 2nd number");
            int b = Convert.ToInt32(Console.ReadLine());
        L2:
            Console.WriteLine("Enter operator(+,-,*,/)");
            string @operator = Convert.ToString(Console.ReadLine());

            switch (@operator)
            {
                case "+":
                    calculate = (x, y) => { return x + y; };
                    break;
                case "-":
                    calculate = (x, y) => { return x - y; };
                    break;
                case "*":
                    calculate = (x, y) => { return x * y; };
                    break;
                case "/":
                    calculate = (x, y) =>
                    {
                        if (y != 0)
                        {
                            return x / (double)y;
                        }
                        else
                        {
                            Console.WriteLine("Division by 0 is not allowed!");
                            return 0;
                        }
                    };
                    break;
                default:
                    Console.WriteLine("no such an operation!");
                    goto L2;
            }
            ExDeviderV2.Line();
            if (calculate != null)
                Console.WriteLine("{0:#.####}", calculate(a, b));

            
            
            
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ExDeviderV2.Ex3();

            Random rand = new Random();

            int N = 5;

            var arr = new CalculateAVG_adder[N];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = () => new CalculateAVG_adder(GetRandom).Invoke();
                Console.WriteLine(arr[i].Invoke());
            }

            
            CalculateAVG calculateAVG_res = delegate(CalculateAVG_adder[] c)
                {
                    int sum = 0;
                    for (int i = 0; i < c.Length; i++)
                    {
                        sum += c[i].Invoke();
                    }
                    Console.WriteLine("Avg = "+ sum/c.Length);
                };

            calculateAVG_res(arr);

            Console.ReadKey();
      
        }



    }
}
