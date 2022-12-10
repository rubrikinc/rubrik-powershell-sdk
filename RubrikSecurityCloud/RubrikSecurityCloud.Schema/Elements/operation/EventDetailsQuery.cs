// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class EventDetailsQuery {
      /// <summary>
      /// EventDetailsQuery.Request 
      /// <para>Required variables:<br/> { activitySeriesId=(any), clusterUuid=(any) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = EventDetailsDocument,
          OperationName = "EventDetails",
          Variables = variables
        };
      }

      
      public static string EventDetailsDocument = @"
        query EventDetails($activitySeriesId: UUID!, $clusterUuid: UUID!) {
          activitySeries(
            input: {activitySeriesId: $activitySeriesId, clusterUuid: $clusterUuid}
          ) {
            ...EventDetailFragment
          }
        }
        fragment EventDetailFragment on ActivitySeries {
          activityConnection {
            nodes {
              message
              status
              time
              severity
            }
          }
          id
          fid
          activitySeriesId
          objectId
          objectName
          objectType
          cluster {
            id
            name
          }
          lastActivityStatus
        }";
      
    }
}
