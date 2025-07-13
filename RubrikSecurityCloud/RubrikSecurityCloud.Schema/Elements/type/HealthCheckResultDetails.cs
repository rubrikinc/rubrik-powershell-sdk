// HealthCheckResultDetails.cs
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
    #region HealthCheckResultDetails
    public class HealthCheckResultDetails: BaseType
    {
        #region members

        //      C# -> ExoHealthCheckStatus? Status
        // GraphQL -> status: ExoHealthCheckStatus! (enum)
        [JsonProperty("status")]
        public ExoHealthCheckStatus? Status { get; set; }

        //      C# -> TextWithActions? Details
        // GraphQL -> details: TextWithActions (type)
        [JsonProperty("details")]
        public TextWithActions? Details { get; set; }

        //      C# -> TextWithActions? Heading
        // GraphQL -> heading: TextWithActions (type)
        [JsonProperty("heading")]
        public TextWithActions? Heading { get; set; }

        //      C# -> TextWithActions? RemediationStep
        // GraphQL -> remediationStep: TextWithActions (type)
        [JsonProperty("remediationStep")]
        public TextWithActions? RemediationStep { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HealthCheckResultDetails";
    }

    public HealthCheckResultDetails Set(
        ExoHealthCheckStatus? Status = null,
        TextWithActions? Details = null,
        TextWithActions? Heading = null,
        TextWithActions? RemediationStep = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Details != null ) {
            this.Details = Details;
        }
        if ( Heading != null ) {
            this.Heading = Heading;
        }
        if ( RemediationStep != null ) {
            this.RemediationStep = RemediationStep;
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
        //      C# -> ExoHealthCheckStatus? Status
        // GraphQL -> status: ExoHealthCheckStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> TextWithActions? Details
        // GraphQL -> details: TextWithActions (type)
        if (this.Details != null) {
            var fspec = this.Details.AsFieldSpec(conf.Child("details"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "details" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> TextWithActions? Heading
        // GraphQL -> heading: TextWithActions (type)
        if (this.Heading != null) {
            var fspec = this.Heading.AsFieldSpec(conf.Child("heading"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "heading" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> TextWithActions? RemediationStep
        // GraphQL -> remediationStep: TextWithActions (type)
        if (this.RemediationStep != null) {
            var fspec = this.RemediationStep.AsFieldSpec(conf.Child("remediationStep"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "remediationStep" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ExoHealthCheckStatus? Status
        // GraphQL -> status: ExoHealthCheckStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new ExoHealthCheckStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> TextWithActions? Details
        // GraphQL -> details: TextWithActions (type)
        if (ec.Includes("details",false))
        {
            if(this.Details == null) {

                this.Details = new TextWithActions();
                this.Details.ApplyExploratoryFieldSpec(ec.NewChild("details"));

            } else {

                this.Details.ApplyExploratoryFieldSpec(ec.NewChild("details"));

            }
        }
        else if (this.Details != null && ec.Excludes("details",false))
        {
            this.Details = null;
        }
        //      C# -> TextWithActions? Heading
        // GraphQL -> heading: TextWithActions (type)
        if (ec.Includes("heading",false))
        {
            if(this.Heading == null) {

                this.Heading = new TextWithActions();
                this.Heading.ApplyExploratoryFieldSpec(ec.NewChild("heading"));

            } else {

                this.Heading.ApplyExploratoryFieldSpec(ec.NewChild("heading"));

            }
        }
        else if (this.Heading != null && ec.Excludes("heading",false))
        {
            this.Heading = null;
        }
        //      C# -> TextWithActions? RemediationStep
        // GraphQL -> remediationStep: TextWithActions (type)
        if (ec.Includes("remediationStep",false))
        {
            if(this.RemediationStep == null) {

                this.RemediationStep = new TextWithActions();
                this.RemediationStep.ApplyExploratoryFieldSpec(ec.NewChild("remediationStep"));

            } else {

                this.RemediationStep.ApplyExploratoryFieldSpec(ec.NewChild("remediationStep"));

            }
        }
        else if (this.RemediationStep != null && ec.Excludes("remediationStep",false))
        {
            this.RemediationStep = null;
        }
    }


    #endregion

    } // class HealthCheckResultDetails
    
    #endregion

    public static class ListHealthCheckResultDetailsExtensions
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
            this List<HealthCheckResultDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HealthCheckResultDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HealthCheckResultDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HealthCheckResultDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HealthCheckResultDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types