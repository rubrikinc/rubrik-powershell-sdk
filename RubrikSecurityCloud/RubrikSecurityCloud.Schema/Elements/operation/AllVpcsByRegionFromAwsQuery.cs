// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AllVpcsByRegionFromAwsQuery {
      /// <summary>
      /// AllVpcsByRegionFromAwsQuery.Request 
      /// <para>Required variables:<br/> { region=(AwsNativeRegion), aws_native_account_id=(any) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AllVpcsByRegionFromAwsDocument,
          OperationName = "AllVpcsByRegionFromAws",
          Variables = variables
        };
      }

      
      public static string AllVpcsByRegionFromAwsDocument = @"
        query AllVpcsByRegionFromAws($region: AwsNativeRegion!, $aws_native_account_id: UUID!) {
          allVpcsByRegionFromAws(
            region: $region
            awsAccountRubrikId: $aws_native_account_id
          ) {
            ...AllVpcsByRegionFromAwsFragment
          }
        }
        fragment AllVpcsByRegionFromAwsFragment on AwsVpc {
          id
          name
          subnets {
            id
            name
            availabilityZone
          }
          securityGroups {
            id
            name
          }
        }";
      
    }
}
