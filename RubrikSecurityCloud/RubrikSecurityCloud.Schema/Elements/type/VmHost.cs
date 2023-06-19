// VmHost.cs
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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region VmHost
    public class VmHost: BaseType
    {
        #region members

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: String! (scalar)
        [JsonProperty("vcenterId")]
        public System.String? VcenterId { get; set; }

        //      C# -> System.String? VcenterName
        // GraphQL -> vcenterName: String! (scalar)
        [JsonProperty("vcenterName")]
        public System.String? VcenterName { get; set; }


        #endregion

    #region methods

    public VmHost Set(
        System.String? HostId = null,
        System.String? HostName = null,
        System.String? VcenterId = null,
        System.String? VcenterName = null
    ) 
    {
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( VcenterId != null ) {
            this.VcenterId = VcenterId;
        }
        if ( VcenterName != null ) {
            this.VcenterName = VcenterName;
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
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId != null) {
            s += ind + "hostId\n" ;
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName != null) {
            s += ind + "hostName\n" ;
        }
        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: String! (scalar)
        if (this.VcenterId != null) {
            s += ind + "vcenterId\n" ;
        }
        //      C# -> System.String? VcenterName
        // GraphQL -> vcenterName: String! (scalar)
        if (this.VcenterName != null) {
            s += ind + "vcenterName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId == null && Exploration.Includes(parent + ".hostId", true))
        {
            this.HostId = "FETCH";
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName == null && Exploration.Includes(parent + ".hostName", true))
        {
            this.HostName = "FETCH";
        }
        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: String! (scalar)
        if (this.VcenterId == null && Exploration.Includes(parent + ".vcenterId", true))
        {
            this.VcenterId = "FETCH";
        }
        //      C# -> System.String? VcenterName
        // GraphQL -> vcenterName: String! (scalar)
        if (this.VcenterName == null && Exploration.Includes(parent + ".vcenterName", true))
        {
            this.VcenterName = "FETCH";
        }
    }


    #endregion

    } // class VmHost
    
    #endregion

    public static class ListVmHostExtensions
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
            this List<VmHost> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmHost> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VmHost());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types