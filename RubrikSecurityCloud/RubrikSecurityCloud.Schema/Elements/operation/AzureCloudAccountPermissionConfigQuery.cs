// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AzureCloudAccountPermissionConfigQuery {
      /// <summary>
      /// AzureCloudAccountPermissionConfigQuery.Request 
      /// <para>Required variables:<br/> { cloud_account_features=(CloudAccountFeature) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AzureCloudAccountPermissionConfigDocument,
          OperationName = "AzureCloudAccountPermissionConfig",
          Variables = variables
        };
      }

      
      public static string AzureCloudAccountPermissionConfigDocument = @"
        query AzureCloudAccountPermissionConfig($cloud_account_features: CloudAccountFeature!) {
          azureCloudAccountPermissionConfig(feature: $cloud_account_features) {
            ...AzureCloudAccountPermissionConfigFragment
          }
        }
        fragment AzureCloudAccountPermissionConfigFragment on AzureCloudAccountPermissionConfigResponse {
          permissionVersion
          rolePermissions {
            excludedActions
            excludedDataActions
            includedActions
            includedDataActions
          }
        }";
      
    }
}
