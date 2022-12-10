// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AllBlueprintsQuery {
      /// <summary>
      /// AllBlueprintsQuery.Request 
      /// <para>Required variables:<br/> { filter=(Filter[]) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AllBlueprintsDocument,
          OperationName = "AllBlueprints",
          Variables = variables
        };
      }

      
      public static string AllBlueprintsDocument = @"
        query AllBlueprints($filter: [Filter!]!) {
          allBlueprints(filter: $filter) {
            ...AllBlueprintsFragment
          }
        }
        fragment AllBlueprintsFragment on BlueprintNewConnection {
          edges {
            node {
              id
              name
              status
              version
              numChildren
              sourceLocation {
                ... on BlueprintCdmLocation {
                  cluster {
                    name
                    id
                    status
                  }
                }
              }
              targetLocation {
                ... on BlueprintCdmLocation {
                  cluster {
                    name
                    id
                    status
                  }
                }
              }
              latestFailover {
                status
                failoverType
              }
              lastFailoverStatus
              lastFailoverTime
              lastTestFailoverStatus
            }
          }
        }";
      
    }
}
