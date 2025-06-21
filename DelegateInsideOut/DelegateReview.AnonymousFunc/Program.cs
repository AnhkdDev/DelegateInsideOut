namespace DelegateReview.AnonymousFunc
{
    //khai báo datatype, class chứa các hàm thuộc style void F()
    public delegate void NoInputNoOutputDelegate();

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("call method directly - not using delegate");
            //PrintNumbers();//ko xài thân chủ - luật sư, call hàm directly
            //chơi trực tiếp hàm với tên gọi gốc - truyền thống

            Console.WriteLine("call method indirectly - using delegate");
            NoInputNoOutputDelegate f1 = PrintNumbers;
            //f1();


            f1 = delegate ()        //KHỎI CẦN TÊN HÀM, DÙNG F CHO RỒI, BÁN TÊN, BÁN LINH HỒN CHO QUỶ DỮ
            {
                Console.WriteLine("the list of even number from 1 ... 100");
                for (int i = 0; i <= 100; i++)
                {
                    if (i % 2 == 0)
                        Console.Write($"{i} ");
                }
                Console.WriteLine();
            };//VIP ĐỂ KẾT THÚC 1 LỆNH - 1 PHÉP GÁN HỢP ĐỒNG CHO LUẬT SƯ THÂN CHỦ
            //ĐOẠN CODE Ở TRÊN, MÀY THUỘC HÀM NÀO?????????? HÀM PHẢI CÓ TÊN
            //dạ ngày xưa em thuộc hàm PrintEvenNumbers nay bán cái tên đi rồi, còn lại xử lí thôi, gọi hàm cũ qua tên mới f, delegate ủy quyền hàm cũ, xử lí hàm cũ CHO F NÓ ĐẠI DIỆN 

            //HÀM GỐC KO CẦN TÊN MÀ SẼ GỌI QUA HỢP ĐỒNG VỚI LUẬT SƯ!!!!!!!
            //HÀM ẨN DANH - ANONYMOUS FUNCTION
            //ĐOẠN CODE CỦA HÀM GỐC, NAY DÙNG NICK NAME / TÊN LUẬT SƯ!!!
            //chỉ còn lại 1 tên mà éo phải là tên gốc
            //gọi bth nhưng qua tên mới
            //luật sư phát ngôn - run hàm
            Console.WriteLine("call method indirectly - using anonymous function 1");
            //f1();

            //thách thức: in ra các số lẻ tử 1 ... 100
            // bắt buộc phải dùng anonymous

            //f1 = delegate ()
            //{
            //    Console.WriteLine("list of odd number from 1 ... 100:");
            //    for (int i = 0; i <= 100; i++)
            //        if (i % 2 != 0)
            //            Console.Write($"{i} ");
            //    Console.WriteLine();
            //};
            //Console.WriteLine("call method indirectly - using anonymous function 2");
            //f1();

            //hack não: in vừa chẵn vừa lẻ
            Console.WriteLine("chẵn lẻ song hành");
            f1 += delegate ()
            {
                Console.WriteLine("list of odd number from 1 ... 100:");
                for (int i = 0; i <= 100; i++)
                    if (i % 2 != 0)
                        Console.Write($"{i} ");
                Console.WriteLine();
            };
            Console.WriteLine("call method indirectly - using anonymous function 2");
            //f1();

            //in thêm dãy chia hết cho 5 rồi thôi
            f1 += delegate ()
            {
                Console.WriteLine("list of number chc 5 from 1 ... 100:");
                for (int i = 0; i <= 100; i++)
                    if (i % 5 == 0)
                        Console.Write($"{i} ");
                Console.WriteLine();
            };
            f1();

        }
        //challenge: viết hàm in ra các số tự nhiên từ 1 đến 100
        static void PrintNumbers()
        {
            Console.WriteLine("the list of number from 1 ... 100");
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        //challenge: viết hàm in ra các số chẵn từ 1 đến 100
        //static void PrintEvenNumbers()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("the list of even number from 1 ... 100");
        //    for (int i = 0; i <= 100; i++)
        //    {
        //        if (i % 2 == 0)
        //            Console.Write($"{i} ");
        //    }
        //    Console.WriteLine();
        //}
    }
}
