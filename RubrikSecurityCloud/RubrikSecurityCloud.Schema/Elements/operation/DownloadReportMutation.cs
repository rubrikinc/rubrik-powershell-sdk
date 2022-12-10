// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class DownloadReportMutation {
      /// <summary>
      /// DownloadReportMutation.Request 
      /// <para>Required variables:<br/> { id=(int) }</para>
      /// <para>Optional variables:<br/> { config=(CustomReportCreate) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = DownloadReportDocument,
          OperationName = "DownloadReport",
          Variables = variables
        };
      }

      
      public static string DownloadReportDocument = @"
        mutation DownloadReport($id: Int!, $config: CustomReportCreate) {
          downloadReportCsvAsync(input: {id: $id, config: $config}) {
            ...DownloadReportFragment
          }
        }
        fragment DownloadReportFragment on AsyncDownloadReply {
          jobId
          referenceId
        }";
      
    }
}
