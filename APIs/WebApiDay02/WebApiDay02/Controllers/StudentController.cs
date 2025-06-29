using System.Linq.Expressions;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDay02.DTO.DepartmentDTO;
using WebApiDay02.DTO.studentDTO;
using WebApiDay02.Models;

namespace WebApiDay02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ITIContext context;

        public StudentController(ITIContext context,IMapper mapper) {
            this.context = context;
            Mapper = mapper;
        }

        public IMapper Mapper { get; }

        [HttpGet]
        //public ActionResult get()
        //{
        //    //List<Student> sts = context.Students1.ToList();
        //    //return Ok(context.Students1.ToList());
        //    List<Student> student = context.Students.ToList();
        //    List< getstudentDTO> stsdto = Mapper.Map<List<getstudentDTO>>(student);
        //    return Ok(stsdto);
        //}
        public IActionResult get(int page = 1, int recordNum = 10)
        {
            List<Student> students = context.Students.Skip((page - 1) * recordNum).Take(recordNum).ToList();
            return Ok(Mapper.Map<List<getstudentDTO>>(students));
        }
        [HttpGet("/search{search}")]
        public ActionResult getbysearch(string search)
        {
            List<Student> sts = context.Students.Where(s => s.St_Fname.Contains(search)).ToList();
            //List< getstudentDTO> dTO = Mapper.Map<List<getstudentDTO>>(sts);
            return Ok(Mapper.Map<List<getstudentDTO>>(sts));
        }
        [HttpGet("/search/{searchby}/{search}")]

        public ActionResult getbysearch( string searchby, string search) {

            IQueryable<Student> st = context.Students;
            switch (searchby.ToLower())
            {
                case "fname":
                    st = st.Where(s => s.St_Fname.Contains(search));
                    break;
                case "lname":
                    st = st.Where(s => s.St_Lname.Contains(search));
                    break;
                case "address":
                    st = st.Where(s => s.St_Address.Contains(search));
                    break;
                case "age":
                    int.TryParse(search, out int age);
                    st = st.Where(s => s.St_Age == age);
                    break;
                case "deptname":
                    st = st.Where(s => s.Dept.Dept_Name.Contains(search));
                    break;
                case "supervisorName":
                    st = st.Where(s => s.St_superNavigation.St_Fname.Contains(search));
                    break;
                default:
                    return BadRequest("incorrect search field"); }
            List<getstudentDTO> sts = Mapper.Map<List<getstudentDTO>>(st.ToList());


            return Ok(sts);

            }



        [HttpGet("{id}")]

        public ActionResult getbyid(int id) {
            Student student = context.Students.Find(id);
            if (student == null) return NotFound();
            getstudentDTO stdto = Mapper.Map<getstudentDTO>(student);
            return Ok(stdto);
        }
        [HttpGet("{name:alpha}")]
        public IActionResult getbyname(string name)
        {
            Student s = context.Students.Where(s => s.St_Fname == name).FirstOrDefault();
            if (s == null) return NotFound();
            getstudentDTO stdto = Mapper.Map<getstudentDTO>(s);
            return Ok(s);
        }

        [HttpPost]
        public ActionResult add(AddstudentDTO stdto)
        {
            if (stdto == null) return BadRequest();
            if (!ModelState.IsValid) return BadRequest(ModelState);
            Student s = Mapper.Map<Student>(stdto);
            context.Students.Add(s);
            context.SaveChanges();
            return CreatedAtAction("getbyid", new { id = s.St_Id }, Mapper.Map<getstudentDTO>(s));
        }
        [HttpPut("{id:int}")]
        public ActionResult update(int id,updatestudentDTO s)
        {
            if (s == null) return BadRequest();
            if (!ModelState.IsValid) return BadRequest();
            //Student st = context.Students.Find(s.St_Id);
            //    st.St_Fname = s.St_Fname;
            //st.St_Lname = s.St_Lname;
            //st.St_Address = s.St_Address;
            //st.St_Age = s.St_Age;
            //st.Dept.Dept_Name = s.Dept?.Dept_Name;
            //st.St_superNavigation.St_Fname = s.St_superNavigation?.St_Fname;
            //context.Students.Update(st);
            //context.SaveChanges();
            Student student = context.Students.Find(id);
            Console.WriteLine(student.GetHashCode());
            Mapper.Map(s,student);
            Console.WriteLine(student.GetHashCode());

            //context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //context.Students.Update(student);
            context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id:int}")]
        
        public ActionResult delete (int id)
        {

            Student s = context.Students.Find(id);
            if (s == null) return BadRequest("This id is not valid");
            context.Students.Remove(s);
            context.SaveChanges();
            return Ok(s);// عشان يظهر الحاجة اللى اتمسحت
        }




        // طريقة من chatgpt ابقى افهمها 

        //[HttpGet("search/{searchby}/{search}")]
        //public ActionResult GetBySearch(string searchby, string search)
        //{
        //    var param = Expression.Parameter(typeof(Student), "s");

        //    // تأكد إن اسم الخاصية صحيح وموجود
        //    var propInfo = typeof(Student).GetProperty(searchby,
        //                    System.Reflection.BindingFlags.IgnoreCase |
        //                    System.Reflection.BindingFlags.Public |
        //                    System.Reflection.BindingFlags.Instance);

        //    if (propInfo == null || propInfo.PropertyType != typeof(string))
        //        return BadRequest("Invalid field name or non-string field.");

        //    var property = Expression.Property(param, propInfo);
        //    var searchValue = Expression.Constant(search);
        //    var containsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) });
        //    var containsExpr = Expression.Call(property, containsMethod, searchValue);
        //    var lambda = Expression.Lambda<Func<Student, bool>>(containsExpr, param);

        //    var result = context.Students.Where(lambda).ToList();
        //    return Ok(Mapper.Map<List<getstudentDTO>>(result));
        //}

    }
}
