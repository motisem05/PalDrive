
using Microsoft.AspNetCore.Mvc;

namespace paldrive.controllers
{
    public class Name
    {
        public string Value1 { get; set; }
        public string Value2 { get; set; }
    }


    [Route("/api/Files")]
    public class FilesController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "hello world!";
        }

        [HttpGet("{id}")]
        public int GetById(int id)
        {
            return id;
        }

        [HttpPost("{id}")]
        public string Post(int id)
        {
            return "OK!";
        }
        [HttpPost("{id}")]
        public string Post(
            [FromRoute] int id,
            [FromQuery] int query,
            [FromQuery] string question,
            [FromBody] Name name,
            [FromHeader] string header
        )
        {
            return "id : " + id + "query" + query + "question" + question + "Value1" + name.Value1 + "Value2" + name.Value2 + "header: " + header;
        }

    }

}