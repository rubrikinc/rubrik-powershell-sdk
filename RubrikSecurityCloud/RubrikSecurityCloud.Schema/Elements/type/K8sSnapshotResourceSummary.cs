// K8sSnapshotResourceSummary.cs
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
    #region K8sSnapshotResourceSummary
    public class K8sSnapshotResourceSummary: BaseType
    {
        #region members

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> List<K8sResourceTypeCount>? ClusterScoped
        // GraphQL -> clusterScoped: [K8sResourceTypeCount!]! (type)
        [JsonProperty("clusterScoped")]
        public List<K8sResourceTypeCount>? ClusterScoped { get; set; }

        //      C# -> List<K8sNamespaceResourceSummary>? Namespaces
        // GraphQL -> namespaces: [K8sNamespaceResourceSummary!]! (type)
        [JsonProperty("namespaces")]
        public List<K8sNamespaceResourceSummary>? Namespaces { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "K8sSnapshotResourceSummary";
    }

    public K8sSnapshotResourceSummary Set(
        System.String? Version = null,
        List<K8sResourceTypeCount>? ClusterScoped = null,
        List<K8sNamespaceResourceSummary>? Namespaces = null
    ) 
    {
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( ClusterScoped != null ) {
            this.ClusterScoped = ClusterScoped;
        }
        if ( Namespaces != null ) {
            this.Namespaces = Namespaces;
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
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> List<K8sResourceTypeCount>? ClusterScoped
        // GraphQL -> clusterScoped: [K8sResourceTypeCount!]! (type)
        if (this.ClusterScoped != null) {
            var fspec = this.ClusterScoped.AsFieldSpec(conf.Child("clusterScoped"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterScoped" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<K8sNamespaceResourceSummary>? Namespaces
        // GraphQL -> namespaces: [K8sNamespaceResourceSummary!]! (type)
        if (this.Namespaces != null) {
            var fspec = this.Namespaces.AsFieldSpec(conf.Child("namespaces"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "namespaces" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> List<K8sResourceTypeCount>? ClusterScoped
        // GraphQL -> clusterScoped: [K8sResourceTypeCount!]! (type)
        if (ec.Includes("clusterScoped",false))
        {
            if(this.ClusterScoped == null) {

                this.ClusterScoped = new List<K8sResourceTypeCount>();
                this.ClusterScoped.ApplyExploratoryFieldSpec(ec.NewChild("clusterScoped"));

            } else {

                this.ClusterScoped.ApplyExploratoryFieldSpec(ec.NewChild("clusterScoped"));

            }
        }
        else if (this.ClusterScoped != null && ec.Excludes("clusterScoped",false))
        {
            this.ClusterScoped = null;
        }
        //      C# -> List<K8sNamespaceResourceSummary>? Namespaces
        // GraphQL -> namespaces: [K8sNamespaceResourceSummary!]! (type)
        if (ec.Includes("namespaces",false))
        {
            if(this.Namespaces == null) {

                this.Namespaces = new List<K8sNamespaceResourceSummary>();
                this.Namespaces.ApplyExploratoryFieldSpec(ec.NewChild("namespaces"));

            } else {

                this.Namespaces.ApplyExploratoryFieldSpec(ec.NewChild("namespaces"));

            }
        }
        else if (this.Namespaces != null && ec.Excludes("namespaces",false))
        {
            this.Namespaces = null;
        }
    }


    #endregion

    } // class K8sSnapshotResourceSummary
    
    #endregion

    public static class ListK8sSnapshotResourceSummaryExtensions
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
            this List<K8sSnapshotResourceSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<K8sSnapshotResourceSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<K8sSnapshotResourceSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sSnapshotResourceSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<K8sSnapshotResourceSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types