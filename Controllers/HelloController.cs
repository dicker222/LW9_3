using Microsoft.AspNetCore.Mvc;

namespace MyWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var message = new 
        { 
            Text = "Привіт! Це твоя Лабораторна №9.", 
            Status = "Працює успішно", 
            ServerTime = DateTime.Now.ToString("HH:mm:ss") 
        };
        
        return Ok(message);
    }
}