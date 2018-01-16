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
using APIMATIC.SDK.Common;


namespace SecuritytextOrgAPI.UWP.Models
{
    public class ResponsesQueryModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool found;
        private int status;
        private string output;

        /// <summary>
        /// Query matched exactly one Domain object
        /// </summary>
        [JsonProperty("found")]
        public bool Found 
        { 
            get 
            {
                return this.found; 
            } 
            set 
            {
                this.found = value;
                onPropertyChanged("Found");
            }
        }

        /// <summary>
        /// Status of matched Domain object (if any)
        /// </summary>
        [JsonProperty("status")]
        public int Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Text output of Query
        /// </summary>
        [JsonProperty("output")]
        public string Output 
        { 
            get 
            {
                return this.output; 
            } 
            set 
            {
                this.output = value;
                onPropertyChanged("Output");
            }
        }
    }
} 