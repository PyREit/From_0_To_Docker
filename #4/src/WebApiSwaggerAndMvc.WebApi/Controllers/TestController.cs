using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace WebApiSwaggerAndMvc.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {

        private static Dictionary<int, string> FakeStorage = new Dictionary<int, string>
        {
            { 1, "value1" },
            { 2, "value2" },
        };

        [SwaggerOperation("GetValues")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return FakeStorage.Select(x => x.Value);
        }

        [SwaggerOperation("GetValue")]
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return FakeStorage[id];
        }

        [SwaggerOperation("AddValue")]
        [HttpPost]
        public void Post([FromBody]string value)
        {
            var maxId = FakeStorage.Max(x => x.Key);
            var nextId = maxId + 1;
            FakeStorage.Add(nextId, value);
        }

        [SwaggerOperation("UpdateValue")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            if (FakeStorage.ContainsKey(id))
            {
                FakeStorage[id] = value;
            }
        }

        [SwaggerOperation("DeleteValue")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            FakeStorage.Remove(id);
        }

    }
}
