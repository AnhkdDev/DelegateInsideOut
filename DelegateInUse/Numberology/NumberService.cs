using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerology
{
    internal class NumberService
    {
        static private List<int> _arr = new List<int>() { -5, -10, -1, 5, 10, 15, 20, 1, 3, 4, 5, 7, 99, 100, 101 };

        public static void PrintNumbers(Action<int> f)
        {
            foreach (var x in _arr)
            {
                //f(x);   //TAO LẦN LƯỢT GỬI DATA CHO MÀY, cho hàm f() hàm f() làm gì với data thì kệ
                //nếu f() check x > 0 mới in
                //PrintNumbers() chính là hàm in ra các số > 0
            }


        }
        //style cũ: thiết kế đủ các loại hàm cung cấp data! đủ cỡ nào cũng ko là đủ, do nhu cầu tính toán khác nhau trên toàn bộ data: có người tính chẵn, lẻ, âm, dương, nguyên tố, chia hết cho 5, ...
        //viết hàm đếm cái gì đó trong dãy số: đếm chẵn, đếm lẻ, đếm nguyên tố
        //thuộc nhóm: giành kiểm soát, outsource 1 phần
        public static void Count(Predicate<int> f)  // = hàm checkNT(int x)
        {
            int count = 0;
            foreach (var x in _arr)
            {
                if (f(x))
                count++;
            }
            Console.WriteLine("count: " + count);
        }


    }
}
