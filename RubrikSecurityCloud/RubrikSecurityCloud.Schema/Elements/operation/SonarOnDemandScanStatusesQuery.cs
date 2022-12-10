// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class SonarOnDemandScanStatusesQuery {
      /// <summary>
      /// SonarOnDemandScanStatusesQuery.Request 
      /// <para>Required variables:<br/> { crawlId=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = SonarOnDemandScanStatusesDocument,
          OperationName = "SonarOnDemandScanStatuses",
          Variables = variables
        };
      }

      
      public static string SonarOnDemandScanStatusesDocument = @"
        query SonarOnDemandScanStatuses($crawlId: String!) {
          crawl(crawlId: $crawlId) {
            id
            crawlObjConnection {
              nodes {
                ...CrawlObjFragment
              }
            }
          }
        }
        fragment CrawlObjFragment on CrawlObj {
          crawlId
          error
          snappable {
            id
            name
            objectType
          }
          snapshotTime
          status
          progress
          totalHits
          analyzerGroupResults {
            ...AnalyzerGroupResultFragment
          }
          cluster {
            id
            name
            type
          }
        }
        fragment AnalyzerGroupResultFragment on AnalyzerGroupResult {
          analyzerGroup {
            groupType
            id
            name
          }
          analyzerResults {
            hits {
              totalHits
              violations
              permittedHits
            }
            analyzer {
              id
              name
              analyzerType
            }
          }
          hits {
            totalHits
            violations
            permittedHits
            violationsDelta
            totalHitsDelta
          }
        }";
      
    }
}
