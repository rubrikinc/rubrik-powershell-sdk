// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class StartSonarOnDemandScanMutation {
      /// <summary>
      /// StartSonarOnDemandScanMutation.Request 
      /// <para>Required variables:<br/> { crawlName=(string), resources=(ResourceInput[]), analyzerGroups=(AnalyzerGroupInput[]) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = StartSonarOnDemandScanDocument,
          OperationName = "StartSonarOnDemandScan",
          Variables = variables
        };
      }

      
      public static string StartSonarOnDemandScanDocument = @"
        mutation StartSonarOnDemandScan($crawlName: String!, $resources: [ResourceInput!]!, $analyzerGroups: [AnalyzerGroupInput!]!) {
          startCrawl(
            name: $crawlName
            resources: $resources
            analyzerGroups: $analyzerGroups
          ) {
            ...StartCrawlFragment
          }
        }
        fragment StartCrawlFragment on StartCrawlReply {
          crawlId
        }";
      
    }
}
