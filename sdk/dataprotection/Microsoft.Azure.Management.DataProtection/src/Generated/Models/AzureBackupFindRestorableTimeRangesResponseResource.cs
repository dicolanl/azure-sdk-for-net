// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// List Restore Ranges Response
    /// </summary>
    public partial class AzureBackupFindRestorableTimeRangesResponseResource : DppResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureBackupFindRestorableTimeRangesResponseResource class.
        /// </summary>
        public AzureBackupFindRestorableTimeRangesResponseResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureBackupFindRestorableTimeRangesResponseResource class.
        /// </summary>
        /// <param name="id">Resource Id represents the complete path to the
        /// resource.</param>
        /// <param name="name">Resource name associated with the
        /// resource.</param>
        /// <param name="type">Resource type represents the complete path of
        /// the form Namespace/ResourceType/ResourceType/...</param>
        /// <param
        /// name="properties">AzureBackupFindRestorableTimeRangesResponseResource
        /// properties</param>
        public AzureBackupFindRestorableTimeRangesResponseResource(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), AzureBackupFindRestorableTimeRangesResponse properties = default(AzureBackupFindRestorableTimeRangesResponse))
            : base(id, name, type, systemData)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets azureBackupFindRestorableTimeRangesResponseResource
        /// properties
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public AzureBackupFindRestorableTimeRangesResponse Properties { get; set; }

    }
}
