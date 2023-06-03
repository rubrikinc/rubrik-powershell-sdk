// AzureResourceGroupInfo.cs
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
    #region AzureResourceGroupInfo
    public class AzureResourceGroupInfo: BaseType
    {
        #region members

        //      C# -> AzureCloudAccountRegion? Region
        // GraphQL -> region: AzureCloudAccountRegion! (enum)
        [JsonProperty("region")]
        public AzureCloudAccountRegion? Region { get; set; }

        //      C# -> System.String? ResourceGroupName
        // GraphQL -> resourceGroupName: String! (scalar)
        [JsonProperty("resourceGroupName")]
        public System.String? ResourceGroupName { get; set; }

        //      C# -> System.String? SubscriptionNativeId
        // GraphQL -> subscriptionNativeId: UUID! (scalar)
        [JsonProperty("subscriptionNativeId")]
        public System.String? SubscriptionNativeId { get; set; }

        //      C# -> List<TagObject>? Tags
        // GraphQL -> tags: [TagObject!]! (type)
        [JsonProperty("tags")]
        public List<TagObject>? Tags { get; set; }


        #endregion

    #region methods

    public AzureResourceGroupInfo Set(
        AzureCloudAccountRegion? Region = null,
        System.String? ResourceGroupName = null,
        System.String? SubscriptionNativeId = null,
        List<TagObject>? Tags = null
    ) 
    {
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( ResourceGroupName != null ) {
            this.ResourceGroupName = ResourceGroupName;
        }
        if ( SubscriptionNativeId != null ) {
            this.SubscriptionNativeId = SubscriptionNativeId;
        }
        if ( Tags != null ) {
            this.Tags = Tags;
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
        //      C# -> AzureCloudAccountRegion? Region
        // GraphQL -> region: AzureCloudAccountRegion! (enum)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> System.String? ResourceGroupName
        // GraphQL -> resourceGroupName: String! (scalar)
        if (this.ResourceGroupName != null) {
            s += ind + "resourceGroupName\n" ;
        }
        //      C# -> System.String? SubscriptionNativeId
        // GraphQL -> subscriptionNativeId: UUID! (scalar)
        if (this.SubscriptionNativeId != null) {
            s += ind + "subscriptionNativeId\n" ;
        }
        //      C# -> List<TagObject>? Tags
        // GraphQL -> tags: [TagObject!]! (type)
        if (this.Tags != null) {
            s += ind + "tags {\n" + this.Tags.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AzureCloudAccountRegion? Region
        // GraphQL -> region: AzureCloudAccountRegion! (enum)
        if (this.Region == null && Exploration.Includes(parent + ".region", true))
        {
            this.Region = new AzureCloudAccountRegion();
        }
        //      C# -> System.String? ResourceGroupName
        // GraphQL -> resourceGroupName: String! (scalar)
        if (this.ResourceGroupName == null && Exploration.Includes(parent + ".resourceGroupName", true))
        {
            this.ResourceGroupName = new System.String("FETCH");
        }
        //      C# -> System.String? SubscriptionNativeId
        // GraphQL -> subscriptionNativeId: UUID! (scalar)
        if (this.SubscriptionNativeId == null && Exploration.Includes(parent + ".subscriptionNativeId", true))
        {
            this.SubscriptionNativeId = new System.String("FETCH");
        }
        //      C# -> List<TagObject>? Tags
        // GraphQL -> tags: [TagObject!]! (type)
        if (this.Tags == null && Exploration.Includes(parent + ".tags"))
        {
            this.Tags = new List<TagObject>();
            this.Tags.ApplyExploratoryFieldSpec(parent + ".tags");
        }
    }


    #endregion

    } // class AzureResourceGroupInfo
    
    #endregion

    public static class ListAzureResourceGroupInfoExtensions
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
            this List<AzureResourceGroupInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureResourceGroupInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureResourceGroupInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types