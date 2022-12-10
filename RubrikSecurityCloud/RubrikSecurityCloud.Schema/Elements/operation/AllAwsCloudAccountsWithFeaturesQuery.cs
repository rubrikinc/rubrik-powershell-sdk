// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AllAwsCloudAccountsWithFeaturesQuery {
      /// <summary>
      /// AllAwsCloudAccountsWithFeaturesQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { column_filter=(string) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AllAwsCloudAccountsWithFeaturesDocument,
          OperationName = "AllAwsCloudAccountsWithFeatures",
          Variables = variables
        };
      }

      
      public static string AllAwsCloudAccountsWithFeaturesDocument = @"
        query AllAwsCloudAccountsWithFeatures($column_filter: String = """") {
          allAwsCloudAccountsWithFeatures(
            awsCloudAccountsArg: {columnSearchFilter: $column_filter, statusFilters: [], feature: CLOUD_NATIVE_PROTECTION}
          ) {
            ...AllAwsCloudAccountsWithFeaturesFragment
          }
        }
        fragment AllAwsCloudAccountsWithFeaturesFragment on AwsCloudAccountWithFeatures {
          awsCloudAccount {
            id
            nativeId
            message
            accountName
          }
          featureDetails {
            feature
            roleArn
            stackArn
            status
            awsRegions
          }
        }";
      
    }
}
