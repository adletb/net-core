using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    //api/commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }

        // private readonly MockCommanderRepo _repository = new MockCommanderRepo();
         //GET api/commads
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commadsItems = _repository.GetAllCommands();

            return Ok(commadsItems);
        }

        //GET api/commads/5
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commadItem = _repository.GetCommandById(id);
            return Ok(commadItem);
        }
    }
}