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
            this List<AzureKeyVault> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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