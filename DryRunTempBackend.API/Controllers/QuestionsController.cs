using System;
using System.Collections.Generic;
using DryRunTempBackend.API.Proxies;
using Microsoft.AspNetCore.Mvc;

namespace DryRunTempBackend.API.Controllers
{
    [Route("api/Questions")]
    public class QuestionsController : Controller
    {
        [HttpGet]
        public ObjectResult Get()
        {
            var result = new ListModel<Question>
            {
                Total = 4,
                Items = new List<Question>
                {
                    new Question{ Id = Guid.NewGuid(), Title = "Are you agree A ?" },
                    new Question{ Id = Guid.NewGuid(), Title = "Are you agree A ?" },
                    new Question{ Id = Guid.NewGuid(), Title = "Are you agree A ?" },
                    new Question{ Id = Guid.NewGuid(), Title = "Are you agree A ?" }
                }
            };

            return Ok(result);
        }

        [HttpPost]
        [Route("api/Questions/Answers")]
        public ObjectResult AnswerQuestions([FromBody] QuestionsAnswer model)
        {
            return Ok("");
        }
    }
}