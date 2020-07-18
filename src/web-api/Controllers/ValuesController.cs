using System.Collections.Generic;
using System.Web.Http;
using Sample.Services;

namespace Sample.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly ValuesService valuesService;

        public ValuesController(ValuesService valuesService) =>
            this.valuesService = valuesService;

        // GET api/values
        public IEnumerable<string> Get() =>
            valuesService.GetAll();

        // POST api/values
        public void Post(string id) =>
            valuesService.Add(id);

        // DELETE api/values/5
        public void Delete(string id) =>
            valuesService.Remove(id);
    }
}
