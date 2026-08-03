// SensitiveFileMetadata.cs
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
    #region SensitiveFileMetadata
    public class SensitiveFileMetadata: BaseType
    {
        #region members

        //      C# -> DatabaseEntityType? DbEntityType
        // GraphQL -> dbEntityType: DatabaseEntityType! (enum)
        [JsonProperty("dbEntityType")]
        public DatabaseEntityType? DbEntityType { get; set; }

        //      C# -> System.Int64? CreationTime
        // GraphQL -> creationTime: Long! (scalar)
        [JsonProperty("creationTime")]
        public System.Int64? CreationTime { get; set; }

        //      C# -> System.Int64? LastAccessTime
        // GraphQL -> lastAccessTime: Long! (scalar)
        [JsonProperty("lastAccessTime")]
        public System.Int64? LastAccessTime { get; set; }

        //      C# -> System.Int64? LastModifiedTime
        // GraphQL -> lastModifiedTime: Long! (scalar)
        [JsonProperty("lastModifiedTime")]
        public System.Int64? LastModifiedTime { get; set; }

        //      C# -> System.Int64? LastScanTime
        // GraphQL -> lastScanTime: Long! (scalar)
        [JsonProperty("lastScanTime")]
        public System.Int64? LastScanTime { get; set; }

        //      C# -> System.Int32? NumDescendantFiles
        // GraphQL -> numDescendantFiles: Int! (scalar)
        [JsonProperty("numDescendantFiles")]
        public System.Int32? NumDescendantFiles { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> FilePrincipalIdentity? CreatedBy
        // GraphQL -> createdBy: FilePrincipalIdentity (type)
        [JsonProperty("createdBy")]
        public FilePrincipalIdentity? CreatedBy { get; set; }

        //      C# -> FilePrincipalIdentity? LastModifiedBy
        // GraphQL -> lastModifiedBy: FilePrincipalIdentity (type)
        [JsonProperty("lastModifiedBy")]
        public FilePrincipalIdentity? LastModifiedBy { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SensitiveFileMetadata";
    }

    public SensitiveFileMetadata Set(
        DatabaseEntityType? DbEntityType = null,
        System.Int64? CreationTime = null,
        System.Int64? LastAccessTime = null,
        System.Int64? LastModifiedTime = null,
        System.Int64? LastScanTime = null,
        System.Int32? NumDescendantFiles = null,
        System.String? Path = null,
        System.Int64? Size = null,
        FilePrincipalIdentity? CreatedBy = null,
        FilePrincipalIdentity? LastModifiedBy = null
    ) 
    {
        if ( DbEntityType != null ) {
            this.DbEntityType = DbEntityType;
        }
        if ( CreationTime != null ) {
            this.CreationTime = CreationTime;
        }
        if ( LastAccessTime != null ) {
            this.LastAccessTime = LastAccessTime;
        }
        if ( LastModifiedTime != null ) {
            this.LastModifiedTime = LastModifiedTime;
        }
        if ( LastScanTime != null ) {
            this.LastScanTime = LastScanTime;
        }
        if ( NumDescendantFiles != null ) {
            this.NumDescendantFiles = NumDescendantFiles;
        }
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( CreatedBy != null ) {
            this.CreatedBy = CreatedBy;
        }
        if ( LastModifiedBy != null ) {
            this.LastModifiedBy = LastModifiedBy;
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
        //      C# -> DatabaseEntityType? DbEntityType
        // GraphQL -> dbEntityType: DatabaseEntityType! (enum)
        if (this.DbEntityType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dbEntityType\n" ;
            } else {
                s += ind + "dbEntityType\n" ;
            }
        }
        //      C# -> System.Int64? CreationTime
        // GraphQL -> creationTime: Long! (scalar)
        if (this.CreationTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "creationTime\n" ;
            } else {
                s += ind + "creationTime\n" ;
            }
        }
        //      C# -> System.Int64? LastAccessTime
        // GraphQL -> lastAccessTime: Long! (scalar)
        if (this.LastAccessTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastAccessTime\n" ;
            } else {
                s += ind + "lastAccessTime\n" ;
            }
        }
        //      C# -> System.Int64? LastModifiedTime
        // GraphQL -> lastModifiedTime: Long! (scalar)
        if (this.LastModifiedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastModifiedTime\n" ;
            } else {
                s += ind + "lastModifiedTime\n" ;
            }
        }
        //      C# -> System.Int64? LastScanTime
        // GraphQL -> lastScanTime: Long! (scalar)
        if (this.LastScanTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastScanTime\n" ;
            } else {
                s += ind + "lastScanTime\n" ;
            }
        }
        //      C# -> System.Int32? NumDescendantFiles
        // GraphQL -> numDescendantFiles: Int! (scalar)
        if (this.NumDescendantFiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numDescendantFiles\n" ;
            } else {
                s += ind + "numDescendantFiles\n" ;
            }
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path != null) {
            if (conf.Flat) {
                s += conf.Prefix + "path\n" ;
            } else {
                s += ind + "path\n" ;
            }
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size != null) {
            if (conf.Flat) {
                s += conf.Prefix + "size\n" ;
            } else {
                s += ind + "size\n" ;
            }
        }
        //      C# -> FilePrincipalIdentity? CreatedBy
        // GraphQL -> createdBy: FilePrincipalIdentity (type)
        if (this.CreatedBy != null) {
            var fspec = this.CreatedBy.AsFieldSpec(conf.Child("createdBy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "createdBy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> FilePrincipalIdentity? LastModifiedBy
        // GraphQL -> lastModifiedBy: FilePrincipalIdentity (type)
        if (this.LastModifiedBy != null) {
            var fspec = this.LastModifiedBy.AsFieldSpec(conf.Child("lastModifiedBy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lastModifiedBy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DatabaseEntityType? DbEntityType
        // GraphQL -> dbEntityType: DatabaseEntityType! (enum)
        if (ec.Includes("dbEntityType",true))
        {
            if(this.DbEntityType == null) {

                this.DbEntityType = new DatabaseEntityType();

            } else {


            }
        }
        else if (this.DbEntityType != null && ec.Excludes("dbEntityType",true))
        {
            this.DbEntityType = null;
        }
        //      C# -> System.Int64? CreationTime
        // GraphQL -> creationTime: Long! (scalar)
        if (ec.Includes("creationTime",true))
        {
            if(this.CreationTime == null) {

                this.CreationTime = new System.Int64();

            } else {


            }
        }
        else if (this.CreationTime != null && ec.Excludes("creationTime",true))
        {
            this.CreationTime = null;
        }
        //      C# -> System.Int64? LastAccessTime
        // GraphQL -> lastAccessTime: Long! (scalar)
        if (ec.Includes("lastAccessTime",true))
        {
            if(this.LastAccessTime == null) {

                this.LastAccessTime = new System.Int64();

            } else {


            }
        }
        else if (this.LastAccessTime != null && ec.Excludes("lastAccessTime",true))
        {
            this.LastAccessTime = null;
        }
        //      C# -> System.Int64? LastModifiedTime
        // GraphQL -> lastModifiedTime: Long! (scalar)
        if (ec.Includes("lastModifiedTime",true))
        {
            if(this.LastModifiedTime == null) {

                this.LastModifiedTime = new System.Int64();

            } else {


            }
        }
        else if (this.LastModifiedTime != null && ec.Excludes("lastModifiedTime",true))
        {
            this.LastModifiedTime = null;
        }
        //      C# -> System.Int64? LastScanTime
        // GraphQL -> lastScanTime: Long! (scalar)
        if (ec.Includes("lastScanTime",true))
        {
            if(this.LastScanTime == null) {

                this.LastScanTime = new System.Int64();

            } else {


            }
        }
        else if (this.LastScanTime != null && ec.Excludes("lastScanTime",true))
        {
            this.LastScanTime = null;
        }
        //      C# -> System.Int32? NumDescendantFiles
        // GraphQL -> numDescendantFiles: Int! (scalar)
        if (ec.Includes("numDescendantFiles",true))
        {
            if(this.NumDescendantFiles == null) {

                this.NumDescendantFiles = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumDescendantFiles != null && ec.Excludes("numDescendantFiles",true))
        {
            this.NumDescendantFiles = null;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (ec.Includes("path",true))
        {
            if(this.Path == null) {

                this.Path = "FETCH";

            } else {


            }
        }
        else if (this.Path != null && ec.Excludes("path",true))
        {
            this.Path = null;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (ec.Includes("size",true))
        {
            if(this.Size == null) {

                this.Size = new System.Int64();

            } else {


            }
        }
        else if (this.Size != null && ec.Excludes("size",true))
        {
            this.Size = null;
        }
        //      C# -> FilePrincipalIdentity? CreatedBy
        // GraphQL -> createdBy: FilePrincipalIdentity (type)
        if (ec.Includes("createdBy",false))
        {
            if(this.CreatedBy == null) {

                this.CreatedBy = new FilePrincipalIdentity();
                this.CreatedBy.ApplyExploratoryFieldSpec(ec.NewChild("createdBy"));

            } else {

                this.CreatedBy.ApplyExploratoryFieldSpec(ec.NewChild("createdBy"));

            }
        }
        else if (this.CreatedBy != null && ec.Excludes("createdBy",false))
        {
            this.CreatedBy = null;
        }
        //      C# -> FilePrincipalIdentity? LastModifiedBy
        // GraphQL -> lastModifiedBy: FilePrincipalIdentity (type)
        if (ec.Includes("lastModifiedBy",false))
        {
            if(this.LastModifiedBy == null) {

                this.LastModifiedBy = new FilePrincipalIdentity();
                this.LastModifiedBy.ApplyExploratoryFieldSpec(ec.NewChild("lastModifiedBy"));

            } else {

                this.LastModifiedBy.ApplyExploratoryFieldSpec(ec.NewChild("lastModifiedBy"));

            }
        }
        else if (this.LastModifiedBy != null && ec.Excludes("lastModifiedBy",false))
        {
            this.LastModifiedBy = null;
        }
    }


    #endregion

    } // class SensitiveFileMetadata
    
    #endregion

    public static class ListSensitiveFileMetadataExtensions
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
            this List<SensitiveFileMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SensitiveFileMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SensitiveFileMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SensitiveFileMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SensitiveFileMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types