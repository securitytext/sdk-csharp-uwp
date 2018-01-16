/*
 * SecuritytextOrgAPI.UWP
 *
 * This file was automatically generated for SecurityTextOrg by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using APIMATIC.SDK.Common;
using APIMATIC.SDK.Http.Request;
using APIMATIC.SDK.Http.Response;
using APIMATIC.SDK.Http.Client;
using SecuritytextOrgAPI.UWP.Exceptions;

namespace SecuritytextOrgAPI.UWP.Controllers
{
    public partial class WhoisController: BaseController, IWhoisController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static WhoisController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static WhoisController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new WhoisController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Query the server for a Domain object
        /// </summary>
        /// <param name="body">Required parameter: Body of API request</param>
        /// <return>Returns the Models.ResponsesQueryModel response from the API call</return>
        public Models.ResponsesQueryModel CreateApiWhoisQuery(Models.RequestsQueryModel body)
        {
            Task<Models.ResponsesQueryModel> t = CreateApiWhoisQueryAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Query the server for a Domain object
        /// </summary>
        /// <param name="body">Required parameter: Body of API request</param>
        /// <return>Returns the Models.ResponsesQueryModel response from the API call</return>
        public async Task<Models.ResponsesQueryModel> CreateApiWhoisQueryAsync(Models.RequestsQueryModel body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/query");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "securitytextorg-sdk/v1" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes

            //return null on 404
            if (_response.StatusCode == 404)
                 return null;

            if (_response.StatusCode == 400)
                throw new ResponsesErrorException(@"Bad Request", _context);

            if (_response.StatusCode == 406)
                throw new ResponsesErrorException(@"Not Acceptable", _context);

            if (_response.StatusCode == 500)
                throw new ResponsesErrorException(@"Internal Server Error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.ResponsesQueryModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 