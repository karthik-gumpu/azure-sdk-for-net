// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MongoCluster.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.MongoCluster.Samples
{
    public partial class Sample_SubscriptionResourceExtensions
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetMongoClusters_ListsTheMongoClusterResourcesInASubscription()
        {
            // Generated from example definition: 2024-07-01/MongoClusters_List.json
            // this example is just showing the usage of "MongoCluster_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (MongoClusterResource item in subscriptionResource.GetMongoClustersAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MongoClusterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CheckMongoClusterNameAvailability_ChecksAndConfirmsTheMongoClusterNameIsAvailabilityForUse()
        {
            // Generated from example definition: 2024-07-01/MongoClusters_NameAvailability.json
            // this example is just showing the usage of "MongoClusters_CheckMongoClusterNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("westus2");
            MongoClusterNameAvailabilityContent content = new MongoClusterNameAvailabilityContent
            {
                Name = "newmongocluster",
                ResourceType = "Microsoft.DocumentDB/mongoClusters",
            };
            MongoClusterNameAvailabilityResult result = await subscriptionResource.CheckMongoClusterNameAvailabilityAsync(location, content);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CheckMongoClusterNameAvailability_ChecksAndReturnsThatTheMongoClusterNameIsAlreadyInUse()
        {
            // Generated from example definition: 2024-07-01/MongoClusters_NameAvailability_AlreadyExists.json
            // this example is just showing the usage of "MongoClusters_CheckMongoClusterNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("westus2");
            MongoClusterNameAvailabilityContent content = new MongoClusterNameAvailabilityContent
            {
                Name = "existingmongocluster",
                ResourceType = "Microsoft.DocumentDB/mongoClusters",
            };
            MongoClusterNameAvailabilityResult result = await subscriptionResource.CheckMongoClusterNameAvailabilityAsync(location, content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
