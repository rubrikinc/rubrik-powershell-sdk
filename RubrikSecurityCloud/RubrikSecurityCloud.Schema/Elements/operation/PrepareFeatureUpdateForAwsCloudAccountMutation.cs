// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class PrepareFeatureUpdateForAwsCloudAccountMutation {
      /// <summary>
      /// PrepareFeatureUpdateForAwsCloudAccountMutation.Request 
      /// <para>Required variables:<br/> { aws_native_protection_feature=(CloudAccountFeature[]), polaris_account_id=(any) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = PrepareFeatureUpdateForAwsCloudAccountDocument,
          OperationName = "PrepareFeatureUpdateForAwsCloudAccount",
          Variables = variables
        };
      }

      
      public static string PrepareFeatureUpdateForAwsCloudAccountDocument = @"
        mutation PrepareFeatureUpdateForAwsCloudAccount($aws_native_protection_feature: [CloudAccountFeature!]!, $polaris_account_id: UUID!) {
          prepareFeatureUpdateForAwsCloudAccount(
            input: {features: $aws_native_protection_feature, cloudAccountId: $polaris_account_id}
          ) {
            ...PrepareFeatureUpdateForAwsCloudAccountFragment
          }
        }
        fragment PrepareFeatureUpdateForAwsCloudAccountFragment on PrepareFeatureUpdateForAwsCloudAccountReply {
          cloudFormationUrl
          templateUrl
        }";
      
    }
}
