// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class PrepareAwsCloudAccountDeletionMutation {
      /// <summary>
      /// PrepareAwsCloudAccountDeletionMutation.Request 
      /// <para>Required variables:<br/> { cloud_account_uuid=(any) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = PrepareAwsCloudAccountDeletionDocument,
          OperationName = "PrepareAwsCloudAccountDeletion",
          Variables = variables
        };
      }

      
      public static string PrepareAwsCloudAccountDeletionDocument = @"
        mutation PrepareAwsCloudAccountDeletion($cloud_account_uuid: UUID!) {
          prepareAwsCloudAccountDeletion(
            input: {cloudAccountId: $cloud_account_uuid, feature: CLOUD_NATIVE_PROTECTION}
          ) {
            ...PrepareAwsCloudAccountDeletionFragment
          }
        }
        fragment PrepareAwsCloudAccountDeletionFragment on PrepareAwsCloudAccountDeletionReply {
          cloudFormationUrl
        }";
      
    }
}
