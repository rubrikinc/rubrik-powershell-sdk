// VpcOptionInput.cs
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
    #region VpcOptionInput

    public class VpcOptionInput: IInput
    {
        #region members

        //      C# -> AwsCloneVpcSameCidrInput? CloneVpcSameCidr
        // GraphQL -> cloneVpcSameCidr: AwsCloneVpcSameCidrInput (input)
        [JsonProperty("cloneVpcSameCidr")]
        public AwsCloneVpcSameCidrInput? CloneVpcSameCidr { get; set; }

        //      C# -> AwsCloneVpcAlternateCidrInput? CloneVpcAlternateCidr
        // GraphQL -> cloneVpcAlternateCidr: AwsCloneVpcAlternateCidrInput (input)
        [JsonProperty("cloneVpcAlternateCidr")]
        public AwsCloneVpcAlternateCidrInput? CloneVpcAlternateCidr { get; set; }

        //      C# -> AwsUseExistingVpcInput? UseExistingVpc
        // GraphQL -> useExistingVpc: AwsUseExistingVpcInput (input)
        [JsonProperty("useExistingVpc")]
        public AwsUseExistingVpcInput? UseExistingVpc { get; set; }


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

    } // class VpcOptionInput
    #endregion

} // namespace RubrikSecurityCloud.Types