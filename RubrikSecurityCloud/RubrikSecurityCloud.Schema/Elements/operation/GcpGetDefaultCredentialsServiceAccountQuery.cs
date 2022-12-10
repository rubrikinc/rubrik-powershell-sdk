// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class GcpGetDefaultCredentialsServiceAccountQuery {
      /// <summary>
      /// GcpGetDefaultCredentialsServiceAccountQuery.Request 
      /// </summary>
      public static GraphQLRequest Request() {
        return new GraphQLRequest {
          Query = GcpGetDefaultCredentialsServiceAccountDocument,
          OperationName = "GcpGetDefaultCredentialsServiceAccount"
        };
      }

      
      public static string GcpGetDefaultCredentialsServiceAccountDocument = @"
        query GcpGetDefaultCredentialsServiceAccount {
          gcpGetDefaultCredentialsServiceAccount
        }
        ";
      
    }
}
