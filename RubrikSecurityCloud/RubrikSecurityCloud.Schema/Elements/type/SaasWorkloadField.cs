// SaasWorkloadField.cs
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
    #region SaasWorkloadField
    public class SaasWorkloadField: BaseType
    {
        #region members

        //      C# -> List<System.String>? DistinctValues
        // GraphQL -> distinctValues: [String!]! (scalar)
        [JsonProperty("distinctValues")]
        public List<System.String>? DistinctValues { get; set; }

        //      C# -> System.Boolean? IsDefault
        // GraphQL -> isDefault: Boolean! (scalar)
        [JsonProperty("isDefault")]
        public System.Boolean? IsDefault { get; set; }

        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        [JsonProperty("label")]
        public System.String? Label { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Type
        // GraphQL -> type: String! (scalar)
        [JsonProperty("type")]
        public System.String? Type { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SaasWorkloadField";
    }

    public SaasWorkloadField Set(
        List<System.String>? DistinctValues = null,
        System.Boolean? IsDefault = null,
        System.String? Label = null,
        System.String? Name = null,
        System.String? Type = null
    ) 
    {
        if ( DistinctValues != null ) {
            this.DistinctValues = DistinctValues;
        }
        if ( IsDefault != null ) {
            this.IsDefault = IsDefault;
        }
        if ( Label != null ) {
            this.Label = Label;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Type != null ) {
            this.Type = Type;
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
        //      C# -> List<System.String>? DistinctValues
        // GraphQL -> distinctValues: [String!]! (scalar)
        if (this.DistinctValues != null) {
            if (conf.Flat) {
                s += conf.Prefix + "distinctValues\n" ;
            } else {
                s += ind + "distinctValues\n" ;
            }
        }
        //      C# -> System.Boolean? IsDefault
        // GraphQL -> isDefault: Boolean! (scalar)
        if (this.IsDefault != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDefault\n" ;
            } else {
                s += ind + "isDefault\n" ;
            }
        }
        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        if (this.Label != null) {
            if (conf.Flat) {
                s += conf.Prefix + "label\n" ;
            } else {
                s += ind + "label\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? Type
        // GraphQL -> type: String! (scalar)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? DistinctValues
        // GraphQL -> distinctValues: [String!]! (scalar)
        if (ec.Includes("distinctValues",true))
        {
            if(this.DistinctValues == null) {

                this.DistinctValues = new List<System.String>();

            } else {


            }
        }
        else if (this.DistinctValues != null && ec.Excludes("distinctValues",true))
        {
            this.DistinctValues = null;
        }
        //      C# -> System.Boolean? IsDefault
        // GraphQL -> isDefault: Boolean! (scalar)
        if (ec.Includes("isDefault",true))
        {
            if(this.IsDefault == null) {

                this.IsDefault = true;

            } else {


            }
        }
        else if (this.IsDefault != null && ec.Excludes("isDefault",true))
        {
            this.IsDefault = null;
        }
        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        if (ec.Includes("label",true))
        {
            if(this.Label == null) {

                this.Label = "FETCH";

            } else {


            }
        }
        else if (this.Label != null && ec.Excludes("label",true))
        {
            this.Label = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? Type
        // GraphQL -> type: String! (scalar)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = "FETCH";

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
    }


    #endregion

    } // class SaasWorkloadField
    
    #endregion

    public static class ListSaasWorkloadFieldExtensions
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
            this List<SaasWorkloadField> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SaasWorkloadField> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SaasWorkloadField> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SaasWorkloadField());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SaasWorkloadField> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types