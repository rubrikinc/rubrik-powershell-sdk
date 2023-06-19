// AwsNativeProtectionAccountAddResponse.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region AwsNativeProtectionAccountAddResponse
    public class AwsNativeProtectionAccountAddResponse: BaseType
    {
        #region members

        //      C# -> System.String? CloudFormationName
        // GraphQL -> cloudFormationName: String! (scalar)
        [JsonProperty("cloudFormationName")]
        public System.String? CloudFormationName { get; set; }

        //      C# -> System.String? CloudFormationTemplateUrl
        // GraphQL -> cloudFormationTemplateUrl: String! (scalar)
        [JsonProperty("cloudFormationTemplateUrl")]
        public System.String? CloudFormationTemplateUrl { get; set; }

        //      C# -> System.String? CloudFormationUrl
        // GraphQL -> cloudFormationUrl: String! (scalar)
        [JsonProperty("cloudFormationUrl")]
        public System.String? CloudFormationUrl { get; set; }

        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        [JsonProperty("errorMessage")]
        public System.String? ErrorMessage { get; set; }


        #endregion

    #region methods

    public AwsNativeProtectionAccountAddResponse Set(
        System.String? CloudFormationName = null,
        System.String? CloudFormationTemplateUrl = null,
        System.String? CloudFormationUrl = null,
        System.String? ErrorMessage = null
    ) 
    {
        if ( CloudFormationName != null ) {
            this.CloudFormationName = CloudFormationName;
        }
        if ( CloudFormationTemplateUrl != null ) {
            this.CloudFormationTemplateUrl = CloudFormationTemplateUrl;
        }
        if ( CloudFormationUrl != null ) {
            this.CloudFormationUrl = CloudFormationUrl;
        }
        if ( ErrorMessage != null ) {
            this.ErrorMessage = ErrorMessage;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? CloudFormationName
        // GraphQL -> cloudFormationName: String! (scalar)
        if (this.CloudFormationName != null) {
            s += ind + "cloudFormationName\n" ;
        }
        //      C# -> System.String? CloudFormationTemplateUrl
        // GraphQL -> cloudFormationTemplateUrl: String! (scalar)
        if (this.CloudFormationTemplateUrl != null) {
            s += ind + "cloudFormationTemplateUrl\n" ;
        }
        //      C# -> System.String? CloudFormationUrl
        // GraphQL -> cloudFormationUrl: String! (scalar)
        if (this.CloudFormationUrl != null) {
            s += ind + "cloudFormationUrl\n" ;
        }
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (this.ErrorMessage != null) {
            s += ind + "errorMessage\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? CloudFormationName
        // GraphQL -> cloudFormationName: String! (scalar)
        if (this.CloudFormationName == null && Exploration.Includes(parent + ".cloudFormationName", true))
        {
            this.CloudFormationName = "FETCH";
        }
        //      C# -> System.String? CloudFormationTemplateUrl
        // GraphQL -> cloudFormationTemplateUrl: String! (scalar)
        if (this.CloudFormationTemplateUrl == null && Exploration.Includes(parent + ".cloudFormationTemplateUrl", true))
        {
            this.CloudFormationTemplateUrl = "FETCH";
        }
        //      C# -> System.String? CloudFormationUrl
        // GraphQL -> cloudFormationUrl: String! (scalar)
        if (this.CloudFormationUrl == null && Exploration.Includes(parent + ".cloudFormationUrl", true))
        {
            this.CloudFormationUrl = "FETCH";
        }
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (this.ErrorMessage == null && Exploration.Includes(parent + ".errorMessage", true))
        {
            this.ErrorMessage = "FETCH";
        }
    }


    #endregion

    } // class AwsNativeProtectionAccountAddResponse
    
    #endregion

    public static class ListAwsNativeProtectionAccountAddResponseExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<AwsNativeProtectionAccountAddResponse> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsNativeProtectionAccountAddResponse> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsNativeProtectionAccountAddResponse());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types