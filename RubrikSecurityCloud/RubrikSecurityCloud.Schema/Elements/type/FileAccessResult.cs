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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<FileAccessResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FileAccessResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FileAccessResult> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FileAccessResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FileAccessResult> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types