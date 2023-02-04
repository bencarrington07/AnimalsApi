using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AnimalsApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase
{
	private readonly ILogger _logger;

	public AnimalsController(ILogger logger)
	{
		_logger = logger;
	}

    [HttpGet(Name = "GetAnimals")]
    public IEnumerable<string> Get() => Enumerable.Range(1, 5).Select(index => "Random");
}