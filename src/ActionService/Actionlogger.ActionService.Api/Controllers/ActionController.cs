using Actionlogger.ActionService.Core.Interface;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public async Task<IEnumerable<Action>> GetAll()
    {
        //return await _actionRepository.GetAll();

        var actions = new List<Action>();
        actions.Add(new Action
        {
            Id = Guid.NewGuid(),
            Task = User.IsInRole("default-roles-actionlogger").ToString()
        });

        return actions;
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