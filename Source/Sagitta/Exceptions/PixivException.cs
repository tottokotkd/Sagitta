﻿using System;

namespace Sagitta.Exceptions
{
    public class PixivException : Exception
    {
        public PixivException() {}

        public PixivException(string message) : base(message) {}

        public PixivException(string message, Exception innerException) : base(message, innerException) {}
    }
}