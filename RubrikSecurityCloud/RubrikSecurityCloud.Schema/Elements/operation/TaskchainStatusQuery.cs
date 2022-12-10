// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class TaskchainStatusQuery {
      /// <summary>
      /// TaskchainStatusQuery.Request 
      /// <para>Required variables:<br/> { filter=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = TaskchainStatusDocument,
          OperationName = "TaskchainStatus",
          Variables = variables
        };
      }

      
      public static string TaskchainStatusDocument = @"
        query TaskchainStatus($filter: String!) {
          getKorgTaskchainStatus(taskchainId: $filter) {
            ...KorgTaskchainStatusFragment
          }
        }
        fragment KorgTaskchainStatusFragment on GetTaskchainStatusReply {
          taskchain {
            id
            state
            taskchainUuid
            ... on Taskchain {
              progressedAt
            }
          }
        }";
      
    }
}
