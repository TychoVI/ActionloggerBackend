using Actionlogger.Core.Entity;
using Actionlogger.ProfileService.Core.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Actionlogger.ProfileService.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProfileController : Controller
{
    private readonly IProfileRepository _profileRepository;

    public ProfileController(IProfileRepository profileRepository)
    {
        _profileRepository = profileRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<Profile>> Get()
    {
        return await _profileRepository.GetAll();
    }

    [HttpPost]
    public async Task<Profile> Create(Profile profile)
    {
        return await _profileRepository.Create(profile);
    }
}