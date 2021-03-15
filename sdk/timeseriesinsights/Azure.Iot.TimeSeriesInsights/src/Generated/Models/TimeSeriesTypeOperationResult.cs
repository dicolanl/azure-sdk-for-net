// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Iot.TimeSeriesInsights
{
    /// <summary> Result of a batch operation on a particular time series type. Type object is set when operation is successful and error object is set when operation is unsuccessful. </summary>
    public partial class TimeSeriesTypeOperationResult
    {
        /// <summary> Initializes a new instance of TimeSeriesTypeOperationResult. </summary>
        internal TimeSeriesTypeOperationResult()
        {
        }

        /// <summary> Initializes a new instance of TimeSeriesTypeOperationResult. </summary>
        /// <param name="timeSeriesType"> Time series type object - set when the operation is successful. </param>
        /// <param name="error"> Error object - set when the operation is unsuccessful. </param>
        internal TimeSeriesTypeOperationResult(TimeSeriesType timeSeriesType, InstancesOperationError error)
        {
            TimeSeriesType = timeSeriesType;
            Error = error;
        }

        /// <summary> Time series type object - set when the operation is successful. </summary>
        public TimeSeriesType TimeSeriesType { get; }
        /// <summary> Error object - set when the operation is unsuccessful. </summary>
        public InstancesOperationError Error { get; }
    }
}
