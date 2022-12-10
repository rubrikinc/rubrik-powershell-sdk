// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AllRscEventsPerTimePeriodQuery {
      /// <summary>
      /// AllRscEventsPerTimePeriodQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { timeAgo=(any), after=(string) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AllRscEventsPerTimePeriodDocument,
          OperationName = "AllRscEventsPerTimePeriod",
          Variables = variables
        };
      }

      
      public static string AllRscEventsPerTimePeriodDocument = @"
        query AllRscEventsPerTimePeriod($timeAgo: DateTime, $after: String) {
          activitySeriesConnection(
            filters: {clusterId: {id: [""00000000-0000-0000-0000-000000000000""]}, startTimeGt: $timeAgo, lastUpdatedTimeGt: $timeAgo}
            first: 20
            after: $after
          ) {
            ...AllRscEventsPerTimePeriodFragment
          }
        }
        fragment AllRscEventsPerTimePeriodFragment on ActivitySeriesConnection {
          edges {
            node {
              id
              fid
              activitySeriesId
              lastUpdated
              lastActivityType
              lastActivityStatus
              objectId
              objectName
              objectType
              severity
              progress
              cluster {
                id
                name
              }
              cluster {
                id
                name
              }
              activityConnection {
                nodes {
                  id
                  message
                  time
                }
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
