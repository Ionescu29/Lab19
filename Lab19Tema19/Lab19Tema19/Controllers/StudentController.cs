using Lab19Tema19.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab19Tema19.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        
        private List<Student> Students = new List<Student>();
        
    
        public StudentController()
        {
            Student.Add(new Student { ID=1, Name="Hritcu", FirstName="Nadia", Age=23});
            Student.Add(new Student { ID=2, Name = "Dobrean", FirstName = "Andrei", Age = 30 });
            Student.Add(new Student { ID=3, Name = "Olar", FirstName = "Marius", Age = 27 });
        }
        //Obtinerea tuturor studentilor
        [HttpGet]
        public List<Student> GetStudents()
        {
            return Students;
        }
        //obtinerea studentilor dupa id
        [HttpGet("ID")]
        public Student GetStudents(int ID)
        {
            return Student.FirstOrDefault(c => c.ID == ID);
        }
    }
}
