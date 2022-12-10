// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AllFeaturePermissionsForGcpCloudAccountQuery {
      /// <summary>
      /// AllFeaturePermissionsForGcpCloudAccountQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { feature=(CloudAccountFeature) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AllFeaturePermissionsForGcpCloudAccountDocument,
          OperationName = "AllFeaturePermissionsForGcpCloudAccount",
          Variables = variables
        };
      }

      
      public static string AllFeaturePermissionsForGcpCloudAccountDocument = @"
        query AllFeaturePermissionsForGcpCloudAccount($feature: CloudAccountFeature = CLOUD_NATIVE_PROTECTION) {
          allFeaturePermissionsForGcpCloudAccount(feature: $feature) {
            ...AllFeaturePermissionsForGcpCloudAccountFragment
          }
        }
        fragment AllFeaturePermissionsForGcpCloudAccountFragment on GcpPermission {
          permission
        }";
      
    }
}
