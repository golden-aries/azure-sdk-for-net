// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Network Mapping Properties. </summary>
    public partial class SiteRecoveryNetworkMappingProperties
    {
        /// <summary> Initializes a new instance of SiteRecoveryNetworkMappingProperties. </summary>
        internal SiteRecoveryNetworkMappingProperties()
        {
        }

        /// <summary> Initializes a new instance of SiteRecoveryNetworkMappingProperties. </summary>
        /// <param name="state"> The pairing state for network mapping. </param>
        /// <param name="primaryNetworkFriendlyName"> The primary network friendly name. </param>
        /// <param name="primaryNetworkId"> The primary network id for network mapping. </param>
        /// <param name="primaryFabricFriendlyName"> The primary fabric friendly name. </param>
        /// <param name="recoveryNetworkFriendlyName"> The recovery network friendly name. </param>
        /// <param name="recoveryNetworkId"> The recovery network id for network mapping. </param>
        /// <param name="recoveryFabricArmId"> The recovery fabric ARM id. </param>
        /// <param name="recoveryFabricFriendlyName"> The recovery fabric friendly name. </param>
        /// <param name="fabricSpecificSettings">
        /// The fabric specific settings.
        /// Please note <see cref="NetworkMappingFabricSpecificSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2ANetworkMappingSettings"/>, <see cref="VmmToAzureNetworkMappingSettings"/> and <see cref="VmmToVmmNetworkMappingSettings"/>.
        /// </param>
        internal SiteRecoveryNetworkMappingProperties(string state, string primaryNetworkFriendlyName, ResourceIdentifier primaryNetworkId, string primaryFabricFriendlyName, string recoveryNetworkFriendlyName, ResourceIdentifier recoveryNetworkId, ResourceIdentifier recoveryFabricArmId, string recoveryFabricFriendlyName, NetworkMappingFabricSpecificSettings fabricSpecificSettings)
        {
            State = state;
            PrimaryNetworkFriendlyName = primaryNetworkFriendlyName;
            PrimaryNetworkId = primaryNetworkId;
            PrimaryFabricFriendlyName = primaryFabricFriendlyName;
            RecoveryNetworkFriendlyName = recoveryNetworkFriendlyName;
            RecoveryNetworkId = recoveryNetworkId;
            RecoveryFabricArmId = recoveryFabricArmId;
            RecoveryFabricFriendlyName = recoveryFabricFriendlyName;
            FabricSpecificSettings = fabricSpecificSettings;
        }

        /// <summary> The pairing state for network mapping. </summary>
        public string State { get; }
        /// <summary> The primary network friendly name. </summary>
        public string PrimaryNetworkFriendlyName { get; }
        /// <summary> The primary network id for network mapping. </summary>
        public ResourceIdentifier PrimaryNetworkId { get; }
        /// <summary> The primary fabric friendly name. </summary>
        public string PrimaryFabricFriendlyName { get; }
        /// <summary> The recovery network friendly name. </summary>
        public string RecoveryNetworkFriendlyName { get; }
        /// <summary> The recovery network id for network mapping. </summary>
        public ResourceIdentifier RecoveryNetworkId { get; }
        /// <summary> The recovery fabric ARM id. </summary>
        public ResourceIdentifier RecoveryFabricArmId { get; }
        /// <summary> The recovery fabric friendly name. </summary>
        public string RecoveryFabricFriendlyName { get; }
        /// <summary>
        /// The fabric specific settings.
        /// Please note <see cref="NetworkMappingFabricSpecificSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2ANetworkMappingSettings"/>, <see cref="VmmToAzureNetworkMappingSettings"/> and <see cref="VmmToVmmNetworkMappingSettings"/>.
        /// </summary>
        public NetworkMappingFabricSpecificSettings FabricSpecificSettings { get; }
    }
}
