// IntegrationConfigInput.cs
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
    #region IntegrationConfigInput

    public class IntegrationConfigInput: IInput
    {
        #region members

        //      C# -> DlpConfigInput? DataLossPrevention
        // GraphQL -> dataLossPrevention: DlpConfigInput (input)
        [JsonProperty("dataLossPrevention")]
        public DlpConfigInput? DataLossPrevention { get; set; }

        //      C# -> ServiceNowItsmIntegrationConfigInput? ServiceNowItsm
        // GraphQL -> serviceNowItsm: ServiceNowItsmIntegrationConfigInput (input)
        [JsonProperty("serviceNowItsm")]
        public ServiceNowItsmIntegrationConfigInput? ServiceNowItsm { get; set; }

        //      C# -> OktaIntegrationConfigInput? Okta
        // GraphQL -> okta: OktaIntegrationConfigInput (input)
        [JsonProperty("okta")]
        public OktaIntegrationConfigInput? Okta { get; set; }

        //      C# -> MicrosoftPurviewConfigInput? MicrosoftPurview
        // GraphQL -> microsoftPurview: MicrosoftPurviewConfigInput (input)
        [JsonProperty("microsoftPurview")]
        public MicrosoftPurviewConfigInput? MicrosoftPurview { get; set; }

        //      C# -> PamIntegrationConfigInput? Pam
        // GraphQL -> pam: PamIntegrationConfigInput (input)
        [JsonProperty("pam")]
        public PamIntegrationConfigInput? Pam { get; set; }

        //      C# -> CrowdStrikeIntegrationConfigInput? CrowdStrike
        // GraphQL -> crowdStrike: CrowdStrikeIntegrationConfigInput (input)
        [JsonProperty("crowdStrike")]
        public CrowdStrikeIntegrationConfigInput? CrowdStrike { get; set; }


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

    } // class IntegrationConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types