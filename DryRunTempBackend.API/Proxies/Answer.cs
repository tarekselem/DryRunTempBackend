using System;

namespace DryRunTempBackend.API.Controllers
{
    public class Answer
    {
        public Guid QuestionId { get; set; }
        public bool QuestionAnswer { get; set; }
    }
}