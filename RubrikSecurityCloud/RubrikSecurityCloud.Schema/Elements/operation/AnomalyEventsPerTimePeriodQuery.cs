// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AnomalyEventsPerTimePeriodQuery {
      /// <summary>
      /// AnomalyEventsPerTimePeriodQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { timeAgo=(any) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AnomalyEventsPerTimePeriodDocument,
          OperationName = "AnomalyEventsPerTimePeriod",
          Variables = variables
        };
      }

      
      public static string AnomalyEventsPerTimePeriodDocument = @"
        query AnomalyEventsPerTimePeriod($timeAgo: DateTime) {
          activitySeriesConnection(
            filters: {lastActivityType: ANOMALY, startTimeGt: $timeAgo}
          ) {
            ...AnomalyEventFragment
          }
        }
        fragment AnomalyEventFragment on ActivitySeriesConnection {
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
              activityConnection {
                nodes {
                  id
                  message
                  time
                }
              }
            }
          }
        }";
      
    }
}
