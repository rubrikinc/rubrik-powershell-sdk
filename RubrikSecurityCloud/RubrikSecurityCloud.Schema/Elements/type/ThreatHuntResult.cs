// ThreatHuntResult.cs
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
    #region ThreatHuntResult
    public class ThreatHuntResult: BaseType
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
        // GraphQL -> config: ThreatHuntConfig! (type)
        [JsonProperty("config")]
        public ThreatHuntConfig? Config { get; set; }

        //      C# -> List<MalwareScanResult>? Results
        // GraphQL -> results: [MalwareScanResult!]! (type)
        [JsonProperty("results")]
        public List<MalwareScanResult>? Results { get; set; }

        //      C# -> ThreatHuntStats? Stats
        // GraphQL -> stats: ThreatHuntStats (type)
        [JsonProperty("stats")]
        public ThreatHuntStats? Stats { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatHuntResult";
    }

    public ThreatHuntResult Set(
        ThreatHuntStatus? Status = null,
        System.String? HuntId = null,
        ThreatHuntConfig? Config = null,
        List<MalwareScanResult>? Results = null,
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
        if ( Results != null ) {
            this.Results = Results;
        }
        if ( Stats != null ) {
            this.Stats = Stats;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ThreatHuntStatus? Status
        // GraphQL -> status: ThreatHuntStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? HuntId
        // GraphQL -> huntId: String! (scalar)
        if (this.HuntId != null) {
            s += ind + "huntId\n" ;
        }
        //      C# -> ThreatHuntConfig? Config
        // GraphQL -> config: ThreatHuntConfig! (type)
        if (this.Config != null) {
            var fspec = this.Config.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "config {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<MalwareScanResult>? Results
        // GraphQL -> results: [MalwareScanResult!]! (type)
        if (this.Results != null) {
            var fspec = this.Results.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "results {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ThreatHuntStats? Stats
        // GraphQL -> stats: ThreatHuntStats (type)
        if (this.Stats != null) {
            var fspec = this.Stats.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "stats {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ThreatHuntStatus? Status
        // GraphQL -> status: ThreatHuntStatus! (enum)
        if (this.Status == null && ec.Includes("status",true))
        {
            this.Status = new ThreatHuntStatus();
        }
        //      C# -> System.String? HuntId
        // GraphQL -> huntId: String! (scalar)
        if (this.HuntId == null && ec.Includes("huntId",true))
        {
            this.HuntId = "FETCH";
        }
        //      C# -> ThreatHuntConfig? Config
        // GraphQL -> config: ThreatHuntConfig! (type)
        if (this.Config == null && ec.Includes("config",false))
        {
            this.Config = new ThreatHuntConfig();
            this.Config.ApplyExploratoryFieldSpec(ec.NewChild("config"));
        }
        //      C# -> List<MalwareScanResult>? Results
        // GraphQL -> results: [MalwareScanResult!]! (type)
        if (this.Results == null && ec.Includes("results",false))
        {
            this.Results = new List<MalwareScanResult>();
            this.Results.ApplyExploratoryFieldSpec(ec.NewChild("results"));
        }
        //      C# -> ThreatHuntStats? Stats
        // GraphQL -> stats: ThreatHuntStats (type)
        if (this.Stats == null && ec.Includes("stats",false))
        {
            this.Stats = new ThreatHuntStats();
            this.Stats.ApplyExploratoryFieldSpec(ec.NewChild("stats"));
        }
    }


    #endregion

    } // class ThreatHuntResult
    
    #endregion

    public static class ListThreatHuntResultExtensions
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
            this List<ThreatHuntResult> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHuntResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ThreatHuntResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types