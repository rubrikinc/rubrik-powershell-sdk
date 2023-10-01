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

    public override string GetGqlTypeName() {
        return "FilesetOptions";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? AllowBackupHiddenFoldersInNetworkMounts
        // GraphQL -> allowBackupHiddenFoldersInNetworkMounts: Boolean (scalar)
        if (this.AllowBackupHiddenFoldersInNetworkMounts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "allowBackupHiddenFoldersInNetworkMounts\n" ;
            } else {
                s += ind + "allowBackupHiddenFoldersInNetworkMounts\n" ;
            }
        }
        //      C# -> System.Boolean? AllowBackupNetworkMounts
        // GraphQL -> allowBackupNetworkMounts: Boolean (scalar)
        if (this.AllowBackupNetworkMounts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "allowBackupNetworkMounts\n" ;
            } else {
                s += ind + "allowBackupNetworkMounts\n" ;
            }
        }
        //      C# -> System.Boolean? UseWindowsVss
        // GraphQL -> useWindowsVss: Boolean (scalar)
        if (this.UseWindowsVss != null) {
            if (conf.Flat) {
                s += conf.Prefix + "useWindowsVss\n" ;
            } else {
                s += ind + "useWindowsVss\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? AllowBackupHiddenFoldersInNetworkMounts
        // GraphQL -> allowBackupHiddenFoldersInNetworkMounts: Boolean (scalar)
        if (ec.Includes("allowBackupHiddenFoldersInNetworkMounts",true))
        {
            if(this.AllowBackupHiddenFoldersInNetworkMounts == null) {

                this.AllowBackupHiddenFoldersInNetworkMounts = true;

            } else {


            }
        }
        else if (this.AllowBackupHiddenFoldersInNetworkMounts != null && ec.Excludes("allowBackupHiddenFoldersInNetworkMounts",true))
        {
            this.AllowBackupHiddenFoldersInNetworkMounts = null;
        }
        //      C# -> System.Boolean? AllowBackupNetworkMounts
        // GraphQL -> allowBackupNetworkMounts: Boolean (scalar)
        if (ec.Includes("allowBackupNetworkMounts",true))
        {
            if(this.AllowBackupNetworkMounts == null) {

                this.AllowBackupNetworkMounts = true;

            } else {


            }
        }
        else if (this.AllowBackupNetworkMounts != null && ec.Excludes("allowBackupNetworkMounts",true))
        {
            this.AllowBackupNetworkMounts = null;
        }
        //      C# -> System.Boolean? UseWindowsVss
        // GraphQL -> useWindowsVss: Boolean (scalar)
        if (ec.Includes("useWindowsVss",true))
        {
            if(this.UseWindowsVss == null) {

                this.UseWindowsVss = true;

            } else {


            }
        }
        else if (this.UseWindowsVss != null && ec.Excludes("useWindowsVss",true))
        {
            this.UseWindowsVss = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<FilesetOptions> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FilesetOptions> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FilesetOptions());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FilesetOptions> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types