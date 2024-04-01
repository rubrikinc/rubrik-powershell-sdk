// PolarisSnapshotGroupBy.cs
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
    #region PolarisSnapshotGroupBy
    public class PolarisSnapshotGroupBy: BaseType
    {
        #region members

        //      C# -> PolarisSnapshotConnection? PolarisSnapshotConnection
        // GraphQL -> polarisSnapshotConnection: PolarisSnapshotConnection! (type)
        [JsonProperty("polarisSnapshotConnection")]
        public PolarisSnapshotConnection? PolarisSnapshotConnection { get; set; }

        //      C# -> List<PolarisSnapshotGroupBy>? PolarisSnapshotGroupByField
        // GraphQL -> polarisSnapshotGroupBy: [PolarisSnapshotGroupBy!]! (type)
        [JsonProperty("polarisSnapshotGroupBy")]
        public List<PolarisSnapshotGroupBy>? PolarisSnapshotGroupByField { get; set; }

        //      C# -> PolarisSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: PolarisSnapshotGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public PolarisSnapshotGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PolarisSnapshotGroupBy";
    }

    public PolarisSnapshotGroupBy Set(
        PolarisSnapshotConnection? PolarisSnapshotConnection = null,
        List<PolarisSnapshotGroupBy>? PolarisSnapshotGroupByField = null,
        PolarisSnapshotGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( PolarisSnapshotConnection != null ) {
            this.PolarisSnapshotConnection = PolarisSnapshotConnection;
        }
        if ( PolarisSnapshotGroupByField != null ) {
            this.PolarisSnapshotGroupByField = PolarisSnapshotGroupByField;
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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> PolarisSnapshotConnection? PolarisSnapshotConnection
        // GraphQL -> polarisSnapshotConnection: PolarisSnapshotConnection! (type)
        if (this.PolarisSnapshotConnection != null) {
            var fspec = this.PolarisSnapshotConnection.AsFieldSpec(conf.Child("polarisSnapshotConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "polarisSnapshotConnection {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PolarisSnapshotGroupBy>? PolarisSnapshotGroupByField
        // GraphQL -> polarisSnapshotGroupBy: [PolarisSnapshotGroupBy!]! (type)
        if (this.PolarisSnapshotGroupByField != null) {
            var fspec = this.PolarisSnapshotGroupByField.AsFieldSpec(conf.Child("polarisSnapshotGroupBy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "polarisSnapshotGroupBy {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PolarisSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: PolarisSnapshotGroupByInfo! (union)
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
        //      C# -> PolarisSnapshotConnection? PolarisSnapshotConnection
        // GraphQL -> polarisSnapshotConnection: PolarisSnapshotConnection! (type)
        if (ec.Includes("polarisSnapshotConnection",false))
        {
            if(this.PolarisSnapshotConnection == null) {

                this.PolarisSnapshotConnection = new PolarisSnapshotConnection();
                this.PolarisSnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("polarisSnapshotConnection"));

            } else {

                this.PolarisSnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("polarisSnapshotConnection"));

            }
        }
        else if (this.PolarisSnapshotConnection != null && ec.Excludes("polarisSnapshotConnection",false))
        {
            this.PolarisSnapshotConnection = null;
        }
        //      C# -> List<PolarisSnapshotGroupBy>? PolarisSnapshotGroupByField
        // GraphQL -> polarisSnapshotGroupBy: [PolarisSnapshotGroupBy!]! (type)
        if (ec.Includes("polarisSnapshotGroupBy",false))
        {
            if(this.PolarisSnapshotGroupByField == null) {

                this.PolarisSnapshotGroupByField = new List<PolarisSnapshotGroupBy>();
                this.PolarisSnapshotGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("polarisSnapshotGroupBy"));

            } else {

                this.PolarisSnapshotGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("polarisSnapshotGroupBy"));

            }
        }
        else if (this.PolarisSnapshotGroupByField != null && ec.Excludes("polarisSnapshotGroupBy",false))
        {
            this.PolarisSnapshotGroupByField = null;
        }
        //      C# -> PolarisSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: PolarisSnapshotGroupByInfo! (union)
        if (ec.Includes("groupByInfo",false))
        {
            if(this.GroupByInfo == null) {

                var impls = new List<PolarisSnapshotGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (PolarisSnapshotGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<PolarisSnapshotGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (PolarisSnapshotGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.GroupByInfo != null && ec.Excludes("groupByInfo",false))
        {
            this.GroupByInfo = null;
        }
    }


    #endregion

    } // class PolarisSnapshotGroupBy
    
    #endregion

    public static class ListPolarisSnapshotGroupByExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<PolarisSnapshotGroupBy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PolarisSnapshotGroupBy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PolarisSnapshotGroupBy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisSnapshotGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolarisSnapshotGroupBy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types