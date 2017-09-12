using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        public static IList<Todo> todoRepository = new List<Todo>
        {
            new Todo {Title = "Levar o cachorro para tomar banho"},
            new Todo {Title = "Lavar a louça"},
            new Todo {Title = "Jogar Fifa"},
            new Todo {Title = "Atualizar a planilha de contas do mês"},
        };

        [HttpGet]
        public IEnumerable<Todo> Get() => todoRepository;

        [HttpPost]
        public IActionResult Post([FromBody] Todo todo)
        {
            if (todo != null)
                todoRepository.Add(todo);

            return Ok();
        }
    }
}
