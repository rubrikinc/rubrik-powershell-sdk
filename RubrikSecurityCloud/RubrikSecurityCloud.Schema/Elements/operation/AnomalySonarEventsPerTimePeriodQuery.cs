// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AnomalySonarEventsPerTimePeriodQuery {
      /// <summary>
      /// AnomalySonarEventsPerTimePeriodQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { timeAgo=(any) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AnomalySonarEventsPerTimePeriodDocument,
          OperationName = "AnomalySonarEventsPerTimePeriod",
          Variables = variables
        };
      }

      
      public static string AnomalySonarEventsPerTimePeriodDocument = @"
        query AnomalySonarEventsPerTimePeriod($timeAgo: DateTime) {
          activitySeriesConnection(
            filters: {lastActivityType: [ANOMALY, CLASSIFICATION], startTimeGt: $timeAgo}
          ) {
            ...AnomalySonarEventFragment
          }
        }
        fragment AnomalySonarEventFragment on ActivitySeriesConnection {
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
