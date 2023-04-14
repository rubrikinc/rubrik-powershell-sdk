// AzureNativeExportCompatibleVmSizes.cs
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
    #region AzureNativeExportCompatibleVmSizes
    public class AzureNativeExportCompatibleVmSizes: IFragment
    {
        #region members
        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        [JsonProperty("availabilityZone")]
        public System.String? AvailabilityZone { get; set; }

        //      C# -> List<System.String>? VmSizes
        // GraphQL -> vmSizes: [String!]! (scalar)
        [JsonProperty("vmSizes")]
        public List<System.String>? VmSizes { get; set; }

        #endregion

    #region methods

    public AzureNativeExportCompatibleVmSizes Set(
        System.String? AvailabilityZone = null,
        List<System.String>? VmSizes = null
    ) 
    {
        if ( AvailabilityZone != null ) {
            this.AvailabilityZone = AvailabilityZone;
        }
        if ( VmSizes != null ) {
            this.VmSizes = VmSizes;
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
            //      C# -> System.String? AvailabilityZone
            // GraphQL -> availabilityZone: String! (scalar)
            if (this.AvailabilityZone != null)
            {
                 s += ind + "availabilityZone\n";

            }
            //      C# -> List<System.String>? VmSizes
            // GraphQL -> vmSizes: [String!]! (scalar)
            if (this.VmSizes != null)
            {
                 s += ind + "vmSizes\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AvailabilityZone
            // GraphQL -> availabilityZone: String! (scalar)
            if (this.AvailabilityZone == null && Exploration.Includes(parent + ".availabilityZone$"))
            {
                this.AvailabilityZone = new System.String("FETCH");
            }
            //      C# -> List<System.String>? VmSizes
            // GraphQL -> vmSizes: [String!]! (scalar)
            if (this.VmSizes == null && Exploration.Includes(parent + ".vmSizes$"))
            {
                this.VmSizes = new List<System.String>();
            }
        }


    #endregion

    } // class AzureNativeExportCompatibleVmSizes
    #endregion

    public static class ListAzureNativeExportCompatibleVmSizesExtensions
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
            this List<AzureNativeExportCompatibleVmSizes> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureNativeExportCompatibleVmSizes> list, 
            String parent = "")
        {
            var item = new AzureNativeExportCompatibleVmSizes();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types