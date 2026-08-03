// K8sNamespaceResourceSummary.cs
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
    #region K8sNamespaceResourceSummary
    public class K8sNamespaceResourceSummary: BaseType
    {
        #region members

        //      C# -> System.String? Namespace
        // GraphQL -> namespace: String! (scalar)
        [JsonProperty("namespace")]
        public System.String? Namespace { get; set; }

        //      C# -> System.Int32? TotalCount
        // GraphQL -> totalCount: Int! (scalar)
        [JsonProperty("totalCount")]
        public System.Int32? TotalCount { get; set; }

        //      C# -> List<K8sResourceTypeCount>? Types
        // GraphQL -> types: [K8sResourceTypeCount!]! (type)
        [JsonProperty("types")]
        public List<K8sResourceTypeCount>? Types { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "K8sNamespaceResourceSummary";
    }

    public K8sNamespaceResourceSummary Set(
        System.String? Namespace = null,
        System.Int32? TotalCount = null,
        List<K8sResourceTypeCount>? Types = null
    ) 
    {
        if ( Namespace != null ) {
            this.Namespace = Namespace;
        }
        if ( TotalCount != null ) {
            this.TotalCount = TotalCount;
        }
        if ( Types != null ) {
            this.Types = Types;
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
        //      C# -> System.String? Namespace
        // GraphQL -> namespace: String! (scalar)
        if (this.Namespace != null) {
            if (conf.Flat) {
                s += conf.Prefix + "namespace\n" ;
            } else {
                s += ind + "namespace\n" ;
            }
        }
        //      C# -> System.Int32? TotalCount
        // GraphQL -> totalCount: Int! (scalar)
        if (this.TotalCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalCount\n" ;
            } else {
                s += ind + "totalCount\n" ;
            }
        }
        //      C# -> List<K8sResourceTypeCount>? Types
        // GraphQL -> types: [K8sResourceTypeCount!]! (type)
        if (this.Types != null) {
            var fspec = this.Types.AsFieldSpec(conf.Child("types"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "types" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Namespace
        // GraphQL -> namespace: String! (scalar)
        if (ec.Includes("namespace",true))
        {
            if(this.Namespace == null) {

                this.Namespace = "FETCH";

            } else {


            }
        }
        else if (this.Namespace != null && ec.Excludes("namespace",true))
        {
            this.Namespace = null;
        }
        //      C# -> System.Int32? TotalCount
        // GraphQL -> totalCount: Int! (scalar)
        if (ec.Includes("totalCount",true))
        {
            if(this.TotalCount == null) {

                this.TotalCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalCount != null && ec.Excludes("totalCount",true))
        {
            this.TotalCount = null;
        }
        //      C# -> List<K8sResourceTypeCount>? Types
        // GraphQL -> types: [K8sResourceTypeCount!]! (type)
        if (ec.Includes("types",false))
        {
            if(this.Types == null) {

                this.Types = new List<K8sResourceTypeCount>();
                this.Types.ApplyExploratoryFieldSpec(ec.NewChild("types"));

            } else {

                this.Types.ApplyExploratoryFieldSpec(ec.NewChild("types"));

            }
        }
        else if (this.Types != null && ec.Excludes("types",false))
        {
            this.Types = null;
        }
    }


    #endregion

    } // class K8sNamespaceResourceSummary
    
    #endregion

    public static class ListK8sNamespaceResourceSummaryExtensions
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
            this List<K8sNamespaceResourceSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<K8sNamespaceResourceSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<K8sNamespaceResourceSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sNamespaceResourceSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<K8sNamespaceResourceSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types