// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> The platform type where packet core is deployed. The contents of this enum can change. </summary>
    public readonly partial struct PlatformType : IEquatable<PlatformType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PlatformType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PlatformType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AKSHCIValue = "AKS-HCI";
        private const string ThreePAzureStackHCIValue = "3P-AZURE-STACK-HCI";

        /// <summary> If this option is chosen, you must set one of "azureStackEdgeDevice", "connectedCluster" or "customLocation". If multiple are set, they must be consistent with each other. </summary>
        public static PlatformType AKSHCI { get; } = new PlatformType(AKSHCIValue);
        /// <summary> If this option is chosen, you must set one of "azureStackHciCluster", "connectedCluster" or "customLocation". If multiple are set, they must be consistent with each other. </summary>
        public static PlatformType ThreePAzureStackHCI { get; } = new PlatformType(ThreePAzureStackHCIValue);
        /// <summary> Determines if two <see cref="PlatformType"/> values are the same. </summary>
        public static bool operator ==(PlatformType left, PlatformType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PlatformType"/> values are not the same. </summary>
        public static bool operator !=(PlatformType left, PlatformType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PlatformType"/>. </summary>
        public static implicit operator PlatformType(string value) => new PlatformType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PlatformType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PlatformType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
