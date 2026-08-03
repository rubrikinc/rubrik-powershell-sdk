// GetHitsExposureStatsReply.cs
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
    #region GetHitsExposureStatsReply
    public class GetHitsExposureStatsReply: BaseType
    {
        #region members

        //      C# -> ExposureHits? ExposureHitsSummary
        // GraphQL -> exposureHitsSummary: ExposureHits (type)
        [JsonProperty("exposureHitsSummary")]
        public ExposureHits? ExposureHitsSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetHitsExposureStatsReply";
    }

    public GetHitsExposureStatsReply Set(
        ExposureHits? ExposureHitsSummary = null
    ) 
    {
        if ( ExposureHitsSummary != null ) {
            this.ExposureHitsSummary = ExposureHitsSummary;
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
        //      C# -> ExposureHits? ExposureHitsSummary
        // GraphQL -> exposureHitsSummary: ExposureHits (type)
        if (this.ExposureHitsSummary != null) {
            var fspec = this.ExposureHitsSummary.AsFieldSpec(conf.Child("exposureHitsSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "exposureHitsSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ExposureHits? ExposureHitsSummary
        // GraphQL -> exposureHitsSummary: ExposureHits (type)
        if (ec.Includes("exposureHitsSummary",false))
        {
            if(this.ExposureHitsSummary == null) {

                this.ExposureHitsSummary = new ExposureHits();
                this.ExposureHitsSummary.ApplyExploratoryFieldSpec(ec.NewChild("exposureHitsSummary"));

            } else {

                this.ExposureHitsSummary.ApplyExploratoryFieldSpec(ec.NewChild("exposureHitsSummary"));

            }
        }
        else if (this.ExposureHitsSummary != null && ec.Excludes("exposureHitsSummary",false))
        {
            this.ExposureHitsSummary = null;
        }
    }


    #endregion

    } // class GetHitsExposureStatsReply
    
    #endregion

    public static class ListGetHitsExposureStatsReplyExtensions
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
            this List<GetHitsExposureStatsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetHitsExposureStatsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetHitsExposureStatsReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetHitsExposureStatsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetHitsExposureStatsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types