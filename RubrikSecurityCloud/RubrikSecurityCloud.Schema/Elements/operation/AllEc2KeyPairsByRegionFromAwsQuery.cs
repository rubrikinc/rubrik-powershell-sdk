// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AllEc2KeyPairsByRegionFromAwsQuery {
      /// <summary>
      /// AllEc2KeyPairsByRegionFromAwsQuery.Request 
      /// <para>Required variables:<br/> { region=(AwsNativeRegion), aws_native_account_id=(any) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AllEc2KeyPairsByRegionFromAwsDocument,
          OperationName = "AllEc2KeyPairsByRegionFromAws",
          Variables = variables
        };
      }

      
      public static string AllEc2KeyPairsByRegionFromAwsDocument = @"
        query AllEc2KeyPairsByRegionFromAws($region: AwsNativeRegion!, $aws_native_account_id: UUID!) {
          allEc2KeyPairsByRegionFromAws(
            region: $region
            awsAccountRubrikId: $aws_native_account_id
          )
        }
        ";
      
    }
}
