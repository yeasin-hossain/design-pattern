using DesignPattern.DTO.Request;
using DesignPattern.Service.Interface;
using Microsoft.AspNetCore.Mvc;
namespace DesignPattern.Controllers;

[ApiController]
[Route("design-patterns")]
public class DesignPatternController : Controller
{
   private readonly IDesignPatternService _designPatternService;
   
   public DesignPatternController(IDesignPatternService designPatternService)
   {
      _designPatternService = designPatternService;
   }
   
   [HttpGet]
   public async Task<ActionResult<List<string>>>  GetDesignPattern()
   {
      var designPatterns = await _designPatternService.GetDesignPatterns();
      return Ok(designPatterns);
   }

   [HttpPost("notification")]
   public async Task<ActionResult<string>> SentNotification(Notification notificationParam)
   {
      return await _designPatternService.SentNotification(notificationParam);
   }
}