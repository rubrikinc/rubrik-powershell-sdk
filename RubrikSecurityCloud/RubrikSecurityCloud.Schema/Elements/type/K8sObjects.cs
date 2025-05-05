// K8sObjects.cs
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
    #region K8sObjects
    public class K8sObjects: BaseType
    {
        #region members

        //      C# -> List<System.String>? Objects
        // GraphQL -> objects: [String!]! (scalar)
        [JsonProperty("objects")]
        public List<System.String>? Objects { get; set; }

        //      C# -> System.String? Scope
        // GraphQL -> scope: String! (scalar)
        [JsonProperty("scope")]
        public System.String? Scope { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "K8sObjects";
    }

    public K8sObjects Set(
        List<System.String>? Objects = null,
        System.String? Scope = null
    ) 
    {
        if ( Objects != null ) {
            this.Objects = Objects;
        }
        if ( Scope != null ) {
            this.Scope = Scope;
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
        //      C# -> List<System.String>? Objects
        // GraphQL -> objects: [String!]! (scalar)
        if (this.Objects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objects\n" ;
            } else {
                s += ind + "objects\n" ;
            }
        }
        //      C# -> System.String? Scope
        // GraphQL -> scope: String! (scalar)
        if (this.Scope != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scope\n" ;
            } else {
                s += ind + "scope\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? Objects
        // GraphQL -> objects: [String!]! (scalar)
        if (ec.Includes("objects",true))
        {
            if(this.Objects == null) {

                this.Objects = new List<System.String>();

            } else {


            }
        }
        else if (this.Objects != null && ec.Excludes("objects",true))
        {
            this.Objects = null;
        }
        //      C# -> System.String? Scope
        // GraphQL -> scope: String! (scalar)
        if (ec.Includes("scope",true))
        {
            if(this.Scope == null) {

                this.Scope = "FETCH";

            } else {


            }
        }
        else if (this.Scope != null && ec.Excludes("scope",true))
        {
            this.Scope = null;
        }
    }


    #endregion

    } // class K8sObjects
    
    #endregion

    public static class ListK8sObjectsExtensions
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
            this List<K8sObjects> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<K8sObjects> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<K8sObjects> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sObjects());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<K8sObjects> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types