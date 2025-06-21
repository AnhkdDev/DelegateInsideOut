using System.Reflection.PortableExecutable;

namespace AnonymousFunc
{
    //khai báo class Delegate map vào/đại diện cho đám hàm void F(int), có vào ko ra
    //đại diện cho 2 hàm ở dưới luôn do nó phù hợp format style
    delegate void PlayNumberDelegate(int x);    //map, đại diện, luật sư, sứ giả
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Play methods with an input and return nothing-void");
        //    PlayNumberDelegate playNumber = CloneNumber;//nhân bản 3 lần
        //    //mún gọi CloneNumber(5) phải đưa vào data
        //    //playNumber biến đại diện = tên hàm gốc, thì biến đại diện cũng đưa data vào như bản gốc
        //    playNumber(5);
        //    playNumber.Invoke(3);
        //    //gọi hàm 2 lần với 2 tham số là 5 và 3

        //    //muốn gọi hàm bình phương, gọi mình nó hay nối tiếp với hàm đã ủy quyền trước đó tùy; dùng =; hoặc += tùy bạn
        //    Console.WriteLine("in ra bình phương");
        //    playNumber = PowerBy2Number;//tớ playNumber là tên khác của cậu nha
        //                                //cam kết thôi, chưa thực thi, chưa run() cấm ko có dấu () 
        //                                //hiểu là run thì mới ủy quyền CHƯA THỰC THI, THỰC THI CẦN() PHẢI SAU KHI ỦY QUYỀN
        //    playNumber.Invoke(100);
        //    playNumber(25);

        //    //chơi hệ multicast
        //    Console.WriteLine("hệ multicast: ");
        //    playNumber += CloneNumber;//power() trước rồi clone() sau
        //    playNumber(6);
        //}
        //hàm sẽ đem đi cho thằng khác gọi, đặt nickname, thì hàm để ở đâu cũng được, miễn là phải thuộc về class, nếu là static thì chấm trực tiếp nếu là non static thì new rồi mới chấm
        //oop căn bản
        //giờ học thêm hàm có tham số

        static void CloneNumber(int n) => Console.WriteLine($"{n}{n}{n}");


        //hàm nhận vào 1 con số in ra bình phương của nó
        static void PowerBy2Number(int x) => Console.WriteLine($"the {x}^2 = {x * x}");

        //tui muốn có hàm nhận vào 1 con số nguyên nhưng: in ra, lặp lại thành 4 số
        //vd: nhận vào 9 => in ra 9999

        //C1: tạo hàm 4 số 9 như 3 số ở trên - tạo hàm tường minh - explicit
        static void CloneNumberLikeGoldFormat(int n) => Console.WriteLine($"{n}{n}{n}{n}");

        //C2: dùng anonymous function: thiết kế 1 hàm ko thèm có tên, chỉ cần đầu vào tuan theo định dạng của delegate đã khai báo; viết code ngay trên câu lệnh gán hợp đồng ủy quyền

        //static void Main(string[] args)
        //{
        //    //void F(int x)
        //    //PlayNumberDelegate playNumber = CloneNumberLikeGoldFormat;
        //    //playNumber(9);
        //    PlayNumberDelegate playNumber = delegate (int x) { Console.WriteLine($"{x}{x}{x}{x}"); };//đem code ngay đây, làm biếng làm hàm rời có trươc, tên hàm ko quan trọng, đặt là cái đéo gì cũng dc
        //    //code là phần quan trọng vì nó dính đến xử lí
        //    //chữ delegate ở lệnh gán chính là thay cho 1 tên hàm lẽ ra viết riêng chỗ khác

        //    playNumber(9);
        //    //hàm ko có tên thì làm sao gọi được => đưa cái tên đó cho thằng nickname Delegate nó giữ, bản chất hàm vẫn có tên, LẤY TÊN NICKNAME RA MÀ DÙNG
        //    //=> HÀM KO CÓ TÊN, MAY QUÁ, CÓ NICK ĐỂ GỌI, GỌI HÀM TRỞ LẠI QUỸ ĐẠO BÌNH THƯỜNG, ÍT NHẤT PHẢI CÓ 1 TÊN, HOẶC 2 TÊN ỦY QUYỀN
        //    //EM SINH RA ÉO CÓ TÊN, ỦY QUYỀN luôn - ANONYMOUS FUNCTION
        //    //HÀM VÔ DANH, GỌI EM QUA NICKNAE - ON THE GO - TAKE A WAY
        //    //HÀM CƠ ĐỘNG NGAY Ở CHỖ GÁN HỢP ĐỒNG ỦY QUYỀN
        //}

        static void Main(string[] args)
        {
            //tui muốn có hàm mũ 5
            //c1: làm hàm bình thường, mua chỗ ngồi trong quán, cố định 1 hàm như ở trên
            //c2: anonymous, viết code gán luôn cho nickname
            PlayNumberDelegate PlayNumber = delegate (int x) { Console.WriteLine($"{x} ^ 5 = {Math.Pow(x, 5)}"); };
            PlayNumber(10);
        }
    }
}

