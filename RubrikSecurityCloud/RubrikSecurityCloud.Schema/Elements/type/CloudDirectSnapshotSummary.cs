// CloudDirectSnapshotSummary.cs
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
    #region CloudDirectSnapshotSummary
    public class CloudDirectSnapshotSummary: BaseType
    {
        #region members

        //      C# -> System.Int64? BytesProcessed
        // GraphQL -> bytesProcessed: Long! (scalar)
        [JsonProperty("bytesProcessed")]
        public System.Int64? BytesProcessed { get; set; }

        //      C# -> System.Int64? BytesTransferred
        // GraphQL -> bytesTransferred: Long! (scalar)
        [JsonProperty("bytesTransferred")]
        public System.Int64? BytesTransferred { get; set; }

        //      C# -> System.Int64? Deleted
        // GraphQL -> deleted: Long! (scalar)
        [JsonProperty("deleted")]
        public System.Int64? Deleted { get; set; }

        //      C# -> System.Int64? Dirs
        // GraphQL -> dirs: Long! (scalar)
        [JsonProperty("dirs")]
        public System.Int64? Dirs { get; set; }

        //      C# -> System.Int64? DirsSkipped
        // GraphQL -> dirsSkipped: Long! (scalar)
        [JsonProperty("dirsSkipped")]
        public System.Int64? DirsSkipped { get; set; }

        //      C# -> System.Int64? Failures
        // GraphQL -> failures: Long! (scalar)
        [JsonProperty("failures")]
        public System.Int64? Failures { get; set; }

        //      C# -> System.Int64? Files
        // GraphQL -> files: Long! (scalar)
        [JsonProperty("files")]
        public System.Int64? Files { get; set; }

        //      C# -> System.Int64? FilesSkipped
        // GraphQL -> filesSkipped: Long! (scalar)
        [JsonProperty("filesSkipped")]
        public System.Int64? FilesSkipped { get; set; }

        //      C# -> System.Int64? Links
        // GraphQL -> links: Long! (scalar)
        [JsonProperty("links")]
        public System.Int64? Links { get; set; }

        //      C# -> System.Int64? LinksSkipped
        // GraphQL -> linksSkipped: Long! (scalar)
        [JsonProperty("linksSkipped")]
        public System.Int64? LinksSkipped { get; set; }

        //      C# -> System.Int64? ObjectsProcessed
        // GraphQL -> objectsProcessed: Long! (scalar)
        [JsonProperty("objectsProcessed")]
        public System.Int64? ObjectsProcessed { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudDirectSnapshotSummary";
    }

    public CloudDirectSnapshotSummary Set(
        System.Int64? BytesProcessed = null,
        System.Int64? BytesTransferred = null,
        System.Int64? Deleted = null,
        System.Int64? Dirs = null,
        System.Int64? DirsSkipped = null,
        System.Int64? Failures = null,
        System.Int64? Files = null,
        System.Int64? FilesSkipped = null,
        System.Int64? Links = null,
        System.Int64? LinksSkipped = null,
        System.Int64? ObjectsProcessed = null
    ) 
    {
        if ( BytesProcessed != null ) {
            this.BytesProcessed = BytesProcessed;
        }
        if ( BytesTransferred != null ) {
            this.BytesTransferred = BytesTransferred;
        }
        if ( Deleted != null ) {
            this.Deleted = Deleted;
        }
        if ( Dirs != null ) {
            this.Dirs = Dirs;
        }
        if ( DirsSkipped != null ) {
            this.DirsSkipped = DirsSkipped;
        }
        if ( Failures != null ) {
            this.Failures = Failures;
        }
        if ( Files != null ) {
            this.Files = Files;
        }
        if ( FilesSkipped != null ) {
            this.FilesSkipped = FilesSkipped;
        }
        if ( Links != null ) {
            this.Links = Links;
        }
        if ( LinksSkipped != null ) {
            this.LinksSkipped = LinksSkipped;
        }
        if ( ObjectsProcessed != null ) {
            this.ObjectsProcessed = ObjectsProcessed;
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
        //      C# -> System.Int64? BytesProcessed
        // GraphQL -> bytesProcessed: Long! (scalar)
        if (this.BytesProcessed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bytesProcessed\n" ;
            } else {
                s += ind + "bytesProcessed\n" ;
            }
        }
        //      C# -> System.Int64? BytesTransferred
        // GraphQL -> bytesTransferred: Long! (scalar)
        if (this.BytesTransferred != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bytesTransferred\n" ;
            } else {
                s += ind + "bytesTransferred\n" ;
            }
        }
        //      C# -> System.Int64? Deleted
        // GraphQL -> deleted: Long! (scalar)
        if (this.Deleted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deleted\n" ;
            } else {
                s += ind + "deleted\n" ;
            }
        }
        //      C# -> System.Int64? Dirs
        // GraphQL -> dirs: Long! (scalar)
        if (this.Dirs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dirs\n" ;
            } else {
                s += ind + "dirs\n" ;
            }
        }
        //      C# -> System.Int64? DirsSkipped
        // GraphQL -> dirsSkipped: Long! (scalar)
        if (this.DirsSkipped != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dirsSkipped\n" ;
            } else {
                s += ind + "dirsSkipped\n" ;
            }
        }
        //      C# -> System.Int64? Failures
        // GraphQL -> failures: Long! (scalar)
        if (this.Failures != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failures\n" ;
            } else {
                s += ind + "failures\n" ;
            }
        }
        //      C# -> System.Int64? Files
        // GraphQL -> files: Long! (scalar)
        if (this.Files != null) {
            if (conf.Flat) {
                s += conf.Prefix + "files\n" ;
            } else {
                s += ind + "files\n" ;
            }
        }
        //      C# -> System.Int64? FilesSkipped
        // GraphQL -> filesSkipped: Long! (scalar)
        if (this.FilesSkipped != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filesSkipped\n" ;
            } else {
                s += ind + "filesSkipped\n" ;
            }
        }
        //      C# -> System.Int64? Links
        // GraphQL -> links: Long! (scalar)
        if (this.Links != null) {
            if (conf.Flat) {
                s += conf.Prefix + "links\n" ;
            } else {
                s += ind + "links\n" ;
            }
        }
        //      C# -> System.Int64? LinksSkipped
        // GraphQL -> linksSkipped: Long! (scalar)
        if (this.LinksSkipped != null) {
            if (conf.Flat) {
                s += conf.Prefix + "linksSkipped\n" ;
            } else {
                s += ind + "linksSkipped\n" ;
            }
        }
        //      C# -> System.Int64? ObjectsProcessed
        // GraphQL -> objectsProcessed: Long! (scalar)
        if (this.ObjectsProcessed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectsProcessed\n" ;
            } else {
                s += ind + "objectsProcessed\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? BytesProcessed
        // GraphQL -> bytesProcessed: Long! (scalar)
        if (ec.Includes("bytesProcessed",true))
        {
            if(this.BytesProcessed == null) {

                this.BytesProcessed = new System.Int64();

            } else {


            }
        }
        else if (this.BytesProcessed != null && ec.Excludes("bytesProcessed",true))
        {
            this.BytesProcessed = null;
        }
        //      C# -> System.Int64? BytesTransferred
        // GraphQL -> bytesTransferred: Long! (scalar)
        if (ec.Includes("bytesTransferred",true))
        {
            if(this.BytesTransferred == null) {

                this.BytesTransferred = new System.Int64();

            } else {


            }
        }
        else if (this.BytesTransferred != null && ec.Excludes("bytesTransferred",true))
        {
            this.BytesTransferred = null;
        }
        //      C# -> System.Int64? Deleted
        // GraphQL -> deleted: Long! (scalar)
        if (ec.Includes("deleted",true))
        {
            if(this.Deleted == null) {

                this.Deleted = new System.Int64();

            } else {


            }
        }
        else if (this.Deleted != null && ec.Excludes("deleted",true))
        {
            this.Deleted = null;
        }
        //      C# -> System.Int64? Dirs
        // GraphQL -> dirs: Long! (scalar)
        if (ec.Includes("dirs",true))
        {
            if(this.Dirs == null) {

                this.Dirs = new System.Int64();

            } else {


            }
        }
        else if (this.Dirs != null && ec.Excludes("dirs",true))
        {
            this.Dirs = null;
        }
        //      C# -> System.Int64? DirsSkipped
        // GraphQL -> dirsSkipped: Long! (scalar)
        if (ec.Includes("dirsSkipped",true))
        {
            if(this.DirsSkipped == null) {

                this.DirsSkipped = new System.Int64();

            } else {


            }
        }
        else if (this.DirsSkipped != null && ec.Excludes("dirsSkipped",true))
        {
            this.DirsSkipped = null;
        }
        //      C# -> System.Int64? Failures
        // GraphQL -> failures: Long! (scalar)
        if (ec.Includes("failures",true))
        {
            if(this.Failures == null) {

                this.Failures = new System.Int64();

            } else {


            }
        }
        else if (this.Failures != null && ec.Excludes("failures",true))
        {
            this.Failures = null;
        }
        //      C# -> System.Int64? Files
        // GraphQL -> files: Long! (scalar)
        if (ec.Includes("files",true))
        {
            if(this.Files == null) {

                this.Files = new System.Int64();

            } else {


            }
        }
        else if (this.Files != null && ec.Excludes("files",true))
        {
            this.Files = null;
        }
        //      C# -> System.Int64? FilesSkipped
        // GraphQL -> filesSkipped: Long! (scalar)
        if (ec.Includes("filesSkipped",true))
        {
            if(this.FilesSkipped == null) {

                this.FilesSkipped = new System.Int64();

            } else {


            }
        }
        else if (this.FilesSkipped != null && ec.Excludes("filesSkipped",true))
        {
            this.FilesSkipped = null;
        }
        //      C# -> System.Int64? Links
        // GraphQL -> links: Long! (scalar)
        if (ec.Includes("links",true))
        {
            if(this.Links == null) {

                this.Links = new System.Int64();

            } else {


            }
        }
        else if (this.Links != null && ec.Excludes("links",true))
        {
            this.Links = null;
        }
        //      C# -> System.Int64? LinksSkipped
        // GraphQL -> linksSkipped: Long! (scalar)
        if (ec.Includes("linksSkipped",true))
        {
            if(this.LinksSkipped == null) {

                this.LinksSkipped = new System.Int64();

            } else {


            }
        }
        else if (this.LinksSkipped != null && ec.Excludes("linksSkipped",true))
        {
            this.LinksSkipped = null;
        }
        //      C# -> System.Int64? ObjectsProcessed
        // GraphQL -> objectsProcessed: Long! (scalar)
        if (ec.Includes("objectsProcessed",true))
        {
            if(this.ObjectsProcessed == null) {

                this.ObjectsProcessed = new System.Int64();

            } else {


            }
        }
        else if (this.ObjectsProcessed != null && ec.Excludes("objectsProcessed",true))
        {
            this.ObjectsProcessed = null;
        }
    }


    #endregion

    } // class CloudDirectSnapshotSummary
    
    #endregion

    public static class ListCloudDirectSnapshotSummaryExtensions
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
            this List<CloudDirectSnapshotSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudDirectSnapshotSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudDirectSnapshotSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudDirectSnapshotSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudDirectSnapshotSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types