// MosaicSnapshotGroupByType.cs
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
    #region MosaicSnapshotGroupByType
    public class MosaicSnapshotGroupByType: BaseType
    {
        #region members

        //      C# -> List<MosaicSnapshotGroupByType>? AllSnapshotGroupBys
        // GraphQL -> allSnapshotGroupBys: [MosaicSnapshotGroupByType!]! (type)
        [JsonProperty("allSnapshotGroupBys")]
        public List<MosaicSnapshotGroupByType>? AllSnapshotGroupBys { get; set; }

        //      C# -> MosaicSnapshotConnection? Snapshots
        // GraphQL -> snapshots: MosaicSnapshotConnection! (type)
        [JsonProperty("snapshots")]
        public MosaicSnapshotConnection? Snapshots { get; set; }

        //      C# -> MosaicSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: MosaicSnapshotGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public MosaicSnapshotGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MosaicSnapshotGroupByType";
    }

    public MosaicSnapshotGroupByType Set(
        List<MosaicSnapshotGroupByType>? AllSnapshotGroupBys = null,
        MosaicSnapshotConnection? Snapshots = null,
        MosaicSnapshotGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( AllSnapshotGroupBys != null ) {
            this.AllSnapshotGroupBys = AllSnapshotGroupBys;
        }
        if ( Snapshots != null ) {
            this.Snapshots = Snapshots;
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
        //      C# -> List<MosaicSnapshotGroupByType>? AllSnapshotGroupBys
        // GraphQL -> allSnapshotGroupBys: [MosaicSnapshotGroupByType!]! (type)
        if (this.AllSnapshotGroupBys != null) {
            var fspec = this.AllSnapshotGroupBys.AsFieldSpec(conf.Child("allSnapshotGroupBys"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allSnapshotGroupBys {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MosaicSnapshotConnection? Snapshots
        // GraphQL -> snapshots: MosaicSnapshotConnection! (type)
        if (this.Snapshots != null) {
            var fspec = this.Snapshots.AsFieldSpec(conf.Child("snapshots"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshots {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MosaicSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: MosaicSnapshotGroupByInfo! (union)
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
        //      C# -> List<MosaicSnapshotGroupByType>? AllSnapshotGroupBys
        // GraphQL -> allSnapshotGroupBys: [MosaicSnapshotGroupByType!]! (type)
        if (ec.Includes("allSnapshotGroupBys",false))
        {
            if(this.AllSnapshotGroupBys == null) {

                this.AllSnapshotGroupBys = new List<MosaicSnapshotGroupByType>();
                this.AllSnapshotGroupBys.ApplyExploratoryFieldSpec(ec.NewChild("allSnapshotGroupBys"));

            } else {

                this.AllSnapshotGroupBys.ApplyExploratoryFieldSpec(ec.NewChild("allSnapshotGroupBys"));

            }
        }
        else if (this.AllSnapshotGroupBys != null && ec.Excludes("allSnapshotGroupBys",false))
        {
            this.AllSnapshotGroupBys = null;
        }
        //      C# -> MosaicSnapshotConnection? Snapshots
        // GraphQL -> snapshots: MosaicSnapshotConnection! (type)
        if (ec.Includes("snapshots",false))
        {
            if(this.Snapshots == null) {

                this.Snapshots = new MosaicSnapshotConnection();
                this.Snapshots.ApplyExploratoryFieldSpec(ec.NewChild("snapshots"));

            } else {

                this.Snapshots.ApplyExploratoryFieldSpec(ec.NewChild("snapshots"));

            }
        }
        else if (this.Snapshots != null && ec.Excludes("snapshots",false))
        {
            this.Snapshots = null;
        }
        //      C# -> MosaicSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: MosaicSnapshotGroupByInfo! (union)
        if (ec.Includes("groupByInfo",false))
        {
            if(this.GroupByInfo == null) {

                var impls = new List<MosaicSnapshotGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (MosaicSnapshotGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<MosaicSnapshotGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (MosaicSnapshotGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.GroupByInfo != null && ec.Excludes("groupByInfo",false))
        {
            this.GroupByInfo = null;
        }
    }


    #endregion

    } // class MosaicSnapshotGroupByType
    
    #endregion

    public static class ListMosaicSnapshotGroupByTypeExtensions
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
            this List<MosaicSnapshotGroupByType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MosaicSnapshotGroupByType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MosaicSnapshotGroupByType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MosaicSnapshotGroupByType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types