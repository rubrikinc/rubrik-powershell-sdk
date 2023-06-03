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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region PasswordComplexityPolicyTemplate
    public class PasswordComplexityPolicyTemplate: BaseType
    {
        #region members

        //      C# -> System.Boolean? Active
        // GraphQL -> active: Boolean! (scalar)
        [JsonProperty("active")]
        public System.Boolean? Active { get; set; }

        //      C# -> System.Int32? DefaultValue
        // GraphQL -> defaultValue: Int! (scalar)
        [JsonProperty("defaultValue")]
        public System.Int32? DefaultValue { get; set; }

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

    public PasswordComplexityPolicyTemplate Set(
        System.Boolean? Active = null,
        System.Int32? DefaultValue = null,
        System.Int32? MaxValue = null,
        System.Int32? MinValue = null
    ) 
    {
        if ( Active != null ) {
            this.Active = Active;
        }
        if ( DefaultValue != null ) {
            this.DefaultValue = DefaultValue;
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Boolean? Active
        // GraphQL -> active: Boolean! (scalar)
        if (this.Active != null) {
            s += ind + "active\n" ;
        }
        //      C# -> System.Int32? DefaultValue
        // GraphQL -> defaultValue: Int! (scalar)
        if (this.DefaultValue != null) {
            s += ind + "defaultValue\n" ;
        }
        //      C# -> System.Int32? MaxValue
        // GraphQL -> maxValue: Int! (scalar)
        if (this.MaxValue != null) {
            s += ind + "maxValue\n" ;
        }
        //      C# -> System.Int32? MinValue
        // GraphQL -> minValue: Int! (scalar)
        if (this.MinValue != null) {
            s += ind + "minValue\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? Active
        // GraphQL -> active: Boolean! (scalar)
        if (this.Active == null && Exploration.Includes(parent + ".active", true))
        {
            this.Active = true;
        }
        //      C# -> System.Int32? DefaultValue
        // GraphQL -> defaultValue: Int! (scalar)
        if (this.DefaultValue == null && Exploration.Includes(parent + ".defaultValue", true))
        {
            this.DefaultValue = new System.Int32();
        }
        //      C# -> System.Int32? MaxValue
        // GraphQL -> maxValue: Int! (scalar)
        if (this.MaxValue == null && Exploration.Includes(parent + ".maxValue", true))
        {
            this.MaxValue = new System.Int32();
        }
        //      C# -> System.Int32? MinValue
        // GraphQL -> minValue: Int! (scalar)
        if (this.MinValue == null && Exploration.Includes(parent + ".minValue", true))
        {
            this.MinValue = new System.Int32();
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
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PasswordComplexityPolicyTemplate> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PasswordComplexityPolicyTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types