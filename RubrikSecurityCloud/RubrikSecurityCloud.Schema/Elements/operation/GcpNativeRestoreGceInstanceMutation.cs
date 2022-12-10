// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class GcpNativeRestoreGceInstanceMutation {
      /// <summary>
      /// GcpNativeRestoreGceInstanceMutation.Request 
      /// <para>Required variables:<br/> { snapshot_id=(any) }</para>
      /// <para>Optional variables:<br/> { should_restore_tags=(bool), should_add_rubrik_labels=(bool), should_power_on=(bool) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = GcpNativeRestoreGceInstanceDocument,
          OperationName = "GcpNativeRestoreGceInstance",
          Variables = variables
        };
      }

      
      public static string GcpNativeRestoreGceInstanceDocument = @"
        mutation GcpNativeRestoreGceInstance($snapshot_id: UUID!, $should_restore_tags: Boolean = true, $should_add_rubrik_labels: Boolean = false, $should_power_on: Boolean = true) {
          gcpNativeRestoreGceInstance(
            input: {snapshotId: $snapshot_id, shouldRestoreLabels: $should_restore_tags, shouldAddRubrikLabels: $should_add_rubrik_labels, shouldStartRestoredInstance: $should_power_on}
          ) {
            ...GcpNativeRestoreGceInstanceFragment
          }
        }
        fragment GcpNativeRestoreGceInstanceFragment on AsyncJobStatus {
          jobId
        }";
      
    }
}
