// SnappableGroupByAtSpecifiedTime.cs
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
    #region SnappableGroupByAtSpecifiedTime
    public class SnappableGroupByAtSpecifiedTime: BaseType
    {
        #region members

        //      C# -> SnappableConnection? SnappableConnection
        // GraphQL -> snappableConnection: SnappableConnection! (type)
        [JsonProperty("snappableConnection")]
        public SnappableConnection? SnappableConnection { get; set; }

        //      C# -> List<SnappableGroupBy>? SnappableGroupBy
        // GraphQL -> snappableGroupBy: [SnappableGroupBy!]! (type)
        [JsonProperty("snappableGroupBy")]
        public List<SnappableGroupBy>? SnappableGroupBy { get; set; }

        //      C# -> SnappableGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: SnappableGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public SnappableGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public SnappableGroupByAtSpecifiedTime Set(
        SnappableConnection? SnappableConnection = null,
        List<SnappableGroupBy>? SnappableGroupBy = null,
        SnappableGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( SnappableConnection != null ) {
            this.SnappableConnection = SnappableConnection;
        }
        if ( SnappableGroupBy != null ) {
            this.SnappableGroupBy = SnappableGroupBy;
        }
        if ( GroupByInfo != null ) {
            this.GroupByInfo = GroupByInfo;
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
        //      C# -> SnappableConnection? SnappableConnection
        // GraphQL -> snappableConnection: SnappableConnection! (type)
        if (this.SnappableConnection != null) {
            var fspec = this.SnappableConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snappableConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<SnappableGroupBy>? SnappableGroupBy
        // GraphQL -> snappableGroupBy: [SnappableGroupBy!]! (type)
        if (this.SnappableGroupBy != null) {
            var fspec = this.SnappableGroupBy.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snappableGroupBy {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SnappableGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: SnappableGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            var fspec = this.GroupByInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "groupByInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SnappableConnection? SnappableConnection
        // GraphQL -> snappableConnection: SnappableConnection! (type)
        if (this.SnappableConnection == null && Exploration.Includes(parent + ".snappableConnection"))
        {
            this.SnappableConnection = new SnappableConnection();
            this.SnappableConnection.ApplyExploratoryFieldSpec(parent + ".snappableConnection");
        }
        //      C# -> List<SnappableGroupBy>? SnappableGroupBy
        // GraphQL -> snappableGroupBy: [SnappableGroupBy!]! (type)
        if (this.SnappableGroupBy == null && Exploration.Includes(parent + ".snappableGroupBy"))
        {
            this.SnappableGroupBy = new List<SnappableGroupBy>();
            this.SnappableGroupBy.ApplyExploratoryFieldSpec(parent + ".snappableGroupBy");
        }
        //      C# -> SnappableGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: SnappableGroupByInfo! (union)
        if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
        {
            var impls = new List<SnappableGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(parent + ".groupByInfo");
            this.GroupByInfo = (SnappableGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);
        }
    }


    #endregion

    } // class SnappableGroupByAtSpecifiedTime
    
    #endregion

    public static class ListSnappableGroupByAtSpecifiedTimeExtensions
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
            this List<SnappableGroupByAtSpecifiedTime> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnappableGroupByAtSpecifiedTime> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SnappableGroupByAtSpecifiedTime());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types