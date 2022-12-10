// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class StartAwsNativeAccountDisableJobMutation {
      /// <summary>
      /// StartAwsNativeAccountDisableJobMutation.Request 
      /// <para>Required variables:<br/> { polaris_account_id=(any) }</para>
      /// <para>Optional variables:<br/> { delete_native_snapshots=(bool), aws_native_protection_feature=(AwsNativeProtectionFeature) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = StartAwsNativeAccountDisableJobDocument,
          OperationName = "StartAwsNativeAccountDisableJob",
          Variables = variables
        };
      }

      
      public static string StartAwsNativeAccountDisableJobDocument = @"
        mutation StartAwsNativeAccountDisableJob($polaris_account_id: UUID!, $delete_native_snapshots: Boolean = false, $aws_native_protection_feature: AwsNativeProtectionFeature = EC2) {
          startAwsNativeAccountDisableJob(
            input: {awsAccountRubrikId: $polaris_account_id, shouldDeleteNativeSnapshots: $delete_native_snapshots, awsNativeProtectionFeature: $aws_native_protection_feature}
          ) {
            ...StartAwsNativeAccountDisableJobFragment
          }
        }
        fragment StartAwsNativeAccountDisableJobFragment on AsyncJobStatus {
          jobId
        }";
      
    }
}
