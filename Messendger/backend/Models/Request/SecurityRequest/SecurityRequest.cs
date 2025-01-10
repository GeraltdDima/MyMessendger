using Request.SecurityRequest;

namespace Request.SecurityRequest
{
    public class SecurityRequest : ISecurityRequest
    {
        public SecurityRequest(string key)
        {
            this.key = key;
        }
        private string key { get; set; }
    }
}