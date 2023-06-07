// EnvoyInfo.cs
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
    #region EnvoyInfo
    public class EnvoyInfo: BaseType
    {
        #region members

        //      C# -> EnvoyStatusField? EnvoyStatus
        // GraphQL -> envoyStatus: EnvoyStatusField! (enum)
        [JsonProperty("envoyStatus")]
        public EnvoyStatusField? EnvoyStatus { get; set; }

        //      C# -> System.String? EnvoyHostname
        // GraphQL -> envoyHostname: String! (scalar)
        [JsonProperty("envoyHostname")]
        public System.String? EnvoyHostname { get; set; }

        //      C# -> List<System.String>? EnvoyIps
        // GraphQL -> envoyIps: [String!]! (scalar)
        [JsonProperty("envoyIps")]
        public List<System.String>? EnvoyIps { get; set; }

        //      C# -> System.String? EnvoyUuid
        // GraphQL -> envoyUuid: UUID! (scalar)
        [JsonProperty("envoyUuid")]
        public System.String? EnvoyUuid { get; set; }


        #endregion

    #region methods

    public EnvoyInfo Set(
        EnvoyStatusField? EnvoyStatus = null,
        System.String? EnvoyHostname = null,
        List<System.String>? EnvoyIps = null,
        System.String? EnvoyUuid = null
    ) 
    {
        if ( EnvoyStatus != null ) {
            this.EnvoyStatus = EnvoyStatus;
        }
        if ( EnvoyHostname != null ) {
            this.EnvoyHostname = EnvoyHostname;
        }
        if ( EnvoyIps != null ) {
            this.EnvoyIps = EnvoyIps;
        }
        if ( EnvoyUuid != null ) {
            this.EnvoyUuid = EnvoyUuid;
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
        //      C# -> EnvoyStatusField? EnvoyStatus
        // GraphQL -> envoyStatus: EnvoyStatusField! (enum)
        if (this.EnvoyStatus != null) {
            s += ind + "envoyStatus\n" ;
        }
        //      C# -> System.String? EnvoyHostname
        // GraphQL -> envoyHostname: String! (scalar)
        if (this.EnvoyHostname != null) {
            s += ind + "envoyHostname\n" ;
        }
        //      C# -> List<System.String>? EnvoyIps
        // GraphQL -> envoyIps: [String!]! (scalar)
        if (this.EnvoyIps != null) {
            s += ind + "envoyIps\n" ;
        }
        //      C# -> System.String? EnvoyUuid
        // GraphQL -> envoyUuid: UUID! (scalar)
        if (this.EnvoyUuid != null) {
            s += ind + "envoyUuid\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> EnvoyStatusField? EnvoyStatus
        // GraphQL -> envoyStatus: EnvoyStatusField! (enum)
        if (this.EnvoyStatus == null && Exploration.Includes(parent + ".envoyStatus", true))
        {
            this.EnvoyStatus = new EnvoyStatusField();
        }
        //      C# -> System.String? EnvoyHostname
        // GraphQL -> envoyHostname: String! (scalar)
        if (this.EnvoyHostname == null && Exploration.Includes(parent + ".envoyHostname", true))
        {
            this.EnvoyHostname = "FETCH";
        }
        //      C# -> List<System.String>? EnvoyIps
        // GraphQL -> envoyIps: [String!]! (scalar)
        if (this.EnvoyIps == null && Exploration.Includes(parent + ".envoyIps", true))
        {
            this.EnvoyIps = new List<System.String>();
        }
        //      C# -> System.String? EnvoyUuid
        // GraphQL -> envoyUuid: UUID! (scalar)
        if (this.EnvoyUuid == null && Exploration.Includes(parent + ".envoyUuid", true))
        {
            this.EnvoyUuid = "FETCH";
        }
    }


    #endregion

    } // class EnvoyInfo
    
    #endregion

    public static class ListEnvoyInfoExtensions
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
            this List<EnvoyInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<EnvoyInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new EnvoyInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types