// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing the NetworkFabricSku data model.
    /// The Network Fabric SKU resource definition.
    /// </summary>
    public partial class NetworkFabricSkuData : ResourceData
    {
        /// <summary> Initializes a new instance of NetworkFabricSkuData. </summary>
        public NetworkFabricSkuData()
        {
            SupportedVersions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of NetworkFabricSkuData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="typePropertiesType"> Type of Network Fabric SKU. </param>
        /// <param name="maxComputeRacks"> Maximum number of compute racks available for this Network Fabric SKU. The value of max count racks is 4 for 4 rack SKU and 8 for 8 rack SKU. </param>
        /// <param name="maximumServerCount"> Maximum number of servers available for this Network Fabric SKU. </param>
        /// <param name="supportedVersions"> List of supported Network Fabric SKU versions. </param>
        /// <param name="details"> URL providing detailed configuration of the fabric SKU. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        internal NetworkFabricSkuData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, NetworkFabricSkuType? typePropertiesType, int? maxComputeRacks, int? maximumServerCount, IReadOnlyList<string> supportedVersions, string details, NetworkFabricProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            TypePropertiesType = typePropertiesType;
            MaxComputeRacks = maxComputeRacks;
            MaximumServerCount = maximumServerCount;
            SupportedVersions = supportedVersions;
            Details = details;
            ProvisioningState = provisioningState;
        }

        /// <summary> Type of Network Fabric SKU. </summary>
        public NetworkFabricSkuType? TypePropertiesType { get; }
        /// <summary> Maximum number of compute racks available for this Network Fabric SKU. The value of max count racks is 4 for 4 rack SKU and 8 for 8 rack SKU. </summary>
        public int? MaxComputeRacks { get; set; }
        /// <summary> Maximum number of servers available for this Network Fabric SKU. </summary>
        public int? MaximumServerCount { get; set; }
        /// <summary> List of supported Network Fabric SKU versions. </summary>
        public IReadOnlyList<string> SupportedVersions { get; }
        /// <summary> URL providing detailed configuration of the fabric SKU. </summary>
        public string Details { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public NetworkFabricProvisioningState? ProvisioningState { get; }
    }
}
