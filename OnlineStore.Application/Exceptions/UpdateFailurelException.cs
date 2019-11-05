﻿using System;

namespace OnlineStore.Application.Exceptions
{
    class UpdateFailureException : Exception
    {
        public UpdateFailureException(string name, object key, string message)
         : base($"Update of entity \"{name}\" ({key}) failed. {message}")
        {

        }
    }
}