// RollingUpgradeNodeInfoEntry.cs
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
    #region RollingUpgradeNodeInfoEntry
    public class RollingUpgradeNodeInfoEntry: BaseType
    {
        #region members

        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        [JsonProperty("nodeName")]
        public System.String? NodeName { get; set; }

        //      C# -> RollingUpgradeNodeInfo? RuNodeInfo
        // GraphQL -> ruNodeInfo: RollingUpgradeNodeInfo (type)
        [JsonProperty("ruNodeInfo")]
        public RollingUpgradeNodeInfo? RuNodeInfo { get; set; }


        #endregion

    #region methods

    public RollingUpgradeNodeInfoEntry Set(
        System.String? NodeName = null,
        RollingUpgradeNodeInfo? RuNodeInfo = null
    ) 
    {
        if ( NodeName != null ) {
            this.NodeName = NodeName;
        }
        if ( RuNodeInfo != null ) {
            this.RuNodeInfo = RuNodeInfo;
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
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        if (this.NodeName != null) {
            s += ind + "nodeName\n" ;
        }
        //      C# -> RollingUpgradeNodeInfo? RuNodeInfo
        // GraphQL -> ruNodeInfo: RollingUpgradeNodeInfo (type)
        if (this.RuNodeInfo != null) {
            var fspec = this.RuNodeInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "ruNodeInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        if (this.NodeName == null && Exploration.Includes(parent + ".nodeName", true))
        {
            this.NodeName = "FETCH";
        }
        //      C# -> RollingUpgradeNodeInfo? RuNodeInfo
        // GraphQL -> ruNodeInfo: RollingUpgradeNodeInfo (type)
        if (this.RuNodeInfo == null && Exploration.Includes(parent + ".ruNodeInfo"))
        {
            this.RuNodeInfo = new RollingUpgradeNodeInfo();
            this.RuNodeInfo.ApplyExploratoryFieldSpec(parent + ".ruNodeInfo");
        }
    }


    #endregion

    } // class RollingUpgradeNodeInfoEntry
    
    #endregion

    public static class ListRollingUpgradeNodeInfoEntryExtensions
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
            this List<RollingUpgradeNodeInfoEntry> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RollingUpgradeNodeInfoEntry> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RollingUpgradeNodeInfoEntry());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types