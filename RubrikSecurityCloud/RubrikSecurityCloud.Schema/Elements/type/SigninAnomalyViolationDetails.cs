// SigninAnomalyViolationDetails.cs
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
    #region SigninAnomalyViolationDetails
 
    public class SigninAnomalyViolationDetails: BaseType, ViolationDetailsUnion
    {
        #region members

        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        [JsonProperty("idpType")]
        public IdpType? IdpType { get; set; }

        //      C# -> SigninConditionDetails? ConditionDetails
        // GraphQL -> conditionDetails: SigninConditionDetails (type)
        [JsonProperty("conditionDetails")]
        public SigninConditionDetails? ConditionDetails { get; set; }

        //      C# -> DetectionWindow? DetectionWindow
        // GraphQL -> detectionWindow: DetectionWindow (type)
        [JsonProperty("detectionWindow")]
        public DetectionWindow? DetectionWindow { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SigninAnomalyViolationDetails";
    }

    public SigninAnomalyViolationDetails Set(
        IdpType? IdpType = null,
        SigninConditionDetails? ConditionDetails = null,
        DetectionWindow? DetectionWindow = null
    ) 
    {
        if ( IdpType != null ) {
            this.IdpType = IdpType;
        }
        if ( ConditionDetails != null ) {
            this.ConditionDetails = ConditionDetails;
        }
        if ( DetectionWindow != null ) {
            this.DetectionWindow = DetectionWindow;
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
        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        if (this.IdpType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "idpType\n" ;
            } else {
                s += ind + "idpType\n" ;
            }
        }
        //      C# -> SigninConditionDetails? ConditionDetails
        // GraphQL -> conditionDetails: SigninConditionDetails (type)
        if (this.ConditionDetails != null) {
            var fspec = this.ConditionDetails.AsFieldSpec(conf.Child("conditionDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "conditionDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> DetectionWindow? DetectionWindow
        // GraphQL -> detectionWindow: DetectionWindow (type)
        if (this.DetectionWindow != null) {
            var fspec = this.DetectionWindow.AsFieldSpec(conf.Child("detectionWindow"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "detectionWindow" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        if (ec.Includes("idpType",true))
        {
            if(this.IdpType == null) {

                this.IdpType = new IdpType();

            } else {


            }
        }
        else if (this.IdpType != null && ec.Excludes("idpType",true))
        {
            this.IdpType = null;
        }
        //      C# -> SigninConditionDetails? ConditionDetails
        // GraphQL -> conditionDetails: SigninConditionDetails (type)
        if (ec.Includes("conditionDetails",false))
        {
            if(this.ConditionDetails == null) {

                this.ConditionDetails = new SigninConditionDetails();
                this.ConditionDetails.ApplyExploratoryFieldSpec(ec.NewChild("conditionDetails"));

            } else {

                this.ConditionDetails.ApplyExploratoryFieldSpec(ec.NewChild("conditionDetails"));

            }
        }
        else if (this.ConditionDetails != null && ec.Excludes("conditionDetails",false))
        {
            this.ConditionDetails = null;
        }
        //      C# -> DetectionWindow? DetectionWindow
        // GraphQL -> detectionWindow: DetectionWindow (type)
        if (ec.Includes("detectionWindow",false))
        {
            if(this.DetectionWindow == null) {

                this.DetectionWindow = new DetectionWindow();
                this.DetectionWindow.ApplyExploratoryFieldSpec(ec.NewChild("detectionWindow"));

            } else {

                this.DetectionWindow.ApplyExploratoryFieldSpec(ec.NewChild("detectionWindow"));

            }
        }
        else if (this.DetectionWindow != null && ec.Excludes("detectionWindow",false))
        {
            this.DetectionWindow = null;
        }
    }


    #endregion

    } // class SigninAnomalyViolationDetails
    
    #endregion

    public static class ListSigninAnomalyViolationDetailsExtensions
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
            this List<SigninAnomalyViolationDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SigninAnomalyViolationDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SigninAnomalyViolationDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SigninAnomalyViolationDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SigninAnomalyViolationDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types