// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class GcpNativeProjectsQuery {
      /// <summary>
      /// GcpNativeProjectsQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { filter=(string) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = GcpNativeProjectsDocument,
          OperationName = "GcpNativeProjects",
          Variables = variables
        };
      }

      
      public static string GcpNativeProjectsDocument = @"
        query GcpNativeProjects($filter: String = """") {
          gcpNativeProjects(
            projectFilters: {nameOrNumberSubstringFilter: {nameOrNumberSubstring: $filter}}
          ) {
            ...GcpNativeProjectsFragment
          }
        }
        fragment GcpNativeProjectsFragment on GcpNativeProjectConnection {
          edges {
            node {
              id: id
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
              gcp_native_project_name: nativeName
              gcp_native_project_id: nativeId
              gcp_native_project_number: projectNumber
              organization_name: organizationName
            }
          }
        }";
      
    }
}
