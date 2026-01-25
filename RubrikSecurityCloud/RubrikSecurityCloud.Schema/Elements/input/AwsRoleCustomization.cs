// AwsRoleCustomization.cs
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
    #region AwsRoleCustomization

    public class AwsRoleCustomization: IInput
    {
        #region members

        //      C# -> System.String? CrossAccountRoleName
        // GraphQL -> crossAccountRoleName: String (scalar)
        [JsonProperty("crossAccountRoleName")]
        public System.String? CrossAccountRoleName { get; set; }

        //      C# -> System.String? CrossAccountRolePath
        // GraphQL -> crossAccountRolePath: String (scalar)
        [JsonProperty("crossAccountRolePath")]
        public System.String? CrossAccountRolePath { get; set; }

        //      C# -> System.String? MasterRoleName
        // GraphQL -> masterRoleName: String (scalar)
        [JsonProperty("masterRoleName")]
        public System.String? MasterRoleName { get; set; }

        //      C# -> System.String? MasterRolePath
        // GraphQL -> masterRolePath: String (scalar)
        [JsonProperty("masterRolePath")]
        public System.String? MasterRolePath { get; set; }

        //      C# -> System.String? WorkerRoleName
        // GraphQL -> workerRoleName: String (scalar)
        [JsonProperty("workerRoleName")]
        public System.String? WorkerRoleName { get; set; }

        //      C# -> System.String? WorkerRolePath
        // GraphQL -> workerRolePath: String (scalar)
        [JsonProperty("workerRolePath")]
        public System.String? WorkerRolePath { get; set; }

        //      C# -> System.String? InstanceProfileName
        // GraphQL -> instanceProfileName: String (scalar)
        [JsonProperty("instanceProfileName")]
        public System.String? InstanceProfileName { get; set; }

        //      C# -> System.String? InstanceProfilePath
        // GraphQL -> instanceProfilePath: String (scalar)
        [JsonProperty("instanceProfilePath")]
        public System.String? InstanceProfilePath { get; set; }

        //      C# -> System.String? Ec2RecoveryRolePath
        // GraphQL -> ec2RecoveryRolePath: String (scalar)
        [JsonProperty("ec2RecoveryRolePath")]
        public System.String? Ec2RecoveryRolePath { get; set; }

        //      C# -> System.String? LambdaRolePath
        // GraphQL -> lambdaRolePath: String (scalar)
        [JsonProperty("lambdaRolePath")]
        public System.String? LambdaRolePath { get; set; }

        //      C# -> System.String? LambdaRoleName
        // GraphQL -> lambdaRoleName: String (scalar)
        [JsonProperty("lambdaRoleName")]
        public System.String? LambdaRoleName { get; set; }

        //      C# -> System.String? PermissionBoundaryName
        // GraphQL -> permissionBoundaryName: String (scalar)
        [JsonProperty("permissionBoundaryName")]
        public System.String? PermissionBoundaryName { get; set; }

        //      C# -> System.String? PermissionBoundaryPath
        // GraphQL -> permissionBoundaryPath: String (scalar)
        [JsonProperty("permissionBoundaryPath")]
        public System.String? PermissionBoundaryPath { get; set; }


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

    } // class AwsRoleCustomization
    #endregion

} // namespace RubrikSecurityCloud.Types