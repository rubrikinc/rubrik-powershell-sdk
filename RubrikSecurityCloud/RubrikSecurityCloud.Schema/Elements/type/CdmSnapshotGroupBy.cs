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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "CdmSnapshotGroupBy";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<CdmSnapshotGroupBy>? CdmSnapshotGroupByField
        // GraphQL -> cdmSnapshotGroupBy: [CdmSnapshotGroupBy!]! (type)
        if (this.CdmSnapshotGroupByField != null) {
            var fspec = this.CdmSnapshotGroupByField.AsFieldSpec(conf.Child("cdmSnapshotGroupBy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cdmSnapshotGroupBy {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection! (type)
        if (this.SnapshotConnection != null) {
            var fspec = this.SnapshotConnection.AsFieldSpec(conf.Child("snapshotConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotConnection {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: CdmSnapshotGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            var fspec = this.GroupByInfo.AsFieldSpec(conf.Child("groupByInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groupByInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<CdmSnapshotGroupBy>? CdmSnapshotGroupByField
        // GraphQL -> cdmSnapshotGroupBy: [CdmSnapshotGroupBy!]! (type)
        if (ec.Includes("cdmSnapshotGroupBy",false))
        {
            if(this.CdmSnapshotGroupByField == null) {

                this.CdmSnapshotGroupByField = new List<CdmSnapshotGroupBy>();
                this.CdmSnapshotGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("cdmSnapshotGroupBy"));

            } else {

                this.CdmSnapshotGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("cdmSnapshotGroupBy"));

            }
        }
        else if (this.CdmSnapshotGroupByField != null && ec.Excludes("cdmSnapshotGroupBy",false))
        {
            this.CdmSnapshotGroupByField = null;
        }
        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection! (type)
        if (ec.Includes("snapshotConnection",false))
        {
            if(this.SnapshotConnection == null) {

                this.SnapshotConnection = new CdmSnapshotConnection();
                this.SnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotConnection"));

            } else {

                this.SnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotConnection"));

            }
        }
        else if (this.SnapshotConnection != null && ec.Excludes("snapshotConnection",false))
        {
            this.SnapshotConnection = null;
        }
        //      C# -> CdmSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: CdmSnapshotGroupByInfo! (union)
        if (ec.Includes("groupByInfo",false))
        {
            if(this.GroupByInfo == null) {

                var impls = new List<CdmSnapshotGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (CdmSnapshotGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<CdmSnapshotGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (CdmSnapshotGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.GroupByInfo != null && ec.Excludes("groupByInfo",false))
        {
            this.GroupByInfo = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CdmSnapshotGroupBy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmSnapshotGroupBy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmSnapshotGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmSnapshotGroupBy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types