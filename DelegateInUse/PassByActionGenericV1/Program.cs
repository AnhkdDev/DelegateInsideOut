using System.Reflection.Metadata;

namespace PassByActionGenericV1
{
    //challenge 1: viết hàm nhận vào 1 con số và in ra con số đó nếu đó là số chẵn
    //             viết hàm nhận vào 1 con số và in ra con số đó nếu đó là số lẻ
    //             viết hàm nhận vào 1 con số và in ra con số đó nếu đó là số lớn hơn hoặc bằng 50
    //             viết hàm nhận vào 1 con số và in ra con số đó nếu đó là số nguyên tố
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //gọi lẻ 4 hàm là style truyền thống, ko thèm nói!!!
        //Console.WriteLine("round 1: ");
        //PrintEvenNumber(5);     //k in
        //PrintOddNumber(5);      //5 
        //PrintPrimeNumber(5);    //5
        //PrintNumberGt50(5);     //k in

        //Console.WriteLine("round 2: ");
        //PrintEvenNumber(10);     //10
        //PrintOddNumber(11);      //11
        //PrintPrimeNumber(13);    //13
        //PrintNumberGt50(50);     //50


        //Console.WriteLine("style nhà thầu");
        //Action<int> f = PrintEvenNumber;
        //f += PrintOddNumber;
        //f += PrintPrimeNumber;
        //f += PrintNumberGt50;
        //f(50);
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("print even number from 5, 10, 15, 20");
            PrintOnDemain(PrintEvenNumber); // in chẵn từ dãy 5, 10, 15, 20

            Console.WriteLine("print odd number from 5, 10, 15, 20");
            PrintOnDemain(PrintOddNumber); // in lẻ từ dãy 5, 10, 15, 20

            Console.WriteLine("print prime number from 5, 10, 15, 20");
            PrintOnDemain(PrintPrimeNumber); // in nguyên tố từ dãy 5, 10, 15, 20

            Console.WriteLine("print >= 50 number from 5, 10, 15, 20");
            PrintOnDemain(PrintNumberGt50); // in >= 50 từ dãy 5, 10, 15, 20
            //nothing 

            //challenge 2: thách thức danh hài: in ra các số chia hết cho 5
            //challenge 3: có số nào in số nấy, in hết
            Console.WriteLine("print divisable by 5 number from 5 10 15 ...");
            PrintOnDemain(n => { if (n % 5 == 0) Console.WriteLine(n); });

            Console.WriteLine("print all 5 10 15 20 25 ...");
            PrintOnDemain(n => Console.WriteLine(n));
            //tao cung cấp 1 con n bên trong cho mày, mày làm gì với n thì kệ mày
            //có thằng sẽ check n là nguyên tố thì mới in, có thằng thì check chẵn mới in, có thằng thì gọi luôn!!!!!!
        }

        //làm hàm style thầu dịch vụ
        // tao là 1 h àm nhận vào 1 h àm khác có tham số int x
        //tao chịu trách nhiệm gọi hàm bên ngoài đưa vào, tao thảy cho nó 
        //tao phó mặc cho hàm đố làm gì thì làm với có số tao thảy cho
        //tao trở nên linh hoạt với nhu cầu xử lí data của mọi người
        //khi tao chỉ thảy data của tao cho mọi người
        static void PrintOnDemain(Action<int> f)
        {
            //đầu vào lấy ở đâu mà đưa cho f
            //giả sử mình có sẵn data 5 10 15 20 25 26 29
            f(5);
            //data bên trong class mình viết chứa hàm TraiBao() sẽ gửi cho hàm đâu đó bên ngoài, outsource xử lí data bên ngoài
            f(10);
            f(15);
            f(20);
            f(25);
            f(36);
            f(29);

            //nhờ bên ngoài filter data theo cách của h ọ 
            //tập data 5 10  15 20 ... trong nội tại sẽ được cung ứng ra bên ngoài
            //bên ngoài xem xét data phù hợp hay ko và sẽ dùng
            //cung ứng dịch vụ xử lí data theo nhu cầu
            //bác nào muốn xử lí, em đưa data cho bác xử lí
            //
        }

        static void PrintOnDemainV2(Action<int> f)
        {
            //nếu ta có nhiều data cần sàng lọc theo nhu cầu bên ngoài, đưa data vào trong mảng
            //lever hôm qua: TAO GỌI MÀY, MÀY LÀM ĐI, Action f, làm trọn gói đóng kín luôn
            //lever hôm nay: ta gọi mày, mày làm đi Action<int> f. tao tử tế gửi thêm
        }


        static void PrintEvenNumber(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine(n);
            }
        }
        static void PrintOddNumber(int n)
        {
            if (n % 2 != 0)
            {
                Console.WriteLine(n);
            }
        }
        static void PrintNumberGt50(int n)
        {
            if (n >= 50)
            {
                Console.WriteLine(n);
            }
        }
        static void PrintPrimeNumber(int n)
        {
            if (n < 2)
                return;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return; //lỡ chia hết nhỏ nào là thoát luôn, ko in
            }
            Console.WriteLine(n); //sống sót đến đây là số nguyên tốt chắc luôn!!!
        }

    }
}
