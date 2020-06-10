// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VaultCertificate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (CertificateUrl != null)
            {
                writer.WritePropertyName("certificateUrl");
                writer.WriteStringValue(CertificateUrl);
            }
            if (CertificateStore != null)
            {
                writer.WritePropertyName("certificateStore");
                writer.WriteStringValue(CertificateStore);
            }
            writer.WriteEndObject();
        }

        internal static VaultCertificate DeserializeVaultCertificate(JsonElement element)
        {
            string certificateUrl = default;
            string certificateStore = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificateUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificateStore"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificateStore = property.Value.GetString();
                    continue;
                }
            }
            return new VaultCertificate(certificateUrl, certificateStore);
        }
    }
}