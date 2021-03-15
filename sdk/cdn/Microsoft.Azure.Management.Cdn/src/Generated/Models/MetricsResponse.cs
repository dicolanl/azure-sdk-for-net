// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Metrics Response
    /// </summary>
    public partial class MetricsResponse
    {
        /// <summary>
        /// Initializes a new instance of the MetricsResponse class.
        /// </summary>
        public MetricsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricsResponse class.
        /// </summary>
        /// <param name="granularity">Possible values include: 'PT5M', 'PT1H',
        /// 'P1D'</param>
        public MetricsResponse(System.DateTime? dateTimeBegin = default(System.DateTime?), System.DateTime? dateTimeEnd = default(System.DateTime?), string granularity = default(string), IList<MetricsResponseSeriesItem> series = default(IList<MetricsResponseSeriesItem>))
        {
            DateTimeBegin = dateTimeBegin;
            DateTimeEnd = dateTimeEnd;
            Granularity = granularity;
            Series = series;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateTimeBegin")]
        public System.DateTime? DateTimeBegin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateTimeEnd")]
        public System.DateTime? DateTimeEnd { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'PT5M', 'PT1H', 'P1D'
        /// </summary>
        [JsonProperty(PropertyName = "granularity")]
        public string Granularity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "series")]
        public IList<MetricsResponseSeriesItem> Series { get; set; }

    }
}
