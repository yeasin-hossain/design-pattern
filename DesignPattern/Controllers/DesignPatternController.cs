using Microsoft.AspNetCore.Mvc;
namespace DesignPattern.Controllers;

[ApiController]
[Route("design-pattern")]
public class DesignPatternController : Controller
{
   [HttpGet]
   public async Task<string> GetDesignPattern()
   {
      return "Hello";
   }
}