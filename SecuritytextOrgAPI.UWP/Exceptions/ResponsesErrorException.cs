/*
 * SecuritytextOrgAPI.UWP
 *
 * This file was automatically generated for SecurityTextOrg by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using APIMATIC.SDK.Http.Client;

using SecuritytextOrgAPI.UWP.Models;
using APIMATIC.SDK.Common;


namespace SecuritytextOrgAPI.UWP.Exceptions
{
    public class ResponsesErrorException : APIException 
    {
        // These fields hold the values for the public properties.
        private string message;
        private object errors;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("message")]
        public string Message 
        { 
            get 
            {
                return this.message; 
            } 
            private set 
            {
                this.message = value;
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("errors")]
        public object Errors 
        { 
            get 
            {
                return this.errors; 
            } 
            private set 
            {
                this.errors = value;
            }
        }

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="reason"> The reason for throwing exception </param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects </param>
        public ResponsesErrorException(string reason, HttpContext context)
            : base(reason, context)
        {
        }
    }
} 