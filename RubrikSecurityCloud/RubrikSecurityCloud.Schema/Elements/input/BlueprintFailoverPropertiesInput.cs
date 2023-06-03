// BlueprintFailoverPropertiesInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region BlueprintFailoverPropertiesInput

    public class BlueprintFailoverPropertiesInput: IInput
    {
        #region members

        //      C# -> PlanName? PlanType
        // GraphQL -> planType: PlanName (enum)
        [JsonProperty("planType")]
        public PlanName? PlanType { get; set; }

        //      C# -> DataTransferType? DataTransferType
        // GraphQL -> dataTransferType: DataTransferType (enum)
        [JsonProperty("dataTransferType")]
        public DataTransferType? DataTransferType { get; set; }

        //      C# -> LocationInfo? TargetLocation
        // GraphQL -> targetLocation: LocationInfo (input)
        [JsonProperty("targetLocation")]
        public LocationInfo? TargetLocation { get; set; }


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

    } // class BlueprintFailoverPropertiesInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types