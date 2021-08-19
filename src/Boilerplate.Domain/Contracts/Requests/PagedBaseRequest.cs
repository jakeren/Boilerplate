namespace Boilerplate.Domain.Contracts.Requests
{
    public class PagedBaseRequest
    {
        public int Offset { get; set; }
        public int Limit { get; set; }
        public string[] Orderby { get; set; }
    }
}