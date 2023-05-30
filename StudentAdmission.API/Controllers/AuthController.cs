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
    public class AuthController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;
        public AuthController(IStudentRepository studentRepository, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Add([FromBody] UserDTO userDTO)
        {

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
            await this.studentRepository.AddStudentAsync(this.mapper.Map<ApplicationUser>(userDTO));
            return Ok(userDTO);
        }
    }
}
