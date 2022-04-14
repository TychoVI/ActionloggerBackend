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
        Thread.Sleep(2000);
        return await _actionRepository.GetAll();
    }

    [HttpGet("{id:guid}")]
    public async Task<Action> GetById(Guid id)
    {
        return await _actionRepository.GetById(id);
    }

    [HttpPost]
    public async Task<Action> Create(Action action)
    {
        return await _actionRepository.Create(action);
    }
}