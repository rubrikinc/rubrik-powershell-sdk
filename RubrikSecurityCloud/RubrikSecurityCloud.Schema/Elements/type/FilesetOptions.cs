// FilesetOptions.cs
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
    #region FilesetOptions
    public class FilesetOptions: BaseType
    {
        #region members

        //      C# -> System.Boolean? AllowBackupHiddenFoldersInNetworkMounts
        // GraphQL -> allowBackupHiddenFoldersInNetworkMounts: Boolean (scalar)
        [JsonProperty("allowBackupHiddenFoldersInNetworkMounts")]
        public System.Boolean? AllowBackupHiddenFoldersInNetworkMounts { get; set; }

        //      C# -> System.Boolean? AllowBackupNetworkMounts
        // GraphQL -> allowBackupNetworkMounts: Boolean (scalar)
        [JsonProperty("allowBackupNetworkMounts")]
        public System.Boolean? AllowBackupNetworkMounts { get; set; }

        //      C# -> System.Boolean? UseWindowsVss
        // GraphQL -> useWindowsVss: Boolean (scalar)
        [JsonProperty("useWindowsVss")]
        public System.Boolean? UseWindowsVss { get; set; }


        #endregion

    #region methods

    public FilesetOptions Set(
        System.Boolean? AllowBackupHiddenFoldersInNetworkMounts = null,
        System.Boolean? AllowBackupNetworkMounts = null,
        System.Boolean? UseWindowsVss = null
    ) 
    {
        if ( AllowBackupHiddenFoldersInNetworkMounts != null ) {
            this.AllowBackupHiddenFoldersInNetworkMounts = AllowBackupHiddenFoldersInNetworkMounts;
        }
        if ( AllowBackupNetworkMounts != null ) {
            this.AllowBackupNetworkMounts = AllowBackupNetworkMounts;
        }
        if ( UseWindowsVss != null ) {
            this.UseWindowsVss = UseWindowsVss;
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
        //      C# -> System.Boolean? AllowBackupHiddenFoldersInNetworkMounts
        // GraphQL -> allowBackupHiddenFoldersInNetworkMounts: Boolean (scalar)
        if (this.AllowBackupHiddenFoldersInNetworkMounts != null) {
            s += ind + "allowBackupHiddenFoldersInNetworkMounts\n" ;
        }
        //      C# -> System.Boolean? AllowBackupNetworkMounts
        // GraphQL -> allowBackupNetworkMounts: Boolean (scalar)
        if (this.AllowBackupNetworkMounts != null) {
            s += ind + "allowBackupNetworkMounts\n" ;
        }
        //      C# -> System.Boolean? UseWindowsVss
        // GraphQL -> useWindowsVss: Boolean (scalar)
        if (this.UseWindowsVss != null) {
            s += ind + "useWindowsVss\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? AllowBackupHiddenFoldersInNetworkMounts
        // GraphQL -> allowBackupHiddenFoldersInNetworkMounts: Boolean (scalar)
        if (this.AllowBackupHiddenFoldersInNetworkMounts == null && Exploration.Includes(parent + ".allowBackupHiddenFoldersInNetworkMounts", true))
        {
            this.AllowBackupHiddenFoldersInNetworkMounts = true;
        }
        //      C# -> System.Boolean? AllowBackupNetworkMounts
        // GraphQL -> allowBackupNetworkMounts: Boolean (scalar)
        if (this.AllowBackupNetworkMounts == null && Exploration.Includes(parent + ".allowBackupNetworkMounts", true))
        {
            this.AllowBackupNetworkMounts = true;
        }
        //      C# -> System.Boolean? UseWindowsVss
        // GraphQL -> useWindowsVss: Boolean (scalar)
        if (this.UseWindowsVss == null && Exploration.Includes(parent + ".useWindowsVss", true))
        {
            this.UseWindowsVss = true;
        }
    }


    #endregion

    } // class FilesetOptions
    
    #endregion

    public static class ListFilesetOptionsExtensions
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
            this List<FilesetOptions> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FilesetOptions> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FilesetOptions());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types