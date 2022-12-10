// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class GcpNativeGceInstancesQuery {
      /// <summary>
      /// GcpNativeGceInstancesQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { first=(int), after=(string), sortBy=(GcpNativeGceInstanceSortFields), sortOrder=(SortOrder), filters=(GcpNativeGceInstanceFilters) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = GcpNativeGceInstancesDocument,
          OperationName = "GcpNativeGceInstances",
          Variables = variables
        };
      }

      
      public static string GcpNativeGceInstancesDocument = @"
        query GcpNativeGceInstances($first: Int, $after: String, $sortBy: GcpNativeGceInstanceSortFields, $sortOrder: SortOrder, $filters: GcpNativeGceInstanceFilters) {
          gcpNativeGceInstances(
            first: $first
            after: $after
            sortBy: $sortBy
            sortOrder: $sortOrder
            gceInstanceFilters: $filters
          ) {
            ...GcpNativeGceInstancesFragment
          }
        }
        fragment GcpNativeGceInstancesFragment on GcpNativeGceInstanceConnection {
          edges {
            node {
              id
              nativeId
              nativeName
              vpcName
              networkHostProjectNativeId
              region
              zone
              isRelic
              machineType
              effectiveSlaDomain {
                name
                ... on ClusterSlaDomain {
                  fid
                  cluster {
                    id
                    name
                  }
                }
                ... on GlobalSlaReply {
                  id
                  name
                }
              }
              gcpNativeProject {
                id
                name
                nativeId
                status
              }
              slaAssignment
              authorizedOperations
              effectiveSlaSourceObject {
                fid
                name
                objectType
              }
            }
          }
          pageInfo {
            endCursor
            hasNextPage
            hasPreviousPage
          }
        }";
      
    }
}
