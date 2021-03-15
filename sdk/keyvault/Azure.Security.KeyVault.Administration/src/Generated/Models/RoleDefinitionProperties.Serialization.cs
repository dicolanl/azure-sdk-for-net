// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration.Models
{
    internal partial class RoleDefinitionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RoleName))
            {
                writer.WritePropertyName("roleName");
                writer.WriteStringValue(RoleName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(RoleType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(RoleType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Permissions))
            {
                writer.WritePropertyName("permissions");
                writer.WriteStartArray();
                foreach (var item in Permissions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AssignableScopes))
            {
                writer.WritePropertyName("assignableScopes");
                writer.WriteStartArray();
                foreach (var item in AssignableScopes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
