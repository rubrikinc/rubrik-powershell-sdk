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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region VirtualMachineFileInfo
    public class VirtualMachineFileInfo: BaseType
    {
        #region members

        //      C# -> VirtualMachineFileType? FileType
        // GraphQL -> fileType: VirtualMachineFileType! (enum)
        [JsonProperty("fileType")]
        public VirtualMachineFileType? FileType { get; set; }

        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        [JsonProperty("fileName")]
        public System.String? FileName { get; set; }

        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        [JsonProperty("sizeInBytes")]
        public System.Int64? SizeInBytes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VirtualMachineFileInfo";
    }

    public VirtualMachineFileInfo Set(
        VirtualMachineFileType? FileType = null,
        System.String? FileName = null,
        System.Int64? SizeInBytes = null
    ) 
    {
        if ( FileType != null ) {
            this.FileType = FileType;
        }
        if ( FileName != null ) {
            this.FileName = FileName;
        }
        if ( SizeInBytes != null ) {
            this.SizeInBytes = SizeInBytes;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> VirtualMachineFileType? FileType
        // GraphQL -> fileType: VirtualMachineFileType! (enum)
        if (this.FileType != null) {
            s += ind + "fileType\n" ;
        }
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (this.FileName != null) {
            s += ind + "fileName\n" ;
        }
        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        if (this.SizeInBytes != null) {
            s += ind + "sizeInBytes\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> VirtualMachineFileType? FileType
        // GraphQL -> fileType: VirtualMachineFileType! (enum)
        if (this.FileType == null && ec.Includes("fileType",true))
        {
            this.FileType = new VirtualMachineFileType();
        }
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (this.FileName == null && ec.Includes("fileName",true))
        {
            this.FileName = "FETCH";
        }
        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        if (this.SizeInBytes == null && ec.Includes("sizeInBytes",true))
        {
            this.SizeInBytes = new System.Int64();
        }
    }


    #endregion

    } // class VirtualMachineFileInfo
    
    #endregion

    public static class ListVirtualMachineFileInfoExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<VirtualMachineFileInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VirtualMachineFileInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VirtualMachineFileInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<VirtualMachineFileInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types