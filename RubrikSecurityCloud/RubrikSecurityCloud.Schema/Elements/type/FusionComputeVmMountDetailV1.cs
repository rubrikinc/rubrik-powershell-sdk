// FusionComputeVmMountDetailV1.cs
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
    #region FusionComputeVmMountDetailV1
    public class FusionComputeVmMountDetailV1: BaseType
    {
        #region members

        //      C# -> System.String? NasIp
        // GraphQL -> nasIp: String (scalar)
        [JsonProperty("nasIp")]
        public System.String? NasIp { get; set; }

        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String (scalar)
        [JsonProperty("powerStatus")]
        public System.String? PowerStatus { get; set; }

        //      C# -> FusionComputeVmMountSummaryV1? FusionComputeVmMountSummaryV1
        // GraphQL -> fusionComputeVmMountSummaryV1: FusionComputeVmMountSummaryV1 (type)
        [JsonProperty("fusionComputeVmMountSummaryV1")]
        public FusionComputeVmMountSummaryV1? FusionComputeVmMountSummaryV1 { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FusionComputeVmMountDetailV1";
    }

    public FusionComputeVmMountDetailV1 Set(
        System.String? NasIp = null,
        System.String? PowerStatus = null,
        FusionComputeVmMountSummaryV1? FusionComputeVmMountSummaryV1 = null
    ) 
    {
        if ( NasIp != null ) {
            this.NasIp = NasIp;
        }
        if ( PowerStatus != null ) {
            this.PowerStatus = PowerStatus;
        }
        if ( FusionComputeVmMountSummaryV1 != null ) {
            this.FusionComputeVmMountSummaryV1 = FusionComputeVmMountSummaryV1;
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
        //      C# -> System.String? NasIp
        // GraphQL -> nasIp: String (scalar)
        if (this.NasIp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nasIp\n" ;
            } else {
                s += ind + "nasIp\n" ;
            }
        }
        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String (scalar)
        if (this.PowerStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "powerStatus\n" ;
            } else {
                s += ind + "powerStatus\n" ;
            }
        }
        //      C# -> FusionComputeVmMountSummaryV1? FusionComputeVmMountSummaryV1
        // GraphQL -> fusionComputeVmMountSummaryV1: FusionComputeVmMountSummaryV1 (type)
        if (this.FusionComputeVmMountSummaryV1 != null) {
            var fspec = this.FusionComputeVmMountSummaryV1.AsFieldSpec(conf.Child("fusionComputeVmMountSummaryV1"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "fusionComputeVmMountSummaryV1" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? NasIp
        // GraphQL -> nasIp: String (scalar)
        if (ec.Includes("nasIp",true))
        {
            if(this.NasIp == null) {

                this.NasIp = "FETCH";

            } else {


            }
        }
        else if (this.NasIp != null && ec.Excludes("nasIp",true))
        {
            this.NasIp = null;
        }
        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String (scalar)
        if (ec.Includes("powerStatus",true))
        {
            if(this.PowerStatus == null) {

                this.PowerStatus = "FETCH";

            } else {


            }
        }
        else if (this.PowerStatus != null && ec.Excludes("powerStatus",true))
        {
            this.PowerStatus = null;
        }
        //      C# -> FusionComputeVmMountSummaryV1? FusionComputeVmMountSummaryV1
        // GraphQL -> fusionComputeVmMountSummaryV1: FusionComputeVmMountSummaryV1 (type)
        if (ec.Includes("fusionComputeVmMountSummaryV1",false))
        {
            if(this.FusionComputeVmMountSummaryV1 == null) {

                this.FusionComputeVmMountSummaryV1 = new FusionComputeVmMountSummaryV1();
                this.FusionComputeVmMountSummaryV1.ApplyExploratoryFieldSpec(ec.NewChild("fusionComputeVmMountSummaryV1"));

            } else {

                this.FusionComputeVmMountSummaryV1.ApplyExploratoryFieldSpec(ec.NewChild("fusionComputeVmMountSummaryV1"));

            }
        }
        else if (this.FusionComputeVmMountSummaryV1 != null && ec.Excludes("fusionComputeVmMountSummaryV1",false))
        {
            this.FusionComputeVmMountSummaryV1 = null;
        }
    }


    #endregion

    } // class FusionComputeVmMountDetailV1
    
    #endregion

    public static class ListFusionComputeVmMountDetailV1Extensions
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
            this List<FusionComputeVmMountDetailV1> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FusionComputeVmMountDetailV1> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FusionComputeVmMountDetailV1> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FusionComputeVmMountDetailV1());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FusionComputeVmMountDetailV1> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types