// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ContainerRegistry.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.ContainerRegistry.Samples
{
    public partial class Sample_SubscriptionResourceExtensions
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CheckContainerRegistryNameAvailability_RegistryCheckNameAvailable()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2024-11-01-preview/examples/RegistryCheckNameAvailable.json
            // this example is just showing the usage of "Registries_CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            ContainerRegistryNameAvailabilityContent content = new ContainerRegistryNameAvailabilityContent("myRegistry")
            {
                ResourceGroupName = "myResourceGroup",
                AutoGeneratedDomainNameLabelScope = AutoGeneratedDomainNameLabelScope.ResourceGroupReuse,
            };
            ContainerRegistryNameAvailableResult result = await subscriptionResource.CheckContainerRegistryNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CheckContainerRegistryNameAvailability_RegistryCheckNameNotAvailable()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2024-11-01-preview/examples/RegistryCheckNameNotAvailable.json
            // this example is just showing the usage of "Registries_CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            ContainerRegistryNameAvailabilityContent content = new ContainerRegistryNameAvailabilityContent("myRegistry")
            {
                ResourceGroupName = "myResourceGroup",
                AutoGeneratedDomainNameLabelScope = AutoGeneratedDomainNameLabelScope.ResourceGroupReuse,
            };
            ContainerRegistryNameAvailableResult result = await subscriptionResource.CheckContainerRegistryNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetContainerRegistries_RegistryList()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2024-11-01-preview/examples/RegistryList.json
            // this example is just showing the usage of "Registries_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ContainerRegistryResource item in subscriptionResource.GetContainerRegistriesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerRegistryData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
