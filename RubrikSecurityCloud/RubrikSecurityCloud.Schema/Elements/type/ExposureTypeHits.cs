// ExposureTypeHits.cs
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
    #region ExposureTypeHits
    public class ExposureTypeHits: BaseType
    {
        #region members

        //      C# -> ExposureType? Type
        // GraphQL -> type: ExposureType! (enum)
        [JsonProperty("type")]
        public ExposureType? Type { get; set; }

        //      C# -> SensitiveFiles? DeltaHits
        // GraphQL -> deltaHits: SensitiveFiles (type)
        [JsonProperty("deltaHits")]
        public SensitiveFiles? DeltaHits { get; set; }

        //      C# -> SensitiveHits? Hits
        // GraphQL -> hits: SensitiveHits (type)
        [JsonProperty("hits")]
        public SensitiveHits? Hits { get; set; }

        //      C# -> List<PolicySummaryDetails>? PolicySummaryDetails
        // GraphQL -> policySummaryDetails: [PolicySummaryDetails!]! (type)
        [JsonProperty("policySummaryDetails")]
        public List<PolicySummaryDetails>? PolicySummaryDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ExposureTypeHits";
    }

    public ExposureTypeHits Set(
        ExposureType? Type = null,
        SensitiveFiles? DeltaHits = null,
        SensitiveHits? Hits = null,
        List<PolicySummaryDetails>? PolicySummaryDetails = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( DeltaHits != null ) {
            this.DeltaHits = DeltaHits;
        }
        if ( Hits != null ) {
            this.Hits = Hits;
        }
        if ( PolicySummaryDetails != null ) {
            this.PolicySummaryDetails = PolicySummaryDetails;
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
        //      C# -> ExposureType? Type
        // GraphQL -> type: ExposureType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> SensitiveFiles? DeltaHits
        // GraphQL -> deltaHits: SensitiveFiles (type)
        if (this.DeltaHits != null) {
            var fspec = this.DeltaHits.AsFieldSpec(conf.Child("deltaHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "deltaHits" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> List<PolicySummaryDetails>? PolicySummaryDetails
        // GraphQL -> policySummaryDetails: [PolicySummaryDetails!]! (type)
        if (this.PolicySummaryDetails != null) {
            var fspec = this.PolicySummaryDetails.AsFieldSpec(conf.Child("policySummaryDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "policySummaryDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ExposureType? Type
        // GraphQL -> type: ExposureType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new ExposureType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> SensitiveFiles? DeltaHits
        // GraphQL -> deltaHits: SensitiveFiles (type)
        if (ec.Includes("deltaHits",false))
        {
            if(this.DeltaHits == null) {

                this.DeltaHits = new SensitiveFiles();
                this.DeltaHits.ApplyExploratoryFieldSpec(ec.NewChild("deltaHits"));

            } else {

                this.DeltaHits.ApplyExploratoryFieldSpec(ec.NewChild("deltaHits"));

            }
        }
        else if (this.DeltaHits != null && ec.Excludes("deltaHits",false))
        {
            this.DeltaHits = null;
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
        //      C# -> List<PolicySummaryDetails>? PolicySummaryDetails
        // GraphQL -> policySummaryDetails: [PolicySummaryDetails!]! (type)
        if (ec.Includes("policySummaryDetails",false))
        {
            if(this.PolicySummaryDetails == null) {

                this.PolicySummaryDetails = new List<PolicySummaryDetails>();
                this.PolicySummaryDetails.ApplyExploratoryFieldSpec(ec.NewChild("policySummaryDetails"));

            } else {

                this.PolicySummaryDetails.ApplyExploratoryFieldSpec(ec.NewChild("policySummaryDetails"));

            }
        }
        else if (this.PolicySummaryDetails != null && ec.Excludes("policySummaryDetails",false))
        {
            this.PolicySummaryDetails = null;
        }
    }


    #endregion

    } // class ExposureTypeHits
    
    #endregion

    public static class ListExposureTypeHitsExtensions
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
            this List<ExposureTypeHits> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ExposureTypeHits> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ExposureTypeHits> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ExposureTypeHits());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ExposureTypeHits> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types