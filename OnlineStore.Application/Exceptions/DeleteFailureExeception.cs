using System;

namespace OnlineStore.Application.Exceptions
{
    public class DeleteFailureExeception : Exception
    {
        public DeleteFailureExeception(string name, object key, string message)
            : base($"Deletion of entity \"{name}\" ({key}) has failed. {message}")
        {

        }
    }
}
