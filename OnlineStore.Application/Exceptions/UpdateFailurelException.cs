using System;

namespace OnlineStore.Application.Exceptions
{
    public class UpdateFailureException : Exception
    {
        public UpdateFailureException(string name, object key, string message)
         : base($"Update of entity \"{name}\" ({key}) failed. {message}")
        {

        }
    }
}
