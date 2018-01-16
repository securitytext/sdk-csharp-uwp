/*
 * SecuritytextOrgAPI.UWP
 *
 * This file was automatically generated for SecurityTextOrg by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using APIMATIC.SDK.Common;
using APIMATIC.SDK.Http.Client;
using APIMATIC.SDK.Http.Response;
using SecuritytextOrgAPI.UWP.Exceptions;

namespace SecuritytextOrgAPI.UWP.Controllers
{
    public partial class BaseController
    {
        #region shared http client instance
        private static object syncObject = new object();
        private static IHttpClient clientInstance = null;

        public static IHttpClient ClientInstance
        {
            get
            {
                lock(syncObject)
                {
                    if(null == clientInstance)
                    {
                        clientInstance = new HTTPClient()
;
                        clientInstance.setTimeout(TimeSpan.FromMilliseconds(5000));
                    }
                    return clientInstance;
                }
            }
            set
            {
                lock (syncObject)
                {
                    if (value is IHttpClient)
                    {
                        clientInstance = value;
                    }
                }
            }
        }
        #endregion shared http client instance

        internal ArrayDeserialization ArrayDeserializationFormat = ArrayDeserialization.Indexed;
        internal static char ParameterSeparator = '&';

        /// <summary>
        /// Validates the response against HTTP errors defined at the API level
        /// </summary>
        /// <param name="_response">The response recieved</param>
        /// <param name="_context">Context of the request and the recieved response</param>
        internal void ValidateResponse(HttpResponse _response, HttpContext _context)
        {
            if ((_response.StatusCode < 200) || (_response.StatusCode > 208)) //[200,208] = HTTP OK
                throw new APIException(@"HTTP Response Not OK", _context);
        }
    }
} 