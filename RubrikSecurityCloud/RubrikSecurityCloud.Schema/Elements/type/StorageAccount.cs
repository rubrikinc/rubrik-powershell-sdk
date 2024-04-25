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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> StorageAccountTier? AccessTier
        // GraphQL -> accessTier: StorageAccountTier! (enum)
        if (this.AccessTier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessTier\n" ;
            } else {
                s += ind + "accessTier\n" ;
            }
        }
        //      C# -> StorageAccountSku? Sku
        // GraphQL -> sku: StorageAccountSku! (enum)
        if (this.Sku != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sku\n" ;
            } else {
                s += ind + "sku\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsVersioningEnabled
        // GraphQL -> isVersioningEnabled: Boolean! (scalar)
        if (this.IsVersioningEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isVersioningEnabled\n" ;
            } else {
                s += ind + "isVersioningEnabled\n" ;
            }
        }
        //      C# -> System.String? Kind
        // GraphQL -> kind: String! (scalar)
        if (this.Kind != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kind\n" ;
            } else {
                s += ind + "kind\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? RegionName
        // GraphQL -> regionName: String! (scalar)
        if (this.RegionName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "regionName\n" ;
            } else {
                s += ind + "regionName\n" ;
            }
        }
        //      C# -> NetworkRuleSet? NetworkRuleSet
        // GraphQL -> networkRuleSet: NetworkRuleSet (type)
        if (this.NetworkRuleSet != null) {
            var fspec = this.NetworkRuleSet.AsFieldSpec(conf.Child("networkRuleSet"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "networkRuleSet" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ResourceGroup? ResourceGroup
        // GraphQL -> resourceGroup: ResourceGroup (type)
        if (this.ResourceGroup != null) {
            var fspec = this.ResourceGroup.AsFieldSpec(conf.Child("resourceGroup"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "resourceGroup" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> StorageAccountTier? AccessTier
        // GraphQL -> accessTier: StorageAccountTier! (enum)
        if (ec.Includes("accessTier",true))
        {
            if(this.AccessTier == null) {

                this.AccessTier = new StorageAccountTier();

            } else {


            }
        }
        else if (this.AccessTier != null && ec.Excludes("accessTier",true))
        {
            this.AccessTier = null;
        }
        //      C# -> StorageAccountSku? Sku
        // GraphQL -> sku: StorageAccountSku! (enum)
        if (ec.Includes("sku",true))
        {
            if(this.Sku == null) {

                this.Sku = new StorageAccountSku();

            } else {


            }
        }
        else if (this.Sku != null && ec.Excludes("sku",true))
        {
            this.Sku = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsVersioningEnabled
        // GraphQL -> isVersioningEnabled: Boolean! (scalar)
        if (ec.Includes("isVersioningEnabled",true))
        {
            if(this.IsVersioningEnabled == null) {

                this.IsVersioningEnabled = true;

            } else {


            }
        }
        else if (this.IsVersioningEnabled != null && ec.Excludes("isVersioningEnabled",true))
        {
            this.IsVersioningEnabled = null;
        }
        //      C# -> System.String? Kind
        // GraphQL -> kind: String! (scalar)
        if (ec.Includes("kind",true))
        {
            if(this.Kind == null) {

                this.Kind = "FETCH";

            } else {


            }
        }
        else if (this.Kind != null && ec.Excludes("kind",true))
        {
            this.Kind = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? RegionName
        // GraphQL -> regionName: String! (scalar)
        if (ec.Includes("regionName",true))
        {
            if(this.RegionName == null) {

                this.RegionName = "FETCH";

            } else {


            }
        }
        else if (this.RegionName != null && ec.Excludes("regionName",true))
        {
            this.RegionName = null;
        }
        //      C# -> NetworkRuleSet? NetworkRuleSet
        // GraphQL -> networkRuleSet: NetworkRuleSet (type)
        if (ec.Includes("networkRuleSet",false))
        {
            if(this.NetworkRuleSet == null) {

                this.NetworkRuleSet = new NetworkRuleSet();
                this.NetworkRuleSet.ApplyExploratoryFieldSpec(ec.NewChild("networkRuleSet"));

            } else {

                this.NetworkRuleSet.ApplyExploratoryFieldSpec(ec.NewChild("networkRuleSet"));

            }
        }
        else if (this.NetworkRuleSet != null && ec.Excludes("networkRuleSet",false))
        {
            this.NetworkRuleSet = null;
        }
        //      C# -> ResourceGroup? ResourceGroup
        // GraphQL -> resourceGroup: ResourceGroup (type)
        if (ec.Includes("resourceGroup",false))
        {
            if(this.ResourceGroup == null) {

                this.ResourceGroup = new ResourceGroup();
                this.ResourceGroup.ApplyExploratoryFieldSpec(ec.NewChild("resourceGroup"));

            } else {

                this.ResourceGroup.ApplyExploratoryFieldSpec(ec.NewChild("resourceGroup"));

            }
        }
        else if (this.ResourceGroup != null && ec.Excludes("resourceGroup",false))
        {
            this.ResourceGroup = null;
        }
    }


    #endregion

    } // class StorageAccount
    
    #endregion

    public static class ListStorageAccountExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<StorageAccount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<StorageAccount> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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