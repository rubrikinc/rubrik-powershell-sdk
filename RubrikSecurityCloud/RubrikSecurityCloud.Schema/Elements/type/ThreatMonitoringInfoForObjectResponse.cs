// ThreatMonitoringInfoForObjectResponse.cs
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
    #region ThreatMonitoringInfoForObjectResponse
    public class ThreatMonitoringInfoForObjectResponse: BaseType
    {
        #region members

        //      C# -> ThreatMonitoringInfoForObject? LatestMaliciousScan
        // GraphQL -> latestMaliciousScan: ThreatMonitoringInfoForObject (type)
        [JsonProperty("latestMaliciousScan")]
        public ThreatMonitoringInfoForObject? LatestMaliciousScan { get; set; }

        //      C# -> ThreatMonitoringInfoForObject? LatestThreatMonitoringScan
        // GraphQL -> latestThreatMonitoringScan: ThreatMonitoringInfoForObject (type)
        [JsonProperty("latestThreatMonitoringScan")]
        public ThreatMonitoringInfoForObject? LatestThreatMonitoringScan { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatMonitoringInfoForObjectResponse";
    }

    public ThreatMonitoringInfoForObjectResponse Set(
        ThreatMonitoringInfoForObject? LatestMaliciousScan = null,
        ThreatMonitoringInfoForObject? LatestThreatMonitoringScan = null
    ) 
    {
        if ( LatestMaliciousScan != null ) {
            this.LatestMaliciousScan = LatestMaliciousScan;
        }
        if ( LatestThreatMonitoringScan != null ) {
            this.LatestThreatMonitoringScan = LatestThreatMonitoringScan;
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
        //      C# -> ThreatMonitoringInfoForObject? LatestMaliciousScan
        // GraphQL -> latestMaliciousScan: ThreatMonitoringInfoForObject (type)
        if (this.LatestMaliciousScan != null) {
            var fspec = this.LatestMaliciousScan.AsFieldSpec(conf.Child("latestMaliciousScan"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "latestMaliciousScan" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ThreatMonitoringInfoForObject? LatestThreatMonitoringScan
        // GraphQL -> latestThreatMonitoringScan: ThreatMonitoringInfoForObject (type)
        if (this.LatestThreatMonitoringScan != null) {
            var fspec = this.LatestThreatMonitoringScan.AsFieldSpec(conf.Child("latestThreatMonitoringScan"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "latestThreatMonitoringScan" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ThreatMonitoringInfoForObject? LatestMaliciousScan
        // GraphQL -> latestMaliciousScan: ThreatMonitoringInfoForObject (type)
        if (ec.Includes("latestMaliciousScan",false))
        {
            if(this.LatestMaliciousScan == null) {

                this.LatestMaliciousScan = new ThreatMonitoringInfoForObject();
                this.LatestMaliciousScan.ApplyExploratoryFieldSpec(ec.NewChild("latestMaliciousScan"));

            } else {

                this.LatestMaliciousScan.ApplyExploratoryFieldSpec(ec.NewChild("latestMaliciousScan"));

            }
        }
        else if (this.LatestMaliciousScan != null && ec.Excludes("latestMaliciousScan",false))
        {
            this.LatestMaliciousScan = null;
        }
        //      C# -> ThreatMonitoringInfoForObject? LatestThreatMonitoringScan
        // GraphQL -> latestThreatMonitoringScan: ThreatMonitoringInfoForObject (type)
        if (ec.Includes("latestThreatMonitoringScan",false))
        {
            if(this.LatestThreatMonitoringScan == null) {

                this.LatestThreatMonitoringScan = new ThreatMonitoringInfoForObject();
                this.LatestThreatMonitoringScan.ApplyExploratoryFieldSpec(ec.NewChild("latestThreatMonitoringScan"));

            } else {

                this.LatestThreatMonitoringScan.ApplyExploratoryFieldSpec(ec.NewChild("latestThreatMonitoringScan"));

            }
        }
        else if (this.LatestThreatMonitoringScan != null && ec.Excludes("latestThreatMonitoringScan",false))
        {
            this.LatestThreatMonitoringScan = null;
        }
    }


    #endregion

    } // class ThreatMonitoringInfoForObjectResponse
    
    #endregion

    public static class ListThreatMonitoringInfoForObjectResponseExtensions
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
            this List<ThreatMonitoringInfoForObjectResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatMonitoringInfoForObjectResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatMonitoringInfoForObjectResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatMonitoringInfoForObjectResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatMonitoringInfoForObjectResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types