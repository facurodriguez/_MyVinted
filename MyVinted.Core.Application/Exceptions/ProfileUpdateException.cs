using MyVinted.Core.Common.Helpers;
using System;

namespace MyVinted.Core.Application.Exceptions
{
    public class ProfileUpdateException : Exception
    {
        public string ErrorCode { get; }

        public ProfileUpdateException(string message, string errorCode = ErrorCodes.ProfileUpdateError) : base(message)
            => (ErrorCode) = (errorCode);
    }
}