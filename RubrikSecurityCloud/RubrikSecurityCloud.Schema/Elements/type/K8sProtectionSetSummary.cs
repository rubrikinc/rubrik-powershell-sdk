// K8sProtectionSetSummary.cs
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
    #region K8sProtectionSetSummary
    public class K8sProtectionSetSummary: BaseType
    {
        #region members

        //      C# -> System.String? Definition
        // GraphQL -> definition: String! (scalar)
        [JsonProperty("definition")]
        public System.String? Definition { get; set; }

        //      C# -> List<System.String>? HookConfigs
        // GraphQL -> hookConfigs: [String!]! (scalar)
        [JsonProperty("hookConfigs")]
        public List<System.String>? HookConfigs { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? KubernetesClusterUuid
        // GraphQL -> kubernetesClusterUuid: String! (scalar)
        [JsonProperty("kubernetesClusterUuid")]
        public System.String? KubernetesClusterUuid { get; set; }

        //      C# -> System.String? KubernetesNamespace
        // GraphQL -> kubernetesNamespace: String (scalar)
        [JsonProperty("kubernetesNamespace")]
        public System.String? KubernetesNamespace { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? RsType
        // GraphQL -> rsType: String! (scalar)
        [JsonProperty("rsType")]
        public System.String? RsType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "K8sProtectionSetSummary";
    }

    public K8sProtectionSetSummary Set(
        System.String? Definition = null,
        List<System.String>? HookConfigs = null,
        System.String? Id = null,
        System.String? KubernetesClusterUuid = null,
        System.String? KubernetesNamespace = null,
        System.String? Name = null,
        System.String? RsType = null
    ) 
    {
        if ( Definition != null ) {
            this.Definition = Definition;
        }
        if ( HookConfigs != null ) {
            this.HookConfigs = HookConfigs;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( KubernetesClusterUuid != null ) {
            this.KubernetesClusterUuid = KubernetesClusterUuid;
        }
        if ( KubernetesNamespace != null ) {
            this.KubernetesNamespace = KubernetesNamespace;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( RsType != null ) {
            this.RsType = RsType;
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
        //      C# -> System.String? Definition
        // GraphQL -> definition: String! (scalar)
        if (this.Definition != null) {
            if (conf.Flat) {
                s += conf.Prefix + "definition\n" ;
            } else {
                s += ind + "definition\n" ;
            }
        }
        //      C# -> List<System.String>? HookConfigs
        // GraphQL -> hookConfigs: [String!]! (scalar)
        if (this.HookConfigs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hookConfigs\n" ;
            } else {
                s += ind + "hookConfigs\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? KubernetesClusterUuid
        // GraphQL -> kubernetesClusterUuid: String! (scalar)
        if (this.KubernetesClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kubernetesClusterUuid\n" ;
            } else {
                s += ind + "kubernetesClusterUuid\n" ;
            }
        }
        //      C# -> System.String? KubernetesNamespace
        // GraphQL -> kubernetesNamespace: String (scalar)
        if (this.KubernetesNamespace != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kubernetesNamespace\n" ;
            } else {
                s += ind + "kubernetesNamespace\n" ;
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
        //      C# -> System.String? RsType
        // GraphQL -> rsType: String! (scalar)
        if (this.RsType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rsType\n" ;
            } else {
                s += ind + "rsType\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Definition
        // GraphQL -> definition: String! (scalar)
        if (ec.Includes("definition",true))
        {
            if(this.Definition == null) {

                this.Definition = "FETCH";

            } else {


            }
        }
        else if (this.Definition != null && ec.Excludes("definition",true))
        {
            this.Definition = null;
        }
        //      C# -> List<System.String>? HookConfigs
        // GraphQL -> hookConfigs: [String!]! (scalar)
        if (ec.Includes("hookConfigs",true))
        {
            if(this.HookConfigs == null) {

                this.HookConfigs = new List<System.String>();

            } else {


            }
        }
        else if (this.HookConfigs != null && ec.Excludes("hookConfigs",true))
        {
            this.HookConfigs = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? KubernetesClusterUuid
        // GraphQL -> kubernetesClusterUuid: String! (scalar)
        if (ec.Includes("kubernetesClusterUuid",true))
        {
            if(this.KubernetesClusterUuid == null) {

                this.KubernetesClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.KubernetesClusterUuid != null && ec.Excludes("kubernetesClusterUuid",true))
        {
            this.KubernetesClusterUuid = null;
        }
        //      C# -> System.String? KubernetesNamespace
        // GraphQL -> kubernetesNamespace: String (scalar)
        if (ec.Includes("kubernetesNamespace",true))
        {
            if(this.KubernetesNamespace == null) {

                this.KubernetesNamespace = "FETCH";

            } else {


            }
        }
        else if (this.KubernetesNamespace != null && ec.Excludes("kubernetesNamespace",true))
        {
            this.KubernetesNamespace = null;
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
        //      C# -> System.String? RsType
        // GraphQL -> rsType: String! (scalar)
        if (ec.Includes("rsType",true))
        {
            if(this.RsType == null) {

                this.RsType = "FETCH";

            } else {


            }
        }
        else if (this.RsType != null && ec.Excludes("rsType",true))
        {
            this.RsType = null;
        }
    }


    #endregion

    } // class K8sProtectionSetSummary
    
    #endregion

    public static class ListK8sProtectionSetSummaryExtensions
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
            this List<K8sProtectionSetSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<K8sProtectionSetSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<K8sProtectionSetSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sProtectionSetSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<K8sProtectionSetSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types