/*
 * SecuritytextOrgAPI.UWP
 *
 * This file was automatically generated for SecurityTextOrg by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
namespace SecuritytextOrgAPI.UWP.Models
{
    public class BaseModel : INotifyPropertyChanged
    {
        private Dictionary<string, object> additionalProperties;

        /// <summary>
        /// A dictionary holding all the additional properties.
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}