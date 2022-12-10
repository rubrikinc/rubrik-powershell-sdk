// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class DeleteAzureCloudAccountWithoutOauthMutation {
      /// <summary>
      /// DeleteAzureCloudAccountWithoutOauthMutation.Request 
      /// <para>Required variables:<br/> { cloud_account_features=(CloudAccountFeature[]), azure_subscription_ids=(any[]) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = DeleteAzureCloudAccountWithoutOauthDocument,
          OperationName = "DeleteAzureCloudAccountWithoutOauth",
          Variables = variables
        };
      }

      
      public static string DeleteAzureCloudAccountWithoutOauthDocument = @"
        mutation DeleteAzureCloudAccountWithoutOauth($cloud_account_features: [CloudAccountFeature!]!, $azure_subscription_ids: [UUID!]!) {
          deleteAzureCloudAccountWithoutOauth(
            input: {features: $cloud_account_features, azureSubscriptionRubrikIds: $azure_subscription_ids}
          ) {
            ...DeleteAzureCloudAccountWithoutOauthFragment
          }
        }
        fragment DeleteAzureCloudAccountWithoutOauthFragment on DeleteAzureCloudAccountWithoutOauthReply {
          status {
            azureSubscriptionNativeId
            isSuccess
            error
          }
        }";
      
    }
}
