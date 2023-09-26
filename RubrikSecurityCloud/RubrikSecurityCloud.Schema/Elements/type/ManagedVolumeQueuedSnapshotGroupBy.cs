// ManagedVolumeQueuedSnapshotGroupBy.cs
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
    #region ManagedVolumeQueuedSnapshotGroupBy
    public class ManagedVolumeQueuedSnapshotGroupBy: BaseType
    {
        #region members

        //      C# -> ManagedVolumeQueuedSnapshotConnection? ManagedVolumeQueuedSnapshotConnection
        // GraphQL -> managedVolumeQueuedSnapshotConnection: ManagedVolumeQueuedSnapshotConnection! (type)
        [JsonProperty("managedVolumeQueuedSnapshotConnection")]
        public ManagedVolumeQueuedSnapshotConnection? ManagedVolumeQueuedSnapshotConnection { get; set; }

        //      C# -> List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField
        // GraphQL -> managedVolumeQueuedSnapshotGroupBy: [ManagedVolumeQueuedSnapshotGroupBy!]! (type)
        [JsonProperty("managedVolumeQueuedSnapshotGroupBy")]
        public List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField { get; set; }

        //      C# -> ManagedVolumeQueuedSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ManagedVolumeQueuedSnapshotGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public ManagedVolumeQueuedSnapshotGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManagedVolumeQueuedSnapshotGroupBy";
    }

    public ManagedVolumeQueuedSnapshotGroupBy Set(
        ManagedVolumeQueuedSnapshotConnection? ManagedVolumeQueuedSnapshotConnection = null,
        List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField = null,
        ManagedVolumeQueuedSnapshotGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( ManagedVolumeQueuedSnapshotConnection != null ) {
            this.ManagedVolumeQueuedSnapshotConnection = ManagedVolumeQueuedSnapshotConnection;
        }
        if ( ManagedVolumeQueuedSnapshotGroupByField != null ) {
            this.ManagedVolumeQueuedSnapshotGroupByField = ManagedVolumeQueuedSnapshotGroupByField;
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
        //      C# -> ManagedVolumeQueuedSnapshotConnection? ManagedVolumeQueuedSnapshotConnection
        // GraphQL -> managedVolumeQueuedSnapshotConnection: ManagedVolumeQueuedSnapshotConnection! (type)
        if (this.ManagedVolumeQueuedSnapshotConnection != null) {
            var fspec = this.ManagedVolumeQueuedSnapshotConnection.AsFieldSpec(conf.Child("managedVolumeQueuedSnapshotConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "managedVolumeQueuedSnapshotConnection {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField
        // GraphQL -> managedVolumeQueuedSnapshotGroupBy: [ManagedVolumeQueuedSnapshotGroupBy!]! (type)
        if (this.ManagedVolumeQueuedSnapshotGroupByField != null) {
            var fspec = this.ManagedVolumeQueuedSnapshotGroupByField.AsFieldSpec(conf.Child("managedVolumeQueuedSnapshotGroupBy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "managedVolumeQueuedSnapshotGroupBy {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ManagedVolumeQueuedSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ManagedVolumeQueuedSnapshotGroupByInfo! (union)
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
        //      C# -> ManagedVolumeQueuedSnapshotConnection? ManagedVolumeQueuedSnapshotConnection
        // GraphQL -> managedVolumeQueuedSnapshotConnection: ManagedVolumeQueuedSnapshotConnection! (type)
        if (ec.Includes("managedVolumeQueuedSnapshotConnection",false))
        {
            if(this.ManagedVolumeQueuedSnapshotConnection == null) {

                this.ManagedVolumeQueuedSnapshotConnection = new ManagedVolumeQueuedSnapshotConnection();
                this.ManagedVolumeQueuedSnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumeQueuedSnapshotConnection"));

            } else {

                this.ManagedVolumeQueuedSnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumeQueuedSnapshotConnection"));

            }
        }
        else if (this.ManagedVolumeQueuedSnapshotConnection != null && ec.Excludes("managedVolumeQueuedSnapshotConnection",false))
        {
            this.ManagedVolumeQueuedSnapshotConnection = null;
        }
        //      C# -> List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField
        // GraphQL -> managedVolumeQueuedSnapshotGroupBy: [ManagedVolumeQueuedSnapshotGroupBy!]! (type)
        if (ec.Includes("managedVolumeQueuedSnapshotGroupBy",false))
        {
            if(this.ManagedVolumeQueuedSnapshotGroupByField == null) {

                this.ManagedVolumeQueuedSnapshotGroupByField = new List<ManagedVolumeQueuedSnapshotGroupBy>();
                this.ManagedVolumeQueuedSnapshotGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumeQueuedSnapshotGroupBy"));

            } else {

                this.ManagedVolumeQueuedSnapshotGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumeQueuedSnapshotGroupBy"));

            }
        }
        else if (this.ManagedVolumeQueuedSnapshotGroupByField != null && ec.Excludes("managedVolumeQueuedSnapshotGroupBy",false))
        {
            this.ManagedVolumeQueuedSnapshotGroupByField = null;
        }
        //      C# -> ManagedVolumeQueuedSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ManagedVolumeQueuedSnapshotGroupByInfo! (union)
        if (ec.Includes("groupByInfo",false))
        {
            if(this.GroupByInfo == null) {

                var impls = new List<ManagedVolumeQueuedSnapshotGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (ManagedVolumeQueuedSnapshotGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<ManagedVolumeQueuedSnapshotGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (ManagedVolumeQueuedSnapshotGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.GroupByInfo != null && ec.Excludes("groupByInfo",false))
        {
            this.GroupByInfo = null;
        }
    }


    #endregion

    } // class ManagedVolumeQueuedSnapshotGroupBy
    
    #endregion

    public static class ListManagedVolumeQueuedSnapshotGroupByExtensions
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
            this List<ManagedVolumeQueuedSnapshotGroupBy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeQueuedSnapshotGroupBy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeQueuedSnapshotGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManagedVolumeQueuedSnapshotGroupBy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types