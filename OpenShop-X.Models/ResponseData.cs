namespace OpenShop_X.Models
{
    public class ResponseData
    {
        public Object? Result { get; set; }

        public bool IsSuccessful { get; set; }

        public string Msg { get; set; } = string.Empty;

        public int? ErrorCode { get; set; }

        public string? ErrorMsg { get; set; } = string.Empty;
    }
}
