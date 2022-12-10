// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class IntrospectionEnumValueQuery {
      /// <summary>
      /// IntrospectionEnumValueQuery.Request 
      /// <para>Required variables:<br/> { enum_name=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = IntrospectionEnumValueDocument,
          OperationName = "IntrospectionEnumValue",
          Variables = variables
        };
      }

      
      public static string IntrospectionEnumValueDocument = @"
        query IntrospectionEnumValue($enum_name: String!) {
          __type(name: $enum_name) {
            states: enumValues {
              name
            }
          }
        }
        ";
      
    }
}
