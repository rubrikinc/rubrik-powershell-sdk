// WorkloadSpecificRecoverySpecInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region WorkloadSpecificRecoverySpecInput

    public class WorkloadSpecificRecoverySpecInput: IInput
    {
        #region members

        //      C# -> VsphereVmRecoverySpecInput? VmwareVm
        // GraphQL -> vmwareVm: VsphereVmRecoverySpecInput (input)
        [JsonProperty("vmwareVm")]
        public VsphereVmRecoverySpecInput? VmwareVm { get; set; }

        //      C# -> NutanixVmRecoverySpecInput? NutanixVm
        // GraphQL -> nutanixVm: NutanixVmRecoverySpecInput (input)
        [JsonProperty("nutanixVm")]
        public NutanixVmRecoverySpecInput? NutanixVm { get; set; }

        //      C# -> AzureNativeVmRecoverySpecInput? AzureVm
        // GraphQL -> azureVm: AzureNativeVmRecoverySpecInput (input)
        [JsonProperty("azureVm")]
        public AzureNativeVmRecoverySpecInput? AzureVm { get; set; }

        //      C# -> AwsEc2InstanceRecoverySpecInput? AwsEc2Instance
        // GraphQL -> awsEc2Instance: AwsEc2InstanceRecoverySpecInput (input)
        [JsonProperty("awsEc2Instance")]
        public AwsEc2InstanceRecoverySpecInput? AwsEc2Instance { get; set; }

        //      C# -> AwsRdsInstanceRecoverySpecInput? AwsRdsInstance
        // GraphQL -> awsRdsInstance: AwsRdsInstanceRecoverySpecInput (input)
        [JsonProperty("awsRdsInstance")]
        public AwsRdsInstanceRecoverySpecInput? AwsRdsInstance { get; set; }

        //      C# -> AdfrRecoverySpecInput? Adfr
        // GraphQL -> adfr: AdfrRecoverySpecInput (input)
        [JsonProperty("adfr")]
        public AdfrRecoverySpecInput? Adfr { get; set; }

        //      C# -> AddcRecoverySpecInput? Addc
        // GraphQL -> addc: AddcRecoverySpecInput (input)
        [JsonProperty("addc")]
        public AddcRecoverySpecInput? Addc { get; set; }


        #endregion

    
        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;

                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion

    } // class WorkloadSpecificRecoverySpecInput
    #endregion

} // namespace RubrikSecurityCloud.Types