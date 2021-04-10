using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Hackathon2021.Model;
using Hackathon2021.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon2021.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CricketController : ControllerBase
    {
        private readonly ICricket _CricketRepository;
        public CricketController(ICricket CricketRepository)
        {
            _CricketRepository = CricketRepository;
        }

        // GET: api/Cricket
        [HttpGet]
        public IActionResult Get()
        {
            var Data = _CricketRepository.GetMatchData();
            return new OkObjectResult(Data);
        }

        // GET: api/Cricket/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var Data = _CricketRepository.GetMatchByID(id);
            return new OkObjectResult(Data);
        }

        // POST: api/Cricket
        [HttpPost]
        public void Post([FromBody] Data value)
        {
            using (var scope = new TransactionScope())
            {
                _CricketRepository.InsertMatch(value);
                scope.Complete();
                 
            }
        }

        // PUT: api/Cricket/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Data value)
        {
            if (value != null)
            {
                using (var scope = new TransactionScope())
                {
                    _CricketRepository.UpdateMatch(value);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _CricketRepository.DeleteMatch(id);
            return new OkResult();
        }
    }
}
