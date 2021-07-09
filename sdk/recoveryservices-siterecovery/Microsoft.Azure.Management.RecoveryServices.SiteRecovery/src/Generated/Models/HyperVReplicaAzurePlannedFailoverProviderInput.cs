// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// HyperVReplicaAzure specific planned failover input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("HyperVReplicaAzure")]
    public partial class HyperVReplicaAzurePlannedFailoverProviderInput : PlannedFailoverProviderSpecificFailoverInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// HyperVReplicaAzurePlannedFailoverProviderInput class.
        /// </summary>
        public HyperVReplicaAzurePlannedFailoverProviderInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// HyperVReplicaAzurePlannedFailoverProviderInput class.
        /// </summary>
        /// <param name="primaryKekCertificatePfx">Primary kek certificate
        /// pfx.</param>
        /// <param name="secondaryKekCertificatePfx">Secondary kek certificate
        /// pfx.</param>
        /// <param name="recoveryPointId">The recovery point id to be passed to
        /// failover to a particular recovery point. In case of latest recovery
        /// point, null should be passed.</param>
        public HyperVReplicaAzurePlannedFailoverProviderInput(string primaryKekCertificatePfx = default(string), string secondaryKekCertificatePfx = default(string), string recoveryPointId = default(string))
        {
            PrimaryKekCertificatePfx = primaryKekCertificatePfx;
            SecondaryKekCertificatePfx = secondaryKekCertificatePfx;
            RecoveryPointId = recoveryPointId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets primary kek certificate pfx.
        /// </summary>
        [JsonProperty(PropertyName = "primaryKekCertificatePfx")]
        public string PrimaryKekCertificatePfx { get; set; }

        /// <summary>
        /// Gets or sets secondary kek certificate pfx.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryKekCertificatePfx")]
        public string SecondaryKekCertificatePfx { get; set; }

        /// <summary>
        /// Gets or sets the recovery point id to be passed to failover to a
        /// particular recovery point. In case of latest recovery point, null
        /// should be passed.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointId")]
        public string RecoveryPointId { get; set; }

    }
}
