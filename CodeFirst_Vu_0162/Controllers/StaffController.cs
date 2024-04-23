using CaoNguyenVu_0162_CodeFirst.data_access;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst_Vu_0162.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly InforCompanyDBContext _context;
        public StaffController(InforCompanyDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
           
            var result = from st in _context.Staff
                         join de in _context.Department on st.DepartmentId equals de.DepartmentId
                         join co in _context.Company on de.CompanyId equals co.CompanyId
                         where st.Age >= 30 && st.Age <= 40 && (de.DepartmentName == null ? de.DepartmentName != null : de.DepartmentName == "Marketing") 
                         && (st.Gender == null ? st.Gender != null : st.Gender == "Nam")
                         select new
                         {
                             StaffId = st.StaffId,
                             StaffName = st.StaffName,
                             Gender = st.Gender,
                             Age = st.Age,
                             Salary = st.Salary,
                             DepartmentName = de.DepartmentName
                         };
            return Ok(result);
        }
    }
}
