// WorkloadSpecificResourceSpec.cs
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
    #region WorkloadSpecificResourceSpec
    public class WorkloadSpecificResourceSpec: BaseType
    {
        #region members

        //      C# -> AwsEc2InstanceResourceSpec? AwsNativeEc2Instance
        // GraphQL -> awsNativeEc2Instance: AwsEc2InstanceResourceSpec (type)
        [JsonProperty("awsNativeEc2Instance")]
        public AwsEc2InstanceResourceSpec? AwsNativeEc2Instance { get; set; }

        //      C# -> AwsRdsInstanceResourceSpec? AwsNativeRdsInstance
        // GraphQL -> awsNativeRdsInstance: AwsRdsInstanceResourceSpec (type)
        [JsonProperty("awsNativeRdsInstance")]
        public AwsRdsInstanceResourceSpec? AwsNativeRdsInstance { get; set; }

        //      C# -> AzureNativeVirtualMachineResourceSpec? AzureNativeVm
        // GraphQL -> azureNativeVm: AzureNativeVirtualMachineResourceSpec (type)
        [JsonProperty("azureNativeVm")]
        public AzureNativeVirtualMachineResourceSpec? AzureNativeVm { get; set; }

        //      C# -> NutanixVirtualMachineResourceSpec? NutanixVm
        // GraphQL -> nutanixVm: NutanixVirtualMachineResourceSpec (type)
        [JsonProperty("nutanixVm")]
        public NutanixVirtualMachineResourceSpec? NutanixVm { get; set; }

        //      C# -> VmwareVirtualMachineResourceSpec? VmwareVm
        // GraphQL -> vmwareVm: VmwareVirtualMachineResourceSpec (type)
        [JsonProperty("vmwareVm")]
        public VmwareVirtualMachineResourceSpec? VmwareVm { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WorkloadSpecificResourceSpec";
    }

    public WorkloadSpecificResourceSpec Set(
        AwsEc2InstanceResourceSpec? AwsNativeEc2Instance = null,
        AwsRdsInstanceResourceSpec? AwsNativeRdsInstance = null,
        AzureNativeVirtualMachineResourceSpec? AzureNativeVm = null,
        NutanixVirtualMachineResourceSpec? NutanixVm = null,
        VmwareVirtualMachineResourceSpec? VmwareVm = null
    ) 
    {
        if ( AwsNativeEc2Instance != null ) {
            this.AwsNativeEc2Instance = AwsNativeEc2Instance;
        }
        if ( AwsNativeRdsInstance != null ) {
            this.AwsNativeRdsInstance = AwsNativeRdsInstance;
        }
        if ( AzureNativeVm != null ) {
            this.AzureNativeVm = AzureNativeVm;
        }
        if ( NutanixVm != null ) {
            this.NutanixVm = NutanixVm;
        }
        if ( VmwareVm != null ) {
            this.VmwareVm = VmwareVm;
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
        //      C# -> AwsEc2InstanceResourceSpec? AwsNativeEc2Instance
        // GraphQL -> awsNativeEc2Instance: AwsEc2InstanceResourceSpec (type)
        if (this.AwsNativeEc2Instance != null) {
            var fspec = this.AwsNativeEc2Instance.AsFieldSpec(conf.Child("awsNativeEc2Instance"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsNativeEc2Instance" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AwsRdsInstanceResourceSpec? AwsNativeRdsInstance
        // GraphQL -> awsNativeRdsInstance: AwsRdsInstanceResourceSpec (type)
        if (this.AwsNativeRdsInstance != null) {
            var fspec = this.AwsNativeRdsInstance.AsFieldSpec(conf.Child("awsNativeRdsInstance"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsNativeRdsInstance" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureNativeVirtualMachineResourceSpec? AzureNativeVm
        // GraphQL -> azureNativeVm: AzureNativeVirtualMachineResourceSpec (type)
        if (this.AzureNativeVm != null) {
            var fspec = this.AzureNativeVm.AsFieldSpec(conf.Child("azureNativeVm"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureNativeVm" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NutanixVirtualMachineResourceSpec? NutanixVm
        // GraphQL -> nutanixVm: NutanixVirtualMachineResourceSpec (type)
        if (this.NutanixVm != null) {
            var fspec = this.NutanixVm.AsFieldSpec(conf.Child("nutanixVm"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nutanixVm" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VmwareVirtualMachineResourceSpec? VmwareVm
        // GraphQL -> vmwareVm: VmwareVirtualMachineResourceSpec (type)
        if (this.VmwareVm != null) {
            var fspec = this.VmwareVm.AsFieldSpec(conf.Child("vmwareVm"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vmwareVm" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AwsEc2InstanceResourceSpec? AwsNativeEc2Instance
        // GraphQL -> awsNativeEc2Instance: AwsEc2InstanceResourceSpec (type)
        if (ec.Includes("awsNativeEc2Instance",false))
        {
            if(this.AwsNativeEc2Instance == null) {

                this.AwsNativeEc2Instance = new AwsEc2InstanceResourceSpec();
                this.AwsNativeEc2Instance.ApplyExploratoryFieldSpec(ec.NewChild("awsNativeEc2Instance"));

            } else {

                this.AwsNativeEc2Instance.ApplyExploratoryFieldSpec(ec.NewChild("awsNativeEc2Instance"));

            }
        }
        else if (this.AwsNativeEc2Instance != null && ec.Excludes("awsNativeEc2Instance",false))
        {
            this.AwsNativeEc2Instance = null;
        }
        //      C# -> AwsRdsInstanceResourceSpec? AwsNativeRdsInstance
        // GraphQL -> awsNativeRdsInstance: AwsRdsInstanceResourceSpec (type)
        if (ec.Includes("awsNativeRdsInstance",false))
        {
            if(this.AwsNativeRdsInstance == null) {

                this.AwsNativeRdsInstance = new AwsRdsInstanceResourceSpec();
                this.AwsNativeRdsInstance.ApplyExploratoryFieldSpec(ec.NewChild("awsNativeRdsInstance"));

            } else {

                this.AwsNativeRdsInstance.ApplyExploratoryFieldSpec(ec.NewChild("awsNativeRdsInstance"));

            }
        }
        else if (this.AwsNativeRdsInstance != null && ec.Excludes("awsNativeRdsInstance",false))
        {
            this.AwsNativeRdsInstance = null;
        }
        //      C# -> AzureNativeVirtualMachineResourceSpec? AzureNativeVm
        // GraphQL -> azureNativeVm: AzureNativeVirtualMachineResourceSpec (type)
        if (ec.Includes("azureNativeVm",false))
        {
            if(this.AzureNativeVm == null) {

                this.AzureNativeVm = new AzureNativeVirtualMachineResourceSpec();
                this.AzureNativeVm.ApplyExploratoryFieldSpec(ec.NewChild("azureNativeVm"));

            } else {

                this.AzureNativeVm.ApplyExploratoryFieldSpec(ec.NewChild("azureNativeVm"));

            }
        }
        else if (this.AzureNativeVm != null && ec.Excludes("azureNativeVm",false))
        {
            this.AzureNativeVm = null;
        }
        //      C# -> NutanixVirtualMachineResourceSpec? NutanixVm
        // GraphQL -> nutanixVm: NutanixVirtualMachineResourceSpec (type)
        if (ec.Includes("nutanixVm",false))
        {
            if(this.NutanixVm == null) {

                this.NutanixVm = new NutanixVirtualMachineResourceSpec();
                this.NutanixVm.ApplyExploratoryFieldSpec(ec.NewChild("nutanixVm"));

            } else {

                this.NutanixVm.ApplyExploratoryFieldSpec(ec.NewChild("nutanixVm"));

            }
        }
        else if (this.NutanixVm != null && ec.Excludes("nutanixVm",false))
        {
            this.NutanixVm = null;
        }
        //      C# -> VmwareVirtualMachineResourceSpec? VmwareVm
        // GraphQL -> vmwareVm: VmwareVirtualMachineResourceSpec (type)
        if (ec.Includes("vmwareVm",false))
        {
            if(this.VmwareVm == null) {

                this.VmwareVm = new VmwareVirtualMachineResourceSpec();
                this.VmwareVm.ApplyExploratoryFieldSpec(ec.NewChild("vmwareVm"));

            } else {

                this.VmwareVm.ApplyExploratoryFieldSpec(ec.NewChild("vmwareVm"));

            }
        }
        else if (this.VmwareVm != null && ec.Excludes("vmwareVm",false))
        {
            this.VmwareVm = null;
        }
    }


    #endregion

    } // class WorkloadSpecificResourceSpec
    
    #endregion

    public static class ListWorkloadSpecificResourceSpecExtensions
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
            this List<WorkloadSpecificResourceSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<WorkloadSpecificResourceSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadSpecificResourceSpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadSpecificResourceSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WorkloadSpecificResourceSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types