// AzureReplicationTarget.cs
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
    #region AzureReplicationTarget
    public class AzureReplicationTarget: BaseType
    {
        #region members

        //      C# -> AzureNativeRegionForReplication? Region
        // GraphQL -> region: AzureNativeRegionForReplication! (enum)
        [JsonProperty("region")]
        public AzureNativeRegionForReplication? Region { get; set; }

        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        [JsonProperty("subscriptionId")]
        public System.String? SubscriptionId { get; set; }

        //      C# -> System.String? SubscriptionName
        // GraphQL -> subscriptionName: String! (scalar)
        [JsonProperty("subscriptionName")]
        public System.String? SubscriptionName { get; set; }


        #endregion

    #region methods

    public AzureReplicationTarget Set(
        AzureNativeRegionForReplication? Region = null,
        System.String? SubscriptionId = null,
        System.String? SubscriptionName = null
    ) 
    {
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( SubscriptionId != null ) {
            this.SubscriptionId = SubscriptionId;
        }
        if ( SubscriptionName != null ) {
            this.SubscriptionName = SubscriptionName;
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
        //      C# -> AzureNativeRegionForReplication? Region
        // GraphQL -> region: AzureNativeRegionForReplication! (enum)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        if (this.SubscriptionId != null) {
            s += ind + "subscriptionId\n" ;
        }
        //      C# -> System.String? SubscriptionName
        // GraphQL -> subscriptionName: String! (scalar)
        if (this.SubscriptionName != null) {
            s += ind + "subscriptionName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AzureNativeRegionForReplication? Region
        // GraphQL -> region: AzureNativeRegionForReplication! (enum)
        if (this.Region == null && Exploration.Includes(parent + ".region", true))
        {
            this.Region = new AzureNativeRegionForReplication();
        }
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        if (this.SubscriptionId == null && Exploration.Includes(parent + ".subscriptionId", true))
        {
            this.SubscriptionId = "FETCH";
        }
        //      C# -> System.String? SubscriptionName
        // GraphQL -> subscriptionName: String! (scalar)
        if (this.SubscriptionName == null && Exploration.Includes(parent + ".subscriptionName", true))
        {
            this.SubscriptionName = "FETCH";
        }
    }


    #endregion

    } // class AzureReplicationTarget
    
    #endregion

    public static class ListAzureReplicationTargetExtensions
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
            this List<AzureReplicationTarget> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureReplicationTarget> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureReplicationTarget());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types