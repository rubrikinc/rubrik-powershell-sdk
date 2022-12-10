// GcpNativeAttachmentDetails.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:34.
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
    #region GcpNativeAttachmentDetails
    public class GcpNativeAttachmentDetails: IFragment
    {
        #region members
        //      C# -> System.String? DeviceName
        // GraphQL -> deviceName: String! (scalar)
        [JsonProperty("deviceName")]
        public System.String? DeviceName { get; set; }

        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        [JsonProperty("diskId")]
        public System.String? DiskId { get; set; }

        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        [JsonProperty("diskName")]
        public System.String? DiskName { get; set; }

        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        [JsonProperty("instanceId")]
        public System.String? InstanceId { get; set; }

        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        [JsonProperty("instanceName")]
        public System.String? InstanceName { get; set; }

        //      C# -> System.String? InstanceZone
        // GraphQL -> instanceZone: String! (scalar)
        [JsonProperty("instanceZone")]
        public System.String? InstanceZone { get; set; }

        //      C# -> System.Boolean? IsBootDisk
        // GraphQL -> isBootDisk: Boolean! (scalar)
        [JsonProperty("isBootDisk")]
        public System.Boolean? IsBootDisk { get; set; }

        //      C# -> System.Boolean? IsExcluded
        // GraphQL -> isExcluded: Boolean! (scalar)
        [JsonProperty("isExcluded")]
        public System.Boolean? IsExcluded { get; set; }

        //      C# -> System.Int32? SizeInGiBs
        // GraphQL -> sizeInGiBs: Int! (scalar)
        [JsonProperty("sizeInGiBs")]
        public System.Int32? SizeInGiBs { get; set; }

        #endregion

    #region methods

    public GcpNativeAttachmentDetails Set(
        System.String? DeviceName = null,
        System.String? DiskId = null,
        System.String? DiskName = null,
        System.String? InstanceId = null,
        System.String? InstanceName = null,
        System.String? InstanceZone = null,
        System.Boolean? IsBootDisk = null,
        System.Boolean? IsExcluded = null,
        System.Int32? SizeInGiBs = null
    ) 
    {
        if ( DeviceName != null ) {
            this.DeviceName = DeviceName;
        }
        if ( DiskId != null ) {
            this.DiskId = DiskId;
        }
        if ( DiskName != null ) {
            this.DiskName = DiskName;
        }
        if ( InstanceId != null ) {
            this.InstanceId = InstanceId;
        }
        if ( InstanceName != null ) {
            this.InstanceName = InstanceName;
        }
        if ( InstanceZone != null ) {
            this.InstanceZone = InstanceZone;
        }
        if ( IsBootDisk != null ) {
            this.IsBootDisk = IsBootDisk;
        }
        if ( IsExcluded != null ) {
            this.IsExcluded = IsExcluded;
        }
        if ( SizeInGiBs != null ) {
            this.SizeInGiBs = SizeInGiBs;
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
            //      C# -> System.String? DeviceName
            // GraphQL -> deviceName: String! (scalar)
            if (this.DeviceName != null)
            {
                 s += ind + "deviceName\n";

            }
            //      C# -> System.String? DiskId
            // GraphQL -> diskId: String! (scalar)
            if (this.DiskId != null)
            {
                 s += ind + "diskId\n";

            }
            //      C# -> System.String? DiskName
            // GraphQL -> diskName: String! (scalar)
            if (this.DiskName != null)
            {
                 s += ind + "diskName\n";

            }
            //      C# -> System.String? InstanceId
            // GraphQL -> instanceId: String! (scalar)
            if (this.InstanceId != null)
            {
                 s += ind + "instanceId\n";

            }
            //      C# -> System.String? InstanceName
            // GraphQL -> instanceName: String! (scalar)
            if (this.InstanceName != null)
            {
                 s += ind + "instanceName\n";

            }
            //      C# -> System.String? InstanceZone
            // GraphQL -> instanceZone: String! (scalar)
            if (this.InstanceZone != null)
            {
                 s += ind + "instanceZone\n";

            }
            //      C# -> System.Boolean? IsBootDisk
            // GraphQL -> isBootDisk: Boolean! (scalar)
            if (this.IsBootDisk != null)
            {
                 s += ind + "isBootDisk\n";

            }
            //      C# -> System.Boolean? IsExcluded
            // GraphQL -> isExcluded: Boolean! (scalar)
            if (this.IsExcluded != null)
            {
                 s += ind + "isExcluded\n";

            }
            //      C# -> System.Int32? SizeInGiBs
            // GraphQL -> sizeInGiBs: Int! (scalar)
            if (this.SizeInGiBs != null)
            {
                 s += ind + "sizeInGiBs\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? DeviceName
            // GraphQL -> deviceName: String! (scalar)
            if (this.DeviceName == null && Exploration.Includes(parent + ".deviceName$"))
            {
                this.DeviceName = new System.String("FETCH");
            }
            //      C# -> System.String? DiskId
            // GraphQL -> diskId: String! (scalar)
            if (this.DiskId == null && Exploration.Includes(parent + ".diskId$"))
            {
                this.DiskId = new System.String("FETCH");
            }
            //      C# -> System.String? DiskName
            // GraphQL -> diskName: String! (scalar)
            if (this.DiskName == null && Exploration.Includes(parent + ".diskName$"))
            {
                this.DiskName = new System.String("FETCH");
            }
            //      C# -> System.String? InstanceId
            // GraphQL -> instanceId: String! (scalar)
            if (this.InstanceId == null && Exploration.Includes(parent + ".instanceId$"))
            {
                this.InstanceId = new System.String("FETCH");
            }
            //      C# -> System.String? InstanceName
            // GraphQL -> instanceName: String! (scalar)
            if (this.InstanceName == null && Exploration.Includes(parent + ".instanceName$"))
            {
                this.InstanceName = new System.String("FETCH");
            }
            //      C# -> System.String? InstanceZone
            // GraphQL -> instanceZone: String! (scalar)
            if (this.InstanceZone == null && Exploration.Includes(parent + ".instanceZone$"))
            {
                this.InstanceZone = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsBootDisk
            // GraphQL -> isBootDisk: Boolean! (scalar)
            if (this.IsBootDisk == null && Exploration.Includes(parent + ".isBootDisk$"))
            {
                this.IsBootDisk = new System.Boolean();
            }
            //      C# -> System.Boolean? IsExcluded
            // GraphQL -> isExcluded: Boolean! (scalar)
            if (this.IsExcluded == null && Exploration.Includes(parent + ".isExcluded$"))
            {
                this.IsExcluded = new System.Boolean();
            }
            //      C# -> System.Int32? SizeInGiBs
            // GraphQL -> sizeInGiBs: Int! (scalar)
            if (this.SizeInGiBs == null && Exploration.Includes(parent + ".sizeInGiBs$"))
            {
                this.SizeInGiBs = new System.Int32();
            }
        }


    #endregion

    } // class GcpNativeAttachmentDetails
    #endregion

    public static class ListGcpNativeAttachmentDetailsExtensions
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
            this List<GcpNativeAttachmentDetails> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GcpNativeAttachmentDetails> list, 
            String parent = "")
        {
            var item = new GcpNativeAttachmentDetails();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types