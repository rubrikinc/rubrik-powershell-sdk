// ThreatHuntSummaryReply.cs
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
    #region ThreatHuntSummaryReply
    public class ThreatHuntSummaryReply: BaseType
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

        //      C# -> ThreatHuntConfig? Config
        // GraphQL -> config: ThreatHuntConfig (type)
        [JsonProperty("config")]
        public ThreatHuntConfig? Config { get; set; }

        //      C# -> List<ThreatHuntResultObjectsSummary>? ObjectsSummary
        // GraphQL -> objectsSummary: [ThreatHuntResultObjectsSummary!]! (type)
        [JsonProperty("objectsSummary")]
        public List<ThreatHuntResultObjectsSummary>? ObjectsSummary { get; set; }

        //      C# -> ThreatHuntStats? Stats
        // GraphQL -> stats: ThreatHuntStats (type)
        [JsonProperty("stats")]
        public ThreatHuntStats? Stats { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatHuntSummaryReply";
    }

    public ThreatHuntSummaryReply Set(
        ThreatHuntStatus? Status = null,
        System.String? HuntId = null,
        ThreatHuntConfig? Config = null,
        List<ThreatHuntResultObjectsSummary>? ObjectsSummary = null,
        ThreatHuntStats? Stats = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( HuntId != null ) {
            this.HuntId = HuntId;
        }
        if ( Config != null ) {
            this.Config = Config;
        }
        if ( ObjectsSummary != null ) {
            this.ObjectsSummary = ObjectsSummary;
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
        //      C# -> ThreatHuntConfig? Config
        // GraphQL -> config: ThreatHuntConfig (type)
        if (this.Config != null) {
            var fspec = this.Config.AsFieldSpec(conf.Child("config"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "config {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ThreatHuntResultObjectsSummary>? ObjectsSummary
        // GraphQL -> objectsSummary: [ThreatHuntResultObjectsSummary!]! (type)
        if (this.ObjectsSummary != null) {
            var fspec = this.ObjectsSummary.AsFieldSpec(conf.Child("objectsSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectsSummary {\n" + fspec + ind + "}\n" ;
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
                    s += ind + "stats {\n" + fspec + ind + "}\n" ;
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
        //      C# -> ThreatHuntConfig? Config
        // GraphQL -> config: ThreatHuntConfig (type)
        if (ec.Includes("config",false))
        {
            if(this.Config == null) {

                this.Config = new ThreatHuntConfig();
                this.Config.ApplyExploratoryFieldSpec(ec.NewChild("config"));

            } else {

                this.Config.ApplyExploratoryFieldSpec(ec.NewChild("config"));

            }
        }
        else if (this.Config != null && ec.Excludes("config",false))
        {
            this.Config = null;
        }
        //      C# -> List<ThreatHuntResultObjectsSummary>? ObjectsSummary
        // GraphQL -> objectsSummary: [ThreatHuntResultObjectsSummary!]! (type)
        if (ec.Includes("objectsSummary",false))
        {
            if(this.ObjectsSummary == null) {

                this.ObjectsSummary = new List<ThreatHuntResultObjectsSummary>();
                this.ObjectsSummary.ApplyExploratoryFieldSpec(ec.NewChild("objectsSummary"));

            } else {

                this.ObjectsSummary.ApplyExploratoryFieldSpec(ec.NewChild("objectsSummary"));

            }
        }
        else if (this.ObjectsSummary != null && ec.Excludes("objectsSummary",false))
        {
            this.ObjectsSummary = null;
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

    } // class ThreatHuntSummaryReply
    
    #endregion

    public static class ListThreatHuntSummaryReplyExtensions
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
            this List<ThreatHuntSummaryReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ThreatHuntSummaryReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHuntSummaryReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntSummaryReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatHuntSummaryReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types