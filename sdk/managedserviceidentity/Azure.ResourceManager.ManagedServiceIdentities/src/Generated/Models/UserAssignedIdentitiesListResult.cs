// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedServiceIdentities;

namespace Azure.ResourceManager.ManagedServiceIdentities.Models
{
    /// <summary> Values returned by the List operation. </summary>
    internal partial class UserAssignedIdentitiesListResult
    {
        /// <summary> Initializes a new instance of UserAssignedIdentitiesListResult. </summary>
        internal UserAssignedIdentitiesListResult()
        {
            Value = new ChangeTrackingList<UserAssignedIdentityData>();
        }

        /// <summary> Initializes a new instance of UserAssignedIdentitiesListResult. </summary>
        /// <param name="value"> The collection of userAssignedIdentities returned by the listing operation. </param>
        /// <param name="nextLink"> The url to get the next page of results, if any. </param>
        internal UserAssignedIdentitiesListResult(IReadOnlyList<UserAssignedIdentityData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The collection of userAssignedIdentities returned by the listing operation. </summary>
        public IReadOnlyList<UserAssignedIdentityData> Value { get; }
        /// <summary> The url to get the next page of results, if any. </summary>
        public string NextLink { get; }
    }
}
