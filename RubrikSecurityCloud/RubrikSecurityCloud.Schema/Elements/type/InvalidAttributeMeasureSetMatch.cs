// InvalidAttributeMeasureSetMatch.cs
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
    #region InvalidAttributeMeasureSetMatch
    public class InvalidAttributeMeasureSetMatch: BaseType
    {
        #region members

        //      C# -> ReportAttributeSet? AttributeSet
        // GraphQL -> attributeSet: ReportAttributeSet (type)
        [JsonProperty("attributeSet")]
        public ReportAttributeSet? AttributeSet { get; set; }

        //      C# -> ReportMeasureSet? MeasureSet
        // GraphQL -> measureSet: ReportMeasureSet (type)
        [JsonProperty("measureSet")]
        public ReportMeasureSet? MeasureSet { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "InvalidAttributeMeasureSetMatch";
    }

    public InvalidAttributeMeasureSetMatch Set(
        ReportAttributeSet? AttributeSet = null,
        ReportMeasureSet? MeasureSet = null
    ) 
    {
        if ( AttributeSet != null ) {
            this.AttributeSet = AttributeSet;
        }
        if ( MeasureSet != null ) {
            this.MeasureSet = MeasureSet;
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
        //      C# -> ReportAttributeSet? AttributeSet
        // GraphQL -> attributeSet: ReportAttributeSet (type)
        if (this.AttributeSet != null) {
            var fspec = this.AttributeSet.AsFieldSpec(conf.Child("attributeSet"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "attributeSet" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ReportMeasureSet? MeasureSet
        // GraphQL -> measureSet: ReportMeasureSet (type)
        if (this.MeasureSet != null) {
            var fspec = this.MeasureSet.AsFieldSpec(conf.Child("measureSet"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "measureSet" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ReportAttributeSet? AttributeSet
        // GraphQL -> attributeSet: ReportAttributeSet (type)
        if (ec.Includes("attributeSet",false))
        {
            if(this.AttributeSet == null) {

                this.AttributeSet = new ReportAttributeSet();
                this.AttributeSet.ApplyExploratoryFieldSpec(ec.NewChild("attributeSet"));

            } else {

                this.AttributeSet.ApplyExploratoryFieldSpec(ec.NewChild("attributeSet"));

            }
        }
        else if (this.AttributeSet != null && ec.Excludes("attributeSet",false))
        {
            this.AttributeSet = null;
        }
        //      C# -> ReportMeasureSet? MeasureSet
        // GraphQL -> measureSet: ReportMeasureSet (type)
        if (ec.Includes("measureSet",false))
        {
            if(this.MeasureSet == null) {

                this.MeasureSet = new ReportMeasureSet();
                this.MeasureSet.ApplyExploratoryFieldSpec(ec.NewChild("measureSet"));

            } else {

                this.MeasureSet.ApplyExploratoryFieldSpec(ec.NewChild("measureSet"));

            }
        }
        else if (this.MeasureSet != null && ec.Excludes("measureSet",false))
        {
            this.MeasureSet = null;
        }
    }


    #endregion

    } // class InvalidAttributeMeasureSetMatch
    
    #endregion

    public static class ListInvalidAttributeMeasureSetMatchExtensions
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
            this List<InvalidAttributeMeasureSetMatch> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<InvalidAttributeMeasureSetMatch> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<InvalidAttributeMeasureSetMatch> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new InvalidAttributeMeasureSetMatch());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<InvalidAttributeMeasureSetMatch> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types