// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class ActivitySeriesListQuery {
      /// <summary>
      /// ActivitySeriesListQuery.Request 
      /// <para>Required variables:<br/> { activitySeriesId=(any) }</para>
      /// <para>Optional variables:<br/> { clusterUuid=(any) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = ActivitySeriesListDocument,
          OperationName = "ActivitySeriesList",
          Variables = variables
        };
      }

      
      public static string ActivitySeriesListDocument = @"
        query ActivitySeriesList($activitySeriesId: UUID!, $clusterUuid: UUID) {
          activitySeries(
            input: {activitySeriesId: $activitySeriesId, clusterUuid: $clusterUuid}
          ) {
            ...ActivitySeriesFragment
          }
        }
        fragment ActivitySeriesFragment on ActivitySeries {
          id
          activityConnection {
            nodes {
              id
              message
              status
              time
              severity
              activityInfo
            }
          }
          progress
          lastUpdated
          startTime
          objectName
          objectType
          objectId
          lastActivityType
          lastActivityStatus
          isPolarisEventSeries
          cluster {
            id
            name
          }
        }";
      
    }
}
