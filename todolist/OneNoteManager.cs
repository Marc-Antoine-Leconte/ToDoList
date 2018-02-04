
using OneNoteServiceSamplesWinUniversal.OneNoteApi;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Linq;
using System.Net;
using System;

namespace todolist
{
    /// <summary>
    /// This class regroup all the functions allowing to get the onenote pages and contents
    /// </summary>
    class OneNoteManager
    {
        /// <summary>
        /// Function of GET
        /// </summary>
        /// <param name="url"></param>
        /// <param name="token"></param>
        /// <param name="stringFormat"></param>
        /// <returns></returns>
        public async Task<object> GetHttpContentWithToken(string url, string token, bool stringFormat = false)
        {
            var httpClient = new System.Net.Http.HttpClient();
            System.Net.Http.HttpResponseMessage response;
            try
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var request = new System.Net.Http.HttpRequestMessage(System.Net.Http.HttpMethod.Get, url);
                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                response = await httpClient.SendAsync(request);
                //var content = await response.Content.ReadAsStringAsync();
                if (!stringFormat)
                    return await TranslateListOfPagesResponse(response);
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        /// <summary>
        /// Get All the pages
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        private static async Task<List<ApiBaseResponse>> TranslateListOfPagesResponse(HttpResponseMessage response)
        {
            var apiBaseResponse = new List<ApiBaseResponse>();
            string body = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK
                /* GET Pages calls always return 200-OK upon success */)
            {
                var content = JObject.Parse(body);
                apiBaseResponse = new List<ApiBaseResponse>(JsonConvert.DeserializeObject<List<PageResponse>>(content["value"].ToString()));
            }
            if (apiBaseResponse.Count == 0)
            {
                apiBaseResponse.Add(new ApiBaseResponse());
            }

            // Extract the correlation id.  Apps should log this if they want to collect the data to diagnose failures with Microsoft support 
            IEnumerable<string> correlationValues;
            if (response.Headers.TryGetValues("X-CorrelationId", out correlationValues))
            {
                apiBaseResponse[0].CorrelationId = correlationValues.FirstOrDefault();
            }
            apiBaseResponse[0].StatusCode = response.StatusCode;
            apiBaseResponse[0].Body = body;
            return apiBaseResponse;
        }


        /// <summary>
        /// POST function
        /// </summary>
        /// <param name="url"></param>
        /// <param name="accessToken"></param>
        /// <param name="content"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public static async Task<ApiBaseResponse> newPage(string url, string accessToken, string content, string title)
        {
            var client = new HttpClient();

            // Note: API only supports JSON response.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Not adding the Authentication header would produce an unauthorized call and the API will return a 401
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            string date = DateTime.Now.ToString();
            string simpleHtml = "<html>" +
                                "<head>" +
                                "<title>" + title + "</title>" +
                                "<meta name=\"created\" content=\"" + date + "\" />" +
                                "</head>" +
                                "<body>" +
                                content + 
                                "</body>" +
                                "</html>";

            // Prepare an HTTP POST request to the Pages endpoint
            // The request body content type is text/html
            var createMessage = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = new StringContent(simpleHtml, Encoding.UTF8, "text/html")
            };

            HttpResponseMessage response = await client.SendAsync(createMessage);

            return await TranslateResponse(response);
        }

        /// <summary>
        /// translate the response of MS 
        /// </summary>
        /// <param name="response"></param>
        /// <param name="expectedStatusCode"></param>
        /// <returns></returns>
        public static async Task<ApiBaseResponse> TranslateResponse(HttpResponseMessage response, HttpStatusCode expectedStatusCode = HttpStatusCode.Created)
        {
            ApiBaseResponse apiBaseResponse;
            string body = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == expectedStatusCode
                /* POST calls always return 201-Created upon success */)
            {
                apiBaseResponse = JsonConvert.DeserializeObject<GenericEntityResponse>(body);
            }
            else
            {
                apiBaseResponse = new ApiBaseResponse();
            }

            // Extract the correlation id.  Apps should log this if they want to collect the data to diagnose failures with Microsoft support 
            IEnumerable<string> correlationValues;
            if (response.Headers.TryGetValues("X-CorrelationId", out correlationValues))
            {
                apiBaseResponse.CorrelationId = correlationValues.FirstOrDefault();
            }
            apiBaseResponse.StatusCode = response.StatusCode;
            apiBaseResponse.Body = body;
            return apiBaseResponse;
        }
    }
}
