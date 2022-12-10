// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AllEventsPerTimePeriodQuery {
      /// <summary>
      /// AllEventsPerTimePeriodQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { timeAgo=(any) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AllEventsPerTimePeriodDocument,
          OperationName = "AllEventsPerTimePeriod",
          Variables = variables
        };
      }

      
      public static string AllEventsPerTimePeriodDocument = @"
        query AllEventsPerTimePeriod($timeAgo: DateTime) {
          activitySeriesConnection(filters: {lastUpdatedTimeGt: $timeAgo}) {
            ...AllEventsPerTimePeriodFragment
          }
        }
        fragment AllEventsPerTimePeriodFragment on ActivitySeriesConnection {
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
              isCancelable
              isPolarisEventSeries
              cluster {
                id
                name
              }
              activityConnection(first: 1) {
                nodes {
                  id
                  message
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
