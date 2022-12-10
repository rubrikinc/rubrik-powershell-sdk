// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class StartEc2InstanceSnapshotExportJobMutation {
      /// <summary>
      /// StartEc2InstanceSnapshotExportJobMutation.Request 
      /// <para>Required variables:<br/> { snapshot_id=(any), account_id=(any), instance_type=(AwsNativeEc2InstanceType), instance_name=(string), security_group_ids=(string[]), subnet_id=(string), region=(AwsNativeRegion), copy_tags=(bool) }</para>
      /// <para>Optional variables:<br/> { kms_key_id=(string), ssh_keypair_name=(string) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = StartEc2InstanceSnapshotExportJobDocument,
          OperationName = "StartEc2InstanceSnapshotExportJob",
          Variables = variables
        };
      }

      
      public static string StartEc2InstanceSnapshotExportJobDocument = @"
        mutation StartEc2InstanceSnapshotExportJob($snapshot_id: UUID!, $account_id: UUID!, $instance_type: AwsNativeEc2InstanceType!, $instance_name: String!, $security_group_ids: [String!]!, $subnet_id: String!, $region: AwsNativeRegion!, $copy_tags: Boolean!, $kms_key_id: String, $ssh_keypair_name: String) {
          startEc2InstanceSnapshotExportJob(
            input: {snapshotId: $snapshot_id, destinationAwsAccountRubrikId: $account_id, instanceType: $instance_type, instanceName: $instance_name, securityGroupIds: $security_group_ids, subnetId: $subnet_id, destinationRegionId: $region, shouldCopyTags: $copy_tags, kmsKeyId: $kms_key_id, sshKeyPairName: $ssh_keypair_name}
          ) {
            ...StartEc2InstanceSnapshotExportJobFragment
          }
        }
        fragment StartEc2InstanceSnapshotExportJobFragment on AsyncJobStatus {
          jobId
          __typename
        }";
      
    }
}
