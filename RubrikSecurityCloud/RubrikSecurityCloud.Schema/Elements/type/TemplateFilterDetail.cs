// TemplateFilterDetail.cs
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
    #region TemplateFilterDetail
    public class TemplateFilterDetail: BaseType
    {
        #region members

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.Boolean? IsDynamic
        // GraphQL -> isDynamic: Boolean! (scalar)
        [JsonProperty("isDynamic")]
        public System.Boolean? IsDynamic { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<TemplateFilterValue>? StaticValues
        // GraphQL -> staticValues: [TemplateFilterValue!]! (type)
        [JsonProperty("staticValues")]
        public List<TemplateFilterValue>? StaticValues { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TemplateFilterDetail";
    }

    public TemplateFilterDetail Set(
        System.String? DisplayName = null,
        System.Boolean? IsDynamic = null,
        System.String? Name = null,
        List<TemplateFilterValue>? StaticValues = null
    ) 
    {
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( IsDynamic != null ) {
            this.IsDynamic = IsDynamic;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( StaticValues != null ) {
            this.StaticValues = StaticValues;
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
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> System.Boolean? IsDynamic
        // GraphQL -> isDynamic: Boolean! (scalar)
        if (this.IsDynamic != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDynamic\n" ;
            } else {
                s += ind + "isDynamic\n" ;
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
        //      C# -> List<TemplateFilterValue>? StaticValues
        // GraphQL -> staticValues: [TemplateFilterValue!]! (type)
        if (this.StaticValues != null) {
            var fspec = this.StaticValues.AsFieldSpec(conf.Child("staticValues"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "staticValues" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
        //      C# -> System.Boolean? IsDynamic
        // GraphQL -> isDynamic: Boolean! (scalar)
        if (ec.Includes("isDynamic",true))
        {
            if(this.IsDynamic == null) {

                this.IsDynamic = true;

            } else {


            }
        }
        else if (this.IsDynamic != null && ec.Excludes("isDynamic",true))
        {
            this.IsDynamic = null;
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
        //      C# -> List<TemplateFilterValue>? StaticValues
        // GraphQL -> staticValues: [TemplateFilterValue!]! (type)
        if (ec.Includes("staticValues",false))
        {
            if(this.StaticValues == null) {

                this.StaticValues = new List<TemplateFilterValue>();
                this.StaticValues.ApplyExploratoryFieldSpec(ec.NewChild("staticValues"));

            } else {

                this.StaticValues.ApplyExploratoryFieldSpec(ec.NewChild("staticValues"));

            }
        }
        else if (this.StaticValues != null && ec.Excludes("staticValues",false))
        {
            this.StaticValues = null;
        }
    }


    #endregion

    } // class TemplateFilterDetail
    
    #endregion

    public static class ListTemplateFilterDetailExtensions
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
            this List<TemplateFilterDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TemplateFilterDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TemplateFilterDetail> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TemplateFilterDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TemplateFilterDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types