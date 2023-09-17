// StorageAccount.cs
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
    #region StorageAccount
    public class StorageAccount: BaseType
    {
        #region members

        //      C# -> StorageAccountTier? AccessTier
        // GraphQL -> accessTier: StorageAccountTier! (enum)
        [JsonProperty("accessTier")]
        public StorageAccountTier? AccessTier { get; set; }

        //      C# -> StorageAccountSku? Sku
        // GraphQL -> sku: StorageAccountSku! (enum)
        [JsonProperty("sku")]
        public StorageAccountSku? Sku { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsVersioningEnabled
        // GraphQL -> isVersioningEnabled: Boolean! (scalar)
        [JsonProperty("isVersioningEnabled")]
        public System.Boolean? IsVersioningEnabled { get; set; }

        //      C# -> System.String? Kind
        // GraphQL -> kind: String! (scalar)
        [JsonProperty("kind")]
        public System.String? Kind { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? RegionName
        // GraphQL -> regionName: String! (scalar)
        [JsonProperty("regionName")]
        public System.String? RegionName { get; set; }

        //      C# -> NetworkRuleSet? NetworkRuleSet
        // GraphQL -> networkRuleSet: NetworkRuleSet (type)
        [JsonProperty("networkRuleSet")]
        public NetworkRuleSet? NetworkRuleSet { get; set; }

        //      C# -> ResourceGroup? ResourceGroup
        // GraphQL -> resourceGroup: ResourceGroup (type)
        [JsonProperty("resourceGroup")]
        public ResourceGroup? ResourceGroup { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "StorageAccount";
    }

    public StorageAccount Set(
        StorageAccountTier? AccessTier = null,
        StorageAccountSku? Sku = null,
        System.String? Id = null,
        System.Boolean? IsVersioningEnabled = null,
        System.String? Kind = null,
        System.String? Name = null,
        System.String? RegionName = null,
        NetworkRuleSet? NetworkRuleSet = null,
        ResourceGroup? ResourceGroup = null
    ) 
    {
        if ( AccessTier != null ) {
            this.AccessTier = AccessTier;
        }
        if ( Sku != null ) {
            this.Sku = Sku;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsVersioningEnabled != null ) {
            this.IsVersioningEnabled = IsVersioningEnabled;
        }
        if ( Kind != null ) {
            this.Kind = Kind;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( RegionName != null ) {
            this.RegionName = RegionName;
        }
        if ( NetworkRuleSet != null ) {
            this.NetworkRuleSet = NetworkRuleSet;
        }
        if ( ResourceGroup != null ) {
            this.ResourceGroup = ResourceGroup;
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
        //      C# -> StorageAccountTier? AccessTier
        // GraphQL -> accessTier: StorageAccountTier! (enum)
        if (this.AccessTier != null) {
            s += ind + "accessTier\n" ;
        }
        //      C# -> StorageAccountSku? Sku
        // GraphQL -> sku: StorageAccountSku! (enum)
        if (this.Sku != null) {
            s += ind + "sku\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsVersioningEnabled
        // GraphQL -> isVersioningEnabled: Boolean! (scalar)
        if (this.IsVersioningEnabled != null) {
            s += ind + "isVersioningEnabled\n" ;
        }
        //      C# -> System.String? Kind
        // GraphQL -> kind: String! (scalar)
        if (this.Kind != null) {
            s += ind + "kind\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? RegionName
        // GraphQL -> regionName: String! (scalar)
        if (this.RegionName != null) {
            s += ind + "regionName\n" ;
        }
        //      C# -> NetworkRuleSet? NetworkRuleSet
        // GraphQL -> networkRuleSet: NetworkRuleSet (type)
        if (this.NetworkRuleSet != null) {
            var fspec = this.NetworkRuleSet.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "networkRuleSet {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ResourceGroup? ResourceGroup
        // GraphQL -> resourceGroup: ResourceGroup (type)
        if (this.ResourceGroup != null) {
            var fspec = this.ResourceGroup.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "resourceGroup {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> StorageAccountTier? AccessTier
        // GraphQL -> accessTier: StorageAccountTier! (enum)
        if (this.AccessTier == null && ec.Includes("accessTier",true))
        {
            this.AccessTier = new StorageAccountTier();
        }
        //      C# -> StorageAccountSku? Sku
        // GraphQL -> sku: StorageAccountSku! (enum)
        if (this.Sku == null && ec.Includes("sku",true))
        {
            this.Sku = new StorageAccountSku();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsVersioningEnabled
        // GraphQL -> isVersioningEnabled: Boolean! (scalar)
        if (this.IsVersioningEnabled == null && ec.Includes("isVersioningEnabled",true))
        {
            this.IsVersioningEnabled = true;
        }
        //      C# -> System.String? Kind
        // GraphQL -> kind: String! (scalar)
        if (this.Kind == null && ec.Includes("kind",true))
        {
            this.Kind = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? RegionName
        // GraphQL -> regionName: String! (scalar)
        if (this.RegionName == null && ec.Includes("regionName",true))
        {
            this.RegionName = "FETCH";
        }
        //      C# -> NetworkRuleSet? NetworkRuleSet
        // GraphQL -> networkRuleSet: NetworkRuleSet (type)
        if (this.NetworkRuleSet == null && ec.Includes("networkRuleSet",false))
        {
            this.NetworkRuleSet = new NetworkRuleSet();
            this.NetworkRuleSet.ApplyExploratoryFieldSpec(ec.NewChild("networkRuleSet"));
        }
        //      C# -> ResourceGroup? ResourceGroup
        // GraphQL -> resourceGroup: ResourceGroup (type)
        if (this.ResourceGroup == null && ec.Includes("resourceGroup",false))
        {
            this.ResourceGroup = new ResourceGroup();
            this.ResourceGroup.ApplyExploratoryFieldSpec(ec.NewChild("resourceGroup"));
        }
    }


    #endregion

    } // class StorageAccount
    
    #endregion

    public static class ListStorageAccountExtensions
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
            this List<StorageAccount> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<StorageAccount> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new StorageAccount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<StorageAccount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types