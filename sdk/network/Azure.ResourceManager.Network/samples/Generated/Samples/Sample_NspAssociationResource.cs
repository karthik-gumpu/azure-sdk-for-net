// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_NspAssociationResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_NspAssociationGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/preview/2024-06-01-preview/examples/NspAssociationGet.json
            // this example is just showing the usage of "NspAssociations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NspAssociationResource created on azure
            // for more information of creating NspAssociationResource, please refer to the document of NspAssociationResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            string networkSecurityPerimeterName = "nsp1";
            string associationName = "association1";
            ResourceIdentifier nspAssociationResourceId = NspAssociationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkSecurityPerimeterName, associationName);
            NspAssociationResource nspAssociation = client.GetNspAssociationResource(nspAssociationResourceId);

            // invoke the operation
            NspAssociationResource result = await nspAssociation.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NspAssociationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_NspAssociationDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/preview/2024-06-01-preview/examples/NspAssociationDelete.json
            // this example is just showing the usage of "NspAssociations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NspAssociationResource created on azure
            // for more information of creating NspAssociationResource, please refer to the document of NspAssociationResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            string networkSecurityPerimeterName = "nsp1";
            string associationName = "association1";
            ResourceIdentifier nspAssociationResourceId = NspAssociationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkSecurityPerimeterName, associationName);
            NspAssociationResource nspAssociation = client.GetNspAssociationResource(nspAssociationResourceId);

            // invoke the operation
            await nspAssociation.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_NspAssociationPut()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/preview/2024-06-01-preview/examples/NspAssociationPut.json
            // this example is just showing the usage of "NspAssociations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NspAssociationResource created on azure
            // for more information of creating NspAssociationResource, please refer to the document of NspAssociationResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            string networkSecurityPerimeterName = "nsp1";
            string associationName = "association1";
            ResourceIdentifier nspAssociationResourceId = NspAssociationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkSecurityPerimeterName, associationName);
            NspAssociationResource nspAssociation = client.GetNspAssociationResource(nspAssociationResourceId);

            // invoke the operation
            NspAssociationData data = new NspAssociationData(default)
            {
                PrivateLinkResourceId = new ResourceIdentifier("/subscriptions/{paasSubscriptionId}/resourceGroups/{paasResourceGroupName}/providers/{providerName}/{resourceType}/{resourceName}"),
                ProfileId = new ResourceIdentifier("/subscriptions/subId/resourceGroups/rg1/providers/Microsoft.Network/networkSecurityPerimeters/nsp1/profiles/{profileName}"),
                AccessMode = AssociationAccessMode.Enforced,
            };
            ArmOperation<NspAssociationResource> lro = await nspAssociation.UpdateAsync(WaitUntil.Completed, data);
            NspAssociationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NspAssociationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task PostNspAssociationReconcile_NspAssociationReconcile()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/preview/2024-06-01-preview/examples/NspAssociationReconcile.json
            // this example is just showing the usage of "NspAssociationReconcile_Post" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NspAssociationResource created on azure
            // for more information of creating NspAssociationResource, please refer to the document of NspAssociationResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            string networkSecurityPerimeterName = "nsp1";
            string associationName = "association1";
            ResourceIdentifier nspAssociationResourceId = NspAssociationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkSecurityPerimeterName, associationName);
            NspAssociationResource nspAssociation = client.GetNspAssociationResource(nspAssociationResourceId);

            // invoke the operation
            BinaryData unknown = BinaryData.FromObjectAsJson(new
            {
                properties = new object(),
            });
            BinaryData result = await nspAssociation.PostNspAssociationReconcileAsync(unknown);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
