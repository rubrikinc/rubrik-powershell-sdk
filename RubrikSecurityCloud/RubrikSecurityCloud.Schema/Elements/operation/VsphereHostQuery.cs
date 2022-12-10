// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class VsphereHostQuery {
      /// <summary>
      /// VsphereHostQuery.Request 
      /// <para>Required variables:<br/> { hostId=(any) }</para>
      /// <para>Optional variables:<br/> { first=(int), after=(string), filter=(Filter[]), sortBy=(HierarchySortByField), sortOrder=(SortOrder) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = VsphereHostDocument,
          OperationName = "VsphereHost",
          Variables = variables
        };
      }

      
      public static string VsphereHostDocument = @"
        query VsphereHost($hostId: UUID!, $first: Int, $after: String, $filter: [Filter!], $sortBy: HierarchySortByField, $sortOrder: SortOrder) {
          vSphereHost(fid: $hostId) {
            descendantConnection(
              first: $first
              after: $after
              filter: $filter
              sortBy: $sortBy
              sortOrder: $sortOrder
              typeFilter: [VSphereDatastore]
            ) {
              edges {
                node {
                  id
                  ...HierarchyObjectNameColumnFragment
                  ... on VsphereDatastore {
                    capacity
                    isLocal
                    freeSpace
                    datastoreType
                  }
                }
              }
              pageInfo {
                endCursor
                hasNextPage
                hasPreviousPage
              }
            }
          }
        }
        fragment HierarchyObjectNameColumnFragment on HierarchyObject {
          name
        }";
      
    }
}
