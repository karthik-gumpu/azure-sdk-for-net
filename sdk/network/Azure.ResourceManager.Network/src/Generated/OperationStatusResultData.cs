// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the OperationStatusResult data model.
    /// The current status of an async operation.
    /// </summary>
    public partial class OperationStatusResultData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OperationStatusResultData"/>. </summary>
        /// <param name="status"> Operation status. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="status"/> is null. </exception>
        internal OperationStatusResultData(string status)
        {
            Argument.AssertNotNull(status, nameof(status));

            Status = status;
            Operations = new ChangeTrackingList<OperationStatusResultData>();
        }

        /// <summary> Initializes a new instance of <see cref="OperationStatusResultData"/>. </summary>
        /// <param name="id"> Fully qualified ID for the async operation. </param>
        /// <param name="resourceId"> Fully qualified ID of the resource against which the original async operation was started. </param>
        /// <param name="name"> Name of the async operation. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="percentComplete"> Percent of the operation that is complete. </param>
        /// <param name="startOn"> The start time of the operation. </param>
        /// <param name="endOn"> The end time of the operation. </param>
        /// <param name="operations"> The operations list. </param>
        /// <param name="error"> If present, details of the operation error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OperationStatusResultData(ResourceIdentifier id, ResourceIdentifier resourceId, string name, string status, float? percentComplete, DateTimeOffset? startOn, DateTimeOffset? endOn, IReadOnlyList<OperationStatusResultData> operations, ResponseError error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            ResourceId = resourceId;
            Name = name;
            Status = status;
            PercentComplete = percentComplete;
            StartOn = startOn;
            EndOn = endOn;
            Operations = operations;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="OperationStatusResultData"/> for deserialization. </summary>
        internal OperationStatusResultData()
        {
        }

        /// <summary> Fully qualified ID for the async operation. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> Fully qualified ID of the resource against which the original async operation was started. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> Name of the async operation. </summary>
        public string Name { get; }
        /// <summary> Operation status. </summary>
        public string Status { get; }
        /// <summary> Percent of the operation that is complete. </summary>
        public float? PercentComplete { get; }
        /// <summary> The start time of the operation. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The end time of the operation. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> The operations list. </summary>
        public IReadOnlyList<OperationStatusResultData> Operations { get; }
        /// <summary> If present, details of the operation error. </summary>
        public ResponseError Error { get; }
    }
}
