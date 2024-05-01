// AzureKeyVault.cs
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
    #region AzureKeyVault
    public class AzureKeyVault: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsAccessibleByUserAssignedManagedIdentity
        // GraphQL -> isAccessibleByUserAssignedManagedIdentity: Boolean! (scalar)
        [JsonProperty("isAccessibleByUserAssignedManagedIdentity")]
        public System.Boolean? IsAccessibleByUserAssignedManagedIdentity { get; set; }

        //      C# -> System.String? KeyVaultName
        // GraphQL -> keyVaultName: String! (scalar)
        [JsonProperty("keyVaultName")]
        public System.String? KeyVaultName { get; set; }

        //      C# -> System.String? ResourceGroupName
        // GraphQL -> resourceGroupName: String! (scalar)
        [JsonProperty("resourceGroupName")]
        public System.String? ResourceGroupName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureKeyVault";
    }

    public AzureKeyVault Set(
        System.Boolean? IsAccessibleByUserAssignedManagedIdentity = null,
        System.String? KeyVaultName = null,
        System.String? ResourceGroupName = null
    ) 
    {
        if ( IsAccessibleByUserAssignedManagedIdentity != null ) {
            this.IsAccessibleByUserAssignedManagedIdentity = IsAccessibleByUserAssignedManagedIdentity;
        }
        if ( KeyVaultName != null ) {
            this.KeyVaultName = KeyVaultName;
        }
        if ( ResourceGroupName != null ) {
            this.ResourceGroupName = ResourceGroupName;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? IsAccessibleByUserAssignedManagedIdentity
        // GraphQL -> isAccessibleByUserAssignedManagedIdentity: Boolean! (scalar)
        if (this.IsAccessibleByUserAssignedManagedIdentity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAccessibleByUserAssignedManagedIdentity\n" ;
            } else {
                s += ind + "isAccessibleByUserAssignedManagedIdentity\n" ;
            }
        }
        //      C# -> System.String? KeyVaultName
        // GraphQL -> keyVaultName: String! (scalar)
        if (this.KeyVaultName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyVaultName\n" ;
            } else {
                s += ind + "keyVaultName\n" ;
            }
        }
        //      C# -> System.String? ResourceGroupName
        // GraphQL -> resourceGroupName: String! (scalar)
        if (this.ResourceGroupName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceGroupName\n" ;
            } else {
                s += ind + "resourceGroupName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsAccessibleByUserAssignedManagedIdentity
        // GraphQL -> isAccessibleByUserAssignedManagedIdentity: Boolean! (scalar)
        if (ec.Includes("isAccessibleByUserAssignedManagedIdentity",true))
        {
            if(this.IsAccessibleByUserAssignedManagedIdentity == null) {

                this.IsAccessibleByUserAssignedManagedIdentity = true;

            } else {


            }
        }
        else if (this.IsAccessibleByUserAssignedManagedIdentity != null && ec.Excludes("isAccessibleByUserAssignedManagedIdentity",true))
        {
            this.IsAccessibleByUserAssignedManagedIdentity = null;
        }
        //      C# -> System.String? KeyVaultName
        // GraphQL -> keyVaultName: String! (scalar)
        if (ec.Includes("keyVaultName",true))
        {
            if(this.KeyVaultName == null) {

                this.KeyVaultName = "FETCH";

            } else {


            }
        }
        else if (this.KeyVaultName != null && ec.Excludes("keyVaultName",true))
        {
            this.KeyVaultName = null;
        }
        //      C# -> System.String? ResourceGroupName
        // GraphQL -> resourceGroupName: String! (scalar)
        if (ec.Includes("resourceGroupName",true))
        {
            if(this.ResourceGroupName == null) {

                this.ResourceGroupName = "FETCH";

            } else {


            }
        }
        else if (this.ResourceGroupName != null && ec.Excludes("resourceGroupName",true))
        {
            this.ResourceGroupName = null;
        }
    }


    #endregion

    } // class AzureKeyVault
    
    #endregion

    public static class ListAzureKeyVaultExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AzureKeyVault> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureKeyVault> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureKeyVault> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureKeyVault());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureKeyVault> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types