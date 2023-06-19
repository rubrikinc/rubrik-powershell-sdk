// BidirectionalReplicationSpecInput.cs
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
    #region BidirectionalReplicationSpecInput

    public class BidirectionalReplicationSpecInput: IInput
    {
        #region members

        //      C# -> UnidirectionalReplicationSpecInput? ReplicationSpec1
        // GraphQL -> replicationSpec1: UnidirectionalReplicationSpecInput (input)
        [JsonProperty("replicationSpec1")]
        public UnidirectionalReplicationSpecInput? ReplicationSpec1 { get; set; }

        //      C# -> UnidirectionalReplicationSpecInput? ReplicationSpec2
        // GraphQL -> replicationSpec2: UnidirectionalReplicationSpecInput (input)
        [JsonProperty("replicationSpec2")]
        public UnidirectionalReplicationSpecInput? ReplicationSpec2 { get; set; }


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

    } // class BidirectionalReplicationSpecInput
    #endregion

} // namespace RubrikSecurityCloud.Types