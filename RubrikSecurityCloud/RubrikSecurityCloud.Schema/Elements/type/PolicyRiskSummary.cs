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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        if (this.Risk != null) {
            if (conf.Flat) {
                s += conf.Prefix + "risk\n" ;
            } else {
                s += ind + "risk\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> SensitiveFiles? Files
        // GraphQL -> files: SensitiveFiles (type)
        if (this.Files != null) {
            var fspec = this.Files.AsFieldSpec(conf.Child("files"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "files" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveHits? Hits
        // GraphQL -> hits: SensitiveHits (type)
        if (this.Hits != null) {
            var fspec = this.Hits.AsFieldSpec(conf.Child("hits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        if (ec.Includes("risk",true))
        {
            if(this.Risk == null) {

                this.Risk = new RiskLevelType();

            } else {


            }
        }
        else if (this.Risk != null && ec.Excludes("risk",true))
        {
            this.Risk = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> SensitiveFiles? Files
        // GraphQL -> files: SensitiveFiles (type)
        if (ec.Includes("files",false))
        {
            if(this.Files == null) {

                this.Files = new SensitiveFiles();
                this.Files.ApplyExploratoryFieldSpec(ec.NewChild("files"));

            } else {

                this.Files.ApplyExploratoryFieldSpec(ec.NewChild("files"));

            }
        }
        else if (this.Files != null && ec.Excludes("files",false))
        {
            this.Files = null;
        }
        //      C# -> SensitiveHits? Hits
        // GraphQL -> hits: SensitiveHits (type)
        if (ec.Includes("hits",false))
        {
            if(this.Hits == null) {

                this.Hits = new SensitiveHits();
                this.Hits.ApplyExploratoryFieldSpec(ec.NewChild("hits"));

            } else {

                this.Hits.ApplyExploratoryFieldSpec(ec.NewChild("hits"));

            }
        }
        else if (this.Hits != null && ec.Excludes("hits",false))
        {
            this.Hits = null;
        }
    }


    #endregion

    } // class PolicyRiskSummary
    
    #endregion

    public static class ListPolicyRiskSummaryExtensions
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
            this List<PolicyRiskSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PolicyRiskSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<PolicyRiskSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types