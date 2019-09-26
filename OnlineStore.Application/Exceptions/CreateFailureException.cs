﻿using System;

namespace OnlineStore.Application.Exceptions
{
    public class CreateFailureException : Exception
    {
        public CreateFailureException(string name, object key, string message)
            : base($"Creation of entity \"{name}\" ({key}) failed. {message}")
        {

        }
    }
}
