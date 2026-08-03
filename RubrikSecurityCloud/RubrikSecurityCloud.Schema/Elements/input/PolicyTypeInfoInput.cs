// PolicyTypeInfoInput.cs
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
    #region PolicyTypeInfoInput

    public class PolicyTypeInfoInput: IInput
    {
        #region members

        //      C# -> IdentityEventPolicyInfoInput? IdentityEventPolicyInfo
        // GraphQL -> identityEventPolicyInfo: IdentityEventPolicyInfoInput (input)
        [JsonProperty("identityEventPolicyInfo")]
        public IdentityEventPolicyInfoInput? IdentityEventPolicyInfo { get; set; }

        //      C# -> IdentityPolicyInfoInput? IdentityPolicyInfo
        // GraphQL -> identityPolicyInfo: IdentityPolicyInfoInput (input)
        [JsonProperty("identityPolicyInfo")]
        public IdentityPolicyInfoInput? IdentityPolicyInfo { get; set; }

        //      C# -> IdpPolicyInfoInput? IdpPolicyInfo
        // GraphQL -> idpPolicyInfo: IdpPolicyInfoInput (input)
        [JsonProperty("idpPolicyInfo")]
        public IdpPolicyInfoInput? IdpPolicyInfo { get; set; }

        //      C# -> SigninAnomalyPolicyInfoInput? SigninAnomalyPolicyInfo
        // GraphQL -> signinAnomalyPolicyInfo: SigninAnomalyPolicyInfoInput (input)
        [JsonProperty("signinAnomalyPolicyInfo")]
        public SigninAnomalyPolicyInfoInput? SigninAnomalyPolicyInfo { get; set; }


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

    } // class PolicyTypeInfoInput
    #endregion

} // namespace RubrikSecurityCloud.Types