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


