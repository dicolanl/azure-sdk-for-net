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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// BackupPolicy
    /// </summary>
    /// <remarks>
    /// Rule based backup policy
    /// </remarks>
    [Newtonsoft.Json.JsonObject("BackupPolicy")]
    public partial class BackupPolicy : BaseBackupPolicy
    {
        /// <summary>
        /// Initializes a new instance of the BackupPolicy class.
        /// </summary>
        public BackupPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupPolicy class.
        /// </summary>
        /// <param name="datasourceTypes">Type of datasource for the backup
        /// management</param>
        /// <param name="policyRules">Policy rule dictionary that contains
        /// rules for each backuptype i.e Full/Incremental/Logs etc</param>
        public BackupPolicy(IList<string> datasourceTypes, IList<BasePolicyRule> policyRules)
            : base(datasourceTypes)
        {
            PolicyRules = policyRules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets policy rule dictionary that contains rules for each
        /// backuptype i.e Full/Incremental/Logs etc
        /// </summary>
        [JsonProperty(PropertyName = "policyRules")]
        public IList<BasePolicyRule> PolicyRules { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (PolicyRules == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PolicyRules");
            }
            if (PolicyRules != null)
            {
                foreach (var element in PolicyRules)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
