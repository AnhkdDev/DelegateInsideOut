namespace DelegateReview.LambdaEx
{
    internal class Program
    {
        //challenge: in cho tui tổng các số từ 1 ... 100 => 5050
        //hàm void F();
        public delegate void NoInputNoOutputDelegate();
        static void Main(string[] args)
        {
            NoInputNoOutputDelegate f = delegate ()
            {
                int sum = 0;
                Console.Write("sum (1 ... 100) = ");
                for (int i = 0; i <= 100; i++)
                    sum += i;
                Console.WriteLine(sum);
            };  //hợp đồng bán tên - vô danh

            //phát ngôn - run()
            //f();

            //tui mún tính tổng các số chẵn từ 1 ... 10
            //2 4 6 8 10 => 30;
            //  =====> KĨ THUẬT RÚT GỌN PHÂN SỐ/ BIỂU THỨC
            //RÚT GỌN ANONYMOUS MEHTHOD ĐỂ CHỈ CÒN CÁI DÂY NỊT => LAMBDA EXPRESSION
            f += () =>
            {
                int sum = 0;
                Console.Write("sum of evens numbers (1 ... 10) = ");
                for (int i = 0; i <= 10; i++)
                    if (i % 2 == 0)
                        sum += i;
                Console.WriteLine(sum);
            };  //hợp đồng bán tên - vô danh
            Console.WriteLine("to see the sum of 30: ");
            f();
            //CHỐT HẠ: 
            //BIỂU THỨC LAMDA: BẢN CHẤT LÀ HÀM ANONYMOUS NHƯNG VIẾT RÚT GỌN ĐẾN MỨC TỐI GIẢN - CHỈ CÒN CÁI DÂY NỊT
            //CÓ CÂU: LAMBDA LÀ ANONYMOUS 
            //        ANONYMOUS KHÔNG HẲN LÀ LAMBDA NẾU CHƯA TỐI GIẢN
            //

            //          EXPRESSION BODY VÀ LAMBDA EX DÙNG CHUNG KÍ HIỆU => 
            //NHƯNG KHÁC NHAU
            //EXPRESSION BODY: HÀM VẪN CÒN FULL TÊN, HÀM CHRI CÓ 1 LỆNH => RÚT GỌN LUÔN CẢ CẶP DẤU {}
            //LAMBDA EX: BỐI CẢNH HÀM VÔ DANH, CHƠI VỚI DELEGATE
            //           HÀM KO CÓ TÊN;
            //           CÓ THỂ RÚT GỌN {} HOẶC KO TÙY HÀM NHIỀU LỆNH HAY ÍT LỆNH.
            //           HÀM 1 LỆNH ĐƯỢC QUYỀN LOẠI BỎ {} 

            //CÚ PHÁP GÕ LAMBDA
            //Tên-datatype-delegate     biến-trỏ-hàm    =   delegate() { ... }; //ANONYMOUS
            //Tên-datatype-delegate     biến-trỏ-hàm    =   () => { ... };    //RÚT GỌN TIẾP...


        }
    }
}
