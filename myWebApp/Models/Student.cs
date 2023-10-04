using System.ComponentModel.DataAnnotations;

namespace myWebApp.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên
        [Required(ErrorMessage = "Tên bắt buộc phải được nhập")]
		[StringLength(100, MinimumLength = 4, ErrorMessage = "Tên phải trên 4 ký tự.")]
		[MaxLength(100, ErrorMessage = "Tên không được vượt quá 100 ký tự.")]
		public string? Name { get; set; } //Họ tên

		[Required(ErrorMessage = "Nhập Email")]
		[EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ.")]
		[RegularExpression(@"^[a-zA-Z0-9._%+-]+@gmail\.com$", ErrorMessage = "Email phải có đuôi gmail.com.")]
		public string? Email { get; set; } //Email
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu phải trên 8 ký tự")]
		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=!]).+$",
		ErrorMessage = "Mật khẩu phải chứa ít nhất một ký tự viết hoa, một ký tự viết thường, một chữ số và một ký tự đặc biệt.")]
		[Required(ErrorMessage = "Nhập Mật Khẩu")]
		public string? Password { get; set; }//Mật khẩu
		[Required(ErrorMessage = "Nhập Ngành học")]
		public Branch? Branch { get; set; }//Ngành học
		[Required(ErrorMessage = "Nhập Giới tính")]
		public Gender? Gender { get; set; }//Giới tính
		[Required(ErrorMessage = "Chọn Hệ")]
		public bool IsRegular { get; set; }//Hệ: true-chính quy, false-phi chính quy
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Nhập địa chỉ")]
        public string? Address { get; set; }//Địa chỉ
        [Range(typeof(DateTime), "1/1/1963", "12/31/2006")]
        [DataType(DataType.Date)]
		[Required(ErrorMessage = "Nhập ngày sinh")]
		public DateTime DateOfBorth { get; set; }//Ngày sinh
		[Required(ErrorMessage = "Nhập Điểm")]
		[Range(0.0, 10.0, ErrorMessage = "Giá trị phải từ 0.0 đến 10.0.")]
		public string? Diem { get; set; } // Điểm
    }
}
