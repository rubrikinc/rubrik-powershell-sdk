// ThreatHuntInfoForObjectResponse.cs
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
    #region ThreatHuntInfoForObjectResponse
    public class ThreatHuntInfoForObjectResponse: BaseType
    {
        #region members

        //      C# -> ThreatHuntInfoForObject? LatestMaliciousThreatHunt
        // GraphQL -> latestMaliciousThreatHunt: ThreatHuntInfoForObject (type)
        [JsonProperty("latestMaliciousThreatHunt")]
        public ThreatHuntInfoForObject? LatestMaliciousThreatHunt { get; set; }

        //      C# -> ThreatHuntInfoForObject? LatestScannedThreatHunt
        // GraphQL -> latestScannedThreatHunt: ThreatHuntInfoForObject (type)
        [JsonProperty("latestScannedThreatHunt")]
        public ThreatHuntInfoForObject? LatestScannedThreatHunt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatHuntInfoForObjectResponse";
    }

    public ThreatHuntInfoForObjectResponse Set(
        ThreatHuntInfoForObject? LatestMaliciousThreatHunt = null,
        ThreatHuntInfoForObject? LatestScannedThreatHunt = null
    ) 
    {
        if ( LatestMaliciousThreatHunt != null ) {
            this.LatestMaliciousThreatHunt = LatestMaliciousThreatHunt;
        }
        if ( LatestScannedThreatHunt != null ) {
            this.LatestScannedThreatHunt = LatestScannedThreatHunt;
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
        //      C# -> ThreatHuntInfoForObject? LatestMaliciousThreatHunt
        // GraphQL -> latestMaliciousThreatHunt: ThreatHuntInfoForObject (type)
        if (this.LatestMaliciousThreatHunt != null) {
            var fspec = this.LatestMaliciousThreatHunt.AsFieldSpec(conf.Child("latestMaliciousThreatHunt"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "latestMaliciousThreatHunt" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ThreatHuntInfoForObject? LatestScannedThreatHunt
        // GraphQL -> latestScannedThreatHunt: ThreatHuntInfoForObject (type)
        if (this.LatestScannedThreatHunt != null) {
            var fspec = this.LatestScannedThreatHunt.AsFieldSpec(conf.Child("latestScannedThreatHunt"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "latestScannedThreatHunt" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ThreatHuntInfoForObject? LatestMaliciousThreatHunt
        // GraphQL -> latestMaliciousThreatHunt: ThreatHuntInfoForObject (type)
        if (ec.Includes("latestMaliciousThreatHunt",false))
        {
            if(this.LatestMaliciousThreatHunt == null) {

                this.LatestMaliciousThreatHunt = new ThreatHuntInfoForObject();
                this.LatestMaliciousThreatHunt.ApplyExploratoryFieldSpec(ec.NewChild("latestMaliciousThreatHunt"));

            } else {

                this.LatestMaliciousThreatHunt.ApplyExploratoryFieldSpec(ec.NewChild("latestMaliciousThreatHunt"));

            }
        }
        else if (this.LatestMaliciousThreatHunt != null && ec.Excludes("latestMaliciousThreatHunt",false))
        {
            this.LatestMaliciousThreatHunt = null;
        }
        //      C# -> ThreatHuntInfoForObject? LatestScannedThreatHunt
        // GraphQL -> latestScannedThreatHunt: ThreatHuntInfoForObject (type)
        if (ec.Includes("latestScannedThreatHunt",false))
        {
            if(this.LatestScannedThreatHunt == null) {

                this.LatestScannedThreatHunt = new ThreatHuntInfoForObject();
                this.LatestScannedThreatHunt.ApplyExploratoryFieldSpec(ec.NewChild("latestScannedThreatHunt"));

            } else {

                this.LatestScannedThreatHunt.ApplyExploratoryFieldSpec(ec.NewChild("latestScannedThreatHunt"));

            }
        }
        else if (this.LatestScannedThreatHunt != null && ec.Excludes("latestScannedThreatHunt",false))
        {
            this.LatestScannedThreatHunt = null;
        }
    }


    #endregion

    } // class ThreatHuntInfoForObjectResponse
    
    #endregion

    public static class ListThreatHuntInfoForObjectResponseExtensions
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
            this List<ThreatHuntInfoForObjectResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatHuntInfoForObjectResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHuntInfoForObjectResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntInfoForObjectResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatHuntInfoForObjectResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types