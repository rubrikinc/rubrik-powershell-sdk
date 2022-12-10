// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class SonarPolicyObjectsQuery {
      /// <summary>
      /// SonarPolicyObjectsQuery.Request 
      /// <para>Required variables:<br/> { snappableFid=(string), snapshotFid=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = SonarPolicyObjectsDocument,
          OperationName = "SonarPolicyObjects",
          Variables = variables
        };
      }

      
      public static string SonarPolicyObjectsDocument = @"
        query SonarPolicyObjects($snappableFid: String!, $snapshotFid: String!) {
          policyObj(snappableFid: $snappableFid, snapshotFid: $snapshotFid) {
            ...PolicyObjectFragment
          }
        }
        fragment PolicyObjectFragment on PolicyObj {
          id
          rootFileResult {
            hits {
              totalHits
            }
            analyzerGroupResults {
              analyzerGroup {
                name
              }
              analyzerResults {
                hits {
                  totalHits
                }
                analyzer {
                  name
                }
              }
              hits {
                totalHits
              }
            }
            filesWithHits {
              totalHits
            }
            openAccessFiles {
              totalHits
            }
            openAccessFolders {
              totalHits
            }
            openAccessFilesWithHits {
              totalHits
            }
            staleFiles {
              totalHits
            }
            staleFilesWithHits {
              totalHits
            }
            openAccessStaleFiles {
              totalHits
            }
          }
        }";
      
    }
}
