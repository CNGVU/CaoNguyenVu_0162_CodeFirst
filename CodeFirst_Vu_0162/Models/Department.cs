namespace CaoNguyenVu_0162_CodeFirst.Models
{
    public class Department
    {
        public int DepartmentId { set; get; }
        public string DepartmentName { set; get; }
        public int QuantityStaff { set; get; }

        public virtual List<Staff> staffs { set; get; }
        public int CompanyId { set; get; }
        public virtual Company Company { get; set; }
    }
}
