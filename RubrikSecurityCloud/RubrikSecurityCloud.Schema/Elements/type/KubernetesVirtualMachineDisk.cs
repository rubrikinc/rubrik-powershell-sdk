// KubernetesVirtualMachineDisk.cs
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
    #region KubernetesVirtualMachineDisk
    public class KubernetesVirtualMachineDisk: BaseType
    {
        #region members

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? DiskType
        // GraphQL -> diskType: String (scalar)
        [JsonProperty("diskType")]
        public System.String? DiskType { get; set; }

        //      C# -> System.Boolean? ExcludeFromSnapshots
        // GraphQL -> excludeFromSnapshots: Boolean! (scalar)
        [JsonProperty("excludeFromSnapshots")]
        public System.Boolean? ExcludeFromSnapshots { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.Boolean? IsFullNeeded
        // GraphQL -> isFullNeeded: Boolean! (scalar)
        [JsonProperty("isFullNeeded")]
        public System.Boolean? IsFullNeeded { get; set; }

        //      C# -> System.Boolean? IsThin
        // GraphQL -> isThin: Boolean! (scalar)
        [JsonProperty("isThin")]
        public System.Boolean? IsThin { get; set; }

        //      C# -> System.String? K8sClusterUuid
        // GraphQL -> k8sClusterUuid: UUID! (scalar)
        [JsonProperty("k8sClusterUuid")]
        public System.String? K8sClusterUuid { get; set; }

        //      C# -> System.String? K8sVirtualMachineId
        // GraphQL -> k8sVirtualMachineId: String! (scalar)
        [JsonProperty("k8sVirtualMachineId")]
        public System.String? K8sVirtualMachineId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NamespaceName
        // GraphQL -> namespaceName: String! (scalar)
        [JsonProperty("namespaceName")]
        public System.String? NamespaceName { get; set; }

        //      C# -> System.String? PrimaryClusterUuid
        // GraphQL -> primaryClusterUuid: UUID! (scalar)
        [JsonProperty("primaryClusterUuid")]
        public System.String? PrimaryClusterUuid { get; set; }

        //      C# -> System.String? PvcName
        // GraphQL -> pvcName: String! (scalar)
        [JsonProperty("pvcName")]
        public System.String? PvcName { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "KubernetesVirtualMachineDisk";
    }

    public KubernetesVirtualMachineDisk Set(
        System.String? CdmId = null,
        System.String? ClusterUuid = null,
        System.String? DiskType = null,
        System.Boolean? ExcludeFromSnapshots = null,
        System.String? Id = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsFullNeeded = null,
        System.Boolean? IsThin = null,
        System.String? K8sClusterUuid = null,
        System.String? K8sVirtualMachineId = null,
        System.String? Name = null,
        System.String? NamespaceName = null,
        System.String? PrimaryClusterUuid = null,
        System.String? PvcName = null,
        System.Int64? Size = null
    ) 
    {
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( DiskType != null ) {
            this.DiskType = DiskType;
        }
        if ( ExcludeFromSnapshots != null ) {
            this.ExcludeFromSnapshots = ExcludeFromSnapshots;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( IsFullNeeded != null ) {
            this.IsFullNeeded = IsFullNeeded;
        }
        if ( IsThin != null ) {
            this.IsThin = IsThin;
        }
        if ( K8sClusterUuid != null ) {
            this.K8sClusterUuid = K8sClusterUuid;
        }
        if ( K8sVirtualMachineId != null ) {
            this.K8sVirtualMachineId = K8sVirtualMachineId;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NamespaceName != null ) {
            this.NamespaceName = NamespaceName;
        }
        if ( PrimaryClusterUuid != null ) {
            this.PrimaryClusterUuid = PrimaryClusterUuid;
        }
        if ( PvcName != null ) {
            this.PvcName = PvcName;
        }
        if ( Size != null ) {
            this.Size = Size;
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
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmId\n" ;
            } else {
                s += ind + "cdmId\n" ;
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.String? DiskType
        // GraphQL -> diskType: String (scalar)
        if (this.DiskType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskType\n" ;
            } else {
                s += ind + "diskType\n" ;
            }
        }
        //      C# -> System.Boolean? ExcludeFromSnapshots
        // GraphQL -> excludeFromSnapshots: Boolean! (scalar)
        if (this.ExcludeFromSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "excludeFromSnapshots\n" ;
            } else {
                s += ind + "excludeFromSnapshots\n" ;
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
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchived\n" ;
            } else {
                s += ind + "isArchived\n" ;
            }
        }
        //      C# -> System.Boolean? IsFullNeeded
        // GraphQL -> isFullNeeded: Boolean! (scalar)
        if (this.IsFullNeeded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isFullNeeded\n" ;
            } else {
                s += ind + "isFullNeeded\n" ;
            }
        }
        //      C# -> System.Boolean? IsThin
        // GraphQL -> isThin: Boolean! (scalar)
        if (this.IsThin != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isThin\n" ;
            } else {
                s += ind + "isThin\n" ;
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
        //      C# -> System.String? K8sVirtualMachineId
        // GraphQL -> k8sVirtualMachineId: String! (scalar)
        if (this.K8sVirtualMachineId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "k8sVirtualMachineId\n" ;
            } else {
                s += ind + "k8sVirtualMachineId\n" ;
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
        //      C# -> System.String? NamespaceName
        // GraphQL -> namespaceName: String! (scalar)
        if (this.NamespaceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "namespaceName\n" ;
            } else {
                s += ind + "namespaceName\n" ;
            }
        }
        //      C# -> System.String? PrimaryClusterUuid
        // GraphQL -> primaryClusterUuid: UUID! (scalar)
        if (this.PrimaryClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryClusterUuid\n" ;
            } else {
                s += ind + "primaryClusterUuid\n" ;
            }
        }
        //      C# -> System.String? PvcName
        // GraphQL -> pvcName: String! (scalar)
        if (this.PvcName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pvcName\n" ;
            } else {
                s += ind + "pvcName\n" ;
            }
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        if (this.Size != null) {
            if (conf.Flat) {
                s += conf.Prefix + "size\n" ;
            } else {
                s += ind + "size\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (ec.Includes("cdmId",true))
        {
            if(this.CdmId == null) {

                this.CdmId = "FETCH";

            } else {


            }
        }
        else if (this.CdmId != null && ec.Excludes("cdmId",true))
        {
            this.CdmId = null;
        }
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
        //      C# -> System.String? DiskType
        // GraphQL -> diskType: String (scalar)
        if (ec.Includes("diskType",true))
        {
            if(this.DiskType == null) {

                this.DiskType = "FETCH";

            } else {


            }
        }
        else if (this.DiskType != null && ec.Excludes("diskType",true))
        {
            this.DiskType = null;
        }
        //      C# -> System.Boolean? ExcludeFromSnapshots
        // GraphQL -> excludeFromSnapshots: Boolean! (scalar)
        if (ec.Includes("excludeFromSnapshots",true))
        {
            if(this.ExcludeFromSnapshots == null) {

                this.ExcludeFromSnapshots = true;

            } else {


            }
        }
        else if (this.ExcludeFromSnapshots != null && ec.Excludes("excludeFromSnapshots",true))
        {
            this.ExcludeFromSnapshots = null;
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
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (ec.Includes("isArchived",true))
        {
            if(this.IsArchived == null) {

                this.IsArchived = true;

            } else {


            }
        }
        else if (this.IsArchived != null && ec.Excludes("isArchived",true))
        {
            this.IsArchived = null;
        }
        //      C# -> System.Boolean? IsFullNeeded
        // GraphQL -> isFullNeeded: Boolean! (scalar)
        if (ec.Includes("isFullNeeded",true))
        {
            if(this.IsFullNeeded == null) {

                this.IsFullNeeded = true;

            } else {


            }
        }
        else if (this.IsFullNeeded != null && ec.Excludes("isFullNeeded",true))
        {
            this.IsFullNeeded = null;
        }
        //      C# -> System.Boolean? IsThin
        // GraphQL -> isThin: Boolean! (scalar)
        if (ec.Includes("isThin",true))
        {
            if(this.IsThin == null) {

                this.IsThin = true;

            } else {


            }
        }
        else if (this.IsThin != null && ec.Excludes("isThin",true))
        {
            this.IsThin = null;
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
        //      C# -> System.String? K8sVirtualMachineId
        // GraphQL -> k8sVirtualMachineId: String! (scalar)
        if (ec.Includes("k8sVirtualMachineId",true))
        {
            if(this.K8sVirtualMachineId == null) {

                this.K8sVirtualMachineId = "FETCH";

            } else {


            }
        }
        else if (this.K8sVirtualMachineId != null && ec.Excludes("k8sVirtualMachineId",true))
        {
            this.K8sVirtualMachineId = null;
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
        //      C# -> System.String? NamespaceName
        // GraphQL -> namespaceName: String! (scalar)
        if (ec.Includes("namespaceName",true))
        {
            if(this.NamespaceName == null) {

                this.NamespaceName = "FETCH";

            } else {


            }
        }
        else if (this.NamespaceName != null && ec.Excludes("namespaceName",true))
        {
            this.NamespaceName = null;
        }
        //      C# -> System.String? PrimaryClusterUuid
        // GraphQL -> primaryClusterUuid: UUID! (scalar)
        if (ec.Includes("primaryClusterUuid",true))
        {
            if(this.PrimaryClusterUuid == null) {

                this.PrimaryClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryClusterUuid != null && ec.Excludes("primaryClusterUuid",true))
        {
            this.PrimaryClusterUuid = null;
        }
        //      C# -> System.String? PvcName
        // GraphQL -> pvcName: String! (scalar)
        if (ec.Includes("pvcName",true))
        {
            if(this.PvcName == null) {

                this.PvcName = "FETCH";

            } else {


            }
        }
        else if (this.PvcName != null && ec.Excludes("pvcName",true))
        {
            this.PvcName = null;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        if (ec.Includes("size",true))
        {
            if(this.Size == null) {

                this.Size = new System.Int64();

            } else {


            }
        }
        else if (this.Size != null && ec.Excludes("size",true))
        {
            this.Size = null;
        }
    }


    #endregion

    } // class KubernetesVirtualMachineDisk
    
    #endregion

    public static class ListKubernetesVirtualMachineDiskExtensions
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
            this List<KubernetesVirtualMachineDisk> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<KubernetesVirtualMachineDisk> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<KubernetesVirtualMachineDisk> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new KubernetesVirtualMachineDisk());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<KubernetesVirtualMachineDisk> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types