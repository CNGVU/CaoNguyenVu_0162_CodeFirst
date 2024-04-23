namespace CaoNguyenVu_0162_CodeFirst.Models
{
    public class Staff
    {
        public int StaffId { set; get; }
        public string StaffName { set; get; }
        public string Gender { set; get; }
        public int Age { set; get; }
        public DateTime Dob { set; get; }
        public double Salary { set; get; }

        public int DepartmentId { set; get; }
        public virtual Department Department { set; get; }
    }
}
