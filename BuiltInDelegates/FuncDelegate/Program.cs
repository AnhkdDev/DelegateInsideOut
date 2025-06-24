using System.Security.Cryptography.X509Certificates;

namespace FuncDelegate
{
    delegate double OneInputOneOutputDelegate(double x);
    //microsoft lại bảo rằng: nếu hàm có trả về giá trị int, long, char, double, pet, cat,...
    // và hàm có thể có đầu vào hay ko thì kệ thì hãy xài 1 cái delegate style generic tên là Func<>
    //Func<int>              =>      hàm ko đầu vào trả về int
    //Func<long>             =>      hàm ko đầu vào trả về long
    //Func<string>           =>      hàm ko đầu vào trả về string
    //Func<Dog>              =>      hàm ko đầu vào trả về Dog

    //Func<int, int>         =>      hàm có đầu vào int, trả về int
    //Func<double, double, double>         =>      hàm có 2 đầu vào double, double trả về double

    //BÊN PHẢI NHẤT LÀ ĐẦU RA, CÒN LẠI LÀ ĐẦU VÀO, CHƠI GENERIC CẢ ĐÁM
    //HÀM CÓ 5 ĐẦU VÀO THÌ + 1 ĐẦU RA => 6 GENERIC
    //HÀM CÓ TỐI ĐA 16 ĐẦU VÀO T1 T2 T3, ... T16 CỘNG VỚI THẰNG ĐẦU RA T RESULT 
    //HÀM CÓ KO ĐẦU VÀO => 17 LOẠI HÀM

    //Func<int, int, long, char, Student, float, Pet, Lecturer,... int>
    //      -------------------------------------------------      ----
    //                      đầu vào                                 đầu ra

    internal class Program
    {
        //challenge 13: viết hàm nhận vào 1 con số sau đó trả về bình phương của nó!
        //có return, ko in trong hàm 
        static void Main(string[] args)
        {
            OneInputOneOutputDelegate f1 = ComputeExponent;
            Console.WriteLine($"10^2 = " + f1(10));

            //challenge 14: tính bình phương 1 con số rồi trả về kq
            Func<double, double> f2 = n => n * n;
            Console.WriteLine("c14: method returns value using func<>");
            Console.WriteLine("1000^2 = " + f2(1000));

            //challenge 15: viết hàm tính chu vi của tam giác
            Func<double, double, double, double> f3 = (x, y, z) => x + y + z;
            Console.WriteLine("c15: triangle func<>");
            Console.WriteLine("chu vi hinh tam giac la: " + f3(1, 2, 3));

            //challenge 16: viết hàm trả về 1 con số bất kì ( ngẫu nhiên mà bạn thích ) 2204 mãi mãi k chết  
            Func<int> getMyOwnNumber = () => 6789;
            Console.WriteLine("c16: RANDOM NUMBER<>");
            Console.WriteLine("my own number " + getMyOwnNumber());

            //challenge 17: viết h àm nhận vào 1 con số double Gpa - điểm trung bình trả về đúng true nếu gpa >= 8, trả về false nếu gpa đưa vào < 8
            Func<double, bool> ff = n => n >= 8;
            Predicate<double> f4 = n => n >= 8;
            Console.WriteLine("10 >= 8? " + f4(4));
        }

        static double ComputeExponent(double x) => x * x;

        //gt ở đây là greater than
        static bool CheckGradeGtEq8(double gpa) => gpa >= 8;


        //gt ở đây là greater than
        //static bool CheckGradeGtEq8(double gpa)
        //{
        //    if (gpa >= 8)       //biểu thức so sánh luôn trả về true/false
        //        return true;    //return luôn biểu thức so sánh cho rồi
        //    return false;       //đằng nào cũng cần ném ra true/false
        //                        //ném luôn biểu thức so sánh cho rồi

        //}
    }
}
