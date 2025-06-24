using System.Data;
using System.Threading.Channels;

namespace ActionGenericDelegate
{
    //challenge 6: viết hàm nhận vào 1 số nguyên dương, in ra bình phương của nó
    //có vài cách: - viết hàm lẻ có sẵn ngoài kia
    //             - anonymous function, lambda expression => xài delegate  

    //microsoft bảo rằng: hàm mà ko trả ra gì cả, gọi là hành động, action
    //tuy nhiên có loại hành động, hàm có cần đàu vào, 1 đầu, 2 đầu, 3 đầu, ... n đầu vào => cũng là hành động, cũng là action
    //tuy thế 1 đầu vào cũng có thể là int, long, student, float
    //        2 đầu vào cũng có thể là int|int, int|long, string|string, string|int

    //hàm nhiều tham số |tham số khác nhau về data type, thứ tự data type
    //vô chừng loại h àm như thế này!!!!!!

    //=======> đó chính là lúc generic xuất hiện, dù bạn int, long, char, person, student, bạn là data type T mà thôi..., lúc nào cần dùng, thay <T> bằng datatype cụ thể là xong

    delegate void OneInputNoOutputDelegate(int n);
    //                              void F(int x)

    //kể từ nay về sau, mỗi khi nói về hàm void, ko đầu vào, thì dùng:
    //               Action f = ...

    //                  mỗi khi nói về hàm void, có đầu vào, thì dùng: 
    //               Action<int>             f    = ...  hàm có 1 đầu vào int
    //               Action<char>            f    = ...  hàm có 1 đầu vào char
    //               Action<Studnet>         f    = ...  hàm có 1 đầu vào là student
    //               Action<Student, int>    f    = ...  hàm có 1 đầu vào là student, 1 đầu vào int
    //               Action<16 đầu vào>      f    = ...  hàm có 16 đầu vào, tùy data type bạn cần!

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("using action<> generic on the method with up to 16 params");
            Action<int> f = n => Console.WriteLine($"{n}^2 = {Math.Pow(n, 2)}");
            f(10);

            //challenge 10: hãy dùng Action<> tính mũ 3 của 1 con số và in ra, dùng luôn anonymous & lambda
            Action<int> f2 = n => Console.WriteLine($"{n}^3 = {Math.Pow(n, 3)}");
            f2(10);

            //challenge 11: viết hàm in ra diện tích hình chữ nhật - width, length
            Action<double, double> f3 = (width, length) => Console.WriteLine($"Dien tich hinh chu nhat la: {width * length}");
            f3(3, 4);

            //challenge 12: in ra các số chẵn từ 1 đến n...
            Action<int> f4 = n =>
            {
                if (n < 1)
                {
                    Console.WriteLine("n must be > 0");
                    return;
                }
                Console.Write($"các số chẵn từ 1 đến {n} là: ");
                for (int i = 0; i <= n; i++)
                    if (i % 2 == 0)
                        Console.Write(i + " ");
                Console.WriteLine();
            };
            f4(10);
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("\ncall method as normal");
        //    ComputeExponet(5);ll 

        //    Console.WriteLine("\ncall method using anonymous func");
        //    OneInputNoOutputDelegate f1 = n => Console.WriteLine($"{n}^2 = {Math.Pow(n, 2)}");
        //    f1(5);
        //    //lambda expression chứ ko phải expression body; do ko có tên hàm full

        //    Action<int> f2 = (n) => { Console.WriteLine($"{n}^2 = {Math.Pow(n, 2)}"); };
        //    f2(2);
        //}
        static void ComputeExponet(int x) => Console.WriteLine($"{x}^2 = {x * x}");
    }
}
