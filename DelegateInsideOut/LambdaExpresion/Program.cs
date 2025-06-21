namespace LambdaExpresion
{
    internal class Program
    {
        delegate void PlayNumberDelegate(int x);   //nhóm hàm nhận vào 1 con x, muốn làm gì với x thì làm
        //3 cách chơi với hàm
        //c1: làm 1 hàm tường minh, nhận x, làm gì đó, in ra kq - có ghế trong quán cf
        //c2: làm 1 hàm ẩn danh - anonymous method/function - implicit, éo thèm đặt tên hàm, éo thềm viết code riêng, tất cả gom cho thằng delegate, nickname, mày lấy code tao, khỏi cần tên tao
        //c3: từ cách 2 cắt bớt code dư thừa!!! => lambda expression (CODE KHÁ GIỐNG EXPRESSION BODY KHI CÙNG DÙNG ---> NHƯNG COI CHỪNG , KHÁC ĐẤY!!!!!!)


        //CÓ CÂU: HÀM VÔ DANH RÚT GỌN CHỈ CÒN CÁI DÂY NỊT => BIẾN THÀNH BIỂU THỨC LAMBDA
        //        BIỂU THỨC LAMBDA LÀ HÀM VÔ DANH TRONG DELEGATE
        //        HÀM VÔ DANH KHÔNG HẲN LÀ LAMBDA NẾU VẪN VIẾT FULL HÀM MỞ ĐÓNG { }
        //        LAMBDA GIỐNG EXPRESSION BODY VỀ KÍ H IỆU => VÀ SỰ LƯỢC BỚT
        //               NHƯNG EXPRESSION BODY PHẢI FULL CẢ TÊN HÀM TỬ TẾ




        static void Main(string[] args)
        {
            //c1:
            //PlayNumberDelegate playNum = MakeTriple;// hợp đồng luật sư thân chủ
            //playNum(3);     //action gián tiếp


            //c2: làm biếng đặt chỗ 1 hàm tường minh, vào quán ko ngồi lấy cf thôi
            //take away, hợp đồng luật sư - thân chủ ko để lại tên
            //hàm vô danh anonymnous
            //PlayNumberDelegate playNum = delegate (int n) { Console.WriteLine($"{n}{n}{n}{n}"); };
            //playNum(9);


            //c3: chỉ còn cái dây nịt!!!! ===> BIỂU THỨC LAMBDA
            PlayNumberDelegate playNum = (int xxx)  => { Console.WriteLine($"{xxx} {xxx} {xxx} {xxx} {xxx}"); };
            playNum(10);

            //c3: còn cái dây nịt mỏng 
             playNum = (a) => { Console.WriteLine($"{a} {a} {a} {a} {a}"); };   //vòng lên định nghĩa ở trên biết ngay (kiểu int, ko cần ghi kiểu, ghi tên biến là dc r)
            playNum(68);

            //c3: còn cái dây nịt mỏng hơn nữa
            playNum = a => { Console.WriteLine($"{a}-{a}-{a}-{a}-{a}"); };   //vòng lên định nghĩa ở trên biết ngay (kiểu int, ko cần ghi kiểu, ghi tên biến là dc r)
            playNum(6789);

            //viết 1 hàm in ra mũ 3 của 1 con số đưa vào, ko chơi hàm lẻ rời, ko chơi anonymous full mà chơi anonymous giản lược tận cùng - lambda expression
            playNum = a => { Console.WriteLine($"{a} ^ 3 = {Math.Pow(a, 3)}"); };
            playNum(2);

        }

        //c1: hàm tường minh
        static void MakeTriple(int n) => Console.WriteLine($"{n}{n}{n}");
    }
}   
