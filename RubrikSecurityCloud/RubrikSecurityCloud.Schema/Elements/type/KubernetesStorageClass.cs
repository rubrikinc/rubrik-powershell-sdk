// KubernetesStorageClass.cs
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
    #region KubernetesStorageClass
    public class KubernetesStorageClass: BaseType
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? K8sClusterUuid
        // GraphQL -> k8sClusterUuid: UUID! (scalar)
        [JsonProperty("k8sClusterUuid")]
        public System.String? K8sClusterUuid { get; set; }

        //      C# -> System.String? Provisioner
        // GraphQL -> provisioner: String (scalar)
        [JsonProperty("provisioner")]
        public System.String? Provisioner { get; set; }

        //      C# -> System.String? StorageClassName
        // GraphQL -> storageClassName: String (scalar)
        [JsonProperty("storageClassName")]
        public System.String? StorageClassName { get; set; }

        //      C# -> System.String? Yaml
        // GraphQL -> yaml: String (scalar)
        [JsonProperty("yaml")]
        public System.String? Yaml { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "KubernetesStorageClass";
    }

    public KubernetesStorageClass Set(
        System.String? ClusterUuid = null,
        System.String? Fid = null,
        System.String? Id = null,
        System.String? K8sClusterUuid = null,
        System.String? Provisioner = null,
        System.String? StorageClassName = null,
        System.String? Yaml = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( K8sClusterUuid != null ) {
            this.K8sClusterUuid = K8sClusterUuid;
        }
        if ( Provisioner != null ) {
            this.Provisioner = Provisioner;
        }
        if ( StorageClassName != null ) {
            this.StorageClassName = StorageClassName;
        }
        if ( Yaml != null ) {
            this.Yaml = Yaml;
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
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (this.Fid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fid\n" ;
            } else {
                s += ind + "fid\n" ;
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
        //      C# -> System.String? K8sClusterUuid
        // GraphQL -> k8sClusterUuid: UUID! (scalar)
        if (this.K8sClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "k8sClusterUuid\n" ;
            } else {
                s += ind + "k8sClusterUuid\n" ;
            }
        }
        //      C# -> System.String? Provisioner
        // GraphQL -> provisioner: String (scalar)
        if (this.Provisioner != null) {
            if (conf.Flat) {
                s += conf.Prefix + "provisioner\n" ;
            } else {
                s += ind + "provisioner\n" ;
            }
        }
        //      C# -> System.String? StorageClassName
        // GraphQL -> storageClassName: String (scalar)
        if (this.StorageClassName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageClassName\n" ;
            } else {
                s += ind + "storageClassName\n" ;
            }
        }
        //      C# -> System.String? Yaml
        // GraphQL -> yaml: String (scalar)
        if (this.Yaml != null) {
            if (conf.Flat) {
                s += conf.Prefix + "yaml\n" ;
            } else {
                s += ind + "yaml\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (ec.Includes("fid",true))
        {
            if(this.Fid == null) {

                this.Fid = "FETCH";

            } else {


            }
        }
        else if (this.Fid != null && ec.Excludes("fid",true))
        {
            this.Fid = null;
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
        //      C# -> System.String? K8sClusterUuid
        // GraphQL -> k8sClusterUuid: UUID! (scalar)
        if (ec.Includes("k8sClusterUuid",true))
        {
            if(this.K8sClusterUuid == null) {

                this.K8sClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.K8sClusterUuid != null && ec.Excludes("k8sClusterUuid",true))
        {
            this.K8sClusterUuid = null;
        }
        //      C# -> System.String? Provisioner
        // GraphQL -> provisioner: String (scalar)
        if (ec.Includes("provisioner",true))
        {
            if(this.Provisioner == null) {

                this.Provisioner = "FETCH";

            } else {


            }
        }
        else if (this.Provisioner != null && ec.Excludes("provisioner",true))
        {
            this.Provisioner = null;
        }
        //      C# -> System.String? StorageClassName
        // GraphQL -> storageClassName: String (scalar)
        if (ec.Includes("storageClassName",true))
        {
            if(this.StorageClassName == null) {

                this.StorageClassName = "FETCH";

            } else {


            }
        }
        else if (this.StorageClassName != null && ec.Excludes("storageClassName",true))
        {
            this.StorageClassName = null;
        }
        //      C# -> System.String? Yaml
        // GraphQL -> yaml: String (scalar)
        if (ec.Includes("yaml",true))
        {
            if(this.Yaml == null) {

                this.Yaml = "FETCH";

            } else {


            }
        }
        else if (this.Yaml != null && ec.Excludes("yaml",true))
        {
            this.Yaml = null;
        }
    }


    #endregion

    } // class KubernetesStorageClass
    
    #endregion

    public static class ListKubernetesStorageClassExtensions
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
            this List<KubernetesStorageClass> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<KubernetesStorageClass> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<KubernetesStorageClass> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new KubernetesStorageClass());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<KubernetesStorageClass> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types