// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI
{
    /// <summary> The authentication types supported with Azure OpenAI On Your Data. </summary>
    internal readonly partial struct OnYourDataAuthenticationType : IEquatable<OnYourDataAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OnYourDataAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OnYourDataAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ApiKeyValue = "APIKey";
        private const string ConnectionStringValue = "ConnectionString";
        private const string KeyAndKeyIdValue = "KeyAndKeyId";
        private const string EncodedApiKeyValue = "EncodedAPIKey";
        private const string AccessTokenValue = "AccessToken";
        private const string SystemAssignedManagedIdentityValue = "SystemAssignedManagedIdentity";
        private const string UserAssignedManagedIdentityValue = "UserAssignedManagedIdentity";

        /// <summary> Authentication via API key. </summary>
        public static OnYourDataAuthenticationType ApiKey { get; } = new OnYourDataAuthenticationType(ApiKeyValue);
        /// <summary> Authentication via connection string. </summary>
        public static OnYourDataAuthenticationType ConnectionString { get; } = new OnYourDataAuthenticationType(ConnectionStringValue);
        /// <summary> Authentication via key and key ID pair. </summary>
        public static OnYourDataAuthenticationType KeyAndKeyId { get; } = new OnYourDataAuthenticationType(KeyAndKeyIdValue);
        /// <summary> Authentication via encoded API key. </summary>
        public static OnYourDataAuthenticationType EncodedApiKey { get; } = new OnYourDataAuthenticationType(EncodedApiKeyValue);
        /// <summary> Authentication via access token. </summary>
        public static OnYourDataAuthenticationType AccessToken { get; } = new OnYourDataAuthenticationType(AccessTokenValue);
        /// <summary> Authentication via system-assigned managed identity. </summary>
        public static OnYourDataAuthenticationType SystemAssignedManagedIdentity { get; } = new OnYourDataAuthenticationType(SystemAssignedManagedIdentityValue);
        /// <summary> Authentication via user-assigned managed identity. </summary>
        public static OnYourDataAuthenticationType UserAssignedManagedIdentity { get; } = new OnYourDataAuthenticationType(UserAssignedManagedIdentityValue);
        /// <summary> Determines if two <see cref="OnYourDataAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(OnYourDataAuthenticationType left, OnYourDataAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OnYourDataAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(OnYourDataAuthenticationType left, OnYourDataAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OnYourDataAuthenticationType"/>. </summary>
        public static implicit operator OnYourDataAuthenticationType(string value) => new OnYourDataAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OnYourDataAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OnYourDataAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
