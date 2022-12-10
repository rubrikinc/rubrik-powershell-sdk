// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class DownloadSonarOnDemandScanResultMutation {
      /// <summary>
      /// DownloadSonarOnDemandScanResultMutation.Request 
      /// <para>Required variables:<br/> { crawlId=(string), filter=(DownloadResultsCsvFiltersInput) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = DownloadSonarOnDemandScanResultDocument,
          OperationName = "DownloadSonarOnDemandScanResult",
          Variables = variables
        };
      }

      
      public static string DownloadSonarOnDemandScanResultDocument = @"
        mutation DownloadSonarOnDemandScanResult($crawlId: String!, $filter: DownloadResultsCsvFiltersInput!) {
          downloadResultsCsv(crawlId: $crawlId, downloadFilter: $filter) {
            ...DownloadResultsCsv
          }
        }
        fragment DownloadResultsCsv on DownloadResultsCsvReply {
          downloadLink
        }";
      
    }
}
