// AzureNativeExportCompatibleDiskTypes.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:15.
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
    #region AzureNativeExportCompatibleDiskTypes
    public class AzureNativeExportCompatibleDiskTypes: IFragment
    {
        #region members
        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        [JsonProperty("availabilityZone")]
        public System.String? AvailabilityZone { get; set; }

        //      C# -> List<AzureNativeManagedDiskType>? DiskTypes
        // GraphQL -> diskTypes: [AzureNativeManagedDiskType!]! (enum)
        [JsonProperty("diskTypes")]
        public List<AzureNativeManagedDiskType>? DiskTypes { get; set; }

        #endregion

    #region methods

    public AzureNativeExportCompatibleDiskTypes Set(
        System.String? AvailabilityZone = null,
        List<AzureNativeManagedDiskType>? DiskTypes = null
    ) 
    {
        if ( AvailabilityZone != null ) {
            this.AvailabilityZone = AvailabilityZone;
        }
        if ( DiskTypes != null ) {
            this.DiskTypes = DiskTypes;
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
            //      C# -> List<AzureNativeManagedDiskType>? DiskTypes
            // GraphQL -> diskTypes: [AzureNativeManagedDiskType!]! (enum)
            if (this.DiskTypes != null)
            {
                 s += ind + "diskTypes\n";

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
            //      C# -> List<AzureNativeManagedDiskType>? DiskTypes
            // GraphQL -> diskTypes: [AzureNativeManagedDiskType!]! (enum)
            if (this.DiskTypes == null && Exploration.Includes(parent + ".diskTypes$"))
            {
                this.DiskTypes = new List<AzureNativeManagedDiskType>();
            }
        }


    #endregion

    } // class AzureNativeExportCompatibleDiskTypes
    #endregion

    public static class ListAzureNativeExportCompatibleDiskTypesExtensions
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
            this List<AzureNativeExportCompatibleDiskTypes> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureNativeExportCompatibleDiskTypes> list, 
            String parent = "")
        {
            var item = new AzureNativeExportCompatibleDiskTypes();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types