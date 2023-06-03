// AzureSubscriptionMissingPermissions.cs
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
    #region AzureSubscriptionMissingPermissions
    public class AzureSubscriptionMissingPermissions: BaseType
    {
        #region members

        //      C# -> List<System.String>? MissingPermissions
        // GraphQL -> missingPermissions: [String!]! (scalar)
        [JsonProperty("missingPermissions")]
        public List<System.String>? MissingPermissions { get; set; }

        //      C# -> System.String? SubscriptionNativeId
        // GraphQL -> subscriptionNativeId: String! (scalar)
        [JsonProperty("subscriptionNativeId")]
        public System.String? SubscriptionNativeId { get; set; }


        #endregion

    #region methods

    public AzureSubscriptionMissingPermissions Set(
        List<System.String>? MissingPermissions = null,
        System.String? SubscriptionNativeId = null
    ) 
    {
        if ( MissingPermissions != null ) {
            this.MissingPermissions = MissingPermissions;
        }
        if ( SubscriptionNativeId != null ) {
            this.SubscriptionNativeId = SubscriptionNativeId;
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
        //      C# -> List<System.String>? MissingPermissions
        // GraphQL -> missingPermissions: [String!]! (scalar)
        if (this.MissingPermissions != null) {
            s += ind + "missingPermissions\n" ;
        }
        //      C# -> System.String? SubscriptionNativeId
        // GraphQL -> subscriptionNativeId: String! (scalar)
        if (this.SubscriptionNativeId != null) {
            s += ind + "subscriptionNativeId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? MissingPermissions
        // GraphQL -> missingPermissions: [String!]! (scalar)
        if (this.MissingPermissions == null && Exploration.Includes(parent + ".missingPermissions", true))
        {
            this.MissingPermissions = new List<System.String>();
        }
        //      C# -> System.String? SubscriptionNativeId
        // GraphQL -> subscriptionNativeId: String! (scalar)
        if (this.SubscriptionNativeId == null && Exploration.Includes(parent + ".subscriptionNativeId", true))
        {
            this.SubscriptionNativeId = new System.String("FETCH");
        }
    }


    #endregion

    } // class AzureSubscriptionMissingPermissions
    
    #endregion

    public static class ListAzureSubscriptionMissingPermissionsExtensions
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
            this List<AzureSubscriptionMissingPermissions> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureSubscriptionMissingPermissions> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureSubscriptionMissingPermissions());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types