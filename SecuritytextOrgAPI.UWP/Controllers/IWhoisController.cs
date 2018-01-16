/*
 * SecuritytextOrgAPI.UWP
 *
 * This file was automatically generated for SecurityTextOrg by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMATIC.SDK.Common;
using APIMATIC.SDK.Http.Request;
using APIMATIC.SDK.Http.Response;
using APIMATIC.SDK.Http.Client;

namespace SecuritytextOrgAPI.UWP.Controllers
{
    public partial interface IWhoisController
    {
        /// <summary>
        /// Query the server for a Domain object
        /// </summary>
        /// <param name="body">Required parameter: Body of API request</param>
        /// <return>Returns the Models.ResponsesQueryModel response from the API call</return>
        Models.ResponsesQueryModel CreateApiWhoisQuery(Models.RequestsQueryModel body);

        /// <summary>
        /// Query the server for a Domain object
        /// </summary>
        /// <param name="body">Required parameter: Body of API request</param>
        /// <return>Returns the Models.ResponsesQueryModel response from the API call</return>
        Task<Models.ResponsesQueryModel> CreateApiWhoisQueryAsync(Models.RequestsQueryModel body);

    }
} 