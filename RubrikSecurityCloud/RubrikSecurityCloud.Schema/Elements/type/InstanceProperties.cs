// InstanceProperties.cs
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
    #region InstanceProperties
    public class InstanceProperties: BaseType
    {
        #region members

        //      C# -> ProcessorType? ProcessorType
        // GraphQL -> processorType: ProcessorType! (enum)
        [JsonProperty("processorType")]
        public ProcessorType? ProcessorType { get; set; }

        //      C# -> VendorType? Vendor
        // GraphQL -> vendor: VendorType! (enum)
        [JsonProperty("vendor")]
        public VendorType? Vendor { get; set; }

        //      C# -> VmType? VmType
        // GraphQL -> vmType: VmType! (enum)
        [JsonProperty("vmType")]
        public VmType? VmType { get; set; }

        //      C# -> System.Int32? CapacityTb
        // GraphQL -> capacityTb: Int! (scalar)
        [JsonProperty("capacityTb")]
        public System.Int32? CapacityTb { get; set; }

        //      C# -> System.Int32? InstanceType
        // GraphQL -> instanceType: Int! (scalar)
        [JsonProperty("instanceType")]
        public System.Int32? InstanceType { get; set; }

        //      C# -> System.Int32? MemoryGib
        // GraphQL -> memoryGib: Int! (scalar)
        [JsonProperty("memoryGib")]
        public System.Int32? MemoryGib { get; set; }

        //      C# -> System.Int32? VcpuCount
        // GraphQL -> vcpuCount: Int! (scalar)
        [JsonProperty("vcpuCount")]
        public System.Int32? VcpuCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "InstanceProperties";
    }

    public InstanceProperties Set(
        ProcessorType? ProcessorType = null,
        VendorType? Vendor = null,
        VmType? VmType = null,
        System.Int32? CapacityTb = null,
        System.Int32? InstanceType = null,
        System.Int32? MemoryGib = null,
        System.Int32? VcpuCount = null
    ) 
    {
        if ( ProcessorType != null ) {
            this.ProcessorType = ProcessorType;
        }
        if ( Vendor != null ) {
            this.Vendor = Vendor;
        }
        if ( VmType != null ) {
            this.VmType = VmType;
        }
        if ( CapacityTb != null ) {
            this.CapacityTb = CapacityTb;
        }
        if ( InstanceType != null ) {
            this.InstanceType = InstanceType;
        }
        if ( MemoryGib != null ) {
            this.MemoryGib = MemoryGib;
        }
        if ( VcpuCount != null ) {
            this.VcpuCount = VcpuCount;
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
        //      C# -> ProcessorType? ProcessorType
        // GraphQL -> processorType: ProcessorType! (enum)
        if (this.ProcessorType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "processorType\n" ;
            } else {
                s += ind + "processorType\n" ;
            }
        }
        //      C# -> VendorType? Vendor
        // GraphQL -> vendor: VendorType! (enum)
        if (this.Vendor != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vendor\n" ;
            } else {
                s += ind + "vendor\n" ;
            }
        }
        //      C# -> VmType? VmType
        // GraphQL -> vmType: VmType! (enum)
        if (this.VmType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmType\n" ;
            } else {
                s += ind + "vmType\n" ;
            }
        }
        //      C# -> System.Int32? CapacityTb
        // GraphQL -> capacityTb: Int! (scalar)
        if (this.CapacityTb != null) {
            if (conf.Flat) {
                s += conf.Prefix + "capacityTb\n" ;
            } else {
                s += ind + "capacityTb\n" ;
            }
        }
        //      C# -> System.Int32? InstanceType
        // GraphQL -> instanceType: Int! (scalar)
        if (this.InstanceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceType\n" ;
            } else {
                s += ind + "instanceType\n" ;
            }
        }
        //      C# -> System.Int32? MemoryGib
        // GraphQL -> memoryGib: Int! (scalar)
        if (this.MemoryGib != null) {
            if (conf.Flat) {
                s += conf.Prefix + "memoryGib\n" ;
            } else {
                s += ind + "memoryGib\n" ;
            }
        }
        //      C# -> System.Int32? VcpuCount
        // GraphQL -> vcpuCount: Int! (scalar)
        if (this.VcpuCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vcpuCount\n" ;
            } else {
                s += ind + "vcpuCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ProcessorType? ProcessorType
        // GraphQL -> processorType: ProcessorType! (enum)
        if (ec.Includes("processorType",true))
        {
            if(this.ProcessorType == null) {

                this.ProcessorType = new ProcessorType();

            } else {


            }
        }
        else if (this.ProcessorType != null && ec.Excludes("processorType",true))
        {
            this.ProcessorType = null;
        }
        //      C# -> VendorType? Vendor
        // GraphQL -> vendor: VendorType! (enum)
        if (ec.Includes("vendor",true))
        {
            if(this.Vendor == null) {

                this.Vendor = new VendorType();

            } else {


            }
        }
        else if (this.Vendor != null && ec.Excludes("vendor",true))
        {
            this.Vendor = null;
        }
        //      C# -> VmType? VmType
        // GraphQL -> vmType: VmType! (enum)
        if (ec.Includes("vmType",true))
        {
            if(this.VmType == null) {

                this.VmType = new VmType();

            } else {


            }
        }
        else if (this.VmType != null && ec.Excludes("vmType",true))
        {
            this.VmType = null;
        }
        //      C# -> System.Int32? CapacityTb
        // GraphQL -> capacityTb: Int! (scalar)
        if (ec.Includes("capacityTb",true))
        {
            if(this.CapacityTb == null) {

                this.CapacityTb = Int32.MinValue;

            } else {


            }
        }
        else if (this.CapacityTb != null && ec.Excludes("capacityTb",true))
        {
            this.CapacityTb = null;
        }
        //      C# -> System.Int32? InstanceType
        // GraphQL -> instanceType: Int! (scalar)
        if (ec.Includes("instanceType",true))
        {
            if(this.InstanceType == null) {

                this.InstanceType = Int32.MinValue;

            } else {


            }
        }
        else if (this.InstanceType != null && ec.Excludes("instanceType",true))
        {
            this.InstanceType = null;
        }
        //      C# -> System.Int32? MemoryGib
        // GraphQL -> memoryGib: Int! (scalar)
        if (ec.Includes("memoryGib",true))
        {
            if(this.MemoryGib == null) {

                this.MemoryGib = Int32.MinValue;

            } else {


            }
        }
        else if (this.MemoryGib != null && ec.Excludes("memoryGib",true))
        {
            this.MemoryGib = null;
        }
        //      C# -> System.Int32? VcpuCount
        // GraphQL -> vcpuCount: Int! (scalar)
        if (ec.Includes("vcpuCount",true))
        {
            if(this.VcpuCount == null) {

                this.VcpuCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.VcpuCount != null && ec.Excludes("vcpuCount",true))
        {
            this.VcpuCount = null;
        }
    }


    #endregion

    } // class InstanceProperties
    
    #endregion

    public static class ListInstancePropertiesExtensions
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
            this List<InstanceProperties> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<InstanceProperties> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<InstanceProperties> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new InstanceProperties());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<InstanceProperties> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types