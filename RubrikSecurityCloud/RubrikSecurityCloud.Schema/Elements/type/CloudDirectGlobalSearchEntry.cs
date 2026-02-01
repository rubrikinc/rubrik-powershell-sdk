// CloudDirectGlobalSearchEntry.cs
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
    #region CloudDirectGlobalSearchEntry
    public class CloudDirectGlobalSearchEntry: BaseType
    {
        #region members

        //      C# -> System.String? Bucket
        // GraphQL -> bucket: String! (scalar)
        [JsonProperty("bucket")]
        public System.String? Bucket { get; set; }

        //      C# -> List<System.String>? Dirs
        // GraphQL -> dirs: [String!]! (scalar)
        [JsonProperty("dirs")]
        public List<System.String>? Dirs { get; set; }

        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        [JsonProperty("filename")]
        public System.String? Filename { get; set; }

        //      C# -> System.Boolean? IsFile
        // GraphQL -> isFile: Boolean! (scalar)
        [JsonProperty("isFile")]
        public System.Boolean? IsFile { get; set; }

        //      C# -> DateTime? LastActivity
        // GraphQL -> lastActivity: DateTime (scalar)
        [JsonProperty("lastActivity")]
        public DateTime? LastActivity { get; set; }

        //      C# -> System.Boolean? Local
        // GraphQL -> local: Boolean! (scalar)
        [JsonProperty("local")]
        public System.Boolean? Local { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: UUID! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> System.Boolean? Remote
        // GraphQL -> remote: Boolean! (scalar)
        [JsonProperty("remote")]
        public System.Boolean? Remote { get; set; }

        //      C# -> System.String? ShareName
        // GraphQL -> shareName: String! (scalar)
        [JsonProperty("shareName")]
        public System.String? ShareName { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? VersionId
        // GraphQL -> versionId: String! (scalar)
        [JsonProperty("versionId")]
        public System.String? VersionId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudDirectGlobalSearchEntry";
    }

    public CloudDirectGlobalSearchEntry Set(
        System.String? Bucket = null,
        List<System.String>? Dirs = null,
        System.String? Filename = null,
        System.Boolean? IsFile = null,
        DateTime? LastActivity = null,
        System.Boolean? Local = null,
        System.String? ObjectId = null,
        System.Boolean? Remote = null,
        System.String? ShareName = null,
        System.Int64? Size = null,
        System.String? VersionId = null
    ) 
    {
        if ( Bucket != null ) {
            this.Bucket = Bucket;
        }
        if ( Dirs != null ) {
            this.Dirs = Dirs;
        }
        if ( Filename != null ) {
            this.Filename = Filename;
        }
        if ( IsFile != null ) {
            this.IsFile = IsFile;
        }
        if ( LastActivity != null ) {
            this.LastActivity = LastActivity;
        }
        if ( Local != null ) {
            this.Local = Local;
        }
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        if ( Remote != null ) {
            this.Remote = Remote;
        }
        if ( ShareName != null ) {
            this.ShareName = ShareName;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( VersionId != null ) {
            this.VersionId = VersionId;
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
        //      C# -> System.String? Bucket
        // GraphQL -> bucket: String! (scalar)
        if (this.Bucket != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bucket\n" ;
            } else {
                s += ind + "bucket\n" ;
            }
        }
        //      C# -> List<System.String>? Dirs
        // GraphQL -> dirs: [String!]! (scalar)
        if (this.Dirs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dirs\n" ;
            } else {
                s += ind + "dirs\n" ;
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
        //      C# -> System.Boolean? IsFile
        // GraphQL -> isFile: Boolean! (scalar)
        if (this.IsFile != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isFile\n" ;
            } else {
                s += ind + "isFile\n" ;
            }
        }
        //      C# -> DateTime? LastActivity
        // GraphQL -> lastActivity: DateTime (scalar)
        if (this.LastActivity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastActivity\n" ;
            } else {
                s += ind + "lastActivity\n" ;
            }
        }
        //      C# -> System.Boolean? Local
        // GraphQL -> local: Boolean! (scalar)
        if (this.Local != null) {
            if (conf.Flat) {
                s += conf.Prefix + "local\n" ;
            } else {
                s += ind + "local\n" ;
            }
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: UUID! (scalar)
        if (this.ObjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectId\n" ;
            } else {
                s += ind + "objectId\n" ;
            }
        }
        //      C# -> System.Boolean? Remote
        // GraphQL -> remote: Boolean! (scalar)
        if (this.Remote != null) {
            if (conf.Flat) {
                s += conf.Prefix + "remote\n" ;
            } else {
                s += ind + "remote\n" ;
            }
        }
        //      C# -> System.String? ShareName
        // GraphQL -> shareName: String! (scalar)
        if (this.ShareName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shareName\n" ;
            } else {
                s += ind + "shareName\n" ;
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
        //      C# -> System.String? VersionId
        // GraphQL -> versionId: String! (scalar)
        if (this.VersionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "versionId\n" ;
            } else {
                s += ind + "versionId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Bucket
        // GraphQL -> bucket: String! (scalar)
        if (ec.Includes("bucket",true))
        {
            if(this.Bucket == null) {

                this.Bucket = "FETCH";

            } else {


            }
        }
        else if (this.Bucket != null && ec.Excludes("bucket",true))
        {
            this.Bucket = null;
        }
        //      C# -> List<System.String>? Dirs
        // GraphQL -> dirs: [String!]! (scalar)
        if (ec.Includes("dirs",true))
        {
            if(this.Dirs == null) {

                this.Dirs = new List<System.String>();

            } else {


            }
        }
        else if (this.Dirs != null && ec.Excludes("dirs",true))
        {
            this.Dirs = null;
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
        //      C# -> System.Boolean? IsFile
        // GraphQL -> isFile: Boolean! (scalar)
        if (ec.Includes("isFile",true))
        {
            if(this.IsFile == null) {

                this.IsFile = true;

            } else {


            }
        }
        else if (this.IsFile != null && ec.Excludes("isFile",true))
        {
            this.IsFile = null;
        }
        //      C# -> DateTime? LastActivity
        // GraphQL -> lastActivity: DateTime (scalar)
        if (ec.Includes("lastActivity",true))
        {
            if(this.LastActivity == null) {

                this.LastActivity = new DateTime();

            } else {


            }
        }
        else if (this.LastActivity != null && ec.Excludes("lastActivity",true))
        {
            this.LastActivity = null;
        }
        //      C# -> System.Boolean? Local
        // GraphQL -> local: Boolean! (scalar)
        if (ec.Includes("local",true))
        {
            if(this.Local == null) {

                this.Local = true;

            } else {


            }
        }
        else if (this.Local != null && ec.Excludes("local",true))
        {
            this.Local = null;
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: UUID! (scalar)
        if (ec.Includes("objectId",true))
        {
            if(this.ObjectId == null) {

                this.ObjectId = "FETCH";

            } else {


            }
        }
        else if (this.ObjectId != null && ec.Excludes("objectId",true))
        {
            this.ObjectId = null;
        }
        //      C# -> System.Boolean? Remote
        // GraphQL -> remote: Boolean! (scalar)
        if (ec.Includes("remote",true))
        {
            if(this.Remote == null) {

                this.Remote = true;

            } else {


            }
        }
        else if (this.Remote != null && ec.Excludes("remote",true))
        {
            this.Remote = null;
        }
        //      C# -> System.String? ShareName
        // GraphQL -> shareName: String! (scalar)
        if (ec.Includes("shareName",true))
        {
            if(this.ShareName == null) {

                this.ShareName = "FETCH";

            } else {


            }
        }
        else if (this.ShareName != null && ec.Excludes("shareName",true))
        {
            this.ShareName = null;
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
        //      C# -> System.String? VersionId
        // GraphQL -> versionId: String! (scalar)
        if (ec.Includes("versionId",true))
        {
            if(this.VersionId == null) {

                this.VersionId = "FETCH";

            } else {


            }
        }
        else if (this.VersionId != null && ec.Excludes("versionId",true))
        {
            this.VersionId = null;
        }
    }


    #endregion

    } // class CloudDirectGlobalSearchEntry
    
    #endregion

    public static class ListCloudDirectGlobalSearchEntryExtensions
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
            this List<CloudDirectGlobalSearchEntry> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudDirectGlobalSearchEntry> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudDirectGlobalSearchEntry> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudDirectGlobalSearchEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudDirectGlobalSearchEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types