// RollingUpgradeNodeInfo.cs
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
    #region RollingUpgradeNodeInfo
    public class RollingUpgradeNodeInfo: BaseType
    {
        #region members

        //      C# -> System.String? RuEndTs
        // GraphQL -> ruEndTs: String! (scalar)
        [JsonProperty("ruEndTs")]
        public System.String? RuEndTs { get; set; }

        //      C# -> System.String? RuStartTs
        // GraphQL -> ruStartTs: String! (scalar)
        [JsonProperty("ruStartTs")]
        public System.String? RuStartTs { get; set; }

        //      C# -> CurrentStateInfo? CurrentStateInfo
        // GraphQL -> currentStateInfo: CurrentStateInfo (type)
        [JsonProperty("currentStateInfo")]
        public CurrentStateInfo? CurrentStateInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RollingUpgradeNodeInfo";
    }

    public RollingUpgradeNodeInfo Set(
        System.String? RuEndTs = null,
        System.String? RuStartTs = null,
        CurrentStateInfo? CurrentStateInfo = null
    ) 
    {
        if ( RuEndTs != null ) {
            this.RuEndTs = RuEndTs;
        }
        if ( RuStartTs != null ) {
            this.RuStartTs = RuStartTs;
        }
        if ( CurrentStateInfo != null ) {
            this.CurrentStateInfo = CurrentStateInfo;
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
        //      C# -> System.String? RuEndTs
        // GraphQL -> ruEndTs: String! (scalar)
        if (this.RuEndTs != null) {
            s += ind + "ruEndTs\n" ;
        }
        //      C# -> System.String? RuStartTs
        // GraphQL -> ruStartTs: String! (scalar)
        if (this.RuStartTs != null) {
            s += ind + "ruStartTs\n" ;
        }
        //      C# -> CurrentStateInfo? CurrentStateInfo
        // GraphQL -> currentStateInfo: CurrentStateInfo (type)
        if (this.CurrentStateInfo != null) {
            var fspec = this.CurrentStateInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "currentStateInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? RuEndTs
        // GraphQL -> ruEndTs: String! (scalar)
        if (this.RuEndTs == null && ec.Includes("ruEndTs",true))
        {
            this.RuEndTs = "FETCH";
        }
        //      C# -> System.String? RuStartTs
        // GraphQL -> ruStartTs: String! (scalar)
        if (this.RuStartTs == null && ec.Includes("ruStartTs",true))
        {
            this.RuStartTs = "FETCH";
        }
        //      C# -> CurrentStateInfo? CurrentStateInfo
        // GraphQL -> currentStateInfo: CurrentStateInfo (type)
        if (this.CurrentStateInfo == null && ec.Includes("currentStateInfo",false))
        {
            this.CurrentStateInfo = new CurrentStateInfo();
            this.CurrentStateInfo.ApplyExploratoryFieldSpec(ec.NewChild("currentStateInfo"));
        }
    }


    #endregion

    } // class RollingUpgradeNodeInfo
    
    #endregion

    public static class ListRollingUpgradeNodeInfoExtensions
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
            this List<RollingUpgradeNodeInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RollingUpgradeNodeInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RollingUpgradeNodeInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<RollingUpgradeNodeInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types