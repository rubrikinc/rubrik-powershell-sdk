// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class PolicyObjConnectionQuery {
      /// <summary>
      /// PolicyObjConnectionQuery.Request 
      /// <para>Required variables:<br/> { day=(string), timezone=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = PolicyObjConnectionDocument,
          OperationName = "PolicyObjConnection",
          Variables = variables
        };
      }

      
      public static string PolicyObjConnectionDocument = @"
        query PolicyObjConnection($day: String!, $timezone: String!) {
          policyObjs(day: $day, timezone: $timezone) {
            edges {
              node {
                snapshotFid
                snapshotTimestamp
                objectStatus {
                  latestSnapshotResult {
                    snapshotTime
                    snapshotFid
                  }
                }
                snappable {
                  name
                  id
                }
              }
            }
          }
        }
        ";
      
    }
}
