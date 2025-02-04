// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the NetworkSecurityPerimeterAccessRule data model.
    /// The NSP access rule resource
    /// </summary>
    public partial class NetworkSecurityPerimeterAccessRuleData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityPerimeterAccessRuleData"/>. </summary>
        /// <param name="location"> The location. </param>
        public NetworkSecurityPerimeterAccessRuleData(AzureLocation location) : base(location)
        {
            AddressPrefixes = new ChangeTrackingList<string>();
            FullyQualifiedDomainNames = new ChangeTrackingList<string>();
            Subscriptions = new ChangeTrackingList<WritableSubResource>();
            NetworkSecurityPerimeters = new ChangeTrackingList<PerimeterBasedAccessRule>();
            EmailAddresses = new ChangeTrackingList<string>();
            PhoneNumbers = new ChangeTrackingList<string>();
            ServiceTags = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityPerimeterAccessRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state of the scope assignment resource. </param>
        /// <param name="direction"> Direction that specifies whether the access rules is inbound/outbound. </param>
        /// <param name="addressPrefixes"> Inbound address prefixes (IPv4/IPv6). </param>
        /// <param name="fullyQualifiedDomainNames"> Outbound rules fully qualified domain name format. </param>
        /// <param name="subscriptions"> List of subscription ids. </param>
        /// <param name="networkSecurityPerimeters"> Rule specified by the perimeter id. </param>
        /// <param name="emailAddresses"> Outbound rules email address format. </param>
        /// <param name="phoneNumbers"> Outbound rules phone number format. </param>
        /// <param name="serviceTags"> Inbound rules service tag names. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkSecurityPerimeterAccessRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, NspProvisioningState? provisioningState, AccessRuleDirection? direction, IList<string> addressPrefixes, IList<string> fullyQualifiedDomainNames, IList<WritableSubResource> subscriptions, IReadOnlyList<PerimeterBasedAccessRule> networkSecurityPerimeters, IList<string> emailAddresses, IList<string> phoneNumbers, IList<string> serviceTags, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            Direction = direction;
            AddressPrefixes = addressPrefixes;
            FullyQualifiedDomainNames = fullyQualifiedDomainNames;
            Subscriptions = subscriptions;
            NetworkSecurityPerimeters = networkSecurityPerimeters;
            EmailAddresses = emailAddresses;
            PhoneNumbers = phoneNumbers;
            ServiceTags = serviceTags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityPerimeterAccessRuleData"/> for deserialization. </summary>
        internal NetworkSecurityPerimeterAccessRuleData()
        {
        }

        /// <summary> The provisioning state of the scope assignment resource. </summary>
        public NspProvisioningState? ProvisioningState { get; }
        /// <summary> Direction that specifies whether the access rules is inbound/outbound. </summary>
        public AccessRuleDirection? Direction { get; set; }
        /// <summary> Inbound address prefixes (IPv4/IPv6). </summary>
        public IList<string> AddressPrefixes { get; }
        /// <summary> Outbound rules fully qualified domain name format. </summary>
        public IList<string> FullyQualifiedDomainNames { get; }
        /// <summary> List of subscription ids. </summary>
        public IList<WritableSubResource> Subscriptions { get; }
        /// <summary> Rule specified by the perimeter id. </summary>
        public IReadOnlyList<PerimeterBasedAccessRule> NetworkSecurityPerimeters { get; }
        /// <summary> Outbound rules email address format. </summary>
        public IList<string> EmailAddresses { get; }
        /// <summary> Outbound rules phone number format. </summary>
        public IList<string> PhoneNumbers { get; }
        /// <summary> Inbound rules service tag names. </summary>
        public IList<string> ServiceTags { get; }
    }
}
