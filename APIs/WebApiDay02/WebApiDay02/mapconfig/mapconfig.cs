using AutoMapper;
using WebApiDay02.DTO.DepartmentDTO;
using WebApiDay02.DTO.studentDTO;
using WebApiDay02.Models;

namespace WebApiDay02.mapconfig
{
    public class mapconfig :Profile
    {
        public mapconfig()
        {
            CreateMap<Student,getstudentDTO>().AfterMap((src,dest)=>
            {
                dest.studentId = src.St_Id;
                dest.fName = src.St_Fname;
                dest.lName = src.St_Lname;
                dest.addresss = src.St_Address;
                dest.age =src.St_Age;
                dest.deptname = src.Dept?.Dept_Name;
                dest.SupervisorName= src.St_superNavigation?.St_Fname;
            }
            ).ReverseMap();
            CreateMap<Student, AddstudentDTO>().ReverseMap();
            CreateMap<Department, getdeptsDTO>().AfterMap((src, dest) =>
            {
                dest.Students_count = src.Students.Count;
            }).ReverseMap();
            CreateMap<Department,AdddeptDTO>().ReverseMap();
        }
    }
}
