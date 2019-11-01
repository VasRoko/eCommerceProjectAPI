using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Application.Exceptions
{
    class UpdateFailException : Exception
    {
        public UpdateFailException(string name, object key, string message)
         : base($"Update of entity \"{name}\" ({key}) failed. {message}")
        {

        }
    }
}
