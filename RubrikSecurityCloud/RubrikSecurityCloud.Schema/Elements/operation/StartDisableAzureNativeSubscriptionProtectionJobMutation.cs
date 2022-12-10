// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class StartDisableAzureNativeSubscriptionProtectionJobMutation {
      /// <summary>
      /// StartDisableAzureNativeSubscriptionProtectionJobMutation.Request 
      /// <para>Required variables:<br/> { azure_subscription_rubrik_id=(any), delete_snapshots=(bool), feature=(AzureNativeProtectionFeature) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = StartDisableAzureNativeSubscriptionProtectionJobDocument,
          OperationName = "StartDisableAzureNativeSubscriptionProtectionJob",
          Variables = variables
        };
      }

      
      public static string StartDisableAzureNativeSubscriptionProtectionJobDocument = @"
        mutation StartDisableAzureNativeSubscriptionProtectionJob($azure_subscription_rubrik_id: UUID!, $delete_snapshots: Boolean!, $feature: AzureNativeProtectionFeature!) {
          startDisableAzureNativeSubscriptionProtectionJob(
            input: {azureSubscriptionRubrikId: $azure_subscription_rubrik_id, shouldDeleteNativeSnapshots: $delete_snapshots, azureNativeProtectionFeature: $feature}
          ) {
            ...StartDisableAzureNativeSubscriptionProtectionJobFragment
          }
        }
        fragment StartDisableAzureNativeSubscriptionProtectionJobFragment on AsyncJobStatus {
          jobId
        }";
      
    }
}
