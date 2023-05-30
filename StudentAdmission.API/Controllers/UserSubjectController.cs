using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAdmission.DAL.Repositories;
using StudentAdmission.DTOs;
using StudentAdmission.Models;

namespace StudentAdmission.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSubjectController : ControllerBase
    {
        private readonly IStudentSubjectRepository studentSubjectRepository;
        private readonly IMapper mapper;
        public UserSubjectController(IStudentSubjectRepository studentSubjectRepository, IMapper mapper)
        {
            this.studentSubjectRepository = studentSubjectRepository;
            this.mapper = mapper;
        }

        [HttpPost]
        [Route("AssignSubject")]
        public async Task<IActionResult> Add([FromBody] StudentSubjectDTO userDTO)
        {
            int a = 0;
            int b = 1;
            var c = b / a;

            //await this.studentRepository.AddStudentAsync(new Models.ApplicationUser()
            //{
            //    FirstName = userDTO.FirstName,
            //    LastName = userDTO.LastName,
            //    DOB = userDTO.DOB,
            //    Email = userDTO.UserName,
            //    PhoneNumber = userDTO.Mobile,
            //    Gender = userDTO.Gender,
            //    CreatedBy = "",
            //    CreatedDate = DateTime.Now
            //});
            var mapoing = this.mapper.Map<StudentSubject>(userDTO);
            await this.studentSubjectRepository.AddStudentSubjectAsync(this.mapper.Map<StudentSubject>(userDTO));
            return Ok(userDTO);
        }
    }
}
