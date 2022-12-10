// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class ValidateAndCreateAwsCloudAccountMutation {
      /// <summary>
      /// ValidateAndCreateAwsCloudAccountMutation.Request 
      /// <para>Required variables:<br/> { account_name=(string), aws_account_id=(string), cloud_account_action=(CloudAccountAction), cloud_account_features=(CloudAccountFeature[]) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = ValidateAndCreateAwsCloudAccountDocument,
          OperationName = "ValidateAndCreateAwsCloudAccount",
          Variables = variables
        };
      }

      
      public static string ValidateAndCreateAwsCloudAccountDocument = @"
        mutation ValidateAndCreateAwsCloudAccount($account_name: String!, $aws_account_id: String!, $cloud_account_action: CloudAccountAction!, $cloud_account_features: [CloudAccountFeature!]!) {
          validateAndCreateAwsCloudAccount(
            input: {action: $cloud_account_action, awsChildAccounts: [{accountName: $account_name, nativeId: $aws_account_id}], features: $cloud_account_features}
          ) {
            ...ValidateAndCreateAwsCloudAccountFragment
          }
        }
        fragment ValidateAndCreateAwsCloudAccountFragment on ValidateAndCreateAwsCloudAccountReply {
          initiateResponse {
            cloudFormationUrl
            externalId
            featureVersions {
              feature
              version
            }
            stackName
            templateUrl
          }
          validateResponse {
            invalidAwsAccounts {
              accountName
              nativeId
              message
            }
            invalidAwsAdminAccount {
              accountName
              nativeId
              message
            }
          }
        }";
      
    }
}
