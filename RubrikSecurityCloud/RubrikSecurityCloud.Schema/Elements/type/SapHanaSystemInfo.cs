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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

        //      C# -> SapHanaSystemAuthTypeSpec? AuthTypeSpec
        // GraphQL -> authTypeSpec: SapHanaSystemAuthTypeSpec (type)
        [JsonProperty("authTypeSpec")]
        public SapHanaSystemAuthTypeSpec? AuthTypeSpec { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SapHanaSystemInfo";
    }

    public SapHanaSystemInfo Set(
        System.String? HanaVersion = null,
        System.Boolean? IsSystemReplicationEnabled = null,
        SapHanaSystemAuthTypeSpec? AuthTypeSpec = null
    ) 
    {
        if ( HanaVersion != null ) {
            this.HanaVersion = HanaVersion;
        }
        if ( IsSystemReplicationEnabled != null ) {
            this.IsSystemReplicationEnabled = IsSystemReplicationEnabled;
        }
        if ( AuthTypeSpec != null ) {
            this.AuthTypeSpec = AuthTypeSpec;
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
        //      C# -> SapHanaSystemAuthTypeSpec? AuthTypeSpec
        // GraphQL -> authTypeSpec: SapHanaSystemAuthTypeSpec (type)
        if (this.AuthTypeSpec != null) {
            var fspec = this.AuthTypeSpec.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "authTypeSpec {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? HanaVersion
        // GraphQL -> hanaVersion: String! (scalar)
        if (this.HanaVersion == null && ec.Includes("hanaVersion",true))
        {
            this.HanaVersion = "FETCH";
        }
        //      C# -> System.Boolean? IsSystemReplicationEnabled
        // GraphQL -> isSystemReplicationEnabled: Boolean! (scalar)
        if (this.IsSystemReplicationEnabled == null && ec.Includes("isSystemReplicationEnabled",true))
        {
            this.IsSystemReplicationEnabled = true;
        }
        //      C# -> SapHanaSystemAuthTypeSpec? AuthTypeSpec
        // GraphQL -> authTypeSpec: SapHanaSystemAuthTypeSpec (type)
        if (this.AuthTypeSpec == null && ec.Includes("authTypeSpec",false))
        {
            this.AuthTypeSpec = new SapHanaSystemAuthTypeSpec();
            this.AuthTypeSpec.ApplyExploratoryFieldSpec(ec.NewChild("authTypeSpec"));
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
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaSystemInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SapHanaSystemInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types