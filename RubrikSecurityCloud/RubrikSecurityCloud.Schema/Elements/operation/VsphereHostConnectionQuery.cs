// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class VsphereHostConnectionQuery {
      /// <summary>
      /// VsphereHostConnectionQuery.Request 
      /// <para>Required variables:<br/> { first=(int) }</para>
      /// <para>Optional variables:<br/> { after=(string), filter=(Filter[]), sortBy=(HierarchySortByField), sortOrder=(SortOrder) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = VsphereHostConnectionDocument,
          OperationName = "VsphereHostConnection",
          Variables = variables
        };
      }

      
      public static string VsphereHostConnectionDocument = @"
        query VsphereHostConnection($first: Int!, $after: String, $filter: [Filter!], $sortBy: HierarchySortByField, $sortOrder: SortOrder) {
          vSphereHostConnection(
            first: $first
            after: $after
            filter: $filter
            sortBy: $sortBy
            sortOrder: $sortOrder
          ) {
            edges {
              node {
                id
                ...VSphereHostNameFragment
                ...VSphereHostPhysicalPathFragment
              }
            }
            pageInfo {
              endCursor
              hasNextPage
              hasPreviousPage
            }
          }
        }
        fragment VSphereHostNameFragment on VsphereHost {
          name
        }
        fragment VSphereHostPhysicalPathFragment on VsphereHost {
          physicalPath {
            fid
            name
            objectType
          }
        }";
      
    }
}
