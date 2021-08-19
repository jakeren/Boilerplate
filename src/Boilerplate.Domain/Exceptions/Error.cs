using System.Net;

namespace Boilerplate.Domain.Exceptions
{
    public class Error
    {
        public Error()
        {
        }

        public Error(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}