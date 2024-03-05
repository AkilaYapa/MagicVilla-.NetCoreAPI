using System.Net;

namespace MagicVilla_Simple_.NET_API_project.Models
{
    public class APIResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public List<string>? ErrorMessages { get; set; }
        public object Result { get; set; }
    }
}
