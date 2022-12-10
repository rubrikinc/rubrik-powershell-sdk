// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class StartRestoreAwsNativeEc2InstanceSnapshotJobMutation {
      /// <summary>
      /// StartRestoreAwsNativeEc2InstanceSnapshotJobMutation.Request 
      /// <para>Required variables:<br/> { snapshot_id=(string) }</para>
      /// <para>Optional variables:<br/> { should_power_on=(bool), should_restore_tags=(bool) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = StartRestoreAwsNativeEc2InstanceSnapshotJobDocument,
          OperationName = "StartRestoreAwsNativeEc2InstanceSnapshotJob",
          Variables = variables
        };
      }

      
      public static string StartRestoreAwsNativeEc2InstanceSnapshotJobDocument = @"
        mutation StartRestoreAwsNativeEc2InstanceSnapshotJob($snapshot_id: String!, $should_power_on: Boolean = true, $should_restore_tags: Boolean = true) {
          startRestoreAwsNativeEc2InstanceSnapshotJob(
            input: {snapshotId: $snapshot_id, shouldPowerOn: $should_power_on, shouldRestoreTags: $should_restore_tags}
          ) {
            ...StartRestoreAwsNativeEc2InstanceSnapshotJobFragment
          }
        }
        fragment StartRestoreAwsNativeEc2InstanceSnapshotJobFragment on AsyncJobStatus {
          jobId
        }";
      
    }
}
