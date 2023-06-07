// SapHanaHost.cs
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
    #region SapHanaHost
    public class SapHanaHost: BaseType
    {
        #region members

        //      C# -> SapHanaHostHostType? HostType
        // GraphQL -> hostType: SapHanaHostHostType (enum)
        [JsonProperty("hostType")]
        public SapHanaHostHostType? HostType { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.String? HostUuid
        // GraphQL -> hostUuid: String! (scalar)
        [JsonProperty("hostUuid")]
        public System.String? HostUuid { get; set; }

        //      C# -> System.String? SapHanaHostName
        // GraphQL -> sapHanaHostName: String (scalar)
        [JsonProperty("sapHanaHostName")]
        public System.String? SapHanaHostName { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }


        #endregion

    #region methods

    public SapHanaHost Set(
        SapHanaHostHostType? HostType = null,
        System.String? HostName = null,
        System.String? HostUuid = null,
        System.String? SapHanaHostName = null,
        System.String? Status = null
    ) 
    {
        if ( HostType != null ) {
            this.HostType = HostType;
        }
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( HostUuid != null ) {
            this.HostUuid = HostUuid;
        }
        if ( SapHanaHostName != null ) {
            this.SapHanaHostName = SapHanaHostName;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        //      C# -> SapHanaHostHostType? HostType
        // GraphQL -> hostType: SapHanaHostHostType (enum)
        if (this.HostType != null) {
            s += ind + "hostType\n" ;
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName != null) {
            s += ind + "hostName\n" ;
        }
        //      C# -> System.String? HostUuid
        // GraphQL -> hostUuid: String! (scalar)
        if (this.HostUuid != null) {
            s += ind + "hostUuid\n" ;
        }
        //      C# -> System.String? SapHanaHostName
        // GraphQL -> sapHanaHostName: String (scalar)
        if (this.SapHanaHostName != null) {
            s += ind + "sapHanaHostName\n" ;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SapHanaHostHostType? HostType
        // GraphQL -> hostType: SapHanaHostHostType (enum)
        if (this.HostType == null && Exploration.Includes(parent + ".hostType", true))
        {
            this.HostType = new SapHanaHostHostType();
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName == null && Exploration.Includes(parent + ".hostName", true))
        {
            this.HostName = "FETCH";
        }
        //      C# -> System.String? HostUuid
        // GraphQL -> hostUuid: String! (scalar)
        if (this.HostUuid == null && Exploration.Includes(parent + ".hostUuid", true))
        {
            this.HostUuid = "FETCH";
        }
        //      C# -> System.String? SapHanaHostName
        // GraphQL -> sapHanaHostName: String (scalar)
        if (this.SapHanaHostName == null && Exploration.Includes(parent + ".sapHanaHostName", true))
        {
            this.SapHanaHostName = "FETCH";
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = "FETCH";
        }
    }


    #endregion

    } // class SapHanaHost
    
    #endregion

    public static class ListSapHanaHostExtensions
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
            this List<SapHanaHost> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaHost> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaHost());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types