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

namespace Rubrik.SecurityCloud.Types
{
    #region AddAzureCloudAccountStatus
    public class AddAzureCloudAccountStatus: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? AzureSubscriptionNativeId
            // GraphQL -> azureSubscriptionNativeId: String! (scalar)
            if (this.AzureSubscriptionNativeId != null)
            {
                 s += ind + "azureSubscriptionNativeId\n";

            }
            //      C# -> System.String? AzureSubscriptionRubrikId
            // GraphQL -> azureSubscriptionRubrikId: String! (scalar)
            if (this.AzureSubscriptionRubrikId != null)
            {
                 s += ind + "azureSubscriptionRubrikId\n";

            }
            //      C# -> System.String? Error
            // GraphQL -> error: String! (scalar)
            if (this.Error != null)
            {
                 s += ind + "error\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AzureSubscriptionNativeId
            // GraphQL -> azureSubscriptionNativeId: String! (scalar)
            if (this.AzureSubscriptionNativeId == null && Exploration.Includes(parent + ".azureSubscriptionNativeId$"))
            {
                this.AzureSubscriptionNativeId = new System.String("FETCH");
            }
            //      C# -> System.String? AzureSubscriptionRubrikId
            // GraphQL -> azureSubscriptionRubrikId: String! (scalar)
            if (this.AzureSubscriptionRubrikId == null && Exploration.Includes(parent + ".azureSubscriptionRubrikId$"))
            {
                this.AzureSubscriptionRubrikId = new System.String("FETCH");
            }
            //      C# -> System.String? Error
            // GraphQL -> error: String! (scalar)
            if (this.Error == null && Exploration.Includes(parent + ".error$"))
            {
                this.Error = new System.String("FETCH");
            }
        }


    #endregion

    } // class AddAzureCloudAccountStatus
    #endregion

    public static class ListAddAzureCloudAccountStatusExtensions
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
            this List<AddAzureCloudAccountStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AddAzureCloudAccountStatus> list, 
            String parent = "")
        {
            var item = new AddAzureCloudAccountStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types