// AutoQuarantineMetadataType.cs
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
    #region AutoQuarantineMetadataType
    public class AutoQuarantineMetadataType: BaseType
    {
        #region members

        //      C# -> System.Boolean? AutoQuarantine
        // GraphQL -> autoQuarantine: Boolean! (scalar)
        [JsonProperty("autoQuarantine")]
        public System.Boolean? AutoQuarantine { get; set; }

        //      C# -> ConfidenceScoreType? ConfidenceScore
        // GraphQL -> confidenceScore: ConfidenceScoreType (type)
        [JsonProperty("confidenceScore")]
        public ConfidenceScoreType? ConfidenceScore { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AutoQuarantineMetadataType";
    }

    public AutoQuarantineMetadataType Set(
        System.Boolean? AutoQuarantine = null,
        ConfidenceScoreType? ConfidenceScore = null
    ) 
    {
        if ( AutoQuarantine != null ) {
            this.AutoQuarantine = AutoQuarantine;
        }
        if ( ConfidenceScore != null ) {
            this.ConfidenceScore = ConfidenceScore;
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
        //      C# -> System.Boolean? AutoQuarantine
        // GraphQL -> autoQuarantine: Boolean! (scalar)
        if (this.AutoQuarantine != null) {
            if (conf.Flat) {
                s += conf.Prefix + "autoQuarantine\n" ;
            } else {
                s += ind + "autoQuarantine\n" ;
            }
        }
        //      C# -> ConfidenceScoreType? ConfidenceScore
        // GraphQL -> confidenceScore: ConfidenceScoreType (type)
        if (this.ConfidenceScore != null) {
            var fspec = this.ConfidenceScore.AsFieldSpec(conf.Child("confidenceScore"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "confidenceScore" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? AutoQuarantine
        // GraphQL -> autoQuarantine: Boolean! (scalar)
        if (ec.Includes("autoQuarantine",true))
        {
            if(this.AutoQuarantine == null) {

                this.AutoQuarantine = true;

            } else {


            }
        }
        else if (this.AutoQuarantine != null && ec.Excludes("autoQuarantine",true))
        {
            this.AutoQuarantine = null;
        }
        //      C# -> ConfidenceScoreType? ConfidenceScore
        // GraphQL -> confidenceScore: ConfidenceScoreType (type)
        if (ec.Includes("confidenceScore",false))
        {
            if(this.ConfidenceScore == null) {

                this.ConfidenceScore = new ConfidenceScoreType();
                this.ConfidenceScore.ApplyExploratoryFieldSpec(ec.NewChild("confidenceScore"));

            } else {

                this.ConfidenceScore.ApplyExploratoryFieldSpec(ec.NewChild("confidenceScore"));

            }
        }
        else if (this.ConfidenceScore != null && ec.Excludes("confidenceScore",false))
        {
            this.ConfidenceScore = null;
        }
    }


    #endregion

    } // class AutoQuarantineMetadataType
    
    #endregion

    public static class ListAutoQuarantineMetadataTypeExtensions
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
            this List<AutoQuarantineMetadataType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AutoQuarantineMetadataType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AutoQuarantineMetadataType> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AutoQuarantineMetadataType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AutoQuarantineMetadataType> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types