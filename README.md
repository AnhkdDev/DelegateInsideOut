📌 Delegate trong C#
Delegate trong C# là một kiểu dữ liệu đặc biệt dùng để tham chiếu đến các phương thức có cùng chữ ký (signature) và kiểu trả về. Delegate hoạt động giống như một "con trỏ hàm" (function pointer) trong các ngôn ngữ khác, nhưng an toàn hơn và hỗ trợ lập trình hướng đối tượng.

Delegate thường được sử dụng để:

Truyền phương thức như một tham số cho phương thức khác.

Tách biệt logic xử lý và hành động thực thi (decoupling).

Xây dựng cơ chế callback hoặc event.

Ví dụ cơ bản:
// Khai báo delegate
public delegate void Notify(string message);

class Program
{
    static void Main()
    {
        // Gán phương thức cho delegate
        Notify notifier = ShowMessage;

        // Gọi delegate
        notifier("Hello from delegate!");
    }

    static void ShowMessage(string msg)
    {
        Console.WriteLine(msg);
    }
}
Khi biên dịch, delegate đảm bảo rằng chỉ các phương thức phù hợp với chữ ký đã khai báo mới có thể được gán, giúp code an toàn và dễ bảo trì.
