// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Direction that specifies whether the access rules is inbound/outbound. </summary>
    public readonly partial struct AccessRuleDirection : IEquatable<AccessRuleDirection>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AccessRuleDirection"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AccessRuleDirection(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InboundValue = "Inbound";
        private const string OutboundValue = "Outbound";

        /// <summary> Inbound. </summary>
        public static AccessRuleDirection Inbound { get; } = new AccessRuleDirection(InboundValue);
        /// <summary> Outbound. </summary>
        public static AccessRuleDirection Outbound { get; } = new AccessRuleDirection(OutboundValue);
        /// <summary> Determines if two <see cref="AccessRuleDirection"/> values are the same. </summary>
        public static bool operator ==(AccessRuleDirection left, AccessRuleDirection right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AccessRuleDirection"/> values are not the same. </summary>
        public static bool operator !=(AccessRuleDirection left, AccessRuleDirection right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AccessRuleDirection"/>. </summary>
        public static implicit operator AccessRuleDirection(string value) => new AccessRuleDirection(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AccessRuleDirection other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AccessRuleDirection other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
