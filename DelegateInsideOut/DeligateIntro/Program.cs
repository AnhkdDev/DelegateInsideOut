namespace DeligateIntro
{

    //delegate sẽ khai báo ở bên ngoài class khác, và nằm dưới namespace/package
    //solution có nhiều project
    //project có nhiều namespace
    //namespace có nhiều class

    //tao - delegate là 1 datatype cho nhóm object phức tạp là cái đám hàm tao trỏ/quản lí, đại diện, tao bình đẳng với các class/datatype khác
    public delegate void X();   //x: tui là class X đại diện cho 1 đám hàm ở dưới hay ở đâu đó có chung style là void ... (...)
    // CHÍNH LÀ LỆNH KHAI BÁO CLASS VIẾT NGẮN GỌN - VIẾT NGOÀI CLASS KHÁC (newbie)
     
        //    public class X [void X()] Delegate 
        //      {
        //          public X(đưa vào tên hàm cất trữ)
        //          do x đại diện cho 1 đám hàm, đưa hàm đây tao cất trữ đại diện trỏ - delegate
        //      }


    //X f = value là tên hàm ở dưới nick name cho tên hàm nào đó ở dưới
    //      f là tên gọi khác cho cái hàm ở dưới cùng style X
    //int x = value 10

    //KHAI BÁO BIẾN VÀ SỬ DỤNG THÌ PHẢI Ở TRONG HÀM, HAY TRONG CLASS KHÁC NÀO ĐÓ!!!
    //X SẴN SÀNG LÀ DATA TYPE BÌNH ĐẲNG NHƯ PERSON, DOG, CAT, PET, RECTANGLE
    //DÙNG NHƯ DATA TYPE BÌNH THƯỜNG
    public class Person
    {

    }
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //Student s = new Student();
        //    //int   yob = 2004;
        //    //X     f1  = Tên hàm nào đó cùng style X đã định nghĩa ở trên
        //    //      f1 trỏ đến hàm nào đó cùng style X
        //    //      f1 là nickname - đại diện - nhận ủy quyền - ủy nhiệm từ hàm khác
        //    //      f1 là con trỏ hàm, biến trỏ đến 1 hàm cụ thể
        //    //      f1 và hàm lúc này là 1
        //    //      gọi f1 cũng như gọi h àm
        //    //      dùng f1() và hàm () đều run hàm như nhau
        //    //      run qua biến ủy quyền - run gián tiếp
        //    //      vs. run trực tiếp qua tên hàm như 100 năm nay!!!!!!!!!!!

        //    X f1 = new X(TellHer);  //f1 là tên khác, nickname của TellHer
        //                            //f1 là TellHer là như nhau, là 1 lúc này
        //                            //f1 cũng là Tellher
        //                            //giống như sếp và sơn tùng m-tp, tb, 1994, chúng ta của tương lai
        //                            //gọi tắt là: f1 trỏ TellHer, f1 là con trỏ hàm
        //                            //            f1 đại diện cho TellHer, f1 là delegate ủy quyền

        //    X f2 = NhanEm;  //viết tắt, bỏ new luôn, cho nó tự nhiên như style 
        //                    //giống như: int yob = 2003;
        //                    //           int[] arr = new int[2003]
        //                    //           int[] arr = {5, 10, 15, 20, 35, 30}
        //                    //           Student s = new Student(..);
        //                    //           Student s = new (...);


        //    //=======> hết sức lưu ý, khi gán biến nick name cho 1 hàm cụ thể nào đó, tuyệt đối ko ghi tên hàm kèm () dấu ngoặc !!! VÌ GHI DẤU NGOẶC LÀ GỌI HÀM LUÔN RỒI
        //    //TRONG KHI ĐÓ LỆNH: X f2 = NhanEm mang ý nghĩa là đặt nickname cho 1 hàm cụ thể nào đó, gán giá trị cho biến, giá trị hơi đặc biệt một tí: giá trị là 1 cái hàm; đưa tên hàm, chứ ko phải Run() hàm

        //    //NhanEm();
        //    //TellHer();

        //    //GỌI HÀM CHÀO NHAU THÔI!!!
        //    //gọi trực tiếp như 2 lệnh đã comment ở trên - ko thèm làm, truyền thống rồi

        //    //ta gọi qua con trỏ hàm - biến delegate - biến ủy quyền - biến nickname - biến f1 đại diện cho hàm nào đó, gọi hàm trực tiếp hoặc gọi qua ủy quyền
        //    f1();   //vì câu lệnh X f1 = TellHer; do đó TellHer() là chạy hàm thì F1() cũng là chạy hàm mà là hàm TellHer(); 
        //            //gọi hàm gián tiếp, hàm đã được ủy quyền cho thằng khác chạy thay vì tự chạy 
        //            //ủy quyền - ủy nhiệm - ủy thác - đại diện => delegate
        //            //delegate: là kĩ thuật đặt tên gọi khác cho 1 cái hàm cụ thể nào đó!!!
        //            //và khi đó hàm cụ thể sẽ có 2 cách gọi, gọi trực tiếp hàm như xưa nay 
        //            //                                       gọi hàm qua tên nickname ủy quyền
        //    f2();

        //    //cách gọi thứ 3: GỌI QUA HÀM Invoke() có sẵn, giống .ToString()
        //    Console.WriteLine("Call mesage by using Invoke() method inside the class X");
        //    f1.Invoke();    //x là class có nhiều hàm bên trong như class student
        //    f2.Invoke();    //bên trong còn chứa cả tên hàm!!!
        //                    //có quyền gọi hàm từ bên trong hay gọi tắt()

        //}


        //chơi delegate style nhiều hàm được nhồi vào biến thuộc style X
        //1 luật sư đại diện cho nhiều thân chủ
        //1 con trỏ trỏ đa hàm nhưng vẫn chỉ 1 vùng new X()
        //x còn đóng vai thùng chưa tên hàm, box chứa tên hàm, cabinet, container hơn là 1 class chứa bên trong 1 info đơn lẻ kiểu person, cat, dog
        //static void Main(string[] args)
        //{
        //    X f = new(TellHer); //tương đương int x = 10;
        //    f += NhanEm;        //                x += 5; (ghép 10 + 5)
        //    f += SayHelloToSweetHeart;

        //    //f là gã luật sư đại diện cho 3 thân chủ thay vì chỉ 1 - multicast delegate 

        //    //gọi 3 hàm cùng lúc
        //    //1. gọi lẻ truyền thống TellHer() NhanEm() SayHelloTo()
        //    //2. gọi qua f(), duyệt mảng/list các tên hàm đã add() vào và run()
        //    //3. gọi qua f.Invoke() duyệt mảng

        //    f();

        //}


        //static void Main(string[] args)
        //{
        //    X f = TellHer;  //new X(TellHer); cái đã tạo không gian đề phòng add nhiều tên hàm
        //    f += NhanEm;
        //    f += SayHelloToSweetHeart;

        //    f.Invoke();

        //}

        static void Main(string[] args)
        {
            X f = TellHer;
            f = NhanEm; //đè con trỏ
            f();    //đáp án ra gì??? int a = 10; a = 11; => a = 11;
                    //tại 1 thời điểm biến chỉ lưu 1 value, tên gọi ứng 1 value!!!
                    //từ bỏ thân chủ tellHer kí hợp đồng với thân chủ mới
              //HẾT SỨC LƯU Ý VÀ CẨN THẬN VỚI =, NÓ KHÁC += ĐẤY!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
        }

        static void TellHer() => Console.WriteLine("cuộc sống em ổn ko. xa anh em phải hạnh phúc!!!");
        static void NhanEm() => Console.WriteLine("chúc em hạnh phúc bên người!!!");
        static void SayHelloToSweetHeart() => Console.WriteLine("Bánh mì không? hai ta về chung 1 nhà? Chúng ta của tương lai");
        //còn nhiều hàm nữa trong tương lai ở đây, mà có thể ở project khác, .Dll khác
        static void HelloWorld() => Console.WriteLine("hello world");
        //...
        //1 2 3 4 5 6 ... => int, long, float, double 

    }
}
