namespace CaoNguyenVu_0162_CodeFirst.Models
{
    public class Company
    {
        public int CompanyId { set; get; }
        public string CompanyName { set; get; }
        public string CompanyDescription { set; get; }
        public string CompanyPhone { set; get; }
        public virtual List<Department> departments { set; get; }
    }
}
