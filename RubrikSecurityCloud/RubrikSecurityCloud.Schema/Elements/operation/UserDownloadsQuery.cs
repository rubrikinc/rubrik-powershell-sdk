// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class UserDownloadsQuery {
      /// <summary>
      /// UserDownloadsQuery.Request 
      /// </summary>
      public static GraphQLRequest Request() {
        return new GraphQLRequest {
          Query = UserDownloadsDocument,
          OperationName = "UserDownloads"
        };
      }

      
      public static string UserDownloadsDocument = @"
        query UserDownloads {
          getUserDownloads {
            id
            name
            status
            progress
            identifier
            createTime
            completeTime
          }
        }
        ";
      
    }
}
