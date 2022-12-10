// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class VsphereVmInitiateLiveMountMutation {
      /// <summary>
      /// VsphereVmInitiateLiveMountMutation.Request 
      /// <para>Required variables:<br/> { snapshotFid=(any) }</para>
      /// <para>Optional variables:<br/> { vmName=(string), disableNetwork=(bool), removeNetworkDevices=(bool), powerOn=(bool), keepMacAddresses=(bool), hostID=(string), datastoreName=(string), createDatastoreOnly=(bool), vlan=(int), shouldRecoverTags=(bool) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = VsphereVmInitiateLiveMountDocument,
          OperationName = "VsphereVMInitiateLiveMount",
          Variables = variables
        };
      }

      
      public static string VsphereVmInitiateLiveMountDocument = @"
        mutation VsphereVMInitiateLiveMount($snapshotFid: UUID!, $vmName: String, $disableNetwork: Boolean, $removeNetworkDevices: Boolean, $powerOn: Boolean, $keepMacAddresses: Boolean, $hostID: String, $datastoreName: String, $createDatastoreOnly: Boolean, $vlan: Int, $shouldRecoverTags: Boolean) {
          vsphereVMInitiateLiveMount(
            snapshotFid: $snapshotFid
            vmName: $vmName
            disableNetwork: $disableNetwork
            removeNetworkDevices: $removeNetworkDevices
            powerOn: $powerOn
            keepMacAddresses: $keepMacAddresses
            hostID: $hostID
            datastoreName: $datastoreName
            createDatastoreOnly: $createDatastoreOnly
            vlan: $vlan
            shouldRecoverTags: $shouldRecoverTags
          ) {
            ...VsphereAsyncRequestStatusFragment1
          }
        }
        fragment VsphereAsyncRequestStatusFragment1 on VsphereAsyncRequestStatus {
          id
        }";
      
    }
}
