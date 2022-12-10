// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class SonarAnalyzerGroupsQuery {
      /// <summary>
      /// SonarAnalyzerGroupsQuery.Request 
      /// </summary>
      public static GraphQLRequest Request() {
        return new GraphQLRequest {
          Query = SonarAnalyzerGroupsDocument,
          OperationName = "SonarAnalyzerGroups"
        };
      }

      
      public static string SonarAnalyzerGroupsDocument = @"
        query SonarAnalyzerGroups {
          analyzerGroups {
            ...AnalyzerGroupFragment
          }
        }
        fragment AnalyzerGroupFragment on AnalyzerGroupConnection {
          nodes {
            id
            name
            groupType
            analyzers {
              id
              name
              analyzerType
            }
          }
        }";
      
    }
}
