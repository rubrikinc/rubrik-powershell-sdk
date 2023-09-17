// ValidateAzureSubnetsForCloudAccountExocomputeReply.cs
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
    #region ValidateAzureSubnetsForCloudAccountExocomputeReply
    public class ValidateAzureSubnetsForCloudAccountExocomputeReply: BaseType
    {
        #region members

        //      C# -> List<AzureExocomputeConfigValidationInfo>? ValidationInfo
        // GraphQL -> validationInfo: [AzureExocomputeConfigValidationInfo!]! (type)
        [JsonProperty("validationInfo")]
        public List<AzureExocomputeConfigValidationInfo>? ValidationInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ValidateAzureSubnetsForCloudAccountExocomputeReply";
    }

    public ValidateAzureSubnetsForCloudAccountExocomputeReply Set(
        List<AzureExocomputeConfigValidationInfo>? ValidationInfo = null
    ) 
    {
        if ( ValidationInfo != null ) {
            this.ValidationInfo = ValidationInfo;
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
        //      C# -> List<AzureExocomputeConfigValidationInfo>? ValidationInfo
        // GraphQL -> validationInfo: [AzureExocomputeConfigValidationInfo!]! (type)
        if (this.ValidationInfo != null) {
            var fspec = this.ValidationInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "validationInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AzureExocomputeConfigValidationInfo>? ValidationInfo
        // GraphQL -> validationInfo: [AzureExocomputeConfigValidationInfo!]! (type)
        if (this.ValidationInfo == null && ec.Includes("validationInfo",false))
        {
            this.ValidationInfo = new List<AzureExocomputeConfigValidationInfo>();
            this.ValidationInfo.ApplyExploratoryFieldSpec(ec.NewChild("validationInfo"));
        }
    }


    #endregion

    } // class ValidateAzureSubnetsForCloudAccountExocomputeReply
    
    #endregion

    public static class ListValidateAzureSubnetsForCloudAccountExocomputeReplyExtensions
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
            this List<ValidateAzureSubnetsForCloudAccountExocomputeReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ValidateAzureSubnetsForCloudAccountExocomputeReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ValidateAzureSubnetsForCloudAccountExocomputeReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ValidateAzureSubnetsForCloudAccountExocomputeReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types