// FailoverGroupBy.cs
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
    #region FailoverGroupBy
    public class FailoverGroupBy: BaseType
    {
        #region members

        //      C# -> FailoverConnection? FailoverConnection
        // GraphQL -> failoverConnection: FailoverConnection! (type)
        [JsonProperty("failoverConnection")]
        public FailoverConnection? FailoverConnection { get; set; }

        //      C# -> List<FailoverGroupBy>? FailoverGroupByField
        // GraphQL -> failoverGroupBy: [FailoverGroupBy!]! (type)
        [JsonProperty("failoverGroupBy")]
        public List<FailoverGroupBy>? FailoverGroupByField { get; set; }

        //      C# -> FailoverGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: FailoverGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public FailoverGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailoverGroupBy";
    }

    public FailoverGroupBy Set(
        FailoverConnection? FailoverConnection = null,
        List<FailoverGroupBy>? FailoverGroupByField = null,
        FailoverGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( FailoverConnection != null ) {
            this.FailoverConnection = FailoverConnection;
        }
        if ( FailoverGroupByField != null ) {
            this.FailoverGroupByField = FailoverGroupByField;
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
        //      C# -> FailoverConnection? FailoverConnection
        // GraphQL -> failoverConnection: FailoverConnection! (type)
        if (this.FailoverConnection != null) {
            var fspec = this.FailoverConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "failoverConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<FailoverGroupBy>? FailoverGroupByField
        // GraphQL -> failoverGroupBy: [FailoverGroupBy!]! (type)
        if (this.FailoverGroupByField != null) {
            var fspec = this.FailoverGroupByField.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "failoverGroupBy {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> FailoverGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: FailoverGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            var fspec = this.GroupByInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "groupByInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> FailoverConnection? FailoverConnection
        // GraphQL -> failoverConnection: FailoverConnection! (type)
        if (this.FailoverConnection == null && ec.Includes("failoverConnection",false))
        {
            this.FailoverConnection = new FailoverConnection();
            this.FailoverConnection.ApplyExploratoryFieldSpec(ec.NewChild("failoverConnection"));
        }
        //      C# -> List<FailoverGroupBy>? FailoverGroupByField
        // GraphQL -> failoverGroupBy: [FailoverGroupBy!]! (type)
        if (this.FailoverGroupByField == null && ec.Includes("failoverGroupBy",false))
        {
            this.FailoverGroupByField = new List<FailoverGroupBy>();
            this.FailoverGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("failoverGroupBy"));
        }
        //      C# -> FailoverGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: FailoverGroupByInfo! (union)
        if (this.GroupByInfo == null && ec.Includes("groupByInfo",false))
        {
            var impls = new List<FailoverGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
            this.GroupByInfo = (FailoverGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);
        }
    }


    #endregion

    } // class FailoverGroupBy
    
    #endregion

    public static class ListFailoverGroupByExtensions
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
            this List<FailoverGroupBy> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FailoverGroupBy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<FailoverGroupBy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types