// VmwareHostDetail.cs
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
    #region VmwareHostDetail
    public class VmwareHostDetail: BaseType
    {
        #region members

        //      C# -> System.String? ComputeClusterId
        // GraphQL -> computeClusterId: String (scalar)
        [JsonProperty("computeClusterId")]
        public System.String? ComputeClusterId { get; set; }

        //      C# -> System.String? Moid
        // GraphQL -> moid: String (scalar)
        [JsonProperty("moid")]
        public System.String? Moid { get; set; }

        //      C# -> DataCenterSummary? Datacenter
        // GraphQL -> datacenter: DataCenterSummary (type)
        [JsonProperty("datacenter")]
        public DataCenterSummary? Datacenter { get; set; }

        //      C# -> List<DataStoreSummary>? Datastores
        // GraphQL -> datastores: [DataStoreSummary!]! (type)
        [JsonProperty("datastores")]
        public List<DataStoreSummary>? Datastores { get; set; }

        //      C# -> List<VirtualMachineSummary>? VirtualMachines
        // GraphQL -> virtualMachines: [VirtualMachineSummary!]! (type)
        [JsonProperty("virtualMachines")]
        public List<VirtualMachineSummary>? VirtualMachines { get; set; }

        //      C# -> VmwareHostSummary? VmwareHostSummary
        // GraphQL -> vmwareHostSummary: VmwareHostSummary (type)
        [JsonProperty("vmwareHostSummary")]
        public VmwareHostSummary? VmwareHostSummary { get; set; }

        //      C# -> VmwareHostUpdate? VmwareHostUpdate
        // GraphQL -> vmwareHostUpdate: VmwareHostUpdate (type)
        [JsonProperty("vmwareHostUpdate")]
        public VmwareHostUpdate? VmwareHostUpdate { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmwareHostDetail";
    }

    public VmwareHostDetail Set(
        System.String? ComputeClusterId = null,
        System.String? Moid = null,
        DataCenterSummary? Datacenter = null,
        List<DataStoreSummary>? Datastores = null,
        List<VirtualMachineSummary>? VirtualMachines = null,
        VmwareHostSummary? VmwareHostSummary = null,
        VmwareHostUpdate? VmwareHostUpdate = null
    ) 
    {
        if ( ComputeClusterId != null ) {
            this.ComputeClusterId = ComputeClusterId;
        }
        if ( Moid != null ) {
            this.Moid = Moid;
        }
        if ( Datacenter != null ) {
            this.Datacenter = Datacenter;
        }
        if ( Datastores != null ) {
            this.Datastores = Datastores;
        }
        if ( VirtualMachines != null ) {
            this.VirtualMachines = VirtualMachines;
        }
        if ( VmwareHostSummary != null ) {
            this.VmwareHostSummary = VmwareHostSummary;
        }
        if ( VmwareHostUpdate != null ) {
            this.VmwareHostUpdate = VmwareHostUpdate;
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
        //      C# -> System.String? ComputeClusterId
        // GraphQL -> computeClusterId: String (scalar)
        if (this.ComputeClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "computeClusterId\n" ;
            } else {
                s += ind + "computeClusterId\n" ;
            }
        }
        //      C# -> System.String? Moid
        // GraphQL -> moid: String (scalar)
        if (this.Moid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "moid\n" ;
            } else {
                s += ind + "moid\n" ;
            }
        }
        //      C# -> DataCenterSummary? Datacenter
        // GraphQL -> datacenter: DataCenterSummary (type)
        if (this.Datacenter != null) {
            var fspec = this.Datacenter.AsFieldSpec(conf.Child("datacenter"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "datacenter" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<DataStoreSummary>? Datastores
        // GraphQL -> datastores: [DataStoreSummary!]! (type)
        if (this.Datastores != null) {
            var fspec = this.Datastores.AsFieldSpec(conf.Child("datastores"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "datastores" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<VirtualMachineSummary>? VirtualMachines
        // GraphQL -> virtualMachines: [VirtualMachineSummary!]! (type)
        if (this.VirtualMachines != null) {
            var fspec = this.VirtualMachines.AsFieldSpec(conf.Child("virtualMachines"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "virtualMachines" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VmwareHostSummary? VmwareHostSummary
        // GraphQL -> vmwareHostSummary: VmwareHostSummary (type)
        if (this.VmwareHostSummary != null) {
            var fspec = this.VmwareHostSummary.AsFieldSpec(conf.Child("vmwareHostSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vmwareHostSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VmwareHostUpdate? VmwareHostUpdate
        // GraphQL -> vmwareHostUpdate: VmwareHostUpdate (type)
        if (this.VmwareHostUpdate != null) {
            var fspec = this.VmwareHostUpdate.AsFieldSpec(conf.Child("vmwareHostUpdate"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vmwareHostUpdate" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ComputeClusterId
        // GraphQL -> computeClusterId: String (scalar)
        if (ec.Includes("computeClusterId",true))
        {
            if(this.ComputeClusterId == null) {

                this.ComputeClusterId = "FETCH";

            } else {


            }
        }
        else if (this.ComputeClusterId != null && ec.Excludes("computeClusterId",true))
        {
            this.ComputeClusterId = null;
        }
        //      C# -> System.String? Moid
        // GraphQL -> moid: String (scalar)
        if (ec.Includes("moid",true))
        {
            if(this.Moid == null) {

                this.Moid = "FETCH";

            } else {


            }
        }
        else if (this.Moid != null && ec.Excludes("moid",true))
        {
            this.Moid = null;
        }
        //      C# -> DataCenterSummary? Datacenter
        // GraphQL -> datacenter: DataCenterSummary (type)
        if (ec.Includes("datacenter",false))
        {
            if(this.Datacenter == null) {

                this.Datacenter = new DataCenterSummary();
                this.Datacenter.ApplyExploratoryFieldSpec(ec.NewChild("datacenter"));

            } else {

                this.Datacenter.ApplyExploratoryFieldSpec(ec.NewChild("datacenter"));

            }
        }
        else if (this.Datacenter != null && ec.Excludes("datacenter",false))
        {
            this.Datacenter = null;
        }
        //      C# -> List<DataStoreSummary>? Datastores
        // GraphQL -> datastores: [DataStoreSummary!]! (type)
        if (ec.Includes("datastores",false))
        {
            if(this.Datastores == null) {

                this.Datastores = new List<DataStoreSummary>();
                this.Datastores.ApplyExploratoryFieldSpec(ec.NewChild("datastores"));

            } else {

                this.Datastores.ApplyExploratoryFieldSpec(ec.NewChild("datastores"));

            }
        }
        else if (this.Datastores != null && ec.Excludes("datastores",false))
        {
            this.Datastores = null;
        }
        //      C# -> List<VirtualMachineSummary>? VirtualMachines
        // GraphQL -> virtualMachines: [VirtualMachineSummary!]! (type)
        if (ec.Includes("virtualMachines",false))
        {
            if(this.VirtualMachines == null) {

                this.VirtualMachines = new List<VirtualMachineSummary>();
                this.VirtualMachines.ApplyExploratoryFieldSpec(ec.NewChild("virtualMachines"));

            } else {

                this.VirtualMachines.ApplyExploratoryFieldSpec(ec.NewChild("virtualMachines"));

            }
        }
        else if (this.VirtualMachines != null && ec.Excludes("virtualMachines",false))
        {
            this.VirtualMachines = null;
        }
        //      C# -> VmwareHostSummary? VmwareHostSummary
        // GraphQL -> vmwareHostSummary: VmwareHostSummary (type)
        if (ec.Includes("vmwareHostSummary",false))
        {
            if(this.VmwareHostSummary == null) {

                this.VmwareHostSummary = new VmwareHostSummary();
                this.VmwareHostSummary.ApplyExploratoryFieldSpec(ec.NewChild("vmwareHostSummary"));

            } else {

                this.VmwareHostSummary.ApplyExploratoryFieldSpec(ec.NewChild("vmwareHostSummary"));

            }
        }
        else if (this.VmwareHostSummary != null && ec.Excludes("vmwareHostSummary",false))
        {
            this.VmwareHostSummary = null;
        }
        //      C# -> VmwareHostUpdate? VmwareHostUpdate
        // GraphQL -> vmwareHostUpdate: VmwareHostUpdate (type)
        if (ec.Includes("vmwareHostUpdate",false))
        {
            if(this.VmwareHostUpdate == null) {

                this.VmwareHostUpdate = new VmwareHostUpdate();
                this.VmwareHostUpdate.ApplyExploratoryFieldSpec(ec.NewChild("vmwareHostUpdate"));

            } else {

                this.VmwareHostUpdate.ApplyExploratoryFieldSpec(ec.NewChild("vmwareHostUpdate"));

            }
        }
        else if (this.VmwareHostUpdate != null && ec.Excludes("vmwareHostUpdate",false))
        {
            this.VmwareHostUpdate = null;
        }
    }


    #endregion

    } // class VmwareHostDetail
    
    #endregion

    public static class ListVmwareHostDetailExtensions
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
            this List<VmwareHostDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VmwareHostDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmwareHostDetail> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareHostDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmwareHostDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types