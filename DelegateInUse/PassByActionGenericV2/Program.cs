namespace PassByFuncGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tính tổng chẵn
            Console.WriteLine("sum of even numbers");
            SumOnDemand(CheckEven);

            //tính tổng lẻ
            Console.WriteLine("sum of even numbers");
            SumOnDemand(n => (n % 2 != 0));

            //tính tổng tất cả
            Console.WriteLine("sum of all");
            SumOnDemand(n => true);
            //đưa x nào em cũng lấy, em trả về true cho mọi x

        }

        static bool CheckEven(int n) => (n % 2 == 0);


        //static bool CheckEven(int n)
        //{
        //    if(n % 2 == 0) return true;
        //    return false;
        //}

        //challenge: viết hàm tính tổng của 1 dãy số cho trước
        //           vẫn dãy số đó, tính tổng của số chẵn
        //           vẫn dãy số đó, đếm các số lẻ
        //           5 10 15 20 2 4 6 8 1 3 5 7 9

        //tính toán theo cái điều kiện đưa vào
        //sum: sum theo cái gì ( điều kiện đưa vào): sum chẵn, sum lẻ, sum nguyên tố
        //count: count cái gì
        static void DoOnDemand(Predicate<int> f)    // = hàm bool f(int x)
        {                                             //CheckEven(int x) => true false  

        }

        static void SumOnDemand(Func<int, bool> f)  // = hàm bool f(int x)
        {
            List<int> list = new List<int>() { 5, 10, 15, 20, 2, 4, 6, 8, 1, 3, 5, 7, 9 };
            int result = 0;
            foreach (int x in list)
            {//if đúng con x (tiêu chí nào đó) thì 
             //con x luôn đúng chả xét theo tiêu chí gì cả
             //mình hàm TraiBao giành lại con x để làm gì tiếp
                if (f(x) == true)//checkEven(x)
                    result += x;
                
            }
            Console.WriteLine("sum: " + result);


        }

     
        static void DoOnDemand()
        {

        }

    }
}
