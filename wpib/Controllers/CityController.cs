using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace wpib.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class CityController : ControllerBase
{
    class Obj {
        public int[] a;
    }

    [HttpGet]
    public IEnumerable<int> Get() {

        return [5, 6];
    }

    // GET, POST, PUT, PATCH, DELETE
    // CRUD create, read, update, delete
    [HttpGet("{id}")]
    public string Get(int id) {

        Obj obj = new Obj();

        if (id == 1) {

            // query your database + other logic + entity frame...
            obj.a = [1, 2];

            // wrapping obj.a in a dummy obj because the front-end doesn't understand C#
            return JsonConvert.SerializeObject(obj);
        }
        else {

            obj.a = [0];
            return JsonConvert.SerializeObject(obj);
        }
    }
}
