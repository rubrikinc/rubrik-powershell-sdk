// VcdVcenterConnectionInfo.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region VcdVcenterConnectionInfo
    public class VcdVcenterConnectionInfo: BaseType
    {
        #region members

        //      C# -> HostConnectivityStatusEnum? ConnectionStatus
        // GraphQL -> connectionStatus: HostConnectivityStatusEnum! (enum)
        [JsonProperty("connectionStatus")]
        public HostConnectivityStatusEnum? ConnectionStatus { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: UUID! (scalar)
        [JsonProperty("vcenterId")]
        public System.String? VcenterId { get; set; }


        #endregion

    #region methods

    public VcdVcenterConnectionInfo Set(
        HostConnectivityStatusEnum? ConnectionStatus = null,
        System.String? Name = null,
        System.String? VcenterId = null
    ) 
    {
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( VcenterId != null ) {
            this.VcenterId = VcenterId;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> HostConnectivityStatusEnum? ConnectionStatus
        // GraphQL -> connectionStatus: HostConnectivityStatusEnum! (enum)
        if (this.ConnectionStatus != null) {
            s += ind + "connectionStatus\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: UUID! (scalar)
        if (this.VcenterId != null) {
            s += ind + "vcenterId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> HostConnectivityStatusEnum? ConnectionStatus
        // GraphQL -> connectionStatus: HostConnectivityStatusEnum! (enum)
        if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus", true))
        {
            this.ConnectionStatus = new HostConnectivityStatusEnum();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: UUID! (scalar)
        if (this.VcenterId == null && Exploration.Includes(parent + ".vcenterId", true))
        {
            this.VcenterId = "FETCH";
        }
    }


    #endregion

    } // class VcdVcenterConnectionInfo
    
    #endregion

    public static class ListVcdVcenterConnectionInfoExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<VcdVcenterConnectionInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VcdVcenterConnectionInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VcdVcenterConnectionInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types