using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveStory
{
    //3 thằng ngang cơ nhau, đứng ngang hàm nhau: InterFace,
    //class (tao chỉ chứa info ngoài đời, hành động),
    //delegate (class đặc biệt - tao chỉ chứa tên hàm đâu đó ngoài kia)

    //public class X [void X()] delegate 
    //{
    //    _nickHamNaoDo = ????
    //}

    public delegate void SendLoveMessageDelegate();
             //bạn: void NhanEm();  f
             //tui: void TellHer(); x
              
internal class KuKia
{
    public static void MeetSweetHeart()
        {
            Console.WriteLine("hey baby, oh my sweet heart");
            //hắn - kukia phải nhận lời gửi gắm của tui và ban -> chính là trỏ đến hàm nhán tin mà lẽ ra tui bạn phải trực tiếp run, trực tiếp nói, nay ku kia sẽ run dùm, delegate cho ku kia, cho nickname, tao chuyển lời của tao cho mày run

            //SendLoveMessageDelegate message = new SendLoveMessageDelegate(Tui.TellHer); 
            SendLoveMessageDelegate message = Tui.TellHer;
            message += Ban.NhanEm;

            Console.WriteLine("By the way, you have messages from...");
            //GỌI HÀM NHẮN TIN NHƯNG KO GỌI TRỰC TIẾP MÀ GỌI QUA DELEGATE
            //do rằng 2 tin nyaf đã được capture dưới dạng biến delegate, bỏ vào vùng new Delegate()
            //gọi gián tiếp, nói giùm, ủy quyền
            message();//em nghe 2 message nè

            //trực tiếp sẽ là: Tui.TellHer() Ban.NhanEm();
        }
    }
}
