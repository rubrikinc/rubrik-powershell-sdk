// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AuditLogsPerTimePeriodQuery {
      /// <summary>
      /// AuditLogsPerTimePeriodQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { timeAgo=(any) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AuditLogsPerTimePeriodDocument,
          OperationName = "AuditLogsPerTimePeriod",
          Variables = variables
        };
      }

      
      public static string AuditLogsPerTimePeriodDocument = @"
        query AuditLogsPerTimePeriod($timeAgo: DateTime) {
          userAuditConnection(filters: {timeGt: $timeAgo}) {
            ...AuditLogsPerTimePeriodFragment
          }
        }
        fragment AuditLogsPerTimePeriodFragment on UserAuditConnection {
          edges {
            node {
              id
              message
              time
              severity
              status
              cluster {
                id
                name
              }
            }
          }
        }";
      
    }
}
