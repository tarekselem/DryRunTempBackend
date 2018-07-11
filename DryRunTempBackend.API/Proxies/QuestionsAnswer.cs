using System.Collections.Generic;

namespace DryRunTempBackend.API.Controllers
{
    public class QuestionsAnswer
    {
        public string UserPublicKey { get; set; }
        public IEnumerable<Answer> Answers { get; set; }
    }
}