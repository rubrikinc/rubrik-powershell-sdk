// ThreatHunt.cs
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
    #region ThreatHunt
    public class ThreatHunt: BaseType
    {
        #region members

        //      C# -> ThreatHuntStatus? Status
        // GraphQL -> status: ThreatHuntStatus! (enum)
        [JsonProperty("status")]
        public ThreatHuntStatus? Status { get; set; }

        //      C# -> System.String? HuntId
        // GraphQL -> huntId: String! (scalar)
        [JsonProperty("huntId")]
        public System.String? HuntId { get; set; }

        //      C# -> ThreatHuntDetails? HuntDetails
        // GraphQL -> huntDetails: ThreatHuntDetails! (type)
        [JsonProperty("huntDetails")]
        public ThreatHuntDetails? HuntDetails { get; set; }

        //      C# -> ThreatHuntStats? Stats
        // GraphQL -> stats: ThreatHuntStats (type)
        [JsonProperty("stats")]
        public ThreatHuntStats? Stats { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatHunt";
    }

    public ThreatHunt Set(
        ThreatHuntStatus? Status = null,
        System.String? HuntId = null,
        ThreatHuntDetails? HuntDetails = null,
        ThreatHuntStats? Stats = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( HuntId != null ) {
            this.HuntId = HuntId;
        }
        if ( HuntDetails != null ) {
            this.HuntDetails = HuntDetails;
        }
        if ( Stats != null ) {
            this.Stats = Stats;
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
        //      C# -> ThreatHuntStatus? Status
        // GraphQL -> status: ThreatHuntStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? HuntId
        // GraphQL -> huntId: String! (scalar)
        if (this.HuntId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "huntId\n" ;
            } else {
                s += ind + "huntId\n" ;
            }
        }
        //      C# -> ThreatHuntDetails? HuntDetails
        // GraphQL -> huntDetails: ThreatHuntDetails! (type)
        if (this.HuntDetails != null) {
            var fspec = this.HuntDetails.AsFieldSpec(conf.Child("huntDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "huntDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ThreatHuntStats? Stats
        // GraphQL -> stats: ThreatHuntStats (type)
        if (this.Stats != null) {
            var fspec = this.Stats.AsFieldSpec(conf.Child("stats"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "stats" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ThreatHuntStatus? Status
        // GraphQL -> status: ThreatHuntStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new ThreatHuntStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? HuntId
        // GraphQL -> huntId: String! (scalar)
        if (ec.Includes("huntId",true))
        {
            if(this.HuntId == null) {

                this.HuntId = "FETCH";

            } else {


            }
        }
        else if (this.HuntId != null && ec.Excludes("huntId",true))
        {
            this.HuntId = null;
        }
        //      C# -> ThreatHuntDetails? HuntDetails
        // GraphQL -> huntDetails: ThreatHuntDetails! (type)
        if (ec.Includes("huntDetails",false))
        {
            if(this.HuntDetails == null) {

                this.HuntDetails = new ThreatHuntDetails();
                this.HuntDetails.ApplyExploratoryFieldSpec(ec.NewChild("huntDetails"));

            } else {

                this.HuntDetails.ApplyExploratoryFieldSpec(ec.NewChild("huntDetails"));

            }
        }
        else if (this.HuntDetails != null && ec.Excludes("huntDetails",false))
        {
            this.HuntDetails = null;
        }
        //      C# -> ThreatHuntStats? Stats
        // GraphQL -> stats: ThreatHuntStats (type)
        if (ec.Includes("stats",false))
        {
            if(this.Stats == null) {

                this.Stats = new ThreatHuntStats();
                this.Stats.ApplyExploratoryFieldSpec(ec.NewChild("stats"));

            } else {

                this.Stats.ApplyExploratoryFieldSpec(ec.NewChild("stats"));

            }
        }
        else if (this.Stats != null && ec.Excludes("stats",false))
        {
            this.Stats = null;
        }
    }


    #endregion

    } // class ThreatHunt
    
    #endregion

    public static class ListThreatHuntExtensions
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
            this List<ThreatHunt> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatHunt> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHunt> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHunt());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatHunt> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types