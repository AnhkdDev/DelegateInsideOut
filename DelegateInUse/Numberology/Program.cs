namespace Numerology
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1. in hết dãy số có trong number service
            //Console.WriteLine("print all numbers");
            //NumberService.PrintNumbers(x => Console.WriteLine(x));

            ////2. in các số âm trong kho
            //Console.WriteLine("print số âm");
            //NumberService.PrintNumbers(x => { if (x < 0) Console.WriteLine(x); });

            //đếm tổng số lớn hơn 0
            Console.WriteLine("> 0: ");
            NumberService.Count(n => n > 0);

            Console.WriteLine("< 0: ");
            NumberService.Count(n => n < 0);


        }

        //hàm lẻ nhận vào x làm gì với x thì kệ: void F(int x) {... hay in luôn}
    }
}
