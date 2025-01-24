// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Network
{
    internal class NspAssociationOperationSource : IOperationSource<NspAssociationResource>
    {
        private readonly ArmClient _client;

        internal NspAssociationOperationSource(ArmClient client)
        {
            _client = client;
        }

        NspAssociationResource IOperationSource<NspAssociationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NspAssociationData.DeserializeNspAssociationData(document.RootElement);
            return new NspAssociationResource(_client, data);
        }

        async ValueTask<NspAssociationResource> IOperationSource<NspAssociationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NspAssociationData.DeserializeNspAssociationData(document.RootElement);
            return new NspAssociationResource(_client, data);
        }
    }
}
