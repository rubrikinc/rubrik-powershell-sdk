// CdmSnapshotGroupBy.cs
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
    #region CdmSnapshotGroupBy
    public class CdmSnapshotGroupBy: BaseType
    {
        #region members

        //      C# -> List<CdmSnapshotGroupBy>? CdmSnapshotGroupByField
        // GraphQL -> cdmSnapshotGroupBy: [CdmSnapshotGroupBy!]! (type)
        [JsonProperty("cdmSnapshotGroupBy")]
        public List<CdmSnapshotGroupBy>? CdmSnapshotGroupByField { get; set; }

        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection! (type)
        [JsonProperty("snapshotConnection")]
        public CdmSnapshotConnection? SnapshotConnection { get; set; }

        //      C# -> CdmSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: CdmSnapshotGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public CdmSnapshotGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public CdmSnapshotGroupBy Set(
        List<CdmSnapshotGroupBy>? CdmSnapshotGroupByField = null,
        CdmSnapshotConnection? SnapshotConnection = null,
        CdmSnapshotGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( CdmSnapshotGroupByField != null ) {
            this.CdmSnapshotGroupByField = CdmSnapshotGroupByField;
        }
        if ( SnapshotConnection != null ) {
            this.SnapshotConnection = SnapshotConnection;
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
        //      C# -> List<CdmSnapshotGroupBy>? CdmSnapshotGroupByField
        // GraphQL -> cdmSnapshotGroupBy: [CdmSnapshotGroupBy!]! (type)
        if (this.CdmSnapshotGroupByField != null) {
            s += ind + "cdmSnapshotGroupBy {\n" + this.CdmSnapshotGroupByField.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection! (type)
        if (this.SnapshotConnection != null) {
            s += ind + "snapshotConnection {\n" + this.SnapshotConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: CdmSnapshotGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            s += ind + "groupByInfo {\n" + this.GroupByInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<CdmSnapshotGroupBy>? CdmSnapshotGroupByField
        // GraphQL -> cdmSnapshotGroupBy: [CdmSnapshotGroupBy!]! (type)
        if (this.CdmSnapshotGroupByField == null && Exploration.Includes(parent + ".cdmSnapshotGroupBy"))
        {
            this.CdmSnapshotGroupByField = new List<CdmSnapshotGroupBy>();
            this.CdmSnapshotGroupByField.ApplyExploratoryFieldSpec(parent + ".cdmSnapshotGroupBy");
        }
        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection! (type)
        if (this.SnapshotConnection == null && Exploration.Includes(parent + ".snapshotConnection"))
        {
            this.SnapshotConnection = new CdmSnapshotConnection();
            this.SnapshotConnection.ApplyExploratoryFieldSpec(parent + ".snapshotConnection");
        }
        //      C# -> CdmSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: CdmSnapshotGroupByInfo! (union)
        if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
        {
            var impls = new List<CdmSnapshotGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(parent + ".groupByInfo");
            this.GroupByInfo = (CdmSnapshotGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);
        }
    }


    #endregion

    } // class CdmSnapshotGroupBy
    
    #endregion

    public static class ListCdmSnapshotGroupByExtensions
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
            this List<CdmSnapshotGroupBy> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmSnapshotGroupBy> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmSnapshotGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types