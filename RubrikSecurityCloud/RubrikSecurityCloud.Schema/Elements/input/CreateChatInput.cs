// CreateChatInput.cs
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
    #region CreateChatInput

    public class CreateChatInput: IInput
    {
        #region members

        //      C# -> ChatUsage? ChatUsage
        // GraphQL -> chatUsage: ChatUsage! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("chatUsage")]
        public ChatUsage? ChatUsage { get; set; }

        //      C# -> ChatRockInitInput? ChatrockInput
        // GraphQL -> chatrockInput: ChatRockInitInput (input)
        [JsonProperty("chatrockInput")]
        public ChatRockInitInput? ChatrockInput { get; set; }

        //      C# -> HelpCenterInitInput? HelpcenterInput
        // GraphQL -> helpcenterInput: HelpCenterInitInput (input)
        [JsonProperty("helpcenterInput")]
        public HelpCenterInitInput? HelpcenterInput { get; set; }

        //      C# -> DataChatInitInput? DataChatInput
        // GraphQL -> dataChatInput: DataChatInitInput (input)
        [JsonProperty("dataChatInput")]
        public DataChatInitInput? DataChatInput { get; set; }


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

    } // class CreateChatInput
    #endregion

} // namespace RubrikSecurityCloud.Types