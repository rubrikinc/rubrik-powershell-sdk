// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class SlaListQuery {
      /// <summary>
      /// SlaListQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { filter=(GlobalSlaFilterInput[]) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = SlaListDocument,
          OperationName = "SlaList",
          Variables = variables
        };
      }

      
      public static string SlaListDocument = @"
        query SlaList($filter: [GlobalSlaFilterInput!]) {
          globalSlaFilterConnection(filter: $filter) {
            ...GlobalSlaForFilterConnectionFragment
          }
        }
        fragment GlobalSlaForFilterConnectionFragment on GlobalSlaForFilterConnection {
          edges {
            node {
              name
              id
            }
          }
        }";
      
    }
}
