// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class StorageSpacesPropertiesVmwareStorageProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Datacenter))
            {
                writer.WritePropertyName("datacenter"u8);
                writer.WriteStringValue(Datacenter);
            }
            if (Optional.IsDefined(Datastore))
            {
                writer.WritePropertyName("datastore"u8);
                writer.WriteStringValue(Datastore);
            }
            if (Optional.IsDefined(Folder))
            {
                writer.WritePropertyName("folder"u8);
                writer.WriteStringValue(Folder);
            }
            if (Optional.IsDefined(ResourcePool))
            {
                writer.WritePropertyName("resourcePool"u8);
                writer.WriteStringValue(ResourcePool);
            }
            writer.WriteEndObject();
        }

        internal static StorageSpacesPropertiesVmwareStorageProfile DeserializeStorageSpacesPropertiesVmwareStorageProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> datacenter = default;
            Optional<string> datastore = default;
            Optional<string> folder = default;
            Optional<string> resourcePool = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("datacenter"u8))
                {
                    datacenter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datastore"u8))
                {
                    datastore = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("folder"u8))
                {
                    folder = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourcePool"u8))
                {
                    resourcePool = property.Value.GetString();
                    continue;
                }
            }
            return new StorageSpacesPropertiesVmwareStorageProfile(datacenter.Value, datastore.Value, folder.Value, resourcePool.Value);
        }
    }
}
