// CustomResourceDependency.cs
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
    #region CustomResourceDependency
    public class CustomResourceDependency: BaseType
    {
        #region members

        //      C# -> System.String? Group
        // GraphQL -> group: String! (scalar)
        [JsonProperty("group")]
        public System.String? Group { get; set; }

        //      C# -> System.String? Resource
        // GraphQL -> resource: String! (scalar)
        [JsonProperty("resource")]
        public System.String? Resource { get; set; }

        //      C# -> System.String? SelectionMode
        // GraphQL -> selectionMode: String! (scalar)
        [JsonProperty("selectionMode")]
        public System.String? SelectionMode { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CustomResourceDependency";
    }

    public CustomResourceDependency Set(
        System.String? Group = null,
        System.String? Resource = null,
        System.String? SelectionMode = null
    ) 
    {
        if ( Group != null ) {
            this.Group = Group;
        }
        if ( Resource != null ) {
            this.Resource = Resource;
        }
        if ( SelectionMode != null ) {
            this.SelectionMode = SelectionMode;
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
        //      C# -> System.String? Group
        // GraphQL -> group: String! (scalar)
        if (this.Group != null) {
            if (conf.Flat) {
                s += conf.Prefix + "group\n" ;
            } else {
                s += ind + "group\n" ;
            }
        }
        //      C# -> System.String? Resource
        // GraphQL -> resource: String! (scalar)
        if (this.Resource != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resource\n" ;
            } else {
                s += ind + "resource\n" ;
            }
        }
        //      C# -> System.String? SelectionMode
        // GraphQL -> selectionMode: String! (scalar)
        if (this.SelectionMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "selectionMode\n" ;
            } else {
                s += ind + "selectionMode\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Group
        // GraphQL -> group: String! (scalar)
        if (ec.Includes("group",true))
        {
            if(this.Group == null) {

                this.Group = "FETCH";

            } else {


            }
        }
        else if (this.Group != null && ec.Excludes("group",true))
        {
            this.Group = null;
        }
        //      C# -> System.String? Resource
        // GraphQL -> resource: String! (scalar)
        if (ec.Includes("resource",true))
        {
            if(this.Resource == null) {

                this.Resource = "FETCH";

            } else {


            }
        }
        else if (this.Resource != null && ec.Excludes("resource",true))
        {
            this.Resource = null;
        }
        //      C# -> System.String? SelectionMode
        // GraphQL -> selectionMode: String! (scalar)
        if (ec.Includes("selectionMode",true))
        {
            if(this.SelectionMode == null) {

                this.SelectionMode = "FETCH";

            } else {


            }
        }
        else if (this.SelectionMode != null && ec.Excludes("selectionMode",true))
        {
            this.SelectionMode = null;
        }
    }


    #endregion

    } // class CustomResourceDependency
    
    #endregion

    public static class ListCustomResourceDependencyExtensions
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
            this List<CustomResourceDependency> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CustomResourceDependency> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CustomResourceDependency> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CustomResourceDependency());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CustomResourceDependency> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types