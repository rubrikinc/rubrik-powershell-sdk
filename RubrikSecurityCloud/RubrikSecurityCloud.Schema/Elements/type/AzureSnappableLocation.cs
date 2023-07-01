// AzureSnappableLocation.cs
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
    #region AzureSnappableLocation
 
    public class AzureSnappableLocation: BaseType, SnappableLocationType
    {
        #region members

        //      C# -> System.String? AzureRegion
        // GraphQL -> azureRegion: String! (scalar)
        [JsonProperty("azureRegion")]
        public System.String? AzureRegion { get; set; }

        //      C# -> System.String? SubscriptionRubrikId
        // GraphQL -> subscriptionRubrikId: String (scalar)
        [JsonProperty("subscriptionRubrikId")]
        public System.String? SubscriptionRubrikId { get; set; }

        //      C# -> System.String? SubscriptionRubrikName
        // GraphQL -> subscriptionRubrikName: String (scalar)
        [JsonProperty("subscriptionRubrikName")]
        public System.String? SubscriptionRubrikName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureSnappableLocation";
    }

    public AzureSnappableLocation Set(
        System.String? AzureRegion = null,
        System.String? SubscriptionRubrikId = null,
        System.String? SubscriptionRubrikName = null
    ) 
    {
        if ( AzureRegion != null ) {
            this.AzureRegion = AzureRegion;
        }
        if ( SubscriptionRubrikId != null ) {
            this.SubscriptionRubrikId = SubscriptionRubrikId;
        }
        if ( SubscriptionRubrikName != null ) {
            this.SubscriptionRubrikName = SubscriptionRubrikName;
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
        //      C# -> System.String? AzureRegion
        // GraphQL -> azureRegion: String! (scalar)
        if (this.AzureRegion != null) {
            s += ind + "azureRegion\n" ;
        }
        //      C# -> System.String? SubscriptionRubrikId
        // GraphQL -> subscriptionRubrikId: String (scalar)
        if (this.SubscriptionRubrikId != null) {
            s += ind + "subscriptionRubrikId\n" ;
        }
        //      C# -> System.String? SubscriptionRubrikName
        // GraphQL -> subscriptionRubrikName: String (scalar)
        if (this.SubscriptionRubrikName != null) {
            s += ind + "subscriptionRubrikName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? AzureRegion
        // GraphQL -> azureRegion: String! (scalar)
        if (this.AzureRegion == null && Exploration.Includes(parent + ".azureRegion", true))
        {
            this.AzureRegion = "FETCH";
        }
        //      C# -> System.String? SubscriptionRubrikId
        // GraphQL -> subscriptionRubrikId: String (scalar)
        if (this.SubscriptionRubrikId == null && Exploration.Includes(parent + ".subscriptionRubrikId", true))
        {
            this.SubscriptionRubrikId = "FETCH";
        }
        //      C# -> System.String? SubscriptionRubrikName
        // GraphQL -> subscriptionRubrikName: String (scalar)
        if (this.SubscriptionRubrikName == null && Exploration.Includes(parent + ".subscriptionRubrikName", true))
        {
            this.SubscriptionRubrikName = "FETCH";
        }
    }


    #endregion

    } // class AzureSnappableLocation
    
    #endregion

    public static class ListAzureSnappableLocationExtensions
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
            this List<AzureSnappableLocation> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureSnappableLocation> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureSnappableLocation());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types