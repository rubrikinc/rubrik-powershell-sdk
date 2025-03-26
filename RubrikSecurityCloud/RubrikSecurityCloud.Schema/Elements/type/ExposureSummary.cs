// ExposureSummary.cs
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
    #region ExposureSummary
    public class ExposureSummary: BaseType
    {
        #region members

        //      C# -> OpenAccessType? ExposureType
        // GraphQL -> exposureType: OpenAccessType! (enum)
        [JsonProperty("exposureType")]
        public OpenAccessType? ExposureType { get; set; }

        //      C# -> SummaryCount? FileCount
        // GraphQL -> fileCount: SummaryCount (type)
        [JsonProperty("fileCount")]
        public SummaryCount? FileCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ExposureSummary";
    }

    public ExposureSummary Set(
        OpenAccessType? ExposureType = null,
        SummaryCount? FileCount = null
    ) 
    {
        if ( ExposureType != null ) {
            this.ExposureType = ExposureType;
        }
        if ( FileCount != null ) {
            this.FileCount = FileCount;
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
        //      C# -> OpenAccessType? ExposureType
        // GraphQL -> exposureType: OpenAccessType! (enum)
        if (this.ExposureType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exposureType\n" ;
            } else {
                s += ind + "exposureType\n" ;
            }
        }
        //      C# -> SummaryCount? FileCount
        // GraphQL -> fileCount: SummaryCount (type)
        if (this.FileCount != null) {
            var fspec = this.FileCount.AsFieldSpec(conf.Child("fileCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "fileCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> OpenAccessType? ExposureType
        // GraphQL -> exposureType: OpenAccessType! (enum)
        if (ec.Includes("exposureType",true))
        {
            if(this.ExposureType == null) {

                this.ExposureType = new OpenAccessType();

            } else {


            }
        }
        else if (this.ExposureType != null && ec.Excludes("exposureType",true))
        {
            this.ExposureType = null;
        }
        //      C# -> SummaryCount? FileCount
        // GraphQL -> fileCount: SummaryCount (type)
        if (ec.Includes("fileCount",false))
        {
            if(this.FileCount == null) {

                this.FileCount = new SummaryCount();
                this.FileCount.ApplyExploratoryFieldSpec(ec.NewChild("fileCount"));

            } else {

                this.FileCount.ApplyExploratoryFieldSpec(ec.NewChild("fileCount"));

            }
        }
        else if (this.FileCount != null && ec.Excludes("fileCount",false))
        {
            this.FileCount = null;
        }
    }


    #endregion

    } // class ExposureSummary
    
    #endregion

    public static class ListExposureSummaryExtensions
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
            this List<ExposureSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ExposureSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ExposureSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ExposureSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ExposureSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types