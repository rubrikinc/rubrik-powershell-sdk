// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class StartRestoreAzureNativeVirtualMachineJobMutation {
      /// <summary>
      /// StartRestoreAzureNativeVirtualMachineJobMutation.Request 
      /// <para>Required variables:<br/> { snapshot_id=(any) }</para>
      /// <para>Optional variables:<br/> { should_power_on=(bool), should_restore_tags=(bool) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = StartRestoreAzureNativeVirtualMachineJobDocument,
          OperationName = "StartRestoreAzureNativeVirtualMachineJob",
          Variables = variables
        };
      }

      
      public static string StartRestoreAzureNativeVirtualMachineJobDocument = @"
        mutation StartRestoreAzureNativeVirtualMachineJob($snapshot_id: UUID!, $should_power_on: Boolean = true, $should_restore_tags: Boolean = true) {
          startRestoreAzureNativeVirtualMachineJob(
            input: {snapshotId: $snapshot_id, shouldPowerOn: $should_power_on, shouldRestoreTags: $should_restore_tags}
          ) {
            ...StartRestoreAzureNativeVirtualMachineJobFragment
          }
        }
        fragment StartRestoreAzureNativeVirtualMachineJobFragment on AsyncJobStatus {
          jobId
        }";
      
    }
}
