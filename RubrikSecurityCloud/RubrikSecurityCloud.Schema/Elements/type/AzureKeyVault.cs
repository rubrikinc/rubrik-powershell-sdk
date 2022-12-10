// AzureKeyVault.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:24.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region AzureKeyVault
    public class AzureKeyVault: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Boolean? IsAccessibleByUserAssignedManagedIdentity
            // GraphQL -> isAccessibleByUserAssignedManagedIdentity: Boolean! (scalar)
            if (this.IsAccessibleByUserAssignedManagedIdentity != null)
            {
                 s += ind + "isAccessibleByUserAssignedManagedIdentity\n";

            }
            //      C# -> System.String? KeyVaultName
            // GraphQL -> keyVaultName: String! (scalar)
            if (this.KeyVaultName != null)
            {
                 s += ind + "keyVaultName\n";

            }
            //      C# -> System.String? ResourceGroupName
            // GraphQL -> resourceGroupName: String! (scalar)
            if (this.ResourceGroupName != null)
            {
                 s += ind + "resourceGroupName\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsAccessibleByUserAssignedManagedIdentity
            // GraphQL -> isAccessibleByUserAssignedManagedIdentity: Boolean! (scalar)
            if (this.IsAccessibleByUserAssignedManagedIdentity == null && Exploration.Includes(parent + ".isAccessibleByUserAssignedManagedIdentity$"))
            {
                this.IsAccessibleByUserAssignedManagedIdentity = new System.Boolean();
            }
            //      C# -> System.String? KeyVaultName
            // GraphQL -> keyVaultName: String! (scalar)
            if (this.KeyVaultName == null && Exploration.Includes(parent + ".keyVaultName$"))
            {
                this.KeyVaultName = new System.String("FETCH");
            }
            //      C# -> System.String? ResourceGroupName
            // GraphQL -> resourceGroupName: String! (scalar)
            if (this.ResourceGroupName == null && Exploration.Includes(parent + ".resourceGroupName$"))
            {
                this.ResourceGroupName = new System.String("FETCH");
            }
        }


    #endregion

    } // class AzureKeyVault
    #endregion

    public static class ListAzureKeyVaultExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<AzureKeyVault> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureKeyVault> list, 
            String parent = "")
        {
            var item = new AzureKeyVault();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types