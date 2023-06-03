// ValidateAndCreateAwsCloudAccountReply.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region ValidateAndCreateAwsCloudAccountReply
    public class ValidateAndCreateAwsCloudAccountReply: BaseType
    {
        #region members

        //      C# -> AwsCloudAccountCreateResponse? InitiateResponse
        // GraphQL -> initiateResponse: AwsCloudAccountCreateResponse (type)
        [JsonProperty("initiateResponse")]
        public AwsCloudAccountCreateResponse? InitiateResponse { get; set; }

        //      C# -> AwsCloudAccountValidateResponse? ValidateResponse
        // GraphQL -> validateResponse: AwsCloudAccountValidateResponse (type)
        [JsonProperty("validateResponse")]
        public AwsCloudAccountValidateResponse? ValidateResponse { get; set; }


        #endregion

    #region methods

    public ValidateAndCreateAwsCloudAccountReply Set(
        AwsCloudAccountCreateResponse? InitiateResponse = null,
        AwsCloudAccountValidateResponse? ValidateResponse = null
    ) 
    {
        if ( InitiateResponse != null ) {
            this.InitiateResponse = InitiateResponse;
        }
        if ( ValidateResponse != null ) {
            this.ValidateResponse = ValidateResponse;
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
        //      C# -> AwsCloudAccountCreateResponse? InitiateResponse
        // GraphQL -> initiateResponse: AwsCloudAccountCreateResponse (type)
        if (this.InitiateResponse != null) {
            s += ind + "initiateResponse {\n" + this.InitiateResponse.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> AwsCloudAccountValidateResponse? ValidateResponse
        // GraphQL -> validateResponse: AwsCloudAccountValidateResponse (type)
        if (this.ValidateResponse != null) {
            s += ind + "validateResponse {\n" + this.ValidateResponse.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AwsCloudAccountCreateResponse? InitiateResponse
        // GraphQL -> initiateResponse: AwsCloudAccountCreateResponse (type)
        if (this.InitiateResponse == null && Exploration.Includes(parent + ".initiateResponse"))
        {
            this.InitiateResponse = new AwsCloudAccountCreateResponse();
            this.InitiateResponse.ApplyExploratoryFieldSpec(parent + ".initiateResponse");
        }
        //      C# -> AwsCloudAccountValidateResponse? ValidateResponse
        // GraphQL -> validateResponse: AwsCloudAccountValidateResponse (type)
        if (this.ValidateResponse == null && Exploration.Includes(parent + ".validateResponse"))
        {
            this.ValidateResponse = new AwsCloudAccountValidateResponse();
            this.ValidateResponse.ApplyExploratoryFieldSpec(parent + ".validateResponse");
        }
    }


    #endregion

    } // class ValidateAndCreateAwsCloudAccountReply
    
    #endregion

    public static class ListValidateAndCreateAwsCloudAccountReplyExtensions
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
            this List<ValidateAndCreateAwsCloudAccountReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ValidateAndCreateAwsCloudAccountReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ValidateAndCreateAwsCloudAccountReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types