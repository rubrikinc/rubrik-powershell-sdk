// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class FinalizeAwsCloudAccountDeletionMutation {
      /// <summary>
      /// FinalizeAwsCloudAccountDeletionMutation.Request 
      /// <para>Required variables:<br/> { cloud_account_uuid=(any) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = FinalizeAwsCloudAccountDeletionDocument,
          OperationName = "FinalizeAwsCloudAccountDeletion",
          Variables = variables
        };
      }

      
      public static string FinalizeAwsCloudAccountDeletionDocument = @"
        mutation FinalizeAwsCloudAccountDeletion($cloud_account_uuid: UUID!) {
          finalizeAwsCloudAccountDeletion(
            input: {cloudAccountId: $cloud_account_uuid, feature: CLOUD_NATIVE_PROTECTION}
          ) {
            ...FinalizeAwsCloudAccountDeletionFragment
          }
        }
        fragment FinalizeAwsCloudAccountDeletionFragment on FinalizeAwsCloudAccountDeletionReply {
          message
        }";
      
    }
}
