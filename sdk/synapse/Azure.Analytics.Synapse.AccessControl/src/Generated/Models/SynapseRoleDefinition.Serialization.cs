// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.AccessControl.Models
{
    public partial class SynapseRoleDefinition
    {
        internal static SynapseRoleDefinition DeserializeSynapseRoleDefinition(JsonElement element)
        {
            Optional<Guid> id = default;
            Optional<string> name = default;
            Optional<bool> isBuiltIn = default;
            Optional<string> description = default;
            Optional<IReadOnlyList<SynapseRbacPermission>> permissions = default;
            Optional<IReadOnlyList<string>> scopes = default;
            Optional<string> availabilityStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isBuiltIn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isBuiltIn = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("permissions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SynapseRbacPermission> array = new List<SynapseRbacPermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseRbacPermission.DeserializeSynapseRbacPermission(item));
                    }
                    permissions = array;
                    continue;
                }
                if (property.NameEquals("scopes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    scopes = array;
                    continue;
                }
                if (property.NameEquals("availabilityStatus"))
                {
                    availabilityStatus = property.Value.GetString();
                    continue;
                }
            }
            return new SynapseRoleDefinition(Optional.ToNullable(id), name.Value, Optional.ToNullable(isBuiltIn), description.Value, Optional.ToList(permissions), Optional.ToList(scopes), availabilityStatus.Value);
        }
    }
}
