// ComputeClusterDetail.cs
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
    #region ComputeClusterDetail
    public class ComputeClusterDetail: BaseType
    {
        #region members

        //      C# -> System.String? Moid
        // GraphQL -> moid: String! (scalar)
        [JsonProperty("moid")]
        public System.String? Moid { get; set; }

        //      C# -> ComputeClusterSummary? ComputeClusterSummary
        // GraphQL -> computeClusterSummary: ComputeClusterSummary (type)
        [JsonProperty("computeClusterSummary")]
        public ComputeClusterSummary? ComputeClusterSummary { get; set; }

        //      C# -> List<VmwareHostSummary>? Hosts
        // GraphQL -> hosts: [VmwareHostSummary!]! (type)
        [JsonProperty("hosts")]
        public List<VmwareHostSummary>? Hosts { get; set; }

        //      C# -> List<VirtualMachineSummary>? VirtualMachines
        // GraphQL -> virtualMachines: [VirtualMachineSummary!]! (type)
        [JsonProperty("virtualMachines")]
        public List<VirtualMachineSummary>? VirtualMachines { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ComputeClusterDetail";
    }

    public ComputeClusterDetail Set(
        System.String? Moid = null,
        ComputeClusterSummary? ComputeClusterSummary = null,
        List<VmwareHostSummary>? Hosts = null,
        List<VirtualMachineSummary>? VirtualMachines = null
    ) 
    {
        if ( Moid != null ) {
            this.Moid = Moid;
        }
        if ( ComputeClusterSummary != null ) {
            this.ComputeClusterSummary = ComputeClusterSummary;
        }
        if ( Hosts != null ) {
            this.Hosts = Hosts;
        }
        if ( VirtualMachines != null ) {
            this.VirtualMachines = VirtualMachines;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? Moid
        // GraphQL -> moid: String! (scalar)
        if (this.Moid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "moid\n" ;
            } else {
                s += ind + "moid\n" ;
            }
        }
        //      C# -> ComputeClusterSummary? ComputeClusterSummary
        // GraphQL -> computeClusterSummary: ComputeClusterSummary (type)
        if (this.ComputeClusterSummary != null) {
            var fspec = this.ComputeClusterSummary.AsFieldSpec(conf.Child("computeClusterSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "computeClusterSummary {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<VmwareHostSummary>? Hosts
        // GraphQL -> hosts: [VmwareHostSummary!]! (type)
        if (this.Hosts != null) {
            var fspec = this.Hosts.AsFieldSpec(conf.Child("hosts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hosts {\n" + fspec + ind + "}\n" ;
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
                    s += ind + "virtualMachines {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Moid
        // GraphQL -> moid: String! (scalar)
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
        //      C# -> ComputeClusterSummary? ComputeClusterSummary
        // GraphQL -> computeClusterSummary: ComputeClusterSummary (type)
        if (ec.Includes("computeClusterSummary",false))
        {
            if(this.ComputeClusterSummary == null) {

                this.ComputeClusterSummary = new ComputeClusterSummary();
                this.ComputeClusterSummary.ApplyExploratoryFieldSpec(ec.NewChild("computeClusterSummary"));

            } else {

                this.ComputeClusterSummary.ApplyExploratoryFieldSpec(ec.NewChild("computeClusterSummary"));

            }
        }
        else if (this.ComputeClusterSummary != null && ec.Excludes("computeClusterSummary",false))
        {
            this.ComputeClusterSummary = null;
        }
        //      C# -> List<VmwareHostSummary>? Hosts
        // GraphQL -> hosts: [VmwareHostSummary!]! (type)
        if (ec.Includes("hosts",false))
        {
            if(this.Hosts == null) {

                this.Hosts = new List<VmwareHostSummary>();
                this.Hosts.ApplyExploratoryFieldSpec(ec.NewChild("hosts"));

            } else {

                this.Hosts.ApplyExploratoryFieldSpec(ec.NewChild("hosts"));

            }
        }
        else if (this.Hosts != null && ec.Excludes("hosts",false))
        {
            this.Hosts = null;
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
    }


    #endregion

    } // class ComputeClusterDetail
    
    #endregion

    public static class ListComputeClusterDetailExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<ComputeClusterDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ComputeClusterDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ComputeClusterDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ComputeClusterDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ComputeClusterDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types