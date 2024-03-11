using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sum.Models;

namespace Sum.Controllers;

[ApiController]
[Route("[controller]")]
public class MathController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(Response), (int) HttpStatusCode.OK)]
    public IActionResult Add([FromQuery] int a, int b)
    {
        try
        {
            var response = new Response
            {
                Code = HttpStatusCode.OK,
                Value = a + b
            };
        
            return Ok(response);
        }
        catch (Exception _)
        {
            var response = new Response
            {
                Code = HttpStatusCode.InternalServerError,
                Message = "An error occurred",
                Value = null
            };
        
            return StatusCode((int) response.Code, response);
        }
    }
}