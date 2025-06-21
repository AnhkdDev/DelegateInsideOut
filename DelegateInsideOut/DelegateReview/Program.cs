using System.Collections.Concurrent;

namespace DelegateReview
{
    //một name space, ko gian, thư mục trên giấy tờ để nói về hộ khẩu của cái class, nơi ở, định cư của cái class. Thường mặc định sẽ lấy tên thư mục trên HDD/SSD để nói về hộ khẩu của 1 class - tên namespace - tên package
    //một xưởng sẽ chứa nhiều class ~ cái khuôn sẽ nằm ở đâu trong xưởng sản xuất
    //một xưởng thì có nhiều khuôn ~ namespace thì có nhiều class
    //ta có thể khai báo các class riêng rẽ, miễn là phần đầu nói rằng nó t huộc về không gian nào, hộ khẩu nào, namespace nào
    //đầu tập tin source code sẽ chứa cái khai báo namespace để quản lí các class thuộc về nó

    // trong 1 tập tin source, ta có thể khai báo các class khác ngoài class default có sẵn khi tạo tập tin source

    public class Student
    {
        //là 1 cái khuôn có nhiều khoảng trống bên trong để đổ vào các info của 1 object cần lưu trữ
    }
    //Student        s              =     new Student(...) {...}
    //datatype      biến/nickname           object, value
    //              tên gọi                 phức tạp

    //delegate là kĩ thuật thiết kế 1 cái class đặc biệt
    //class này không lưu info của các object theo style truyền thống, mà nó đi lưu thông tin là: TÊN CỦA CÁC HÀM TỒN TẠI ĐÂU ĐÓ NGOÀI KIA
    //public class X[void X()] : Delegate
    //{
    //    //biến lưu 1 tên hàm hay nhiều tên hàm
    //    //_list-tên-của-các-hàm-cần-lưu-trỏ-đến
    //    public X(đưa vào tên hàm cần lưu) { ... }
    //    public void Invoke() dùng để duyệt qua danh sách các hàm đang có và run() hàm luôn
    //}
    //xài class đặc biệt này: 
    //x                       f             =           new X(đưa hàm đó vào đây)
    //student               biến                        value - là tên hàm nào đó!

    //CHO PHÉP VIẾT NGẮN GỌN CÚ PHÁP KHAI BÁO CLASS LƯU TRỮ TÊN HÀM
    //delegate void X();//tui X đại diện cho 1 loạt các hàm có style là void F()


    //một namespace sẽ chứa 3 thàng ngang cơ nhau - cùng lever 
    //1. class truyền thống student, person, dog, pet,...
    //2. interface - dạng class đặc biệt (chứa hàm abstract ko có code)
    //3. delegate - dạng class đặc biệt (chứa bên trong tên hàm)

    //challenge: làm việc với các hàm có style void F() - dùng class style delegate
    
    public delegate void NoInputNoOutPutDelegate();     //đại diện cho style void F()
                                                        //public class NoInputNoOutPutDelegate()
                                                        // {
                                                        //..........
                                                        // }

    //xài class ở trong class khác vì class là data type

    internal class Program
    {


        static void Main(string[] args)
        {
            NoInputNoOutPutDelegate f1 = new NoInputNoOutPutDelegate(TellHerMessage1);

            //  f1 là tên gọi khác, nickname, 2nd name của hàm gốc có tên là TellHerMessage1
            //có thể hình dung: muốn chơi với hàm TellHerMessage1, ta có thể dùng tên thay thế là f1
            //   LUẬT SƯ                =        THÂN CHỦ
            //HÃY NÓI CHUYỆN VỚI F1 CŨNG CHÍNH LÀ NÓI CHUYỆN VỚI TELLHERMESSAGE1
            //1 hàm có tận 2 tên

            //========>tí nữa sẽ bán 1 tên cho quỷ dữ!!!!!!!!!!!! chỉ còn lại 1 tên nhưng éo phải là tên gốc!!!!!!!!!

            NoInputNoOutPutDelegate f2 = TellHerMessage2;//new ngầm, làm biếng xài new
            //gọi 2 hàm thử coi
            //thay vì gọi trực tiếp, làm việc trực tiếp với tên gốc của hàm, ta làm việc qua nickname, 2nd name, luật sư
            //f2 = TellHerMessage2 thì         thì f2() = TellHerMessage2()
            //bằng nhau về tên gọi             thì bằng nhau về run() hàm
            Console.WriteLine("see message 1st time ...");
            f1();
            f2.Invoke();    //tương đương nhau, vào trong vùng new để lôi các tên hàm gốc ra và run()

            //luật sư nói là thân chủ nói, nick name run() nghĩa là hàm gốc run() 
            Console.WriteLine("see message 2rd time ...");
            f1();
            f2 = new Program().TellHerMessage3;
            f2();

            Console.WriteLine("see message 3rd time ...");
            f1 += new Program().TellHerMessage3;
            f1();
            f2();
        }

        static void TellHerMessage1() => Console.WriteLine("1. cuộc sống em ổn ko");

        static void TellHerMessage2() => Console.WriteLine("2. xa anh em phải hạnh phúc");
        //expression body

        void TellHerMessage3() => Console.WriteLine("3. giữa mai và đào anh chỉ được chọn em");
    }
    }
