// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AllKmsEncryptionKeysByRegionFromAwsQuery {
      /// <summary>
      /// AllKmsEncryptionKeysByRegionFromAwsQuery.Request 
      /// <para>Required variables:<br/> { region=(AwsNativeRegion), aws_native_account_id=(any) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AllKmsEncryptionKeysByRegionFromAwsDocument,
          OperationName = "AllKmsEncryptionKeysByRegionFromAws",
          Variables = variables
        };
      }

      
      public static string AllKmsEncryptionKeysByRegionFromAwsDocument = @"
        query AllKmsEncryptionKeysByRegionFromAws($region: AwsNativeRegion!, $aws_native_account_id: UUID!) {
          allKmsEncryptionKeysByRegionFromAws(
            region: $region
            awsAccountRubrikId: $aws_native_account_id
          ) {
            ...AllKmsEncryptionKeysByRegionFromAwsFragment
          }
        }
        fragment AllKmsEncryptionKeysByRegionFromAwsFragment on KmsEncryptionKey {
          id
          aliases
          arn
        }";
      
    }
}
