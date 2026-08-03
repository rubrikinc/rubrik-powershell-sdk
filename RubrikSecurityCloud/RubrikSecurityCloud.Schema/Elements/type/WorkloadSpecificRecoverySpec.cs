// WorkloadSpecificRecoverySpec.cs
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
    #region WorkloadSpecificRecoverySpec
    public class WorkloadSpecificRecoverySpec: BaseType
    {
        #region members

        //      C# -> AddcRecoverySpec? Addc
        // GraphQL -> addc: AddcRecoverySpec (type)
        [JsonProperty("addc")]
        public AddcRecoverySpec? Addc { get; set; }

        //      C# -> AdfrRecoverySpec? Adfr
        // GraphQL -> adfr: AdfrRecoverySpec (type)
        [JsonProperty("adfr")]
        public AdfrRecoverySpec? Adfr { get; set; }

        //      C# -> AwsEc2InstanceRecoverySpec? AwsEc2Instance
        // GraphQL -> awsEc2Instance: AwsEc2InstanceRecoverySpec (type)
        [JsonProperty("awsEc2Instance")]
        public AwsEc2InstanceRecoverySpec? AwsEc2Instance { get; set; }

        //      C# -> AwsRdsInstanceRecoverySpec? AwsRdsInstance
        // GraphQL -> awsRdsInstance: AwsRdsInstanceRecoverySpec (type)
        [JsonProperty("awsRdsInstance")]
        public AwsRdsInstanceRecoverySpec? AwsRdsInstance { get; set; }

        //      C# -> AzureNativeVmRecoverySpec? AzureVm
        // GraphQL -> azureVm: AzureNativeVmRecoverySpec (type)
        [JsonProperty("azureVm")]
        public AzureNativeVmRecoverySpec? AzureVm { get; set; }

        //      C# -> NutanixVmRecoverySpec? NutanixVm
        // GraphQL -> nutanixVm: NutanixVmRecoverySpec (type)
        [JsonProperty("nutanixVm")]
        public NutanixVmRecoverySpec? NutanixVm { get; set; }

        //      C# -> VsphereVmRecoverySpec? VmwareVm
        // GraphQL -> vmwareVm: VsphereVmRecoverySpec (type)
        [JsonProperty("vmwareVm")]
        public VsphereVmRecoverySpec? VmwareVm { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WorkloadSpecificRecoverySpec";
    }

    public WorkloadSpecificRecoverySpec Set(
        AddcRecoverySpec? Addc = null,
        AdfrRecoverySpec? Adfr = null,
        AwsEc2InstanceRecoverySpec? AwsEc2Instance = null,
        AwsRdsInstanceRecoverySpec? AwsRdsInstance = null,
        AzureNativeVmRecoverySpec? AzureVm = null,
        NutanixVmRecoverySpec? NutanixVm = null,
        VsphereVmRecoverySpec? VmwareVm = null
    ) 
    {
        if ( Addc != null ) {
            this.Addc = Addc;
        }
        if ( Adfr != null ) {
            this.Adfr = Adfr;
        }
        if ( AwsEc2Instance != null ) {
            this.AwsEc2Instance = AwsEc2Instance;
        }
        if ( AwsRdsInstance != null ) {
            this.AwsRdsInstance = AwsRdsInstance;
        }
        if ( AzureVm != null ) {
            this.AzureVm = AzureVm;
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
        //      C# -> AddcRecoverySpec? Addc
        // GraphQL -> addc: AddcRecoverySpec (type)
        if (this.Addc != null) {
            var fspec = this.Addc.AsFieldSpec(conf.Child("addc"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "addc" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AdfrRecoverySpec? Adfr
        // GraphQL -> adfr: AdfrRecoverySpec (type)
        if (this.Adfr != null) {
            var fspec = this.Adfr.AsFieldSpec(conf.Child("adfr"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "adfr" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AwsEc2InstanceRecoverySpec? AwsEc2Instance
        // GraphQL -> awsEc2Instance: AwsEc2InstanceRecoverySpec (type)
        if (this.AwsEc2Instance != null) {
            var fspec = this.AwsEc2Instance.AsFieldSpec(conf.Child("awsEc2Instance"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsEc2Instance" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AwsRdsInstanceRecoverySpec? AwsRdsInstance
        // GraphQL -> awsRdsInstance: AwsRdsInstanceRecoverySpec (type)
        if (this.AwsRdsInstance != null) {
            var fspec = this.AwsRdsInstance.AsFieldSpec(conf.Child("awsRdsInstance"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsRdsInstance" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureNativeVmRecoverySpec? AzureVm
        // GraphQL -> azureVm: AzureNativeVmRecoverySpec (type)
        if (this.AzureVm != null) {
            var fspec = this.AzureVm.AsFieldSpec(conf.Child("azureVm"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureVm" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NutanixVmRecoverySpec? NutanixVm
        // GraphQL -> nutanixVm: NutanixVmRecoverySpec (type)
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
        //      C# -> VsphereVmRecoverySpec? VmwareVm
        // GraphQL -> vmwareVm: VsphereVmRecoverySpec (type)
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
        //      C# -> AddcRecoverySpec? Addc
        // GraphQL -> addc: AddcRecoverySpec (type)
        if (ec.Includes("addc",false))
        {
            if(this.Addc == null) {

                this.Addc = new AddcRecoverySpec();
                this.Addc.ApplyExploratoryFieldSpec(ec.NewChild("addc"));

            } else {

                this.Addc.ApplyExploratoryFieldSpec(ec.NewChild("addc"));

            }
        }
        else if (this.Addc != null && ec.Excludes("addc",false))
        {
            this.Addc = null;
        }
        //      C# -> AdfrRecoverySpec? Adfr
        // GraphQL -> adfr: AdfrRecoverySpec (type)
        if (ec.Includes("adfr",false))
        {
            if(this.Adfr == null) {

                this.Adfr = new AdfrRecoverySpec();
                this.Adfr.ApplyExploratoryFieldSpec(ec.NewChild("adfr"));

            } else {

                this.Adfr.ApplyExploratoryFieldSpec(ec.NewChild("adfr"));

            }
        }
        else if (this.Adfr != null && ec.Excludes("adfr",false))
        {
            this.Adfr = null;
        }
        //      C# -> AwsEc2InstanceRecoverySpec? AwsEc2Instance
        // GraphQL -> awsEc2Instance: AwsEc2InstanceRecoverySpec (type)
        if (ec.Includes("awsEc2Instance",false))
        {
            if(this.AwsEc2Instance == null) {

                this.AwsEc2Instance = new AwsEc2InstanceRecoverySpec();
                this.AwsEc2Instance.ApplyExploratoryFieldSpec(ec.NewChild("awsEc2Instance"));

            } else {

                this.AwsEc2Instance.ApplyExploratoryFieldSpec(ec.NewChild("awsEc2Instance"));

            }
        }
        else if (this.AwsEc2Instance != null && ec.Excludes("awsEc2Instance",false))
        {
            this.AwsEc2Instance = null;
        }
        //      C# -> AwsRdsInstanceRecoverySpec? AwsRdsInstance
        // GraphQL -> awsRdsInstance: AwsRdsInstanceRecoverySpec (type)
        if (ec.Includes("awsRdsInstance",false))
        {
            if(this.AwsRdsInstance == null) {

                this.AwsRdsInstance = new AwsRdsInstanceRecoverySpec();
                this.AwsRdsInstance.ApplyExploratoryFieldSpec(ec.NewChild("awsRdsInstance"));

            } else {

                this.AwsRdsInstance.ApplyExploratoryFieldSpec(ec.NewChild("awsRdsInstance"));

            }
        }
        else if (this.AwsRdsInstance != null && ec.Excludes("awsRdsInstance",false))
        {
            this.AwsRdsInstance = null;
        }
        //      C# -> AzureNativeVmRecoverySpec? AzureVm
        // GraphQL -> azureVm: AzureNativeVmRecoverySpec (type)
        if (ec.Includes("azureVm",false))
        {
            if(this.AzureVm == null) {

                this.AzureVm = new AzureNativeVmRecoverySpec();
                this.AzureVm.ApplyExploratoryFieldSpec(ec.NewChild("azureVm"));

            } else {

                this.AzureVm.ApplyExploratoryFieldSpec(ec.NewChild("azureVm"));

            }
        }
        else if (this.AzureVm != null && ec.Excludes("azureVm",false))
        {
            this.AzureVm = null;
        }
        //      C# -> NutanixVmRecoverySpec? NutanixVm
        // GraphQL -> nutanixVm: NutanixVmRecoverySpec (type)
        if (ec.Includes("nutanixVm",false))
        {
            if(this.NutanixVm == null) {

                this.NutanixVm = new NutanixVmRecoverySpec();
                this.NutanixVm.ApplyExploratoryFieldSpec(ec.NewChild("nutanixVm"));

            } else {

                this.NutanixVm.ApplyExploratoryFieldSpec(ec.NewChild("nutanixVm"));

            }
        }
        else if (this.NutanixVm != null && ec.Excludes("nutanixVm",false))
        {
            this.NutanixVm = null;
        }
        //      C# -> VsphereVmRecoverySpec? VmwareVm
        // GraphQL -> vmwareVm: VsphereVmRecoverySpec (type)
        if (ec.Includes("vmwareVm",false))
        {
            if(this.VmwareVm == null) {

                this.VmwareVm = new VsphereVmRecoverySpec();
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

    } // class WorkloadSpecificRecoverySpec
    
    #endregion

    public static class ListWorkloadSpecificRecoverySpecExtensions
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
            this List<WorkloadSpecificRecoverySpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<WorkloadSpecificRecoverySpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadSpecificRecoverySpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadSpecificRecoverySpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WorkloadSpecificRecoverySpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types