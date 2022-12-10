// VappTemplateExportOptions.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:04.
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
    #region VappTemplateExportOptions
    public class VappTemplateExportOptions: IFragment
    {
        #region members
        //      C# -> System.String? OrgVdcId
        // GraphQL -> orgVdcId: String! (scalar)
        [JsonProperty("orgVdcId")]
        public System.String? OrgVdcId { get; set; }

        //      C# -> List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies
        // GraphQL -> availableStoragePolicies: [VcdOrgVdcStorageProfile!]! (type)
        [JsonProperty("availableStoragePolicies")]
        public List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies { get; set; }

        #endregion

    #region methods

    public VappTemplateExportOptions Set(
        System.String? OrgVdcId = null,
        List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies = null
    ) 
    {
        if ( OrgVdcId != null ) {
            this.OrgVdcId = OrgVdcId;
        }
        if ( AvailableStoragePolicies != null ) {
            this.AvailableStoragePolicies = AvailableStoragePolicies;
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
            //      C# -> System.String? OrgVdcId
            // GraphQL -> orgVdcId: String! (scalar)
            if (this.OrgVdcId != null)
            {
                 s += ind + "orgVdcId\n";

            }
            //      C# -> List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies
            // GraphQL -> availableStoragePolicies: [VcdOrgVdcStorageProfile!]! (type)
            if (this.AvailableStoragePolicies != null)
            {
                 s += ind + "availableStoragePolicies\n";

                 s += ind + "{\n" + 
                 this.AvailableStoragePolicies.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? OrgVdcId
            // GraphQL -> orgVdcId: String! (scalar)
            if (this.OrgVdcId == null && Exploration.Includes(parent + ".orgVdcId$"))
            {
                this.OrgVdcId = new System.String("FETCH");
            }
            //      C# -> List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies
            // GraphQL -> availableStoragePolicies: [VcdOrgVdcStorageProfile!]! (type)
            if (this.AvailableStoragePolicies == null && Exploration.Includes(parent + ".availableStoragePolicies"))
            {
                this.AvailableStoragePolicies = new List<VcdOrgVdcStorageProfile>();
                this.AvailableStoragePolicies.ApplyExploratoryFragment(parent + ".availableStoragePolicies");
            }
        }


    #endregion

    } // class VappTemplateExportOptions
    #endregion

    public static class ListVappTemplateExportOptionsExtensions
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
            this List<VappTemplateExportOptions> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VappTemplateExportOptions> list, 
            String parent = "")
        {
            var item = new VappTemplateExportOptions();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types