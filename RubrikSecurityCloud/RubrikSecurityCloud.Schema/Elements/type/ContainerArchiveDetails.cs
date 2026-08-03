// ContainerArchiveDetails.cs
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
    #region ContainerArchiveDetails
    public class ContainerArchiveDetails: BaseType
    {
        #region members

        //      C# -> System.String? FilePath
        // GraphQL -> filePath: String! (scalar)
        [JsonProperty("filePath")]
        public System.String? FilePath { get; set; }

        //      C# -> System.Int64? FileSize
        // GraphQL -> fileSize: Long! (scalar)
        [JsonProperty("fileSize")]
        public System.Int64? FileSize { get; set; }

        //      C# -> System.String? Md5Hash
        // GraphQL -> md5Hash: String! (scalar)
        [JsonProperty("md5Hash")]
        public System.String? Md5Hash { get; set; }

        //      C# -> System.String? Sha1Hash
        // GraphQL -> sha1Hash: String! (scalar)
        [JsonProperty("sha1Hash")]
        public System.String? Sha1Hash { get; set; }

        //      C# -> System.String? Sha256Hash
        // GraphQL -> sha256Hash: String! (scalar)
        [JsonProperty("sha256Hash")]
        public System.String? Sha256Hash { get; set; }

        //      C# -> List<ArchiveLayer>? ArchiveLayers
        // GraphQL -> archiveLayers: [ArchiveLayer!]! (type)
        [JsonProperty("archiveLayers")]
        public List<ArchiveLayer>? ArchiveLayers { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ContainerArchiveDetails";
    }

    public ContainerArchiveDetails Set(
        System.String? FilePath = null,
        System.Int64? FileSize = null,
        System.String? Md5Hash = null,
        System.String? Sha1Hash = null,
        System.String? Sha256Hash = null,
        List<ArchiveLayer>? ArchiveLayers = null
    ) 
    {
        if ( FilePath != null ) {
            this.FilePath = FilePath;
        }
        if ( FileSize != null ) {
            this.FileSize = FileSize;
        }
        if ( Md5Hash != null ) {
            this.Md5Hash = Md5Hash;
        }
        if ( Sha1Hash != null ) {
            this.Sha1Hash = Sha1Hash;
        }
        if ( Sha256Hash != null ) {
            this.Sha256Hash = Sha256Hash;
        }
        if ( ArchiveLayers != null ) {
            this.ArchiveLayers = ArchiveLayers;
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
        //      C# -> System.String? FilePath
        // GraphQL -> filePath: String! (scalar)
        if (this.FilePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filePath\n" ;
            } else {
                s += ind + "filePath\n" ;
            }
        }
        //      C# -> System.Int64? FileSize
        // GraphQL -> fileSize: Long! (scalar)
        if (this.FileSize != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileSize\n" ;
            } else {
                s += ind + "fileSize\n" ;
            }
        }
        //      C# -> System.String? Md5Hash
        // GraphQL -> md5Hash: String! (scalar)
        if (this.Md5Hash != null) {
            if (conf.Flat) {
                s += conf.Prefix + "md5Hash\n" ;
            } else {
                s += ind + "md5Hash\n" ;
            }
        }
        //      C# -> System.String? Sha1Hash
        // GraphQL -> sha1Hash: String! (scalar)
        if (this.Sha1Hash != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sha1Hash\n" ;
            } else {
                s += ind + "sha1Hash\n" ;
            }
        }
        //      C# -> System.String? Sha256Hash
        // GraphQL -> sha256Hash: String! (scalar)
        if (this.Sha256Hash != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sha256Hash\n" ;
            } else {
                s += ind + "sha256Hash\n" ;
            }
        }
        //      C# -> List<ArchiveLayer>? ArchiveLayers
        // GraphQL -> archiveLayers: [ArchiveLayer!]! (type)
        if (this.ArchiveLayers != null) {
            var fspec = this.ArchiveLayers.AsFieldSpec(conf.Child("archiveLayers"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "archiveLayers" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? FilePath
        // GraphQL -> filePath: String! (scalar)
        if (ec.Includes("filePath",true))
        {
            if(this.FilePath == null) {

                this.FilePath = "FETCH";

            } else {


            }
        }
        else if (this.FilePath != null && ec.Excludes("filePath",true))
        {
            this.FilePath = null;
        }
        //      C# -> System.Int64? FileSize
        // GraphQL -> fileSize: Long! (scalar)
        if (ec.Includes("fileSize",true))
        {
            if(this.FileSize == null) {

                this.FileSize = new System.Int64();

            } else {


            }
        }
        else if (this.FileSize != null && ec.Excludes("fileSize",true))
        {
            this.FileSize = null;
        }
        //      C# -> System.String? Md5Hash
        // GraphQL -> md5Hash: String! (scalar)
        if (ec.Includes("md5Hash",true))
        {
            if(this.Md5Hash == null) {

                this.Md5Hash = "FETCH";

            } else {


            }
        }
        else if (this.Md5Hash != null && ec.Excludes("md5Hash",true))
        {
            this.Md5Hash = null;
        }
        //      C# -> System.String? Sha1Hash
        // GraphQL -> sha1Hash: String! (scalar)
        if (ec.Includes("sha1Hash",true))
        {
            if(this.Sha1Hash == null) {

                this.Sha1Hash = "FETCH";

            } else {


            }
        }
        else if (this.Sha1Hash != null && ec.Excludes("sha1Hash",true))
        {
            this.Sha1Hash = null;
        }
        //      C# -> System.String? Sha256Hash
        // GraphQL -> sha256Hash: String! (scalar)
        if (ec.Includes("sha256Hash",true))
        {
            if(this.Sha256Hash == null) {

                this.Sha256Hash = "FETCH";

            } else {


            }
        }
        else if (this.Sha256Hash != null && ec.Excludes("sha256Hash",true))
        {
            this.Sha256Hash = null;
        }
        //      C# -> List<ArchiveLayer>? ArchiveLayers
        // GraphQL -> archiveLayers: [ArchiveLayer!]! (type)
        if (ec.Includes("archiveLayers",false))
        {
            if(this.ArchiveLayers == null) {

                this.ArchiveLayers = new List<ArchiveLayer>();
                this.ArchiveLayers.ApplyExploratoryFieldSpec(ec.NewChild("archiveLayers"));

            } else {

                this.ArchiveLayers.ApplyExploratoryFieldSpec(ec.NewChild("archiveLayers"));

            }
        }
        else if (this.ArchiveLayers != null && ec.Excludes("archiveLayers",false))
        {
            this.ArchiveLayers = null;
        }
    }


    #endregion

    } // class ContainerArchiveDetails
    
    #endregion

    public static class ListContainerArchiveDetailsExtensions
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
            this List<ContainerArchiveDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ContainerArchiveDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ContainerArchiveDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ContainerArchiveDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ContainerArchiveDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types