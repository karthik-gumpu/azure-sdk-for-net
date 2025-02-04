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
    public partial class Sample_OperationStatusResultResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_NspOperationStatusGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/preview/2024-06-01-preview/examples/NspOperationStatusGet.json
            // this example is just showing the usage of "NetworkSecurityPerimeterOperationStatus_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationStatusResultResource created on azure
            // for more information of creating OperationStatusResultResource, please refer to the document of OperationStatusResultResource
            string subscriptionId = "subId";
            AzureLocation location = new AzureLocation("location1");
            string operationId = "operationId1";
            ResourceIdentifier operationStatusResultResourceId = OperationStatusResultResource.CreateResourceIdentifier(subscriptionId, location, operationId);
            OperationStatusResultResource operationStatusResult = client.GetOperationStatusResultResource(operationStatusResultResourceId);

            // invoke the operation
            OperationStatusResultResource result = await operationStatusResult.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OperationStatusResultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
