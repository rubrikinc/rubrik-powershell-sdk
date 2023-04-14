// O365AppObject.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region O365AppObject
    public interface O365AppObject: IFragment
    {
        #region members
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        [JsonProperty("appId")]
        System.String? AppId { get; set; }

        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        [JsonProperty("subscriptionId")]
        System.String? SubscriptionId { get; set; }

        //      C# -> System.String? Subscription
        // GraphQL -> subscription: String! (scalar)
        [JsonProperty("subscription")]
        System.String? Subscription { get; set; }

        //      C# -> System.String? AppType
        // GraphQL -> appType: String! (scalar)
        [JsonProperty("appType")]
        System.String? AppType { get; set; }

        //      C# -> System.String? AppOwner
        // GraphQL -> appOwner: String! (scalar)
        [JsonProperty("appOwner")]
        System.String? AppOwner { get; set; }

        //      C# -> DateTime? AddedAt
        // GraphQL -> addedAt: DateTime! (scalar)
        [JsonProperty("addedAt")]
        DateTime? AddedAt { get; set; }

        //      C# -> System.Boolean? IsAuthenticated
        // GraphQL -> isAuthenticated: Boolean! (scalar)
        [JsonProperty("isAuthenticated")]
        System.Boolean? IsAuthenticated { get; set; }

        //      C# -> AppAuthStatus? AppAuthStatus
        // GraphQL -> appAuthStatus: AppAuthStatus! (enum)
        [JsonProperty("appAuthStatus")]
        AppAuthStatus? AppAuthStatus { get; set; }

        //      C# -> System.Int32? AppAuthVersion
        // GraphQL -> appAuthVersion: Int! (scalar)
        [JsonProperty("appAuthVersion")]
        System.Int32? AppAuthVersion { get; set; }

        #endregion

    } // class O365AppObject
    #endregion

    public static class ListO365AppObjectExtensions
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
            this List<O365AppObject> list,
            int indent=0)
        {
            string fragments = "";
            foreach (O365AppObject item in list) 
            {
                string typename = item.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);

                fragments += String.Format("... on {0}\n", typename);

                fragments += "{\n" +
                item.AsFragment(indent+1) +
                "}\n";
            }
            return fragments;
        }

        public static void ApplyExploratoryFragment(
            this List<O365AppObject> list, 
            String parent = "")
        {
            var item = (O365AppObject)InterfaceHelper.CreateInstanceOfFirstType(typeof(O365AppObject));
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types