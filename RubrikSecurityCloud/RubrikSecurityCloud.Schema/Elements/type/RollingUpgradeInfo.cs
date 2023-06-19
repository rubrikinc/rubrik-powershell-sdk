// RollingUpgradeInfo.cs
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
    #region RollingUpgradeInfo
    public class RollingUpgradeInfo: BaseType
    {
        #region members

        //      C# -> List<System.String>? RuCurrentNodes
        // GraphQL -> ruCurrentNodes: [String!]! (scalar)
        [JsonProperty("ruCurrentNodes")]
        public List<System.String>? RuCurrentNodes { get; set; }

        //      C# -> List<RollingUpgradeNodeInfoEntry>? RuNodeInfoList
        // GraphQL -> ruNodeInfoList: [RollingUpgradeNodeInfoEntry!]! (type)
        [JsonProperty("ruNodeInfoList")]
        public List<RollingUpgradeNodeInfoEntry>? RuNodeInfoList { get; set; }


        #endregion

    #region methods

    public RollingUpgradeInfo Set(
        List<System.String>? RuCurrentNodes = null,
        List<RollingUpgradeNodeInfoEntry>? RuNodeInfoList = null
    ) 
    {
        if ( RuCurrentNodes != null ) {
            this.RuCurrentNodes = RuCurrentNodes;
        }
        if ( RuNodeInfoList != null ) {
            this.RuNodeInfoList = RuNodeInfoList;
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
        //      C# -> List<System.String>? RuCurrentNodes
        // GraphQL -> ruCurrentNodes: [String!]! (scalar)
        if (this.RuCurrentNodes != null) {
            s += ind + "ruCurrentNodes\n" ;
        }
        //      C# -> List<RollingUpgradeNodeInfoEntry>? RuNodeInfoList
        // GraphQL -> ruNodeInfoList: [RollingUpgradeNodeInfoEntry!]! (type)
        if (this.RuNodeInfoList != null) {
            var fspec = this.RuNodeInfoList.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "ruNodeInfoList {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? RuCurrentNodes
        // GraphQL -> ruCurrentNodes: [String!]! (scalar)
        if (this.RuCurrentNodes == null && Exploration.Includes(parent + ".ruCurrentNodes", true))
        {
            this.RuCurrentNodes = new List<System.String>();
        }
        //      C# -> List<RollingUpgradeNodeInfoEntry>? RuNodeInfoList
        // GraphQL -> ruNodeInfoList: [RollingUpgradeNodeInfoEntry!]! (type)
        if (this.RuNodeInfoList == null && Exploration.Includes(parent + ".ruNodeInfoList"))
        {
            this.RuNodeInfoList = new List<RollingUpgradeNodeInfoEntry>();
            this.RuNodeInfoList.ApplyExploratoryFieldSpec(parent + ".ruNodeInfoList");
        }
    }


    #endregion

    } // class RollingUpgradeInfo
    
    #endregion

    public static class ListRollingUpgradeInfoExtensions
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
            this List<RollingUpgradeInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RollingUpgradeInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RollingUpgradeInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types