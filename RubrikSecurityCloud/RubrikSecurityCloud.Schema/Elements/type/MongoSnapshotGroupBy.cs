// MongoSnapshotGroupBy.cs
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
    #region MongoSnapshotGroupBy
    public class MongoSnapshotGroupBy: BaseType
    {
        #region members

        //      C# -> CdmSnapshotConnection? MongoSnapshotConnection
        // GraphQL -> mongoSnapshotConnection: CdmSnapshotConnection! (type)
        [JsonProperty("mongoSnapshotConnection")]
        public CdmSnapshotConnection? MongoSnapshotConnection { get; set; }

        //      C# -> List<MongoSnapshotGroupBy>? MongoSnapshotGroupByField
        // GraphQL -> mongoSnapshotGroupBy: [MongoSnapshotGroupBy!]! (type)
        [JsonProperty("mongoSnapshotGroupBy")]
        public List<MongoSnapshotGroupBy>? MongoSnapshotGroupByField { get; set; }

        //      C# -> MongoSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: MongoSnapshotGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public MongoSnapshotGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public MongoSnapshotGroupBy Set(
        CdmSnapshotConnection? MongoSnapshotConnection = null,
        List<MongoSnapshotGroupBy>? MongoSnapshotGroupByField = null,
        MongoSnapshotGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( MongoSnapshotConnection != null ) {
            this.MongoSnapshotConnection = MongoSnapshotConnection;
        }
        if ( MongoSnapshotGroupByField != null ) {
            this.MongoSnapshotGroupByField = MongoSnapshotGroupByField;
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
        //      C# -> CdmSnapshotConnection? MongoSnapshotConnection
        // GraphQL -> mongoSnapshotConnection: CdmSnapshotConnection! (type)
        if (this.MongoSnapshotConnection != null) {
            s += ind + "mongoSnapshotConnection {\n" + this.MongoSnapshotConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<MongoSnapshotGroupBy>? MongoSnapshotGroupByField
        // GraphQL -> mongoSnapshotGroupBy: [MongoSnapshotGroupBy!]! (type)
        if (this.MongoSnapshotGroupByField != null) {
            s += ind + "mongoSnapshotGroupBy {\n" + this.MongoSnapshotGroupByField.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> MongoSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: MongoSnapshotGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            s += ind + "groupByInfo {\n" + this.GroupByInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> CdmSnapshotConnection? MongoSnapshotConnection
        // GraphQL -> mongoSnapshotConnection: CdmSnapshotConnection! (type)
        if (this.MongoSnapshotConnection == null && Exploration.Includes(parent + ".mongoSnapshotConnection"))
        {
            this.MongoSnapshotConnection = new CdmSnapshotConnection();
            this.MongoSnapshotConnection.ApplyExploratoryFieldSpec(parent + ".mongoSnapshotConnection");
        }
        //      C# -> List<MongoSnapshotGroupBy>? MongoSnapshotGroupByField
        // GraphQL -> mongoSnapshotGroupBy: [MongoSnapshotGroupBy!]! (type)
        if (this.MongoSnapshotGroupByField == null && Exploration.Includes(parent + ".mongoSnapshotGroupBy"))
        {
            this.MongoSnapshotGroupByField = new List<MongoSnapshotGroupBy>();
            this.MongoSnapshotGroupByField.ApplyExploratoryFieldSpec(parent + ".mongoSnapshotGroupBy");
        }
        //      C# -> MongoSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: MongoSnapshotGroupByInfo! (union)
        if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
        {
            var impls = new List<MongoSnapshotGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(parent + ".groupByInfo");
            this.GroupByInfo = (MongoSnapshotGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);
        }
    }


    #endregion

    } // class MongoSnapshotGroupBy
    
    #endregion

    public static class ListMongoSnapshotGroupByExtensions
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
            this List<MongoSnapshotGroupBy> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MongoSnapshotGroupBy> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MongoSnapshotGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types