// PasswordComplexityPolicy.cs
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
    #region PasswordComplexityPolicy
    public class PasswordComplexityPolicy: BaseType
    {
        #region members

        //      C# -> PasswordComplexityPolicyTemplate? LeakedDetectionPolicy
        // GraphQL -> leakedDetectionPolicy: PasswordComplexityPolicyTemplate (type)
        [JsonProperty("leakedDetectionPolicy")]
        public PasswordComplexityPolicyTemplate? LeakedDetectionPolicy { get; set; }

        //      C# -> PasswordComplexityPolicyTemplate? LengthPolicy
        // GraphQL -> lengthPolicy: PasswordComplexityPolicyTemplate (type)
        [JsonProperty("lengthPolicy")]
        public PasswordComplexityPolicyTemplate? LengthPolicy { get; set; }

        //      C# -> PasswordComplexityPolicyTemplate? LowercasePolicy
        // GraphQL -> lowercasePolicy: PasswordComplexityPolicyTemplate (type)
        [JsonProperty("lowercasePolicy")]
        public PasswordComplexityPolicyTemplate? LowercasePolicy { get; set; }

        //      C# -> PasswordComplexityPolicyTemplate? NumericPolicy
        // GraphQL -> numericPolicy: PasswordComplexityPolicyTemplate (type)
        [JsonProperty("numericPolicy")]
        public PasswordComplexityPolicyTemplate? NumericPolicy { get; set; }

        //      C# -> PasswordComplexityPolicyTemplate? PasswordExpirationPolicy
        // GraphQL -> passwordExpirationPolicy: PasswordComplexityPolicyTemplate (type)
        [JsonProperty("passwordExpirationPolicy")]
        public PasswordComplexityPolicyTemplate? PasswordExpirationPolicy { get; set; }

        //      C# -> PasswordComplexityPolicyTemplate? PasswordReusePolicy
        // GraphQL -> passwordReusePolicy: PasswordComplexityPolicyTemplate (type)
        [JsonProperty("passwordReusePolicy")]
        public PasswordComplexityPolicyTemplate? PasswordReusePolicy { get; set; }

        //      C# -> PasswordComplexityPolicyTemplate? SpecialCharsPolicy
        // GraphQL -> specialCharsPolicy: PasswordComplexityPolicyTemplate (type)
        [JsonProperty("specialCharsPolicy")]
        public PasswordComplexityPolicyTemplate? SpecialCharsPolicy { get; set; }

        //      C# -> PasswordComplexityPolicyTemplate? UppercasePolicy
        // GraphQL -> uppercasePolicy: PasswordComplexityPolicyTemplate (type)
        [JsonProperty("uppercasePolicy")]
        public PasswordComplexityPolicyTemplate? UppercasePolicy { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PasswordComplexityPolicy";
    }

    public PasswordComplexityPolicy Set(
        PasswordComplexityPolicyTemplate? LeakedDetectionPolicy = null,
        PasswordComplexityPolicyTemplate? LengthPolicy = null,
        PasswordComplexityPolicyTemplate? LowercasePolicy = null,
        PasswordComplexityPolicyTemplate? NumericPolicy = null,
        PasswordComplexityPolicyTemplate? PasswordExpirationPolicy = null,
        PasswordComplexityPolicyTemplate? PasswordReusePolicy = null,
        PasswordComplexityPolicyTemplate? SpecialCharsPolicy = null,
        PasswordComplexityPolicyTemplate? UppercasePolicy = null
    ) 
    {
        if ( LeakedDetectionPolicy != null ) {
            this.LeakedDetectionPolicy = LeakedDetectionPolicy;
        }
        if ( LengthPolicy != null ) {
            this.LengthPolicy = LengthPolicy;
        }
        if ( LowercasePolicy != null ) {
            this.LowercasePolicy = LowercasePolicy;
        }
        if ( NumericPolicy != null ) {
            this.NumericPolicy = NumericPolicy;
        }
        if ( PasswordExpirationPolicy != null ) {
            this.PasswordExpirationPolicy = PasswordExpirationPolicy;
        }
        if ( PasswordReusePolicy != null ) {
            this.PasswordReusePolicy = PasswordReusePolicy;
        }
        if ( SpecialCharsPolicy != null ) {
            this.SpecialCharsPolicy = SpecialCharsPolicy;
        }
        if ( UppercasePolicy != null ) {
            this.UppercasePolicy = UppercasePolicy;
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
        //      C# -> PasswordComplexityPolicyTemplate? LeakedDetectionPolicy
        // GraphQL -> leakedDetectionPolicy: PasswordComplexityPolicyTemplate (type)
        if (this.LeakedDetectionPolicy != null) {
            var fspec = this.LeakedDetectionPolicy.AsFieldSpec(conf.Child("leakedDetectionPolicy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "leakedDetectionPolicy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PasswordComplexityPolicyTemplate? LengthPolicy
        // GraphQL -> lengthPolicy: PasswordComplexityPolicyTemplate (type)
        if (this.LengthPolicy != null) {
            var fspec = this.LengthPolicy.AsFieldSpec(conf.Child("lengthPolicy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lengthPolicy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PasswordComplexityPolicyTemplate? LowercasePolicy
        // GraphQL -> lowercasePolicy: PasswordComplexityPolicyTemplate (type)
        if (this.LowercasePolicy != null) {
            var fspec = this.LowercasePolicy.AsFieldSpec(conf.Child("lowercasePolicy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lowercasePolicy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PasswordComplexityPolicyTemplate? NumericPolicy
        // GraphQL -> numericPolicy: PasswordComplexityPolicyTemplate (type)
        if (this.NumericPolicy != null) {
            var fspec = this.NumericPolicy.AsFieldSpec(conf.Child("numericPolicy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "numericPolicy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PasswordComplexityPolicyTemplate? PasswordExpirationPolicy
        // GraphQL -> passwordExpirationPolicy: PasswordComplexityPolicyTemplate (type)
        if (this.PasswordExpirationPolicy != null) {
            var fspec = this.PasswordExpirationPolicy.AsFieldSpec(conf.Child("passwordExpirationPolicy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "passwordExpirationPolicy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PasswordComplexityPolicyTemplate? PasswordReusePolicy
        // GraphQL -> passwordReusePolicy: PasswordComplexityPolicyTemplate (type)
        if (this.PasswordReusePolicy != null) {
            var fspec = this.PasswordReusePolicy.AsFieldSpec(conf.Child("passwordReusePolicy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "passwordReusePolicy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PasswordComplexityPolicyTemplate? SpecialCharsPolicy
        // GraphQL -> specialCharsPolicy: PasswordComplexityPolicyTemplate (type)
        if (this.SpecialCharsPolicy != null) {
            var fspec = this.SpecialCharsPolicy.AsFieldSpec(conf.Child("specialCharsPolicy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "specialCharsPolicy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PasswordComplexityPolicyTemplate? UppercasePolicy
        // GraphQL -> uppercasePolicy: PasswordComplexityPolicyTemplate (type)
        if (this.UppercasePolicy != null) {
            var fspec = this.UppercasePolicy.AsFieldSpec(conf.Child("uppercasePolicy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "uppercasePolicy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> PasswordComplexityPolicyTemplate? LeakedDetectionPolicy
        // GraphQL -> leakedDetectionPolicy: PasswordComplexityPolicyTemplate (type)
        if (ec.Includes("leakedDetectionPolicy",false))
        {
            if(this.LeakedDetectionPolicy == null) {

                this.LeakedDetectionPolicy = new PasswordComplexityPolicyTemplate();
                this.LeakedDetectionPolicy.ApplyExploratoryFieldSpec(ec.NewChild("leakedDetectionPolicy"));

            } else {

                this.LeakedDetectionPolicy.ApplyExploratoryFieldSpec(ec.NewChild("leakedDetectionPolicy"));

            }
        }
        else if (this.LeakedDetectionPolicy != null && ec.Excludes("leakedDetectionPolicy",false))
        {
            this.LeakedDetectionPolicy = null;
        }
        //      C# -> PasswordComplexityPolicyTemplate? LengthPolicy
        // GraphQL -> lengthPolicy: PasswordComplexityPolicyTemplate (type)
        if (ec.Includes("lengthPolicy",false))
        {
            if(this.LengthPolicy == null) {

                this.LengthPolicy = new PasswordComplexityPolicyTemplate();
                this.LengthPolicy.ApplyExploratoryFieldSpec(ec.NewChild("lengthPolicy"));

            } else {

                this.LengthPolicy.ApplyExploratoryFieldSpec(ec.NewChild("lengthPolicy"));

            }
        }
        else if (this.LengthPolicy != null && ec.Excludes("lengthPolicy",false))
        {
            this.LengthPolicy = null;
        }
        //      C# -> PasswordComplexityPolicyTemplate? LowercasePolicy
        // GraphQL -> lowercasePolicy: PasswordComplexityPolicyTemplate (type)
        if (ec.Includes("lowercasePolicy",false))
        {
            if(this.LowercasePolicy == null) {

                this.LowercasePolicy = new PasswordComplexityPolicyTemplate();
                this.LowercasePolicy.ApplyExploratoryFieldSpec(ec.NewChild("lowercasePolicy"));

            } else {

                this.LowercasePolicy.ApplyExploratoryFieldSpec(ec.NewChild("lowercasePolicy"));

            }
        }
        else if (this.LowercasePolicy != null && ec.Excludes("lowercasePolicy",false))
        {
            this.LowercasePolicy = null;
        }
        //      C# -> PasswordComplexityPolicyTemplate? NumericPolicy
        // GraphQL -> numericPolicy: PasswordComplexityPolicyTemplate (type)
        if (ec.Includes("numericPolicy",false))
        {
            if(this.NumericPolicy == null) {

                this.NumericPolicy = new PasswordComplexityPolicyTemplate();
                this.NumericPolicy.ApplyExploratoryFieldSpec(ec.NewChild("numericPolicy"));

            } else {

                this.NumericPolicy.ApplyExploratoryFieldSpec(ec.NewChild("numericPolicy"));

            }
        }
        else if (this.NumericPolicy != null && ec.Excludes("numericPolicy",false))
        {
            this.NumericPolicy = null;
        }
        //      C# -> PasswordComplexityPolicyTemplate? PasswordExpirationPolicy
        // GraphQL -> passwordExpirationPolicy: PasswordComplexityPolicyTemplate (type)
        if (ec.Includes("passwordExpirationPolicy",false))
        {
            if(this.PasswordExpirationPolicy == null) {

                this.PasswordExpirationPolicy = new PasswordComplexityPolicyTemplate();
                this.PasswordExpirationPolicy.ApplyExploratoryFieldSpec(ec.NewChild("passwordExpirationPolicy"));

            } else {

                this.PasswordExpirationPolicy.ApplyExploratoryFieldSpec(ec.NewChild("passwordExpirationPolicy"));

            }
        }
        else if (this.PasswordExpirationPolicy != null && ec.Excludes("passwordExpirationPolicy",false))
        {
            this.PasswordExpirationPolicy = null;
        }
        //      C# -> PasswordComplexityPolicyTemplate? PasswordReusePolicy
        // GraphQL -> passwordReusePolicy: PasswordComplexityPolicyTemplate (type)
        if (ec.Includes("passwordReusePolicy",false))
        {
            if(this.PasswordReusePolicy == null) {

                this.PasswordReusePolicy = new PasswordComplexityPolicyTemplate();
                this.PasswordReusePolicy.ApplyExploratoryFieldSpec(ec.NewChild("passwordReusePolicy"));

            } else {

                this.PasswordReusePolicy.ApplyExploratoryFieldSpec(ec.NewChild("passwordReusePolicy"));

            }
        }
        else if (this.PasswordReusePolicy != null && ec.Excludes("passwordReusePolicy",false))
        {
            this.PasswordReusePolicy = null;
        }
        //      C# -> PasswordComplexityPolicyTemplate? SpecialCharsPolicy
        // GraphQL -> specialCharsPolicy: PasswordComplexityPolicyTemplate (type)
        if (ec.Includes("specialCharsPolicy",false))
        {
            if(this.SpecialCharsPolicy == null) {

                this.SpecialCharsPolicy = new PasswordComplexityPolicyTemplate();
                this.SpecialCharsPolicy.ApplyExploratoryFieldSpec(ec.NewChild("specialCharsPolicy"));

            } else {

                this.SpecialCharsPolicy.ApplyExploratoryFieldSpec(ec.NewChild("specialCharsPolicy"));

            }
        }
        else if (this.SpecialCharsPolicy != null && ec.Excludes("specialCharsPolicy",false))
        {
            this.SpecialCharsPolicy = null;
        }
        //      C# -> PasswordComplexityPolicyTemplate? UppercasePolicy
        // GraphQL -> uppercasePolicy: PasswordComplexityPolicyTemplate (type)
        if (ec.Includes("uppercasePolicy",false))
        {
            if(this.UppercasePolicy == null) {

                this.UppercasePolicy = new PasswordComplexityPolicyTemplate();
                this.UppercasePolicy.ApplyExploratoryFieldSpec(ec.NewChild("uppercasePolicy"));

            } else {

                this.UppercasePolicy.ApplyExploratoryFieldSpec(ec.NewChild("uppercasePolicy"));

            }
        }
        else if (this.UppercasePolicy != null && ec.Excludes("uppercasePolicy",false))
        {
            this.UppercasePolicy = null;
        }
    }


    #endregion

    } // class PasswordComplexityPolicy
    
    #endregion

    public static class ListPasswordComplexityPolicyExtensions
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
            this List<PasswordComplexityPolicy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PasswordComplexityPolicy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PasswordComplexityPolicy> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PasswordComplexityPolicy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PasswordComplexityPolicy> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types