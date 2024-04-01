// ThreatHuntStats.cs
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
    #region ThreatHuntStats
    public class ThreatHuntStats: BaseType
    {
        #region members

        //      C# -> System.Int64? TotalAffectedObjects
        // GraphQL -> totalAffectedObjects: Long! (scalar)
        [JsonProperty("totalAffectedObjects")]
        public System.Int64? TotalAffectedObjects { get; set; }

        //      C# -> System.Int64? TotalAffectedSnapshots
        // GraphQL -> totalAffectedSnapshots: Long! (scalar)
        [JsonProperty("totalAffectedSnapshots")]
        public System.Int64? TotalAffectedSnapshots { get; set; }

        //      C# -> System.Int64? TotalObjectsScanned
        // GraphQL -> totalObjectsScanned: Long! (scalar)
        [JsonProperty("totalObjectsScanned")]
        public System.Int64? TotalObjectsScanned { get; set; }

        //      C# -> System.Int64? TotalSnapshotsScanned
        // GraphQL -> totalSnapshotsScanned: Long! (scalar)
        [JsonProperty("totalSnapshotsScanned")]
        public System.Int64? TotalSnapshotsScanned { get; set; }

        //      C# -> System.Int64? TotalSucceededScans
        // GraphQL -> totalSucceededScans: Long! (scalar)
        [JsonProperty("totalSucceededScans")]
        public System.Int64? TotalSucceededScans { get; set; }

        //      C# -> System.Int64? TotalUniqueMatchedPaths
        // GraphQL -> totalUniqueMatchedPaths: Long! (scalar)
        [JsonProperty("totalUniqueMatchedPaths")]
        public System.Int64? TotalUniqueMatchedPaths { get; set; }

        //      C# -> System.Int64? TotalUniqueQuarantinedPaths
        // GraphQL -> totalUniqueQuarantinedPaths: Long! (scalar)
        [JsonProperty("totalUniqueQuarantinedPaths")]
        public System.Int64? TotalUniqueQuarantinedPaths { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatHuntStats";
    }

    public ThreatHuntStats Set(
        System.Int64? TotalAffectedObjects = null,
        System.Int64? TotalAffectedSnapshots = null,
        System.Int64? TotalObjectsScanned = null,
        System.Int64? TotalSnapshotsScanned = null,
        System.Int64? TotalSucceededScans = null,
        System.Int64? TotalUniqueMatchedPaths = null,
        System.Int64? TotalUniqueQuarantinedPaths = null
    ) 
    {
        if ( TotalAffectedObjects != null ) {
            this.TotalAffectedObjects = TotalAffectedObjects;
        }
        if ( TotalAffectedSnapshots != null ) {
            this.TotalAffectedSnapshots = TotalAffectedSnapshots;
        }
        if ( TotalObjectsScanned != null ) {
            this.TotalObjectsScanned = TotalObjectsScanned;
        }
        if ( TotalSnapshotsScanned != null ) {
            this.TotalSnapshotsScanned = TotalSnapshotsScanned;
        }
        if ( TotalSucceededScans != null ) {
            this.TotalSucceededScans = TotalSucceededScans;
        }
        if ( TotalUniqueMatchedPaths != null ) {
            this.TotalUniqueMatchedPaths = TotalUniqueMatchedPaths;
        }
        if ( TotalUniqueQuarantinedPaths != null ) {
            this.TotalUniqueQuarantinedPaths = TotalUniqueQuarantinedPaths;
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
        //      C# -> System.Int64? TotalAffectedObjects
        // GraphQL -> totalAffectedObjects: Long! (scalar)
        if (this.TotalAffectedObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalAffectedObjects\n" ;
            } else {
                s += ind + "totalAffectedObjects\n" ;
            }
        }
        //      C# -> System.Int64? TotalAffectedSnapshots
        // GraphQL -> totalAffectedSnapshots: Long! (scalar)
        if (this.TotalAffectedSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalAffectedSnapshots\n" ;
            } else {
                s += ind + "totalAffectedSnapshots\n" ;
            }
        }
        //      C# -> System.Int64? TotalObjectsScanned
        // GraphQL -> totalObjectsScanned: Long! (scalar)
        if (this.TotalObjectsScanned != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalObjectsScanned\n" ;
            } else {
                s += ind + "totalObjectsScanned\n" ;
            }
        }
        //      C# -> System.Int64? TotalSnapshotsScanned
        // GraphQL -> totalSnapshotsScanned: Long! (scalar)
        if (this.TotalSnapshotsScanned != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalSnapshotsScanned\n" ;
            } else {
                s += ind + "totalSnapshotsScanned\n" ;
            }
        }
        //      C# -> System.Int64? TotalSucceededScans
        // GraphQL -> totalSucceededScans: Long! (scalar)
        if (this.TotalSucceededScans != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalSucceededScans\n" ;
            } else {
                s += ind + "totalSucceededScans\n" ;
            }
        }
        //      C# -> System.Int64? TotalUniqueMatchedPaths
        // GraphQL -> totalUniqueMatchedPaths: Long! (scalar)
        if (this.TotalUniqueMatchedPaths != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalUniqueMatchedPaths\n" ;
            } else {
                s += ind + "totalUniqueMatchedPaths\n" ;
            }
        }
        //      C# -> System.Int64? TotalUniqueQuarantinedPaths
        // GraphQL -> totalUniqueQuarantinedPaths: Long! (scalar)
        if (this.TotalUniqueQuarantinedPaths != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalUniqueQuarantinedPaths\n" ;
            } else {
                s += ind + "totalUniqueQuarantinedPaths\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? TotalAffectedObjects
        // GraphQL -> totalAffectedObjects: Long! (scalar)
        if (ec.Includes("totalAffectedObjects",true))
        {
            if(this.TotalAffectedObjects == null) {

                this.TotalAffectedObjects = new System.Int64();

            } else {


            }
        }
        else if (this.TotalAffectedObjects != null && ec.Excludes("totalAffectedObjects",true))
        {
            this.TotalAffectedObjects = null;
        }
        //      C# -> System.Int64? TotalAffectedSnapshots
        // GraphQL -> totalAffectedSnapshots: Long! (scalar)
        if (ec.Includes("totalAffectedSnapshots",true))
        {
            if(this.TotalAffectedSnapshots == null) {

                this.TotalAffectedSnapshots = new System.Int64();

            } else {


            }
        }
        else if (this.TotalAffectedSnapshots != null && ec.Excludes("totalAffectedSnapshots",true))
        {
            this.TotalAffectedSnapshots = null;
        }
        //      C# -> System.Int64? TotalObjectsScanned
        // GraphQL -> totalObjectsScanned: Long! (scalar)
        if (ec.Includes("totalObjectsScanned",true))
        {
            if(this.TotalObjectsScanned == null) {

                this.TotalObjectsScanned = new System.Int64();

            } else {


            }
        }
        else if (this.TotalObjectsScanned != null && ec.Excludes("totalObjectsScanned",true))
        {
            this.TotalObjectsScanned = null;
        }
        //      C# -> System.Int64? TotalSnapshotsScanned
        // GraphQL -> totalSnapshotsScanned: Long! (scalar)
        if (ec.Includes("totalSnapshotsScanned",true))
        {
            if(this.TotalSnapshotsScanned == null) {

                this.TotalSnapshotsScanned = new System.Int64();

            } else {


            }
        }
        else if (this.TotalSnapshotsScanned != null && ec.Excludes("totalSnapshotsScanned",true))
        {
            this.TotalSnapshotsScanned = null;
        }
        //      C# -> System.Int64? TotalSucceededScans
        // GraphQL -> totalSucceededScans: Long! (scalar)
        if (ec.Includes("totalSucceededScans",true))
        {
            if(this.TotalSucceededScans == null) {

                this.TotalSucceededScans = new System.Int64();

            } else {


            }
        }
        else if (this.TotalSucceededScans != null && ec.Excludes("totalSucceededScans",true))
        {
            this.TotalSucceededScans = null;
        }
        //      C# -> System.Int64? TotalUniqueMatchedPaths
        // GraphQL -> totalUniqueMatchedPaths: Long! (scalar)
        if (ec.Includes("totalUniqueMatchedPaths",true))
        {
            if(this.TotalUniqueMatchedPaths == null) {

                this.TotalUniqueMatchedPaths = new System.Int64();

            } else {


            }
        }
        else if (this.TotalUniqueMatchedPaths != null && ec.Excludes("totalUniqueMatchedPaths",true))
        {
            this.TotalUniqueMatchedPaths = null;
        }
        //      C# -> System.Int64? TotalUniqueQuarantinedPaths
        // GraphQL -> totalUniqueQuarantinedPaths: Long! (scalar)
        if (ec.Includes("totalUniqueQuarantinedPaths",true))
        {
            if(this.TotalUniqueQuarantinedPaths == null) {

                this.TotalUniqueQuarantinedPaths = new System.Int64();

            } else {


            }
        }
        else if (this.TotalUniqueQuarantinedPaths != null && ec.Excludes("totalUniqueQuarantinedPaths",true))
        {
            this.TotalUniqueQuarantinedPaths = null;
        }
    }


    #endregion

    } // class ThreatHuntStats
    
    #endregion

    public static class ListThreatHuntStatsExtensions
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
            this List<ThreatHuntStats> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatHuntStats> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHuntStats> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntStats());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatHuntStats> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types