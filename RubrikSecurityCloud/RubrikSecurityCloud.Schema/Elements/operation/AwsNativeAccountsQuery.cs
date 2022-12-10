// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AwsNativeAccountsQuery {
      /// <summary>
      /// AwsNativeAccountsQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { awsNativeProtectionFeature=(AwsNativeProtectionFeature), filter=(string) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AwsNativeAccountsDocument,
          OperationName = "AwsNativeAccounts",
          Variables = variables
        };
      }

      
      public static string AwsNativeAccountsDocument = @"
        query AwsNativeAccounts($awsNativeProtectionFeature: AwsNativeProtectionFeature = EC2, $filter: String = """") {
          awsNativeAccounts(
            awsNativeProtectionFeature: $awsNativeProtectionFeature
            accountFilters: {nameSubstringFilter: {nameSubstring: $filter}}
          ) {
            ...AwsNativeAccountsFragment
          }
        }
        fragment AwsNativeAccountsFragment on AwsNativeAccountConnection {
          edges {
            node {
              id: id
              regionSpecs {
                region
              }
              status
              name: name
              sla_assignment: slaAssignment
              configured_sla_domain_name: configuredSlaDomain {
                name
              }
              configured_sla_domain_id: configuredSlaDomain {
                id
              }
              effective_sla_domain_name: effectiveSlaDomain {
                name
              }
              effective_sla_domain_id: effectiveSlaDomain {
                id
              }
            }
          }
        }";
      
    }
}
