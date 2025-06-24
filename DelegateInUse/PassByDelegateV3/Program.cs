namespace PassByDelegateV3
{
    //challenge 5: in ra lời 2 bài hát thông qua truyền hàm in bài hát vào 1 hàm in tập trung
    //1 hàm chịu trách nhiệm thầu/hub trung tâm nhận các lệnh in khác nhau được đưa vào!!!



    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintSongLyricsLover();
            //PrintSongLyricsThe1();
            Console.WriteLine("C5: call 2 method explicit methods via delegate var");
            Action f = PrintSongLyricsThe1;//luật sư = thân chủ
            f += PrintSongLyricsThe1;//luật sư 2 thân chủ
            //
            //f();

            Console.WriteLine("\n\nC5: call 2 method as traditional");
            PrintOnDemand();    //run hàm chính one

            Console.WriteLine("\n\nC6: print on demaind - dependency injection style\n");

            //PrintOnDemand(Action f = tên hàm nào đó có sẵn, nhiều hàm có sẵn)
            //PrintOnDemand(Action f = tên biến f được trỏ sẵn tên hàm);
            //PrintOnDemand(Action f = anonymous function)
            //PrintOnDemand(Action f = lambda expression)
            //HÀM NGOÀI ĐƯỢC TRUYỀN VÀO HÀM CHÍNH
            //1 Logic xử lí bên ngoài được pass vào bên trong hàm chính POD(???)
            //dependency injection
            //hàm truyền vào hàm chính qua ngả tham số => lập trình hàm - functional programming
            //hàm truyền vào hàm chính qua ngả tham số => hàm chính làm gì thì làm đi, nhớ gọi hàm qua ngả tham số sau khi bị chán chê
            //call back function

            //java: có lambda ex
            //      truyền h àm vào hàm phải bao cái hàm lại trong 1 cái interface chỉ có duy nhất 1 hàm - interface chỉ có duy nhất 1 hàm gọi là @functionnal Interface

            //đừng nhầm lẫn pass hàm vào hàm với pass 1 object student s vào 1 hàm
            //void PrintOneDemand(Student s)        //truyền value bình thường, truyền tham chiếu, truyền nhiều hàm của object, ko truyền 1 hàm đơn như mình đang học ===> ko lambda và delegate gì cả
            //ko call back gì cả

            Action fxxx = PrintSongLyricsThe1;
            fxxx += PrintSongLyricsLover;
            fxxx += PrintSongLyricsTheAugust;
            //gọi hàm chính, DEPENDENCY INJECTION - TAO CHÍCH VÀO HÀM CHÍNH 3 CÁI HÀM KHÁC
            PrintOnDemand(fxxx);    //3 hàm chạy như lúc hard-code

            //challenge 7: tui muốn in bài hát tiếp theo của taylor: carolina
            //chơi qua ngả in dịch vụ:   
            Console.WriteLine("\n\nC7: print on demaind - dependency injection style\n");
            Action fa = () => Console.WriteLine("the song carolina - by taylor  ");
            PrintOnDemand(fa);

            //CHƠI LỚN nguyên lí dấu bằng
            Console.WriteLine("\n\nC7: print on demaind - dependency injection style using anonymous & lambda\n");
            PrintOnDemand(delegate () { Console.WriteLine("chúng ta của hiện tại\n"); });
            PrintOnDemand(() => { Console.WriteLine("chúng ta của tương lai\n"); });

            //hàm nào nhận vào delegate, thì hàm này khi run, nó run luôn cái hàm delegate bên trong - call back 
            //gọi 1 hàm run nhưng là 2 hàm cùng run, hàm chính bao bên ngoài và hàm truyền thái y vào trong

            //challenge 8: hãy in ra các số từ 1 đến 100
            //challenge 9: hãy in ra các số nguyên tố từ 1...1000
            //đều là hàm action f
            Console.WriteLine("challenge 8: print numbers from 1 to 100");
            PrintOnDemand(() =>
            {
                Console.WriteLine("1 => 1000: ");
                for (int i = 0; i <= 1000; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            });//truyền thái y, đưa hàm vào bên trong hàm trai bao POD() và run POD() 
            //khi run hàm POD() phải truyền giá trị - hàm callback khác
            //giống như khi run hàm math.sqrt (đưa 25 vào)
            //đưa style truyền hàm vào, hơi mất sức gõ code 1 tí
            //ko muốn mất sức tạo sẵn hàm lẻ, truyền tên vào
            //mình thích anonymous và lambda vì tính linh hoạt, cần thì mới tạo hàm ngay tại chỗ mình cần => một phần vì logic xử lí event trong lập trình gui!!!
        }

        //phục vụ in ấn theo nhu cầu của các bác, các bác muốn in thế nào bảo em, em in cho
        static void PrintOnDemand()
        {
            Console.WriteLine("The main-method code...code");
            Console.WriteLine("call 2 sub-method");
            PrintSongLyricsThe1();
            PrintSongLyricsLover();
            PrintSongLyricsTheAugust();
            //TYGHT COUPLING - HÀM CHÍNH PrintOnDemand() phụ thuộc và 3 hàm
            //hard-code luôn, sau này muốn in bài khác, 1 bài khác thì phải sửa code trực tiếp

            //CÓ CÁCH HAY HƠN: in gì thì đưa vào, trong hàm chính PrintOnDemaind chỉ có lệnh in đúng cái đưa vào, ĐƯA VÀO CÁI GÌ, IN CÁI ĐÓ, KO HARD-CODE GÌ CẢ => Loose coupling - ràng buộc lỏng lẻo, flexible, adaptive với bên ngoài đưa vào thay vì mình gắn cứng với cái thứ đã làm sẵn
            //tui - PrintOnDemain() ko gắn hard code tên hàm nào cả, muốn làm gì thì đưa tên hàm bên ngoài vào đâym tao in cho, tao gọi cho 

            //TƯ DUY NÀY LÀ TƯ DUY STYLE: KIẾN TRÚC SƯ PHẦN MỀM - SOLUTION ARCHITECT - SA LƯƠNG 4K TRỞ LÊN Ở VN
        }

        //static void PrintOnDemand(int n) //dùng: POD(100) POD(5)
        static void PrintOnDemand(Action f)//hiện tượng OVERLOAD/OVERLOADING
        {
            Console.WriteLine("The main-method code...code");
            Console.WriteLine("call any outside method passed into...");
            Console.WriteLine("For now I'm flexible to receive your request");
            Console.WriteLine("tell me, what do you want, I call it/do it for you...");
            f();        //run baatss kì hàm nào đưa vào qua ngả tham số!!!!!!!
            //giống run() 3 thằng cũ ở bên dưới
            //nay đưa tên hàm muốn run qua ngả tham số
            //đưa từng 3 thằng dưới đây qua ngả 3 tham số, 3 hàm này vẫn run như cũ!!!
            //nhưng nay còn run được hàm bất kf miễn là gửi qua tham số Action đúng style h àm 
            //loose coupling
            //dependency injection: chích vào cho em 1 hàm khác bên ngoài qua ngả tham số
            //chích/pass hàm nào, run hàm đó

            //PrintSongLyricsThe1();
            //PrintSongLyricsLover();       //3 hàm hard-code, tight-coupling
            //PrintSongLyricsTheAugust();   //gọi chung nó là chữ F từ bên ngoài đưa vào
        }
        public static void PrintSongLyricsTheAugust()
        {
            Console.WriteLine("the song The August - by Taylor Swift\n");
        }
        public static void PrintSongLyricsThe1()
        {
            Console.WriteLine("the song The 1 - by Taylor Swift\n");
        }
        public static void PrintSongLyricsLover()
        {
            Console.WriteLine("the song Lover - by Taylor Swift\n");

        }
    }
}
