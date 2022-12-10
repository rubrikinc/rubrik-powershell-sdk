// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class ActivitySeriesConnectionQuery {
      /// <summary>
      /// ActivitySeriesConnectionQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { after=(string), filters=(ActivitySeriesFilter), first=(int), sortBy=(ActivitySeriesSortField), sortOrder=(SortOrder) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = ActivitySeriesConnectionDocument,
          OperationName = "ActivitySeriesConnection",
          Variables = variables
        };
      }

      
      public static string ActivitySeriesConnectionDocument = @"
        query ActivitySeriesConnection($after: String, $filters: ActivitySeriesFilter, $first: Int, $sortBy: ActivitySeriesSortField, $sortOrder: SortOrder) {
          activitySeriesConnection(
            after: $after
            first: $first
            filters: $filters
            sortBy: $sortBy
            sortOrder: $sortOrder
          ) {
            ...ActivitySeriesConnectionFragment1
          }
        }
        fragment ActivitySeriesConnectionFragment1 on ActivitySeriesConnection {
          edges {
            node {
              id
              fid
              activitySeriesId
              startTime
              lastUpdated
              lastActivityType
              lastActivityStatus
              location
              objectName
              objectId
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
                  severity
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
