using CaoNguyenVu_0162_CodeFirst.data_access;
using CaoNguyenVu_0162_CodeFirst.Models;

namespace CodeFirst_Vu_0162
{
    public class Access
    { 
        static InforCompanyDBContext db = new InforCompanyDBContext();

            static void initDB()
            {
                //insert
                var com1 = new Company { CompanyId = 1, CompanyName = "Công ty ABC", CompanyPhone = "0123456789", CompanyDescription = "N" };
                var com2 = new Company { CompanyId = 2, CompanyName = "Công ty ABC", CompanyPhone = "0123456789", CompanyDescription = "N" };
                var com3 = new Company { CompanyId = 3, CompanyName = "Công ty ABC", CompanyPhone = "0123456789", CompanyDescription = "N" };

                db.Company.Add(com1);
                db.Company.Add(com2);
                db.Company.Add(com3);

                var depart1 = new Department { DepartmentId = 1, DepartmentName = "Tài chính", QuantityStaff = 10, CompanyId = 1, Company = com1 };
                var depart2 = new Department { DepartmentId = 2, DepartmentName = "Marketing", QuantityStaff = 10, CompanyId = 2, Company = com2 };
                var depart3 = new Department { DepartmentId = 3, DepartmentName = "Nhân sự", QuantityStaff = 10, CompanyId = 1, Company = com1 };
                db.Department.Add(depart1);
                db.Department.Add(depart2);
                db.Department.Add(depart3);


                var staff1 = new Staff { StaffId = 1, StaffName = "Vũ", Gender = "Nam", Age = 34, Dob = DateTime.Parse("19/01/1990"), Salary = 6000000, DepartmentId = 1, Department = depart1 };
                var staff2 = new Staff { StaffId = 2, StaffName = "Như", Gender = "Nữ", Age = 20, Dob = DateTime.Parse("19/01/2003"), Salary = 6000000, DepartmentId = 1, Department = depart1 };
                var staff3 = new Staff { StaffId = 3, StaffName = "Yến", Gender = "Nữ", Age = 38, Dob = DateTime.Parse("19/01/1986"), Salary = 6000000, DepartmentId = 2, Department = depart2 };
                db.Staff.Add(staff1);
                db.Staff.Add(staff2);
                db.Staff.Add(staff3);
                db.SaveChanges();
            }
            static void Main(string[] args)
            {
                initDB();

                var result = from st in db.Staff
                             join de in db.Department on st.DepartmentId equals de.DepartmentId
                             join co in db.Company on de.CompanyId equals co.CompanyId
                             where st.Age >= 30 && st.Age <= 40
                             select st;


                foreach (var item in result)
                {
                    Console.WriteLine(item.StaffId + "\t" + item.StaffName + "\t" + item.Gender + "\t" + item.Age + "\t" + item.Salary);
                }

            }
         
    }
}
 
