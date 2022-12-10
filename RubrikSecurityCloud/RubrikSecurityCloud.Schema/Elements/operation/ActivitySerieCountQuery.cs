// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class ActivitySerieCountQuery {
      /// <summary>
      /// ActivitySerieCountQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { timeAgo=(any) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = ActivitySerieCountDocument,
          OperationName = "ActivitySerieCount",
          Variables = variables
        };
      }

      
      public static string ActivitySerieCountDocument = @"
        query ActivitySerieCount($timeAgo: DateTime) {
          activitySeriesConnection(
            filters: {lastActivityType: ANOMALY, startTimeGt: $timeAgo}
          ) {
            count
          }
        }
        ";
      
    }
}
