// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class SonarPolicyDetailsQuery {
      /// <summary>
      /// SonarPolicyDetailsQuery.Request 
      /// </summary>
      public static GraphQLRequest Request() {
        return new GraphQLRequest {
          Query = SonarPolicyDetailsDocument,
          OperationName = "SonarPolicyDetails"
        };
      }

      
      public static string SonarPolicyDetailsDocument = @"
        query SonarPolicyDetails {
          policies(policyObjectFilter: HAS_OBJECTS) {
            nodes {
              ...PolicyDetailFragment
            }
          }
        }
        fragment PolicyDetailFragment on ClassificationPolicyDetail {
          id
          name
          description
          creator {
            email
          }
          totalObjects
          numAnalyzers
          objectStatuses {
            id
            latestSnapshotResult {
              snapshotFid
            }
            policyStatuses {
              policyId
              status
            }
          }
        }";
      
    }
}
