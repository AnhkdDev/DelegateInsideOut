namespace PredicateDelegate
{
    //microsoft bảo rằng: nếu hàm nhận vào đúng 1 đầu vào và hàm trả về đúng sai
    //MỞ RỘNG THÊM: TOÁN LOGIC, TOÁN MỆNH ĐỀ - CÂU PHÁT BIỂU ĐÚNG SAI
    //CÓ HÀM MỆNH ĐỀ - HÀM NHẬN 1 ĐẦU VÀO SAU ĐÓ TRẢ VỀ 1 CÂU PHÁT BIỂU ĐUGNS SAI HÀM NÀY ĐƯỢC GỌI LÀ HÀM TIÊN ĐOÁN, HÀM DỰ ĐOÁN, HÀM MỆNH ĐỀ, HÀM ĐÁNH GIÁ,  HÀM LƯỢNG GIÁ, PREDICATE - LOGIC VỊ TỪ

    //Ông X là 1 nhà toán học => câu này k biết đúng sai vì x là biến (mơ hồ)
    //hàm IsNhaToanHoc(ông x nào đó)
    //hàm nhận vào tên người trả ra đúng sai nếu đó là nhà toán học hay ko
    //      IsNhaToanHoc(Ngô Bảo Châu)
    //    => ông Ngô Bảo Châu là 1 nhà toán h ọc => mệnh đề đúng
    //      IsNhaToanHoc(Giáo.Làng) => sai mẹ rồi, gã làm thuê cho tư bản, đam mê code, k đam mê tiền

    //      Predicate(???) => true/false
    //hãy đoán xem điều gì??? là đúng hay sai

    //microsoft bảo rằng: nếu hàm nhận vào đúng 1 đầu vào và hàm trả về đúng sai

    //thay vì khai báo là Func<double, bool> thì khai báo là Predicate<double> là đủ
    //thay vì khai báo là Func<int, bool> thì khai báo là Predicate<int> là đủ
    //thay vì khai báo là Func<Student, bool> thì khai báo là Predicate<Student> là đủ
    //kiểm tra xem sinh viên X có đúng là 


    internal class Program
    {
        static void Main(string[] args)
        {
            //hàm cuối cùng
            //challenge 18: viets hàm nhận vào 1 con số gpa, trả về nó lớn hơn 8 hay = 8
            Func<double, bool> fff = n => n > 8;
            Console.WriteLine("hihi " + fff(4));
        }
    }
}
