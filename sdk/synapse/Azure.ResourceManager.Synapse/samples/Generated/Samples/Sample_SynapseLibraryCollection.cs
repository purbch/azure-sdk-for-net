// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseLibraryCollection
    {
        // Get Library by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetLibraryByName()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/Library_Get.json
            // this example is just showing the usage of "Library_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string workspaceName = "exampleWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseLibraryResource
            SynapseLibraryCollection collection = synapseWorkspace.GetSynapseLibraries();

            // invoke the operation
            string libraryName = "exampleLibraryName.jar";
            SynapseLibraryResource result = await collection.GetAsync(libraryName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseLibraryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Library by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetLibraryByName()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/Library_Get.json
            // this example is just showing the usage of "Library_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string workspaceName = "exampleWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseLibraryResource
            SynapseLibraryCollection collection = synapseWorkspace.GetSynapseLibraries();

            // invoke the operation
            string libraryName = "exampleLibraryName.jar";
            bool result = await collection.ExistsAsync(libraryName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // List libraries in a workspace
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListLibrariesInAWorkspace()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/Libraries_ListByWorkspace.json
            // this example is just showing the usage of "Libraries_ListByWorkspace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string workspaceName = "exampleWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseLibraryResource
            SynapseLibraryCollection collection = synapseWorkspace.GetSynapseLibraries();

            // invoke the operation and iterate over the result
            await foreach (SynapseLibraryResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseLibraryData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
