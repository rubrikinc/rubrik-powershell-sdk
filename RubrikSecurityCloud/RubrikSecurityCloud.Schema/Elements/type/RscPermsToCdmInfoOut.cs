// RscPermsToCdmInfoOut.cs
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
    #region RscPermsToCdmInfoOut
    public class RscPermsToCdmInfoOut: BaseType
    {
        #region members

        //      C# -> SyncedClusterConnection? IncompatibleClusters
        // GraphQL -> incompatibleClusters: SyncedClusterConnection! (type)
        [JsonProperty("incompatibleClusters")]
        public SyncedClusterConnection? IncompatibleClusters { get; set; }

        //      C# -> SyncedClusterConnection? RemovedClusters
        // GraphQL -> removedClusters: SyncedClusterConnection! (type)
        [JsonProperty("removedClusters")]
        public SyncedClusterConnection? RemovedClusters { get; set; }

        //      C# -> SyncedClusterConnection? SyncedClusters
        // GraphQL -> syncedClusters: SyncedClusterConnection! (type)
        [JsonProperty("syncedClusters")]
        public SyncedClusterConnection? SyncedClusters { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RscPermsToCdmInfoOut";
    }

    public RscPermsToCdmInfoOut Set(
        SyncedClusterConnection? IncompatibleClusters = null,
        SyncedClusterConnection? RemovedClusters = null,
        SyncedClusterConnection? SyncedClusters = null
    ) 
    {
        if ( IncompatibleClusters != null ) {
            this.IncompatibleClusters = IncompatibleClusters;
        }
        if ( RemovedClusters != null ) {
            this.RemovedClusters = RemovedClusters;
        }
        if ( SyncedClusters != null ) {
            this.SyncedClusters = SyncedClusters;
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
        //      C# -> SyncedClusterConnection? IncompatibleClusters
        // GraphQL -> incompatibleClusters: SyncedClusterConnection! (type)
        if (this.IncompatibleClusters != null) {
            var fspec = this.IncompatibleClusters.AsFieldSpec(conf.Child("incompatibleClusters"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "incompatibleClusters" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SyncedClusterConnection? RemovedClusters
        // GraphQL -> removedClusters: SyncedClusterConnection! (type)
        if (this.RemovedClusters != null) {
            var fspec = this.RemovedClusters.AsFieldSpec(conf.Child("removedClusters"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "removedClusters" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SyncedClusterConnection? SyncedClusters
        // GraphQL -> syncedClusters: SyncedClusterConnection! (type)
        if (this.SyncedClusters != null) {
            var fspec = this.SyncedClusters.AsFieldSpec(conf.Child("syncedClusters"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "syncedClusters" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SyncedClusterConnection? IncompatibleClusters
        // GraphQL -> incompatibleClusters: SyncedClusterConnection! (type)
        if (ec.Includes("incompatibleClusters",false))
        {
            if(this.IncompatibleClusters == null) {

                this.IncompatibleClusters = new SyncedClusterConnection();
                this.IncompatibleClusters.ApplyExploratoryFieldSpec(ec.NewChild("incompatibleClusters"));

            } else {

                this.IncompatibleClusters.ApplyExploratoryFieldSpec(ec.NewChild("incompatibleClusters"));

            }
        }
        else if (this.IncompatibleClusters != null && ec.Excludes("incompatibleClusters",false))
        {
            this.IncompatibleClusters = null;
        }
        //      C# -> SyncedClusterConnection? RemovedClusters
        // GraphQL -> removedClusters: SyncedClusterConnection! (type)
        if (ec.Includes("removedClusters",false))
        {
            if(this.RemovedClusters == null) {

                this.RemovedClusters = new SyncedClusterConnection();
                this.RemovedClusters.ApplyExploratoryFieldSpec(ec.NewChild("removedClusters"));

            } else {

                this.RemovedClusters.ApplyExploratoryFieldSpec(ec.NewChild("removedClusters"));

            }
        }
        else if (this.RemovedClusters != null && ec.Excludes("removedClusters",false))
        {
            this.RemovedClusters = null;
        }
        //      C# -> SyncedClusterConnection? SyncedClusters
        // GraphQL -> syncedClusters: SyncedClusterConnection! (type)
        if (ec.Includes("syncedClusters",false))
        {
            if(this.SyncedClusters == null) {

                this.SyncedClusters = new SyncedClusterConnection();
                this.SyncedClusters.ApplyExploratoryFieldSpec(ec.NewChild("syncedClusters"));

            } else {

                this.SyncedClusters.ApplyExploratoryFieldSpec(ec.NewChild("syncedClusters"));

            }
        }
        else if (this.SyncedClusters != null && ec.Excludes("syncedClusters",false))
        {
            this.SyncedClusters = null;
        }
    }


    #endregion

    } // class RscPermsToCdmInfoOut
    
    #endregion

    public static class ListRscPermsToCdmInfoOutExtensions
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
            this List<RscPermsToCdmInfoOut> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RscPermsToCdmInfoOut> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RscPermsToCdmInfoOut> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RscPermsToCdmInfoOut());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RscPermsToCdmInfoOut> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types