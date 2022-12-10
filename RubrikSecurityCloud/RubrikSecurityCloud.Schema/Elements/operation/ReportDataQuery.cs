// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class ReportDataQuery {
      /// <summary>
      /// ReportDataQuery.Request 
      /// <para>Required variables:<br/> { first=(int) }</para>
      /// <para>Optional variables:<br/> { filter=(SnappableFilterInput), after=(string), sortBy=(SnappableSortByEnum), sortOrder=(SortOrder) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = ReportDataDocument,
          OperationName = "ReportData",
          Variables = variables
        };
      }

      
      public static string ReportDataDocument = @"
        query ReportData($first: Int!, $filter: SnappableFilterInput, $after: String, $sortBy: SnappableSortByEnum, $sortOrder: SortOrder) {
          snappableConnection(
            first: $first
            filter: $filter
            after: $after
            sortBy: $sortBy
            sortOrder: $sortOrder
          ) {
            ...SnappableConnectionFragment
          }
        }
        fragment SnappableConnectionFragment on SnappableConnection {
          edges {
            cursor
            node {
              name
              objectType
              fid
              protectionStatus
              lastSnapshot
              location
              archiveStorage
              replicaStorage
              pullTime
              totalSnapshots
              missedSnapshots
              localSnapshots
              logicalDataReduction
              physicalBytes
              logicalBytes
              archiveSnapshots
              replicaSnapshots
              complianceStatus
              slaDomain {
                name
                id
              }
              cluster {
                name
                id
              }
            }
          }
          pageInfo {
            endCursor
            hasNextPage
          }
        }";
      
    }
}
