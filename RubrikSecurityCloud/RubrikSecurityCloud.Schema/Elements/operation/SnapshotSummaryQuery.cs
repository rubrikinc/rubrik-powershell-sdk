// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class SnapshotSummaryQuery {
      /// <summary>
      /// SnapshotSummaryQuery.Request 
      /// <para>Required variables:<br/> { workloadId=(string) }</para>
      /// <para>Optional variables:<br/> { first=(int) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = SnapshotSummaryDocument,
          OperationName = "SnapshotSummary",
          Variables = variables
        };
      }

      
      public static string SnapshotSummaryDocument = @"
        query SnapshotSummary($first: Int, $workloadId: String!) {
          snapshotOfASnappableConnection(
            first: $first
            workloadId: $workloadId
            sortOrder: DESC
          ) {
            ...GenericSnapshotConnectionFragment
          }
        }
        fragment GenericSnapshotConnectionFragment on GenericSnapshotConnection {
          edges {
            node {
              id
              date
              expirationDate
              isOnDemandSnapshot
              snappableId
              ... on PolarisSnapshot {
                slaDomain {
                  name
                  id
                }
              }
            }
          }
        }";
      
    }
}
