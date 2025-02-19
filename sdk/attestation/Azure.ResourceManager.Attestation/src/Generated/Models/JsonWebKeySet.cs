// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Attestation.Models
{
    /// <summary> The JsonWebKeySet. </summary>
    internal partial class JsonWebKeySet
    {
        /// <summary> Initializes a new instance of JsonWebKeySet. </summary>
        public JsonWebKeySet()
        {
            Keys = new ChangeTrackingList<JsonWebKey>();
        }

        /// <summary>
        /// The value of the "keys" parameter is an array of JWK values.  By
        /// default, the order of the JWK values within the array does not imply
        /// an order of preference among them, although applications of JWK Sets
        /// can choose to assign a meaning to the order for their purposes, if
        /// desired.
        /// </summary>
        public IList<JsonWebKey> Keys { get; }
    }
}
