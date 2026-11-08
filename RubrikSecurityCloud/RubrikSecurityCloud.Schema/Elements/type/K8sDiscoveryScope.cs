// K8sDiscoveryScope.cs
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
    #region K8sDiscoveryScope
    public class K8sDiscoveryScope: BaseType
    {
        #region members

        //      C# -> List<System.String>? Namespaces
        // GraphQL -> namespaces: [String!]! (scalar)
        [JsonProperty("namespaces")]
        public List<System.String>? Namespaces { get; set; }

        //      C# -> List<K8sLabelSelector>? LabelSelectors
        // GraphQL -> labelSelectors: [K8sLabelSelector!]! (type)
        [JsonProperty("labelSelectors")]
        public List<K8sLabelSelector>? LabelSelectors { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "K8sDiscoveryScope";
    }

    public K8sDiscoveryScope Set(
        List<System.String>? Namespaces = null,
        List<K8sLabelSelector>? LabelSelectors = null
    ) 
    {
        if ( Namespaces != null ) {
            this.Namespaces = Namespaces;
        }
        if ( LabelSelectors != null ) {
            this.LabelSelectors = LabelSelectors;
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
        //      C# -> List<System.String>? Namespaces
        // GraphQL -> namespaces: [String!]! (scalar)
        if (this.Namespaces != null) {
            if (conf.Flat) {
                s += conf.Prefix + "namespaces\n" ;
            } else {
                s += ind + "namespaces\n" ;
            }
        }
        //      C# -> List<K8sLabelSelector>? LabelSelectors
        // GraphQL -> labelSelectors: [K8sLabelSelector!]! (type)
        if (this.LabelSelectors != null) {
            var fspec = this.LabelSelectors.AsFieldSpec(conf.Child("labelSelectors"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "labelSelectors" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? Namespaces
        // GraphQL -> namespaces: [String!]! (scalar)
        if (ec.Includes("namespaces",true))
        {
            if(this.Namespaces == null) {

                this.Namespaces = new List<System.String>();

            } else {


            }
        }
        else if (this.Namespaces != null && ec.Excludes("namespaces",true))
        {
            this.Namespaces = null;
        }
        //      C# -> List<K8sLabelSelector>? LabelSelectors
        // GraphQL -> labelSelectors: [K8sLabelSelector!]! (type)
        if (ec.Includes("labelSelectors",false))
        {
            if(this.LabelSelectors == null) {

                this.LabelSelectors = new List<K8sLabelSelector>();
                this.LabelSelectors.ApplyExploratoryFieldSpec(ec.NewChild("labelSelectors"));

            } else {

                this.LabelSelectors.ApplyExploratoryFieldSpec(ec.NewChild("labelSelectors"));

            }
        }
        else if (this.LabelSelectors != null && ec.Excludes("labelSelectors",false))
        {
            this.LabelSelectors = null;
        }
    }


    #endregion

    } // class K8sDiscoveryScope
    
    #endregion

    public static class ListK8sDiscoveryScopeExtensions
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
            this List<K8sDiscoveryScope> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<K8sDiscoveryScope> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<K8sDiscoveryScope> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sDiscoveryScope());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<K8sDiscoveryScope> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types