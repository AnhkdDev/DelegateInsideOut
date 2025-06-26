namespace PassByAction
{
    //challenge: viết hàm thầu các hành động nào đó bên ngoài đưa vào
    //ví dụ: hàm thầu các dịch vụ in ấn nào đó: in bài hát, in số, dãy số...

    internal class Program
    {
        static void Main(string[] args)
        {
            DoOnDemand(() => { Console.WriteLine("Cầm tay anh, dựa vai anh"); Console.WriteLine("code cùng anh, nơi này có C#"); });

        }
        
        static void DoOnDemand(Action f)    // = hàm nào đó có style void f()
                                            // = hàm ẩn danh hay hàm lambda
        {
            Console.WriteLine("Do - while - for - code as normal");
            f();
        }
    }
}
