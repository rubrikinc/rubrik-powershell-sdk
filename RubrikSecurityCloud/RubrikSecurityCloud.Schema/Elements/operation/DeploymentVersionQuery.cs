// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class DeploymentVersionQuery {
      /// <summary>
      /// DeploymentVersionQuery.Request 
      /// </summary>
      public static GraphQLRequest Request() {
        return new GraphQLRequest {
          Query = DeploymentVersionDocument,
          OperationName = "DeploymentVersion"
        };
      }

      
      public static string DeploymentVersionDocument = @"
        query DeploymentVersion {
          deploymentVersion
        }
        ";
      
    }
}
