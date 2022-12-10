// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AllAuditLogPerTimePeriodQuery {
      /// <summary>
      /// AllAuditLogPerTimePeriodQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { timeAgo=(any) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AllAuditLogPerTimePeriodDocument,
          OperationName = "AllAuditLogPerTimePeriod",
          Variables = variables
        };
      }

      
      public static string AllAuditLogPerTimePeriodDocument = @"
        query AllAuditLogPerTimePeriod($timeAgo: DateTime) {
          userAuditConnection(filters: {timeGt: $timeAgo}) {
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
          }
        }
        ";
      
    }
}
