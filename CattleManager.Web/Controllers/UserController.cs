using Microsoft.EntityFrameworkCore;
using CattleManager.Domain.Interfaces;
using CattleManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CattleManager.Web.Controllers;

[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    private readonly IUserService _service;
    private readonly IRepository<User> repository;

    public UserController(IUserService service, IRepository<User> repository)
    {
        _service = service;
        this.repository = repository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<User>> GetAll() => Ok(_service.GetAll());

    [HttpGet("{id}")]
    public ActionResult<User> GetById(int id) => Ok(_service.GetById(id));

    [HttpPost]
    public ActionResult<User> Add([FromBody] User newUser)
    {
        BadRequest();
        return Ok(_service.Add(newUser));
    }
}
