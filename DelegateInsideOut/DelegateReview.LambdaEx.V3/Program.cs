namespace DelegateReview.LambdaEx.V3
{
    internal class Program
    {
        //viết dùm tôi hàm tính diện tích hình chữ nhật (width * length)
        //viết dùm tôi hàm mũ a^b, x^y

        //hàm phải trả về giá trị, ko được in ra kq, trả về rồi nơi gọi tự in
        //void thì hàm phải tự in
        //style hàm: double F(double a, double b)

        delegate double TwoInputsOneOutputDelegate(double x, double y);
        static void Main(string[] args)
        {
            TwoInputsOneOutputDelegate f = delegate (double x, double y)
            {
                return x + y;
            };//cách này dài quá


            f = (double x, double y) =>
            {
                return x + y;
            };//cách này vẫn dài quá


            f = (double x, double y) => x * y; //đến đây lambda gần ngắn nhất rồi đó


            f = (x, y) => x * y;//ngắn hơn xíu nữa nè, chốt hạ ở đây nha 
            // Y CHANG 1 BIỂU THỨC TOÁN HỌC - EXPRESSION, LAMBDA EXPRESSION
            Console.WriteLine("Compute area (10x15) using LAMBDA: " + f(10, 15));

            //viết hàm tính a^b, 2^10 = 1024 = 2.2.2.2.2.2.2.2.2.2
            //Math.pow(a, b)   

            f = (a, b) => Math.Pow(a, b);

            f = (namEm, NhaPhuong) => Math.Pow(namEm, NhaPhuong);

            Console.WriteLine("2^10 = (using LambdaEx) " + f(2, 10));

            //demo phần sau
            var fx = (int a, int b, int c) => a + b + c;
            Console.WriteLine("fx(3, 4, 5): " + fx(3, 4, 5));
        }
    }
} 
