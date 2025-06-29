using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDay02.DTO.DepartmentDTO;
using WebApiDay02.Models;

namespace WebApiDay02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        public DepartmentController(ITIContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public ITIContext Context { get; }
        public IMapper Mapper { get; }

        [HttpGet]
        public ActionResult get()
        {
            List<Department> depts = Context.Departments.ToList();
            List<getdeptsDTO> getdeptsDTOs = Mapper.Map<List<getdeptsDTO>>(depts);
            return Ok(getdeptsDTOs);
        }
        [HttpGet("{id:int}")]
        public ActionResult getbyid(int id)
        {

            Department dept = Context.Departments.Find(id);
            if (dept == null) return NotFound();
            getdeptsDTO getdept = Mapper.Map<getdeptsDTO>(dept);
            return Ok(getdept);
        }
        [HttpGet("{name:alpha}")]
        public ActionResult getbyname(string name)
        {
            Department dept = Context.Departments.Where(d => d.Dept_Name == name).FirstOrDefault();
            getdeptsDTO getdept = Mapper.Map<getdeptsDTO>(dept);
            return Ok(getdept);
        }
        [HttpPost]
        public ActionResult add(AdddeptDTO deptDTO)
        {
            if (deptDTO == null) return BadRequest();
            if (!ModelState.IsValid) return BadRequest(ModelState);
            Department dept = Mapper.Map<Department>(deptDTO);
            Context.Departments.Add(dept);
            Context.SaveChanges();
            return Ok(dept);
        }
        [HttpPut("{id:int}")]
        public ActionResult Update(int id ,UpdatedeptDTO _updatedeptDTO)
        {
            if (_updatedeptDTO == null) return BadRequest();
            if (!ModelState.IsValid) return BadRequest();
            Department dept = Context.Departments.Find(id);
            Mapper.Map(_updatedeptDTO, dept);
            Context.SaveChanges();
            return Ok(_updatedeptDTO);

        }
        [HttpDelete("{id:int}")]
        public ActionResult delete(int id)
        {
            Department dept = Context.Departments.Find(id);
            if (dept == null) return BadRequest("this id is invalid");
            Context.Departments.Remove(dept);
            Context.SaveChanges();
            return Ok(dept);
        }
    }
}
