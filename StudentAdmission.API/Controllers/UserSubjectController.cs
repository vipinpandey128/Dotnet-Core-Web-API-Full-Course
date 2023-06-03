using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAdmission.DAL.Repositories;
using StudentAdmission.DTOs;
using StudentAdmission.Models.Entities;
using StudentAdmission.Models.Interface;

namespace StudentAdmission.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSubjectController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        //private ILogger<UserSubjectController> logger;
        
        private readonly IMapper mapper;
        public UserSubjectController(IRepositoryWrapper repository, IMapper mapper
            //, ILogger<UserSubjectController> logger
            )
        {
            _repository = repository;
            this.mapper = mapper;
            //this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var subjectList = await _repository.Subject.GetAllAsync();
            return Ok(subjectList);
        }

        [HttpGet]
        [Route("getbyId/{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var subject = await _repository.Subject.GetById(id);
            return Ok(subject);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] StudentSubjectDTO userDTO)
        {
            if (userDTO == null)
                return BadRequest(new { Success = false, ErrorCode = 400, Error = "Invalid post request" });

            _repository.Subject.Create(mapper.Map<StudentSubject>(userDTO));
            _repository.Save();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(int id, [FromBody] StudentSubjectDTO userDTO)
        {
            try
            {
                if (id != userDTO.SubjectId)
                    return BadRequest("ID mismatch");

                var subjectToUpdate = await _repository.Subject.GetById(id);

                if(subjectToUpdate == null)
                    return NotFound($"Subject with id = {id} not found");

                subjectToUpdate.Sem = userDTO.Sem;

                _repository.Subject.Update(subjectToUpdate);
                _repository.Save();
                return Ok(subjectToUpdate);


            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error updating data {ex.Message}");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var subjectToDelete =  await _repository.Subject.GetById(id);
            if(subjectToDelete == null)
                return NotFound();

            _repository.Subject.Delete(subjectToDelete);
            _repository.Save();
            return Ok("Record Deleted Successfully");
        }
    }
}
