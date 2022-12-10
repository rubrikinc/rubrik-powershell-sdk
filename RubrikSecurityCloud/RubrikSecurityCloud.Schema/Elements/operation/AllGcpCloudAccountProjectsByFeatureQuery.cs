// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AllGcpCloudAccountProjectsByFeatureQuery {
      /// <summary>
      /// AllGcpCloudAccountProjectsByFeatureQuery.Request 
      /// <para>Required variables:<br/> { search_text=(string), status_filters=(CloudAccountStatus[]) }</para>
      /// <para>Optional variables:<br/> { feature=(CloudAccountFeature) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AllGcpCloudAccountProjectsByFeatureDocument,
          OperationName = "AllGcpCloudAccountProjectsByFeature",
          Variables = variables
        };
      }

      
      public static string AllGcpCloudAccountProjectsByFeatureDocument = @"
        query AllGcpCloudAccountProjectsByFeature($feature: CloudAccountFeature = CLOUD_NATIVE_PROTECTION, $search_text: String!, $status_filters: [CloudAccountStatus!]!) {
          allGcpCloudAccountProjectsByFeature(
            feature: $feature
            projectStatusFilters: $status_filters
            projectSearchText: $search_text
          ) {
            ...AllGcpCloudAccountProjectsByFeatureFragment
          }
        }
        fragment AllGcpCloudAccountProjectsByFeatureFragment on GcpCloudAccountProjectDetail {
          project {
            projectId
            projectNumber
            name
            id
          }
          featureDetail {
            status
          }
        }";
      
    }
}
