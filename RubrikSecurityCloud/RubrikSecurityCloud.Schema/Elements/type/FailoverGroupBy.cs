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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> FailoverConnection? FailoverConnection
        // GraphQL -> failoverConnection: FailoverConnection! (type)
        if (this.FailoverConnection == null && Exploration.Includes(parent + ".failoverConnection"))
        {
            this.FailoverConnection = new FailoverConnection();
            this.FailoverConnection.ApplyExploratoryFieldSpec(parent + ".failoverConnection");
        }
        //      C# -> List<FailoverGroupBy>? FailoverGroupByField
        // GraphQL -> failoverGroupBy: [FailoverGroupBy!]! (type)
        if (this.FailoverGroupByField == null && Exploration.Includes(parent + ".failoverGroupBy"))
        {
            this.FailoverGroupByField = new List<FailoverGroupBy>();
            this.FailoverGroupByField.ApplyExploratoryFieldSpec(parent + ".failoverGroupBy");
        }
        //      C# -> FailoverGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: FailoverGroupByInfo! (union)
        if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
        {
            var impls = new List<FailoverGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(parent + ".groupByInfo");
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
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types