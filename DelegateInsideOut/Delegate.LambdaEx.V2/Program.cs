namespace DelegateReview.LambdaEx.V2
{
    //ta chơi với hàm có 1 đầu vào, ko trả về gì cả, style void f(int)
    //challenge: in các số 1...n
    //chơi anonymous, chơi lambda

    delegate void HaveInputNoOutPut(int n);
    internal class Program
    {
        static void Main(string[] args)  
        {
            //HaveInputNoOutPut f = delegate (int n)
            //{
            //if (n <= 0)
            //{
            //    Console.WriteLine("vui long nhap vao so tu nhien > 0");
            //    return;
            //}
            //Console.WriteLine("the list of numbers from 1 to " + n);
            //for (int i = 0; i <= n; i++)
            //{
            //    Console.Write($"{i} ");
            //}
            //};

            HaveInputNoOutPut f = (int n) =>
            {
                if (n <= 0)
                {
                    Console.WriteLine("vui long nhap vao so tu nhien > 0");
                    return;
                }
                Console.WriteLine("the list of numbers from 1 to " + n);
                for (int i = 0; i <= n; i++)
                {
                    Console.Write($"{i} ");
                }
            };      //vip => lambda version 1
            Console.WriteLine();
           // f(1000);

            HaveInputNoOutPut fn = (n) =>
            {
                if (n <= 0)
                {
                    Console.WriteLine("vui long nhap vao so tu nhien > 0");
                    return;
                }
                Console.WriteLine("the list of numbers from 1 to " + n);
                for (int i = 0; i <= n; i++)
                {
                    Console.Write($"{i} ");
                }
            };      //vip => lambda version 2 - loại bỏ data type
                    //java giống 100%
            Console.WriteLine();
            //fn(50);


            fn = n =>
            {
                if (n <= 0)
                {
                    Console.WriteLine("vui long nhap vao so tu nhien > 0");
                    return;
                }
                Console.WriteLine("the list of numbers from 1 to " + n);
                for (int i = 0; i <= n; i++)
                {
                    Console.Write($"{i} ");
                }
            };      //vip => lambda version 3 - loại bỏ data type trong tham số VÀ DẤU NGOẶC ĐẦU VÀO NẾU CHỈ CÓ 1 THAM SỐ LUÔN
             
            Console.WriteLine();
            //fn(50);


            fn = ngocTrinh =>
            {
                if (ngocTrinh <= 0)
                {
                    Console.WriteLine("vui long nhap vao so tu nhien > 0");
                    return;
                }
                Console.WriteLine("the list of numbers from 1 to " + ngocTrinh);
                for (int i = 0; i <= ngocTrinh; i++)
                {
                    Console.Write($"{i} ");
                }
            };      //vip => lambda version 4 - biến đầu vào đặt tên gì cũng được
                    
            Console.WriteLine();
            fn(56);

        }
    }
}
