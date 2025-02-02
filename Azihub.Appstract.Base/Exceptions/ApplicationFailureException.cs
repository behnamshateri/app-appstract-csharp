﻿using System;

namespace Azihub.Appstract.Base.Exceptions
{
    public abstract class ApplicationFailureException : Exception, IException
    {
        protected ApplicationFailureException(string message, Exception innerException) : base(message, innerException)
        {
        }
        public TypeException TypeException { get; set; } = TypeException.ApplicationFailure;
        public abstract int Code { get; }
        public abstract string LocaleConst { get; }
    }
}
