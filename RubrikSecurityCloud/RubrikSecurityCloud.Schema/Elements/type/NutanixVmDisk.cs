// NutanixVmDisk.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:50.
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
    #region NutanixVmDisk
    public class NutanixVmDisk: IFragment
    {
        #region members
        //      C# -> System.String? DeviceType
        // GraphQL -> deviceType: String! (scalar)
        [JsonProperty("deviceType")]
        public System.String? DeviceType { get; set; }

        //      C# -> System.Boolean? IsSnapshottable
        // GraphQL -> isSnapshottable: Boolean! (scalar)
        [JsonProperty("isSnapshottable")]
        public System.Boolean? IsSnapshottable { get; set; }

        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        [JsonProperty("label")]
        public System.String? Label { get; set; }

        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        [JsonProperty("sizeInBytes")]
        public System.Int64? SizeInBytes { get; set; }

        //      C# -> System.String? Uuid
        // GraphQL -> uuid: String! (scalar)
        [JsonProperty("uuid")]
        public System.String? Uuid { get; set; }

        //      C# -> System.String? VmDiskUuid
        // GraphQL -> vmDiskUuid: String! (scalar)
        [JsonProperty("vmDiskUuid")]
        public System.String? VmDiskUuid { get; set; }

        #endregion

    #region methods

    public NutanixVmDisk Set(
        System.String? DeviceType = null,
        System.Boolean? IsSnapshottable = null,
        System.String? Label = null,
        System.Int64? SizeInBytes = null,
        System.String? Uuid = null,
        System.String? VmDiskUuid = null
    ) 
    {
        if ( DeviceType != null ) {
            this.DeviceType = DeviceType;
        }
        if ( IsSnapshottable != null ) {
            this.IsSnapshottable = IsSnapshottable;
        }
        if ( Label != null ) {
            this.Label = Label;
        }
        if ( SizeInBytes != null ) {
            this.SizeInBytes = SizeInBytes;
        }
        if ( Uuid != null ) {
            this.Uuid = Uuid;
        }
        if ( VmDiskUuid != null ) {
            this.VmDiskUuid = VmDiskUuid;
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
            //      C# -> System.String? DeviceType
            // GraphQL -> deviceType: String! (scalar)
            if (this.DeviceType != null)
            {
                 s += ind + "deviceType\n";

            }
            //      C# -> System.Boolean? IsSnapshottable
            // GraphQL -> isSnapshottable: Boolean! (scalar)
            if (this.IsSnapshottable != null)
            {
                 s += ind + "isSnapshottable\n";

            }
            //      C# -> System.String? Label
            // GraphQL -> label: String! (scalar)
            if (this.Label != null)
            {
                 s += ind + "label\n";

            }
            //      C# -> System.Int64? SizeInBytes
            // GraphQL -> sizeInBytes: Long! (scalar)
            if (this.SizeInBytes != null)
            {
                 s += ind + "sizeInBytes\n";

            }
            //      C# -> System.String? Uuid
            // GraphQL -> uuid: String! (scalar)
            if (this.Uuid != null)
            {
                 s += ind + "uuid\n";

            }
            //      C# -> System.String? VmDiskUuid
            // GraphQL -> vmDiskUuid: String! (scalar)
            if (this.VmDiskUuid != null)
            {
                 s += ind + "vmDiskUuid\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? DeviceType
            // GraphQL -> deviceType: String! (scalar)
            if (this.DeviceType == null && Exploration.Includes(parent + ".deviceType$"))
            {
                this.DeviceType = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsSnapshottable
            // GraphQL -> isSnapshottable: Boolean! (scalar)
            if (this.IsSnapshottable == null && Exploration.Includes(parent + ".isSnapshottable$"))
            {
                this.IsSnapshottable = new System.Boolean();
            }
            //      C# -> System.String? Label
            // GraphQL -> label: String! (scalar)
            if (this.Label == null && Exploration.Includes(parent + ".label$"))
            {
                this.Label = new System.String("FETCH");
            }
            //      C# -> System.Int64? SizeInBytes
            // GraphQL -> sizeInBytes: Long! (scalar)
            if (this.SizeInBytes == null && Exploration.Includes(parent + ".sizeInBytes$"))
            {
                this.SizeInBytes = new System.Int64();
            }
            //      C# -> System.String? Uuid
            // GraphQL -> uuid: String! (scalar)
            if (this.Uuid == null && Exploration.Includes(parent + ".uuid$"))
            {
                this.Uuid = new System.String("FETCH");
            }
            //      C# -> System.String? VmDiskUuid
            // GraphQL -> vmDiskUuid: String! (scalar)
            if (this.VmDiskUuid == null && Exploration.Includes(parent + ".vmDiskUuid$"))
            {
                this.VmDiskUuid = new System.String("FETCH");
            }
        }


    #endregion

    } // class NutanixVmDisk
    #endregion

    public static class ListNutanixVmDiskExtensions
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
            this List<NutanixVmDisk> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NutanixVmDisk> list, 
            String parent = "")
        {
            var item = new NutanixVmDisk();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types