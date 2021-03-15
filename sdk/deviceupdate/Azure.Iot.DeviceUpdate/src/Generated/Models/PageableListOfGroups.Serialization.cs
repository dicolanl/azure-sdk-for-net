// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.DeviceUpdate.Models
{
    internal partial class PageableListOfGroups
    {
        internal static PageableListOfGroups DeserializePageableListOfGroups(JsonElement element)
        {
            Optional<IReadOnlyList<Group>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Group> array = new List<Group>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Group.DeserializeGroup(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PageableListOfGroups(Optional.ToList(value), nextLink.Value);
        }
    }
}
