using Microsoft.AspNetCore.Mvc;

namespace Dio.Async.Programming.Dummy.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ControllerSimples : ControllerBase
{
    /// <summary>
    /// Este método Get retorna um status code 200 após 2 segundos
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        await Task.Delay(2000);
        return Ok("Tudo certo!");
    }
}
