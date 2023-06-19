// AddAzureCloudAccountStatus.cs
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
    #region AddAzureCloudAccountStatus
    public class AddAzureCloudAccountStatus: BaseType
    {
        #region members

        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        [JsonProperty("azureSubscriptionNativeId")]
        public System.String? AzureSubscriptionNativeId { get; set; }

        //      C# -> System.String? AzureSubscriptionRubrikId
        // GraphQL -> azureSubscriptionRubrikId: String! (scalar)
        [JsonProperty("azureSubscriptionRubrikId")]
        public System.String? AzureSubscriptionRubrikId { get; set; }

        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }


        #endregion

    #region methods

    public AddAzureCloudAccountStatus Set(
        System.String? AzureSubscriptionNativeId = null,
        System.String? AzureSubscriptionRubrikId = null,
        System.String? Error = null
    ) 
    {
        if ( AzureSubscriptionNativeId != null ) {
            this.AzureSubscriptionNativeId = AzureSubscriptionNativeId;
        }
        if ( AzureSubscriptionRubrikId != null ) {
            this.AzureSubscriptionRubrikId = AzureSubscriptionRubrikId;
        }
        if ( Error != null ) {
            this.Error = Error;
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
        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        if (this.AzureSubscriptionNativeId != null) {
            s += ind + "azureSubscriptionNativeId\n" ;
        }
        //      C# -> System.String? AzureSubscriptionRubrikId
        // GraphQL -> azureSubscriptionRubrikId: String! (scalar)
        if (this.AzureSubscriptionRubrikId != null) {
            s += ind + "azureSubscriptionRubrikId\n" ;
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error != null) {
            s += ind + "error\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        if (this.AzureSubscriptionNativeId == null && Exploration.Includes(parent + ".azureSubscriptionNativeId", true))
        {
            this.AzureSubscriptionNativeId = "FETCH";
        }
        //      C# -> System.String? AzureSubscriptionRubrikId
        // GraphQL -> azureSubscriptionRubrikId: String! (scalar)
        if (this.AzureSubscriptionRubrikId == null && Exploration.Includes(parent + ".azureSubscriptionRubrikId", true))
        {
            this.AzureSubscriptionRubrikId = "FETCH";
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error == null && Exploration.Includes(parent + ".error", true))
        {
            this.Error = "FETCH";
        }
    }


    #endregion

    } // class AddAzureCloudAccountStatus
    
    #endregion

    public static class ListAddAzureCloudAccountStatusExtensions
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
            this List<AddAzureCloudAccountStatus> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AddAzureCloudAccountStatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AddAzureCloudAccountStatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types