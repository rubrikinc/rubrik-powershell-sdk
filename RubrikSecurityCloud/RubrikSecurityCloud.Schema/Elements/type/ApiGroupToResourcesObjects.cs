// ApiGroupToResourcesObjects.cs
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
    #region ApiGroupToResourcesObjects
    public class ApiGroupToResourcesObjects: BaseType
    {
        #region members

        //      C# -> System.String? ApiGroup
        // GraphQL -> apiGroup: String! (scalar)
        [JsonProperty("apiGroup")]
        public System.String? ApiGroup { get; set; }

        //      C# -> List<ResourcesToObjects>? Value
        // GraphQL -> value: [ResourcesToObjects!]! (type)
        [JsonProperty("value")]
        public List<ResourcesToObjects>? Value { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ApiGroupToResourcesObjects";
    }

    public ApiGroupToResourcesObjects Set(
        System.String? ApiGroup = null,
        List<ResourcesToObjects>? Value = null
    ) 
    {
        if ( ApiGroup != null ) {
            this.ApiGroup = ApiGroup;
        }
        if ( Value != null ) {
            this.Value = Value;
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
        //      C# -> System.String? ApiGroup
        // GraphQL -> apiGroup: String! (scalar)
        if (this.ApiGroup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "apiGroup\n" ;
            } else {
                s += ind + "apiGroup\n" ;
            }
        }
        //      C# -> List<ResourcesToObjects>? Value
        // GraphQL -> value: [ResourcesToObjects!]! (type)
        if (this.Value != null) {
            var fspec = this.Value.AsFieldSpec(conf.Child("value"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "value" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ApiGroup
        // GraphQL -> apiGroup: String! (scalar)
        if (ec.Includes("apiGroup",true))
        {
            if(this.ApiGroup == null) {

                this.ApiGroup = "FETCH";

            } else {


            }
        }
        else if (this.ApiGroup != null && ec.Excludes("apiGroup",true))
        {
            this.ApiGroup = null;
        }
        //      C# -> List<ResourcesToObjects>? Value
        // GraphQL -> value: [ResourcesToObjects!]! (type)
        if (ec.Includes("value",false))
        {
            if(this.Value == null) {

                this.Value = new List<ResourcesToObjects>();
                this.Value.ApplyExploratoryFieldSpec(ec.NewChild("value"));

            } else {

                this.Value.ApplyExploratoryFieldSpec(ec.NewChild("value"));

            }
        }
        else if (this.Value != null && ec.Excludes("value",false))
        {
            this.Value = null;
        }
    }


    #endregion

    } // class ApiGroupToResourcesObjects
    
    #endregion

    public static class ListApiGroupToResourcesObjectsExtensions
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
            this List<ApiGroupToResourcesObjects> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ApiGroupToResourcesObjects> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ApiGroupToResourcesObjects> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ApiGroupToResourcesObjects());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ApiGroupToResourcesObjects> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types