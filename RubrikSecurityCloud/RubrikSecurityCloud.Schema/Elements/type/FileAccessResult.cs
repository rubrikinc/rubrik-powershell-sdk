// FileAccessResult.cs
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
    #region FileAccessResult
    public class FileAccessResult: BaseType
    {
        #region members

        //      C# -> ActivityAccessType? AccessType
        // GraphQL -> accessType: ActivityAccessType! (enum)
        [JsonProperty("accessType")]
        public ActivityAccessType? AccessType { get; set; }

        //      C# -> System.String? Directory
        // GraphQL -> directory: String! (scalar)
        [JsonProperty("directory")]
        public System.String? Directory { get; set; }

        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        [JsonProperty("filename")]
        public System.String? Filename { get; set; }

        //      C# -> System.String? NativePath
        // GraphQL -> nativePath: String! (scalar)
        [JsonProperty("nativePath")]
        public System.String? NativePath { get; set; }

        //      C# -> System.Int32? NumAccesses
        // GraphQL -> numAccesses: Int! (scalar)
        [JsonProperty("numAccesses")]
        public System.Int32? NumAccesses { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FileAccessResult";
    }

    public FileAccessResult Set(
        ActivityAccessType? AccessType = null,
        System.String? Directory = null,
        System.String? Filename = null,
        System.String? NativePath = null,
        System.Int32? NumAccesses = null
    ) 
    {
        if ( AccessType != null ) {
            this.AccessType = AccessType;
        }
        if ( Directory != null ) {
            this.Directory = Directory;
        }
        if ( Filename != null ) {
            this.Filename = Filename;
        }
        if ( NativePath != null ) {
            this.NativePath = NativePath;
        }
        if ( NumAccesses != null ) {
            this.NumAccesses = NumAccesses;
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
        //      C# -> ActivityAccessType? AccessType
        // GraphQL -> accessType: ActivityAccessType! (enum)
        if (this.AccessType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessType\n" ;
            } else {
                s += ind + "accessType\n" ;
            }
        }
        //      C# -> System.String? Directory
        // GraphQL -> directory: String! (scalar)
        if (this.Directory != null) {
            if (conf.Flat) {
                s += conf.Prefix + "directory\n" ;
            } else {
                s += ind + "directory\n" ;
            }
        }
        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        if (this.Filename != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filename\n" ;
            } else {
                s += ind + "filename\n" ;
            }
        }
        //      C# -> System.String? NativePath
        // GraphQL -> nativePath: String! (scalar)
        if (this.NativePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nativePath\n" ;
            } else {
                s += ind + "nativePath\n" ;
            }
        }
        //      C# -> System.Int32? NumAccesses
        // GraphQL -> numAccesses: Int! (scalar)
        if (this.NumAccesses != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numAccesses\n" ;
            } else {
                s += ind + "numAccesses\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ActivityAccessType? AccessType
        // GraphQL -> accessType: ActivityAccessType! (enum)
        if (ec.Includes("accessType",true))
        {
            if(this.AccessType == null) {

                this.AccessType = new ActivityAccessType();

            } else {


            }
        }
        else if (this.AccessType != null && ec.Excludes("accessType",true))
        {
            this.AccessType = null;
        }
        //      C# -> System.String? Directory
        // GraphQL -> directory: String! (scalar)
        if (ec.Includes("directory",true))
        {
            if(this.Directory == null) {

                this.Directory = "FETCH";

            } else {


            }
        }
        else if (this.Directory != null && ec.Excludes("directory",true))
        {
            this.Directory = null;
        }
        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        if (ec.Includes("filename",true))
        {
            if(this.Filename == null) {

                this.Filename = "FETCH";

            } else {


            }
        }
        else if (this.Filename != null && ec.Excludes("filename",true))
        {
            this.Filename = null;
        }
        //      C# -> System.String? NativePath
        // GraphQL -> nativePath: String! (scalar)
        if (ec.Includes("nativePath",true))
        {
            if(this.NativePath == null) {

                this.NativePath = "FETCH";

            } else {


            }
        }
        else if (this.NativePath != null && ec.Excludes("nativePath",true))
        {
            this.NativePath = null;
        }
        //      C# -> System.Int32? NumAccesses
        // GraphQL -> numAccesses: Int! (scalar)
        if (ec.Includes("numAccesses",true))
        {
            if(this.NumAccesses == null) {

                this.NumAccesses = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumAccesses != null && ec.Excludes("numAccesses",true))
        {
            this.NumAccesses = null;
        }
    }


    #endregion

    } // class FileAccessResult
    
    #endregion

    public static class ListFileAccessResultExtensions
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
            this List<FileAccessResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FileAccessResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FileAccessResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FileAccessResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types