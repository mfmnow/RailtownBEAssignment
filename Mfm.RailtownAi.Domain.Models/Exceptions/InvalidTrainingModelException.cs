using System;

namespace Mfm.RailtownAi.Domain.Models.Exceptions
{
    public class InvalidTestModelException: Exception
    {
        public InvalidTestModelException(string message): base(message)
        {
        }
    }
}
