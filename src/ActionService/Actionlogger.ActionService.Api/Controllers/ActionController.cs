using Actionlogger.ActionService.Core.Interface;
using Microsoft.AspNetCore.Mvc;
using Action = Actionlogger.Core.Entity.Action;

namespace Actionlogger.ActionService.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ActionController : Controller
{
    private readonly IActionRepository _actionRepository;

    public ActionController(IActionRepository actionRepository)
    {
        _actionRepository = actionRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<Action>> GetAll()
    {
        return await _actionRepository.GetAll();
    }
}