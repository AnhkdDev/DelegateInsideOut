BÁO CÁO: CÁCH DÙNG DELEGATE TRONG C#
1. Delegate là gì?
Delegate là một kiểu dữ liệu tham chiếu trong C# dùng để chứa tham chiếu đến các phương thức có cùng chữ ký (signature). Delegate cho phép truyền phương thức như một đối số, rất hữu ích trong lập trình sự kiện và lập trình hàm.
2. Khai báo và sử dụng Delegate
// Khai báo delegate
public delegate int TinhToan(int a, int b);

// Định nghĩa phương thức phù hợp
public static int Cong(int x, int y) => x + y;

// Gán phương thức cho delegate
TinhToan phepCong = new TinhToan(Cong);

// Gọi delegate
int ketQua = phepCong(5, 3); // kết quả = 8

3. Delegate ẩn danh (Anonymous Delegate)
Delegate có thể được khai báo mà không cần phương thức riêng biệt:

TinhToan tru = delegate(int a, int b) {
    return a - b;
};
int kq = tru(10, 4); // kết quả = 6

4. Sử dụng Lambda Expression với Delegate
Lambda giúp viết gọn hơn:

TinhToan nhan = (a, b) => a * b;
int kq = nhan(3, 4); // kết quả = 12

5. Multicast Delegate
Delegate có thể trỏ đến nhiều phương thức:

public delegate void ThongBao();

ThongBao tb = A;
tb += B;
tb(); // gọi A rồi B

6. Ứng dụng Delegate
- Lập trình sự kiện (event handling).
- Call back function.
- Kết hợp với LINQ, async.
- Truyền phương thức làm tham số trong xử lý linh hoạt.
7. Kết luận
Delegate là một thành phần quan trọng trong C#, giúp mã nguồn linh hoạt và dễ bảo trì. Hiểu và sử dụng tốt delegate giúp bạn viết được các ứng dụng có kiến trúc tốt hơn.
