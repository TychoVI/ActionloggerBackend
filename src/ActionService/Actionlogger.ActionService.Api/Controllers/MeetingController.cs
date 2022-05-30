using Actionlogger.ActionService.Core.Interface;
using Actionlogger.Core.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Actionlogger.ActionService.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class MeetingController : Controller
{
    private readonly IMeetingRepository _meetingRepository;

    public MeetingController(IMeetingRepository meetingRepository)
    {
        _meetingRepository = meetingRepository;
    }
    
    [HttpGet]
    public async Task<IEnumerable<Meeting>> GetAll()
    {
        return await _meetingRepository.GetAll();
    }

    [HttpPost]
    public async Task<Meeting> Create(Meeting meeting)
    {
        return await _meetingRepository.Create(meeting);
    }
}