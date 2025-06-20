// ValidateBulkThreatHuntResponse.cs
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
    #region ValidateBulkThreatHuntResponse
    public class ValidateBulkThreatHuntResponse: BaseType
    {
        #region members

        //      C# -> BulkThreatHuntValidationStatus? ValidationStatus
        // GraphQL -> validationStatus: BulkThreatHuntValidationStatus! (enum)
        [JsonProperty("validationStatus")]
        public BulkThreatHuntValidationStatus? ValidationStatus { get; set; }

        //      C# -> List<HuntConfig>? Hunts
        // GraphQL -> hunts: [HuntConfig!]! (type)
        [JsonProperty("hunts")]
        public List<HuntConfig>? Hunts { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ValidateBulkThreatHuntResponse";
    }

    public ValidateBulkThreatHuntResponse Set(
        BulkThreatHuntValidationStatus? ValidationStatus = null,
        List<HuntConfig>? Hunts = null
    ) 
    {
        if ( ValidationStatus != null ) {
            this.ValidationStatus = ValidationStatus;
        }
        if ( Hunts != null ) {
            this.Hunts = Hunts;
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
        //      C# -> BulkThreatHuntValidationStatus? ValidationStatus
        // GraphQL -> validationStatus: BulkThreatHuntValidationStatus! (enum)
        if (this.ValidationStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "validationStatus\n" ;
            } else {
                s += ind + "validationStatus\n" ;
            }
        }
        //      C# -> List<HuntConfig>? Hunts
        // GraphQL -> hunts: [HuntConfig!]! (type)
        if (this.Hunts != null) {
            var fspec = this.Hunts.AsFieldSpec(conf.Child("hunts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hunts" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> BulkThreatHuntValidationStatus? ValidationStatus
        // GraphQL -> validationStatus: BulkThreatHuntValidationStatus! (enum)
        if (ec.Includes("validationStatus",true))
        {
            if(this.ValidationStatus == null) {

                this.ValidationStatus = new BulkThreatHuntValidationStatus();

            } else {


            }
        }
        else if (this.ValidationStatus != null && ec.Excludes("validationStatus",true))
        {
            this.ValidationStatus = null;
        }
        //      C# -> List<HuntConfig>? Hunts
        // GraphQL -> hunts: [HuntConfig!]! (type)
        if (ec.Includes("hunts",false))
        {
            if(this.Hunts == null) {

                this.Hunts = new List<HuntConfig>();
                this.Hunts.ApplyExploratoryFieldSpec(ec.NewChild("hunts"));

            } else {

                this.Hunts.ApplyExploratoryFieldSpec(ec.NewChild("hunts"));

            }
        }
        else if (this.Hunts != null && ec.Excludes("hunts",false))
        {
            this.Hunts = null;
        }
    }


    #endregion

    } // class ValidateBulkThreatHuntResponse
    
    #endregion

    public static class ListValidateBulkThreatHuntResponseExtensions
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
            this List<ValidateBulkThreatHuntResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ValidateBulkThreatHuntResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ValidateBulkThreatHuntResponse> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ValidateBulkThreatHuntResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ValidateBulkThreatHuntResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types