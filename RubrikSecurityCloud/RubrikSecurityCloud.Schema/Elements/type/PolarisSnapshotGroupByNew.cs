// PolarisSnapshotGroupByNew.cs
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
    #region PolarisSnapshotGroupByNew
    public class PolarisSnapshotGroupByNew: BaseType
    {
        #region members

        //      C# -> PolarisSnapshotConnection? PolarisSnapshotConnection
        // GraphQL -> polarisSnapshotConnection: PolarisSnapshotConnection! (type)
        [JsonProperty("polarisSnapshotConnection")]
        public PolarisSnapshotConnection? PolarisSnapshotConnection { get; set; }

        //      C# -> PolarisSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: PolarisSnapshotGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public PolarisSnapshotGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PolarisSnapshotGroupByNew";
    }

    public PolarisSnapshotGroupByNew Set(
        PolarisSnapshotConnection? PolarisSnapshotConnection = null,
        PolarisSnapshotGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( PolarisSnapshotConnection != null ) {
            this.PolarisSnapshotConnection = PolarisSnapshotConnection;
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
        //      C# -> PolarisSnapshotConnection? PolarisSnapshotConnection
        // GraphQL -> polarisSnapshotConnection: PolarisSnapshotConnection! (type)
        if (this.PolarisSnapshotConnection != null) {
            var fspec = this.PolarisSnapshotConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "polarisSnapshotConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PolarisSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: PolarisSnapshotGroupByInfo! (union)
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
        //      C# -> PolarisSnapshotConnection? PolarisSnapshotConnection
        // GraphQL -> polarisSnapshotConnection: PolarisSnapshotConnection! (type)
        if (this.PolarisSnapshotConnection == null && ec.Includes("polarisSnapshotConnection",false))
        {
            this.PolarisSnapshotConnection = new PolarisSnapshotConnection();
            this.PolarisSnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("polarisSnapshotConnection"));
        }
        //      C# -> PolarisSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: PolarisSnapshotGroupByInfo! (union)
        if (this.GroupByInfo == null && ec.Includes("groupByInfo",false))
        {
            var impls = new List<PolarisSnapshotGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
            this.GroupByInfo = (PolarisSnapshotGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);
        }
    }


    #endregion

    } // class PolarisSnapshotGroupByNew
    
    #endregion

    public static class ListPolarisSnapshotGroupByNewExtensions
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
            this List<PolarisSnapshotGroupByNew> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PolarisSnapshotGroupByNew> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisSnapshotGroupByNew());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<PolarisSnapshotGroupByNew> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types