using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public List<EmpDetails> Employees = new List<EmpDetails>()
        {
             new EmpDetails()
               {
                   Id =1111, Name="Vishal", Address ="Bhopal",Company ="Kellton"
               },
             new EmpDetails()
               {
                   Id =1112, Name="Satish" ,Address="Indore",Company ="Kellton"
               },
             new EmpDetails()
               {
                   Id =1113, Name="Akshat", Address="Ujjain",Company ="Kellton"
               },
             new EmpDetails()
               {
                   Id =1114, Name="Komal" ,Address="Jalandhar",Company ="Kellton"
               },
        };

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }


        [HttpPost]
        public ActionResult PostEmployee()
        {
            Employees.Add(new EmpDetails { Id = 1501, Name = "PostEmployeeName", Address = "PostEmployeeAddress", Company= "PostEmployeeCompany" });

            return Ok(Employees);
        }
        [HttpGet]
        public ActionResult GetEmployee()
        {
            return Ok(Employees);
        }
        [HttpPut]
        public ActionResult PutEmployee()
        { 
            Employees.Add(new EmpDetails { Id = 1505, Name = "PutEmployeeName", Address = "PutEmployeeAddress", Company= "PutEmployeeCompany" });
            return Ok(Employees);
        }
        [HttpDelete]
        public ActionResult DeleteEmployee()
        {
            Employees.RemoveAt(0);
            return Ok(Employees);
        }
        [HttpPatch]
        public ActionResult PatchEmployee(int Id, [FromBody] string Name)
        {
            var employee = Employees.FirstOrDefault(x => x.Id == Id);
            if (employee == null)
                return Ok("Wrong Employee ID");
            else
                employee.Name = Name;
            return Ok(employee);
        }
    }
}
