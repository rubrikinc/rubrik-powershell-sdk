// AddAzureCloudAccountReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:21.
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
    #region AddAzureCloudAccountReply
    public class AddAzureCloudAccountReply: IFragment
    {
        #region members
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }

        //      C# -> List<AddAzureCloudAccountStatus>? Status
        // GraphQL -> status: [AddAzureCloudAccountStatus!]! (type)
        [JsonProperty("status")]
        public List<AddAzureCloudAccountStatus>? Status { get; set; }

        #endregion

    #region methods

    public AddAzureCloudAccountReply Set(
        System.String? TenantId = null,
        List<AddAzureCloudAccountStatus>? Status = null
    ) 
    {
        if ( TenantId != null ) {
            this.TenantId = TenantId;
        }
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> System.String? TenantId
            // GraphQL -> tenantId: String! (scalar)
            if (this.TenantId != null)
            {
                 s += ind + "tenantId\n";

            }
            //      C# -> List<AddAzureCloudAccountStatus>? Status
            // GraphQL -> status: [AddAzureCloudAccountStatus!]! (type)
            if (this.Status != null)
            {
                 s += ind + "status\n";

                 s += ind + "{\n" + 
                 this.Status.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? TenantId
            // GraphQL -> tenantId: String! (scalar)
            if (this.TenantId == null && Exploration.Includes(parent + ".tenantId$"))
            {
                this.TenantId = new System.String("FETCH");
            }
            //      C# -> List<AddAzureCloudAccountStatus>? Status
            // GraphQL -> status: [AddAzureCloudAccountStatus!]! (type)
            if (this.Status == null && Exploration.Includes(parent + ".status"))
            {
                this.Status = new List<AddAzureCloudAccountStatus>();
                this.Status.ApplyExploratoryFragment(parent + ".status");
            }
        }


    #endregion

    } // class AddAzureCloudAccountReply
    #endregion

    public static class ListAddAzureCloudAccountReplyExtensions
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
            this List<AddAzureCloudAccountReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AddAzureCloudAccountReply> list, 
            String parent = "")
        {
            var item = new AddAzureCloudAccountReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types