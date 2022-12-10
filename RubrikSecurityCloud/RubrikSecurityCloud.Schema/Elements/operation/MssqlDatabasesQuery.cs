// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class MssqlDatabasesQuery {
      /// <summary>
      /// MssqlDatabasesQuery.Request 
      /// </summary>
      public static GraphQLRequest Request() {
        return new GraphQLRequest {
          Query = MssqlDatabasesDocument,
          OperationName = "MssqlDatabases"
        };
      }

      
      public static string MssqlDatabasesDocument = @"
        query MssqlDatabases {
          mssqlDatabases {
            ...MssqlDatabasesFragment
          }
        }
        fragment MssqlDatabasesFragment on MssqlDatabaseConnection {
          nodes {
            id
            name
            dagId
            physicalPath {
              fid
              name
            }
            logicalPath {
              fid
              name
            }
            isInAvailabilityGroup
            cdmLink
            cdmId
            cluster {
              id
              name
            }
            effectiveSlaDomain {
              id
              name
            }
            primaryClusterLocation {
              name
            }
            recoveryModel
            slaAssignment
            configuredSlaDomain {
              id
              name
            }
          }
        }";
      
    }
}
