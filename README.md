📌 Delegate trong C#
Delegate trong C# là một kiểu dữ liệu đặc biệt được thiết kế để lưu trữ và gọi các phương thức có cùng chữ ký (signature) và kiểu trả về. Về bản chất, delegate đóng vai trò như một function pointer trong các ngôn ngữ như C/C++, nhưng an toàn hơn vì được kiểm tra kiểu ngay tại thời điểm biên dịch (type-safe).

Delegate cho phép bạn:

Tham chiếu đến phương thức mà không cần biết chính xác phương thức đó nằm ở đâu trong chương trình.

Truyền phương thức như một tham số vào một phương thức khác, giúp tăng khả năng tái sử dụng và mở rộng.

Tách biệt (decouple) logic xử lý và hành vi thực thi, giúp mã dễ bảo trì và dễ thay đổi.

Xây dựng cơ chế callback để nhận thông báo khi một tác vụ hoàn thành.

Tạo nền tảng cho cơ chế event trong C#, vì event thực chất là delegate có ràng buộc truy cập đặc biệt.

Một số đặc điểm nổi bật của delegate:

Type-safe – chỉ các phương thức có cùng chữ ký và kiểu trả về mới có thể gán cho delegate.

Có thể tham chiếu nhiều phương thức cùng lúc (multicast delegate).

Là đối tượng – có thể tạo mới, gán, truyền, và lưu trữ như một biến bình thường.

Hỗ trợ ẩn danh – có thể sử dụng với phương thức ẩn danh (anonymous method) hoặc biểu thức lambda để viết code ngắn gọn.

Nhờ những đặc tính này, delegate là một trong những thành phần cốt lõi trong lập trình hướng sự kiện và lập trình bất đồng bộ (asynchronous programming) trong C#.
