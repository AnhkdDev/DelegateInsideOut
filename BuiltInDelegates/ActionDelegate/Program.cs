using Microsoft.Win32.SafeHandles;

namespace ActionDelegate
{

    //challenge 1: VIẾT HÀM IN RA CÂU THÔNG BÁO: NAM EM ĐÃ RA VIỆN RỒI!!!!
    //            VIẾT THEO STYLE TRUYỀN THỐNG

    //challenge 2: viết hàm in ra câu thông báo: nam em và 35 triệu!!!
    //              dùng delegate & anonymous function

    //challenge 3: viết hàm in ra câu thông báo: chúng ta của tương lai!!
    //              dùng delegate & lambda

    //challenge 4: dùng lại hàm của challenge 1 kết hợp với delegate

    //challenge 5: ko dùng delegate do ta tạo ra, NoInputNoOutputDelegate() any more
    //microsoft, .net sdk cung cấp sẵn cho ta 1 delegate syle void F()
    //gọi là: Action, làm đi, hành động đi, run đi, vậy thôi, ko cần vào, ko cần ra

    //=====> NẾU SAU NÀY BẠN CẦN LÀM VIỆC VỚI HÀM KO VÀO KO RA THÌ TA KO CẦN TẠO DELEGATE MÀ XÀI LUÔN Action và chỉ việc khai báo biến = trỏ đến hàm nào là xong

    //in ra câu thông báo: chúng ta của tương lai | Sơn Tùng M-TP vs. Hải Tú vs. Thiều Bảo Trâm
    delegate void NoInputNoOutputDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            NoInputNoOutputDelegate f1 = delegate() { };
            NoInputNoOutputDelegate f2 = () => { };
            //Action f3 = () => { };

            Console.WriteLine("c5: action");
            Action f4 = ShowNotification;//truyền thống hàm có sẵn ngoài kia
            f4();

            Action f5 = () =>  Console.WriteLine("chúng ta của tương lai | Sơn Tùng M-TP vs. Hải Tú vs. Thiều Bảo Trâm");
            f5();
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("challenge 1: call method as nomal");
        //    ShowNotification();

        //    Console.WriteLine("challenge 2: call method as delegate and anonymous func");
        //    NoInputNoOutputDelegate f1 = delegate ()
        //    {
        //        Console.WriteLine("nam em và 35 triệu!\n");
        //    };
        //    f1();

        //    Console.WriteLine("challenge 3: call method as delegate and Lambda");
        //    NoInputNoOutputDelegate f2 = () => Console.WriteLine("chúng ta của tương lai\n");
        //    f2();

        //    Console.WriteLine("challenge 4: call method as delegate and Explicit method");
        //    NoInputNoOutputDelegate f4 = ShowNotification;  //gán = 1 hàm có sẵn
        //                    //luật sư  =   Thân chủ
        //     f4();
        //}
        static void ShowNotification() => Console.WriteLine("2/3/2024: nam em đã ra viện!!!\n");

    }
}

