// SapHanaSystemInfo.cs
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
    #region SapHanaSystemInfo
    public class SapHanaSystemInfo: BaseType
    {
        #region members

        //      C# -> System.String? HanaVersion
        // GraphQL -> hanaVersion: String! (scalar)
        [JsonProperty("hanaVersion")]
        public System.String? HanaVersion { get; set; }

        //      C# -> System.Boolean? IsSystemReplicationEnabled
        // GraphQL -> isSystemReplicationEnabled: Boolean! (scalar)
        [JsonProperty("isSystemReplicationEnabled")]
        public System.Boolean? IsSystemReplicationEnabled { get; set; }


        #endregion

    #region methods

    public SapHanaSystemInfo Set(
        System.String? HanaVersion = null,
        System.Boolean? IsSystemReplicationEnabled = null
    ) 
    {
        if ( HanaVersion != null ) {
            this.HanaVersion = HanaVersion;
        }
        if ( IsSystemReplicationEnabled != null ) {
            this.IsSystemReplicationEnabled = IsSystemReplicationEnabled;
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
        //      C# -> System.String? HanaVersion
        // GraphQL -> hanaVersion: String! (scalar)
        if (this.HanaVersion != null) {
            s += ind + "hanaVersion\n" ;
        }
        //      C# -> System.Boolean? IsSystemReplicationEnabled
        // GraphQL -> isSystemReplicationEnabled: Boolean! (scalar)
        if (this.IsSystemReplicationEnabled != null) {
            s += ind + "isSystemReplicationEnabled\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? HanaVersion
        // GraphQL -> hanaVersion: String! (scalar)
        if (this.HanaVersion == null && Exploration.Includes(parent + ".hanaVersion", true))
        {
            this.HanaVersion = "FETCH";
        }
        //      C# -> System.Boolean? IsSystemReplicationEnabled
        // GraphQL -> isSystemReplicationEnabled: Boolean! (scalar)
        if (this.IsSystemReplicationEnabled == null && Exploration.Includes(parent + ".isSystemReplicationEnabled", true))
        {
            this.IsSystemReplicationEnabled = true;
        }
    }


    #endregion

    } // class SapHanaSystemInfo
    
    #endregion

    public static class ListSapHanaSystemInfoExtensions
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
            this List<SapHanaSystemInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaSystemInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaSystemInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types