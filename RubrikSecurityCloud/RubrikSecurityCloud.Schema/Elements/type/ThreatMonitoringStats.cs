// ThreatMonitoringStats.cs
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
    #region ThreatMonitoringStats
    public class ThreatMonitoringStats: BaseType
    {
        #region members

        //      C# -> System.Int64? ObjectsWithMatches
        // GraphQL -> objectsWithMatches: Long! (scalar)
        [JsonProperty("objectsWithMatches")]
        public System.Int64? ObjectsWithMatches { get; set; }

        //      C# -> System.Int64? ObjectsWithNoMatches
        // GraphQL -> objectsWithNoMatches: Long! (scalar)
        [JsonProperty("objectsWithNoMatches")]
        public System.Int64? ObjectsWithNoMatches { get; set; }

        //      C# -> System.Int64? TotalObjectsScanned
        // GraphQL -> totalObjectsScanned: Long! (scalar)
        [JsonProperty("totalObjectsScanned")]
        public System.Int64? TotalObjectsScanned { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatMonitoringStats";
    }

    public ThreatMonitoringStats Set(
        System.Int64? ObjectsWithMatches = null,
        System.Int64? ObjectsWithNoMatches = null,
        System.Int64? TotalObjectsScanned = null
    ) 
    {
        if ( ObjectsWithMatches != null ) {
            this.ObjectsWithMatches = ObjectsWithMatches;
        }
        if ( ObjectsWithNoMatches != null ) {
            this.ObjectsWithNoMatches = ObjectsWithNoMatches;
        }
        if ( TotalObjectsScanned != null ) {
            this.TotalObjectsScanned = TotalObjectsScanned;
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
        //      C# -> System.Int64? ObjectsWithMatches
        // GraphQL -> objectsWithMatches: Long! (scalar)
        if (this.ObjectsWithMatches != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectsWithMatches\n" ;
            } else {
                s += ind + "objectsWithMatches\n" ;
            }
        }
        //      C# -> System.Int64? ObjectsWithNoMatches
        // GraphQL -> objectsWithNoMatches: Long! (scalar)
        if (this.ObjectsWithNoMatches != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectsWithNoMatches\n" ;
            } else {
                s += ind + "objectsWithNoMatches\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? ObjectsWithMatches
        // GraphQL -> objectsWithMatches: Long! (scalar)
        if (ec.Includes("objectsWithMatches",true))
        {
            if(this.ObjectsWithMatches == null) {

                this.ObjectsWithMatches = new System.Int64();

            } else {


            }
        }
        else if (this.ObjectsWithMatches != null && ec.Excludes("objectsWithMatches",true))
        {
            this.ObjectsWithMatches = null;
        }
        //      C# -> System.Int64? ObjectsWithNoMatches
        // GraphQL -> objectsWithNoMatches: Long! (scalar)
        if (ec.Includes("objectsWithNoMatches",true))
        {
            if(this.ObjectsWithNoMatches == null) {

                this.ObjectsWithNoMatches = new System.Int64();

            } else {


            }
        }
        else if (this.ObjectsWithNoMatches != null && ec.Excludes("objectsWithNoMatches",true))
        {
            this.ObjectsWithNoMatches = null;
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
    }


    #endregion

    } // class ThreatMonitoringStats
    
    #endregion

    public static class ListThreatMonitoringStatsExtensions
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
            this List<ThreatMonitoringStats> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatMonitoringStats> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatMonitoringStats> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatMonitoringStats());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatMonitoringStats> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types