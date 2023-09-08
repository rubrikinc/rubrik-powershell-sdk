// PolicyRiskSummary.cs
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
    #region PolicyRiskSummary
    public class PolicyRiskSummary: BaseType
    {
        #region members

        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        [JsonProperty("risk")]
        public RiskLevelType? Risk { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> SensitiveFiles? Files
        // GraphQL -> files: SensitiveFiles (type)
        [JsonProperty("files")]
        public SensitiveFiles? Files { get; set; }

        //      C# -> SensitiveHits? Hits
        // GraphQL -> hits: SensitiveHits (type)
        [JsonProperty("hits")]
        public SensitiveHits? Hits { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PolicyRiskSummary";
    }

    public PolicyRiskSummary Set(
        RiskLevelType? Risk = null,
        System.String? Id = null,
        SensitiveFiles? Files = null,
        SensitiveHits? Hits = null
    ) 
    {
        if ( Risk != null ) {
            this.Risk = Risk;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Files != null ) {
            this.Files = Files;
        }
        if ( Hits != null ) {
            this.Hits = Hits;
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
        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        if (this.Risk != null) {
            s += ind + "risk\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> SensitiveFiles? Files
        // GraphQL -> files: SensitiveFiles (type)
        if (this.Files != null) {
            var fspec = this.Files.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "files {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SensitiveHits? Hits
        // GraphQL -> hits: SensitiveHits (type)
        if (this.Hits != null) {
            var fspec = this.Hits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "hits {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        if (this.Risk == null && ec.Includes("risk",true))
        {
            this.Risk = new RiskLevelType();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> SensitiveFiles? Files
        // GraphQL -> files: SensitiveFiles (type)
        if (this.Files == null && ec.Includes("files",false))
        {
            this.Files = new SensitiveFiles();
            this.Files.ApplyExploratoryFieldSpec(ec.NewChild("files"));
        }
        //      C# -> SensitiveHits? Hits
        // GraphQL -> hits: SensitiveHits (type)
        if (this.Hits == null && ec.Includes("hits",false))
        {
            this.Hits = new SensitiveHits();
            this.Hits.ApplyExploratoryFieldSpec(ec.NewChild("hits"));
        }
    }


    #endregion

    } // class PolicyRiskSummary
    
    #endregion

    public static class ListPolicyRiskSummaryExtensions
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
            this List<PolicyRiskSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PolicyRiskSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolicyRiskSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<PolicyRiskSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types