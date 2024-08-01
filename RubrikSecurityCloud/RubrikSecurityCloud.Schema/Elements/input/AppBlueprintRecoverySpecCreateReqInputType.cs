// AppBlueprintRecoverySpecCreateReqInputType.cs
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
    #region AppBlueprintRecoverySpecCreateReqInputType

    public class AppBlueprintRecoverySpecCreateReqInputType: IInput
    {
        #region members

        //      C# -> PlanName? PlanType
        // GraphQL -> planType: PlanName! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("planType")]
        public PlanName? PlanType { get; set; }

        //      C# -> LocationInfo? LocationInfo
        // GraphQL -> locationInfo: LocationInfo (input)
        [JsonProperty("locationInfo")]
        public LocationInfo? LocationInfo { get; set; }

        //      C# -> System.String? UserData
        // GraphQL -> userData: String (scalar)
        [JsonProperty("userData")]
        public System.String? UserData { get; set; }

        //      C# -> List<ChildRecoverySpecCreateReqInputType>? ChildRecoverySpecs
        // GraphQL -> childRecoverySpecs: [ChildRecoverySpecCreateReqInputType!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("childRecoverySpecs")]
        public List<ChildRecoverySpecCreateReqInputType>? ChildRecoverySpecs { get; set; }

        //      C# -> ResourceSpecType? ResourceSpecType
        // GraphQL -> resourceSpecType: ResourceSpecType (enum)
        [JsonProperty("resourceSpecType")]
        public ResourceSpecType? ResourceSpecType { get; set; }

        //      C# -> System.String? FailoverId
        // GraphQL -> failoverId: UUID (scalar)
        [JsonProperty("failoverId")]
        public System.String? FailoverId { get; set; }


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

    } // class AppBlueprintRecoverySpecCreateReqInputType
    #endregion

} // namespace RubrikSecurityCloud.Types