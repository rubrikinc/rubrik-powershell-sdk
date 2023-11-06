// PasswordComplexityPolicyTemplate.cs
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
    #region PasswordComplexityPolicyTemplate
    public class PasswordComplexityPolicyTemplate: BaseType
    {
        #region members

        //      C# -> System.Int32? DefaultValue
        // GraphQL -> defaultValue: Int! (scalar)
        [JsonProperty("defaultValue")]
        public System.Int32? DefaultValue { get; set; }

        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        [JsonProperty("isActive")]
        public System.Boolean? IsActive { get; set; }

        //      C# -> System.Boolean? IsInherited
        // GraphQL -> isInherited: Boolean! (scalar)
        [JsonProperty("isInherited")]
        public System.Boolean? IsInherited { get; set; }

        //      C# -> System.Int32? MaxValue
        // GraphQL -> maxValue: Int! (scalar)
        [JsonProperty("maxValue")]
        public System.Int32? MaxValue { get; set; }

        //      C# -> System.Int32? MinValue
        // GraphQL -> minValue: Int! (scalar)
        [JsonProperty("minValue")]
        public System.Int32? MinValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PasswordComplexityPolicyTemplate";
    }

    public PasswordComplexityPolicyTemplate Set(
        System.Int32? DefaultValue = null,
        System.Boolean? IsActive = null,
        System.Boolean? IsInherited = null,
        System.Int32? MaxValue = null,
        System.Int32? MinValue = null
    ) 
    {
        if ( DefaultValue != null ) {
            this.DefaultValue = DefaultValue;
        }
        if ( IsActive != null ) {
            this.IsActive = IsActive;
        }
        if ( IsInherited != null ) {
            this.IsInherited = IsInherited;
        }
        if ( MaxValue != null ) {
            this.MaxValue = MaxValue;
        }
        if ( MinValue != null ) {
            this.MinValue = MinValue;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int32? DefaultValue
        // GraphQL -> defaultValue: Int! (scalar)
        if (this.DefaultValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defaultValue\n" ;
            } else {
                s += ind + "defaultValue\n" ;
            }
        }
        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        if (this.IsActive != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isActive\n" ;
            } else {
                s += ind + "isActive\n" ;
            }
        }
        //      C# -> System.Boolean? IsInherited
        // GraphQL -> isInherited: Boolean! (scalar)
        if (this.IsInherited != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isInherited\n" ;
            } else {
                s += ind + "isInherited\n" ;
            }
        }
        //      C# -> System.Int32? MaxValue
        // GraphQL -> maxValue: Int! (scalar)
        if (this.MaxValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxValue\n" ;
            } else {
                s += ind + "maxValue\n" ;
            }
        }
        //      C# -> System.Int32? MinValue
        // GraphQL -> minValue: Int! (scalar)
        if (this.MinValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "minValue\n" ;
            } else {
                s += ind + "minValue\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? DefaultValue
        // GraphQL -> defaultValue: Int! (scalar)
        if (ec.Includes("defaultValue",true))
        {
            if(this.DefaultValue == null) {

                this.DefaultValue = Int32.MinValue;

            } else {


            }
        }
        else if (this.DefaultValue != null && ec.Excludes("defaultValue",true))
        {
            this.DefaultValue = null;
        }
        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        if (ec.Includes("isActive",true))
        {
            if(this.IsActive == null) {

                this.IsActive = true;

            } else {


            }
        }
        else if (this.IsActive != null && ec.Excludes("isActive",true))
        {
            this.IsActive = null;
        }
        //      C# -> System.Boolean? IsInherited
        // GraphQL -> isInherited: Boolean! (scalar)
        if (ec.Includes("isInherited",true))
        {
            if(this.IsInherited == null) {

                this.IsInherited = true;

            } else {


            }
        }
        else if (this.IsInherited != null && ec.Excludes("isInherited",true))
        {
            this.IsInherited = null;
        }
        //      C# -> System.Int32? MaxValue
        // GraphQL -> maxValue: Int! (scalar)
        if (ec.Includes("maxValue",true))
        {
            if(this.MaxValue == null) {

                this.MaxValue = Int32.MinValue;

            } else {


            }
        }
        else if (this.MaxValue != null && ec.Excludes("maxValue",true))
        {
            this.MaxValue = null;
        }
        //      C# -> System.Int32? MinValue
        // GraphQL -> minValue: Int! (scalar)
        if (ec.Includes("minValue",true))
        {
            if(this.MinValue == null) {

                this.MinValue = Int32.MinValue;

            } else {


            }
        }
        else if (this.MinValue != null && ec.Excludes("minValue",true))
        {
            this.MinValue = null;
        }
    }


    #endregion

    } // class PasswordComplexityPolicyTemplate
    
    #endregion

    public static class ListPasswordComplexityPolicyTemplateExtensions
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
            this List<PasswordComplexityPolicyTemplate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<PasswordComplexityPolicyTemplate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PasswordComplexityPolicyTemplate> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PasswordComplexityPolicyTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PasswordComplexityPolicyTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types