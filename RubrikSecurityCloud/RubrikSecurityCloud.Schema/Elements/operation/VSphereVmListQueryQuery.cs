// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class VSphereVmListQueryQuery {
      /// <summary>
      /// VSphereVmListQueryQuery.Request 
      /// </summary>
      public static GraphQLRequest Request() {
        return new GraphQLRequest {
          Query = VSphereVmListQueryDocument,
          OperationName = "VSphereVmListQuery"
        };
      }

      
      public static string VSphereVmListQueryDocument = @"
        query VSphereVmListQuery {
          vSphereVmNewConnection {
            ...VsphereVmConnectionFragment1
          }
        }
        fragment VsphereVmConnectionFragment1 on VsphereVmConnection {
          nodes {
            id
            name
            cdmId
            cdmLink
            configuredSlaDomain {
              id
              name
            }
            guestOsType
            guestOsName
            slaAssignment
            agentStatus {
              agentStatus
            }
            effectiveSlaDomain {
              id
              name
            }
            protectionDate
            powerStatus
          }
        }";
      
    }
}
