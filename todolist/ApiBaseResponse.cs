using System.Net;

namespace OneNoteServiceSamplesWinUniversal.OneNoteApi
{
    /// <summary>
    /// Base class representing a simplified response from ALL OneNote APIs
    /// </summary>
    public class ApiBaseResponse
    {
        /// <summary>
        /// All OneNote API reponses return a meaningful Http status code
        /// Typical pattern for Http status codes are used: 
        /// 1 1xx Informational
        /// 2 2xx Success. e.g. 200-OK for GETs, 201 -Created for POSTs
        /// 3 3xx Redirection
        /// 4 4xx Client Error e.g. 400-Bad Request
        /// 5 5xx Server Error e.g. 500-Internal Server Error
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Per call identifier that can be logged to diagnose issues with Microsoft support
        /// CorrelationId is included in all Response Headers
        /// </summary>
        public string CorrelationId { get; set; }

        /// <summary>
        /// Body of the OneNote API response represented as a string.
        /// For error cases, this will typically include an error json intended for developers, not for end users.
        /// For success cases, depending on the type API call/HTTP verb this may or may not include a json value
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// URLs to launch OneNote rich client/web app
        /// </summary>
        public Links Links { get; set; }

        /// <summary>
        /// Unique identifier of the object
        /// </summary>
        public string Id { get; set; }

    }

    public class Links
    {
        /// <summary>
        /// URL to launch OneNote rich client
        /// </summary>
        public HrefUrl OneNoteClientUrl { get; set; }

        /// <summary>
        /// URL to launch OneNote web experience
        /// </summary>
        public HrefUrl OneNoteWebUrl { get; set; }
    }

    public class HrefUrl
    {
        public string Href { get; set; }
    }

    public class PageResponse : ApiBaseResponse
    {
        /// <summary>
        /// Title of the page
        /// </summary>
        public string Title;

        public string ContentUrl;

        public string LastModifiedDateTime;

        public override string ToString()
        {
            return "Title: " + Title + ", Id: " + Id;
        }
    }
}