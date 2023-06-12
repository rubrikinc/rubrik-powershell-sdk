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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region PasswordComplexityPolicy
    public class PasswordComplexityPolicy: BaseType
    {
        #region members

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

    public PasswordComplexityPolicy Set(
        PasswordComplexityPolicyTemplate? LengthPolicy = null,
        PasswordComplexityPolicyTemplate? LowercasePolicy = null,
        PasswordComplexityPolicyTemplate? NumericPolicy = null,
        PasswordComplexityPolicyTemplate? PasswordExpirationPolicy = null,
        PasswordComplexityPolicyTemplate? PasswordReusePolicy = null,
        PasswordComplexityPolicyTemplate? SpecialCharsPolicy = null,
        PasswordComplexityPolicyTemplate? UppercasePolicy = null
    ) 
    {
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> PasswordComplexityPolicyTemplate? LengthPolicy
        // GraphQL -> lengthPolicy: PasswordComplexityPolicyTemplate (type)
        if (this.LengthPolicy != null) {
            var fspec = this.LengthPolicy.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "lengthPolicy {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PasswordComplexityPolicyTemplate? LowercasePolicy
        // GraphQL -> lowercasePolicy: PasswordComplexityPolicyTemplate (type)
        if (this.LowercasePolicy != null) {
            var fspec = this.LowercasePolicy.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "lowercasePolicy {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PasswordComplexityPolicyTemplate? NumericPolicy
        // GraphQL -> numericPolicy: PasswordComplexityPolicyTemplate (type)
        if (this.NumericPolicy != null) {
            var fspec = this.NumericPolicy.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "numericPolicy {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PasswordComplexityPolicyTemplate? PasswordExpirationPolicy
        // GraphQL -> passwordExpirationPolicy: PasswordComplexityPolicyTemplate (type)
        if (this.PasswordExpirationPolicy != null) {
            var fspec = this.PasswordExpirationPolicy.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "passwordExpirationPolicy {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PasswordComplexityPolicyTemplate? PasswordReusePolicy
        // GraphQL -> passwordReusePolicy: PasswordComplexityPolicyTemplate (type)
        if (this.PasswordReusePolicy != null) {
            var fspec = this.PasswordReusePolicy.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "passwordReusePolicy {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PasswordComplexityPolicyTemplate? SpecialCharsPolicy
        // GraphQL -> specialCharsPolicy: PasswordComplexityPolicyTemplate (type)
        if (this.SpecialCharsPolicy != null) {
            var fspec = this.SpecialCharsPolicy.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "specialCharsPolicy {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PasswordComplexityPolicyTemplate? UppercasePolicy
        // GraphQL -> uppercasePolicy: PasswordComplexityPolicyTemplate (type)
        if (this.UppercasePolicy != null) {
            var fspec = this.UppercasePolicy.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "uppercasePolicy {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> PasswordComplexityPolicyTemplate? LengthPolicy
        // GraphQL -> lengthPolicy: PasswordComplexityPolicyTemplate (type)
        if (this.LengthPolicy == null && Exploration.Includes(parent + ".lengthPolicy"))
        {
            this.LengthPolicy = new PasswordComplexityPolicyTemplate();
            this.LengthPolicy.ApplyExploratoryFieldSpec(parent + ".lengthPolicy");
        }
        //      C# -> PasswordComplexityPolicyTemplate? LowercasePolicy
        // GraphQL -> lowercasePolicy: PasswordComplexityPolicyTemplate (type)
        if (this.LowercasePolicy == null && Exploration.Includes(parent + ".lowercasePolicy"))
        {
            this.LowercasePolicy = new PasswordComplexityPolicyTemplate();
            this.LowercasePolicy.ApplyExploratoryFieldSpec(parent + ".lowercasePolicy");
        }
        //      C# -> PasswordComplexityPolicyTemplate? NumericPolicy
        // GraphQL -> numericPolicy: PasswordComplexityPolicyTemplate (type)
        if (this.NumericPolicy == null && Exploration.Includes(parent + ".numericPolicy"))
        {
            this.NumericPolicy = new PasswordComplexityPolicyTemplate();
            this.NumericPolicy.ApplyExploratoryFieldSpec(parent + ".numericPolicy");
        }
        //      C# -> PasswordComplexityPolicyTemplate? PasswordExpirationPolicy
        // GraphQL -> passwordExpirationPolicy: PasswordComplexityPolicyTemplate (type)
        if (this.PasswordExpirationPolicy == null && Exploration.Includes(parent + ".passwordExpirationPolicy"))
        {
            this.PasswordExpirationPolicy = new PasswordComplexityPolicyTemplate();
            this.PasswordExpirationPolicy.ApplyExploratoryFieldSpec(parent + ".passwordExpirationPolicy");
        }
        //      C# -> PasswordComplexityPolicyTemplate? PasswordReusePolicy
        // GraphQL -> passwordReusePolicy: PasswordComplexityPolicyTemplate (type)
        if (this.PasswordReusePolicy == null && Exploration.Includes(parent + ".passwordReusePolicy"))
        {
            this.PasswordReusePolicy = new PasswordComplexityPolicyTemplate();
            this.PasswordReusePolicy.ApplyExploratoryFieldSpec(parent + ".passwordReusePolicy");
        }
        //      C# -> PasswordComplexityPolicyTemplate? SpecialCharsPolicy
        // GraphQL -> specialCharsPolicy: PasswordComplexityPolicyTemplate (type)
        if (this.SpecialCharsPolicy == null && Exploration.Includes(parent + ".specialCharsPolicy"))
        {
            this.SpecialCharsPolicy = new PasswordComplexityPolicyTemplate();
            this.SpecialCharsPolicy.ApplyExploratoryFieldSpec(parent + ".specialCharsPolicy");
        }
        //      C# -> PasswordComplexityPolicyTemplate? UppercasePolicy
        // GraphQL -> uppercasePolicy: PasswordComplexityPolicyTemplate (type)
        if (this.UppercasePolicy == null && Exploration.Includes(parent + ".uppercasePolicy"))
        {
            this.UppercasePolicy = new PasswordComplexityPolicyTemplate();
            this.UppercasePolicy.ApplyExploratoryFieldSpec(parent + ".uppercasePolicy");
        }
    }


    #endregion

    } // class PasswordComplexityPolicy
    
    #endregion

    public static class ListPasswordComplexityPolicyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<PasswordComplexityPolicy> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PasswordComplexityPolicy> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PasswordComplexityPolicy());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types