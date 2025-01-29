// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_NspLinkReferenceCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_NspLinkReferencesGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/preview/2024-06-01-preview/examples/NspLinkReferenceGet.json
            // this example is just showing the usage of "NspLinkReferences_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkSecurityPerimeterResource created on azure
            // for more information of creating NetworkSecurityPerimeterResource, please refer to the document of NetworkSecurityPerimeterResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            string networkSecurityPerimeterName = "nsp2";
            ResourceIdentifier networkSecurityPerimeterResourceId = NetworkSecurityPerimeterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkSecurityPerimeterName);
            NetworkSecurityPerimeterResource networkSecurityPerimeter = client.GetNetworkSecurityPerimeterResource(networkSecurityPerimeterResourceId);

            // get the collection of this NspLinkReferenceResource
            NspLinkReferenceCollection collection = networkSecurityPerimeter.GetNspLinkReferences();

            // invoke the operation
            string linkReferenceName = "link1-guid";
            NspLinkReferenceResource result = await collection.GetAsync(linkReferenceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NspLinkReferenceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_NspLinkReferenceList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/preview/2024-06-01-preview/examples/NspLinkReferenceList.json
            // this example is just showing the usage of "NspLinkReferences_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkSecurityPerimeterResource created on azure
            // for more information of creating NetworkSecurityPerimeterResource, please refer to the document of NetworkSecurityPerimeterResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            string networkSecurityPerimeterName = "nsp2";
            ResourceIdentifier networkSecurityPerimeterResourceId = NetworkSecurityPerimeterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkSecurityPerimeterName);
            NetworkSecurityPerimeterResource networkSecurityPerimeter = client.GetNetworkSecurityPerimeterResource(networkSecurityPerimeterResourceId);

            // get the collection of this NspLinkReferenceResource
            NspLinkReferenceCollection collection = networkSecurityPerimeter.GetNspLinkReferences();

            // invoke the operation and iterate over the result
            await foreach (NspLinkReferenceResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NspLinkReferenceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_NspLinkReferencesGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/preview/2024-06-01-preview/examples/NspLinkReferenceGet.json
            // this example is just showing the usage of "NspLinkReferences_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkSecurityPerimeterResource created on azure
            // for more information of creating NetworkSecurityPerimeterResource, please refer to the document of NetworkSecurityPerimeterResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            string networkSecurityPerimeterName = "nsp2";
            ResourceIdentifier networkSecurityPerimeterResourceId = NetworkSecurityPerimeterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkSecurityPerimeterName);
            NetworkSecurityPerimeterResource networkSecurityPerimeter = client.GetNetworkSecurityPerimeterResource(networkSecurityPerimeterResourceId);

            // get the collection of this NspLinkReferenceResource
            NspLinkReferenceCollection collection = networkSecurityPerimeter.GetNspLinkReferences();

            // invoke the operation
            string linkReferenceName = "link1-guid";
            bool result = await collection.ExistsAsync(linkReferenceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_NspLinkReferencesGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/preview/2024-06-01-preview/examples/NspLinkReferenceGet.json
            // this example is just showing the usage of "NspLinkReferences_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkSecurityPerimeterResource created on azure
            // for more information of creating NetworkSecurityPerimeterResource, please refer to the document of NetworkSecurityPerimeterResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            string networkSecurityPerimeterName = "nsp2";
            ResourceIdentifier networkSecurityPerimeterResourceId = NetworkSecurityPerimeterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkSecurityPerimeterName);
            NetworkSecurityPerimeterResource networkSecurityPerimeter = client.GetNetworkSecurityPerimeterResource(networkSecurityPerimeterResourceId);

            // get the collection of this NspLinkReferenceResource
            NspLinkReferenceCollection collection = networkSecurityPerimeter.GetNspLinkReferences();

            // invoke the operation
            string linkReferenceName = "link1-guid";
            NullableResponse<NspLinkReferenceResource> response = await collection.GetIfExistsAsync(linkReferenceName);
            NspLinkReferenceResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NspLinkReferenceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
