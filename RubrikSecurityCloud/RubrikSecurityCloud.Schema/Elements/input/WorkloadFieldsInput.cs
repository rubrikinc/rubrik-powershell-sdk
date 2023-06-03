// WorkloadFieldsInput.cs
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
    #region WorkloadFieldsInput

    public class WorkloadFieldsInput: IInput
    {
        #region members

        //      C# -> O365SnapshotFileDeltaInput? O365FileDelta
        // GraphQL -> o365FileDelta: O365SnapshotFileDeltaInput (input)
        [JsonProperty("o365FileDelta")]
        public O365SnapshotFileDeltaInput? O365FileDelta { get; set; }

        //      C# -> O365SharepointSnapshotFileDeltaInput? O365SharepointDelta
        // GraphQL -> o365SharepointDelta: O365SharepointSnapshotFileDeltaInput (input)
        [JsonProperty("o365SharepointDelta")]
        public O365SharepointSnapshotFileDeltaInput? O365SharepointDelta { get; set; }


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

    } // class WorkloadFieldsInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types