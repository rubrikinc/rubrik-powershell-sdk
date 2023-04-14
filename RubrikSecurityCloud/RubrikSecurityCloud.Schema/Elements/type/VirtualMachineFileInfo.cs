// VirtualMachineFileInfo.cs
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
    #region VirtualMachineFileInfo
    public class VirtualMachineFileInfo: IFragment
    {
        #region members
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        [JsonProperty("fileName")]
        public System.String? FileName { get; set; }

        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        [JsonProperty("sizeInBytes")]
        public System.Int64? SizeInBytes { get; set; }

        //      C# -> VirtualMachineFileType? FileType
        // GraphQL -> fileType: VirtualMachineFileType! (enum)
        [JsonProperty("fileType")]
        public VirtualMachineFileType? FileType { get; set; }

        #endregion

    #region methods

    public VirtualMachineFileInfo Set(
        System.String? FileName = null,
        System.Int64? SizeInBytes = null,
        VirtualMachineFileType? FileType = null
    ) 
    {
        if ( FileName != null ) {
            this.FileName = FileName;
        }
        if ( SizeInBytes != null ) {
            this.SizeInBytes = SizeInBytes;
        }
        if ( FileType != null ) {
            this.FileType = FileType;
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
            //      C# -> System.String? FileName
            // GraphQL -> fileName: String! (scalar)
            if (this.FileName != null)
            {
                 s += ind + "fileName\n";

            }
            //      C# -> System.Int64? SizeInBytes
            // GraphQL -> sizeInBytes: Long! (scalar)
            if (this.SizeInBytes != null)
            {
                 s += ind + "sizeInBytes\n";

            }
            //      C# -> VirtualMachineFileType? FileType
            // GraphQL -> fileType: VirtualMachineFileType! (enum)
            if (this.FileType != null)
            {
                 s += ind + "fileType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? FileName
            // GraphQL -> fileName: String! (scalar)
            if (this.FileName == null && Exploration.Includes(parent + ".fileName$"))
            {
                this.FileName = new System.String("FETCH");
            }
            //      C# -> System.Int64? SizeInBytes
            // GraphQL -> sizeInBytes: Long! (scalar)
            if (this.SizeInBytes == null && Exploration.Includes(parent + ".sizeInBytes$"))
            {
                this.SizeInBytes = new System.Int64();
            }
            //      C# -> VirtualMachineFileType? FileType
            // GraphQL -> fileType: VirtualMachineFileType! (enum)
            if (this.FileType == null && Exploration.Includes(parent + ".fileType$"))
            {
                this.FileType = new VirtualMachineFileType();
            }
        }


    #endregion

    } // class VirtualMachineFileInfo
    #endregion

    public static class ListVirtualMachineFileInfoExtensions
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
            this List<VirtualMachineFileInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VirtualMachineFileInfo> list, 
            String parent = "")
        {
            var item = new VirtualMachineFileInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types