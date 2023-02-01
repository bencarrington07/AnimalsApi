using System;
using Microsoft.AspNetCore.Mvc;

namespace AnimalsApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase
{
	private readonly ILogger<AnimalsController> _logger;

	public AnimalsController(ILogger<AnimalsController> logger)
	{
		_logger = logger;
	}

    [HttpGet(Name = "GetAnimals")]
    public IEnumerable<string> Get() => Enumerable.Range(1, 5).Select(index => "Random");
}