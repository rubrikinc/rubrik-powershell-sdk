// SpecificReplicationSpecInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region SpecificReplicationSpecInput

    public class SpecificReplicationSpecInput: IInput
    {
        #region members

        //      C# -> UnidirectionalReplicationSpecInput? UnidirectionalSpecInput
        // GraphQL -> unidirectionalSpecInput: UnidirectionalReplicationSpecInput (input)
        [JsonProperty("unidirectionalSpecInput")]
        public UnidirectionalReplicationSpecInput? UnidirectionalSpecInput { get; set; }

        //      C# -> BidirectionalReplicationSpecInput? BidirectionalSpecInput
        // GraphQL -> bidirectionalSpecInput: BidirectionalReplicationSpecInput (input)
        [JsonProperty("bidirectionalSpecInput")]
        public BidirectionalReplicationSpecInput? BidirectionalSpecInput { get; set; }

        //      C# -> ReplicationToCloudRegionSpecInput? CloudRegionSpecInput
        // GraphQL -> cloudRegionSpecInput: ReplicationToCloudRegionSpecInput (input)
        [JsonProperty("cloudRegionSpecInput")]
        public ReplicationToCloudRegionSpecInput? CloudRegionSpecInput { get; set; }

        //      C# -> ReplicationToCloudLocationSpecInput? CloudLocationSpecInput
        // GraphQL -> cloudLocationSpecInput: ReplicationToCloudLocationSpecInput (input)
        [JsonProperty("cloudLocationSpecInput")]
        public ReplicationToCloudLocationSpecInput? CloudLocationSpecInput { get; set; }


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

    } // class SpecificReplicationSpecInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types