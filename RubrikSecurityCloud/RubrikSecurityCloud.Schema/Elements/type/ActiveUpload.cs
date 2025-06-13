// ActiveUpload.cs
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
    #region ActiveUpload
    public class ActiveUpload: BaseType
    {
        #region members

        //      C# -> UpgradePackageUploadStatus? Status
        // GraphQL -> status: UpgradePackageUploadStatus! (enum)
        [JsonProperty("status")]
        public UpgradePackageUploadStatus? Status { get; set; }

        //      C# -> System.String? Md5Checksum
        // GraphQL -> md5Checksum: String! (scalar)
        [JsonProperty("md5Checksum")]
        public System.String? Md5Checksum { get; set; }

        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        [JsonProperty("sessionId")]
        public System.String? SessionId { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.Int32? TotalParts
        // GraphQL -> totalParts: Int! (scalar)
        [JsonProperty("totalParts")]
        public System.Int32? TotalParts { get; set; }

        //      C# -> DateTime? UploadStartTime
        // GraphQL -> uploadStartTime: DateTime (scalar)
        [JsonProperty("uploadStartTime")]
        public DateTime? UploadStartTime { get; set; }

        //      C# -> System.Int32? UploadedParts
        // GraphQL -> uploadedParts: Int! (scalar)
        [JsonProperty("uploadedParts")]
        public System.Int32? UploadedParts { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActiveUpload";
    }

    public ActiveUpload Set(
        UpgradePackageUploadStatus? Status = null,
        System.String? Md5Checksum = null,
        System.String? SessionId = null,
        System.Int64? Size = null,
        System.Int32? TotalParts = null,
        DateTime? UploadStartTime = null,
        System.Int32? UploadedParts = null,
        System.String? Version = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Md5Checksum != null ) {
            this.Md5Checksum = Md5Checksum;
        }
        if ( SessionId != null ) {
            this.SessionId = SessionId;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( TotalParts != null ) {
            this.TotalParts = TotalParts;
        }
        if ( UploadStartTime != null ) {
            this.UploadStartTime = UploadStartTime;
        }
        if ( UploadedParts != null ) {
            this.UploadedParts = UploadedParts;
        }
        if ( Version != null ) {
            this.Version = Version;
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
        //      C# -> UpgradePackageUploadStatus? Status
        // GraphQL -> status: UpgradePackageUploadStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? Md5Checksum
        // GraphQL -> md5Checksum: String! (scalar)
        if (this.Md5Checksum != null) {
            if (conf.Flat) {
                s += conf.Prefix + "md5Checksum\n" ;
            } else {
                s += ind + "md5Checksum\n" ;
            }
        }
        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        if (this.SessionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sessionId\n" ;
            } else {
                s += ind + "sessionId\n" ;
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
        //      C# -> System.Int32? TotalParts
        // GraphQL -> totalParts: Int! (scalar)
        if (this.TotalParts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalParts\n" ;
            } else {
                s += ind + "totalParts\n" ;
            }
        }
        //      C# -> DateTime? UploadStartTime
        // GraphQL -> uploadStartTime: DateTime (scalar)
        if (this.UploadStartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uploadStartTime\n" ;
            } else {
                s += ind + "uploadStartTime\n" ;
            }
        }
        //      C# -> System.Int32? UploadedParts
        // GraphQL -> uploadedParts: Int! (scalar)
        if (this.UploadedParts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uploadedParts\n" ;
            } else {
                s += ind + "uploadedParts\n" ;
            }
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> UpgradePackageUploadStatus? Status
        // GraphQL -> status: UpgradePackageUploadStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new UpgradePackageUploadStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? Md5Checksum
        // GraphQL -> md5Checksum: String! (scalar)
        if (ec.Includes("md5Checksum",true))
        {
            if(this.Md5Checksum == null) {

                this.Md5Checksum = "FETCH";

            } else {


            }
        }
        else if (this.Md5Checksum != null && ec.Excludes("md5Checksum",true))
        {
            this.Md5Checksum = null;
        }
        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        if (ec.Includes("sessionId",true))
        {
            if(this.SessionId == null) {

                this.SessionId = "FETCH";

            } else {


            }
        }
        else if (this.SessionId != null && ec.Excludes("sessionId",true))
        {
            this.SessionId = null;
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
        //      C# -> System.Int32? TotalParts
        // GraphQL -> totalParts: Int! (scalar)
        if (ec.Includes("totalParts",true))
        {
            if(this.TotalParts == null) {

                this.TotalParts = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalParts != null && ec.Excludes("totalParts",true))
        {
            this.TotalParts = null;
        }
        //      C# -> DateTime? UploadStartTime
        // GraphQL -> uploadStartTime: DateTime (scalar)
        if (ec.Includes("uploadStartTime",true))
        {
            if(this.UploadStartTime == null) {

                this.UploadStartTime = new DateTime();

            } else {


            }
        }
        else if (this.UploadStartTime != null && ec.Excludes("uploadStartTime",true))
        {
            this.UploadStartTime = null;
        }
        //      C# -> System.Int32? UploadedParts
        // GraphQL -> uploadedParts: Int! (scalar)
        if (ec.Includes("uploadedParts",true))
        {
            if(this.UploadedParts == null) {

                this.UploadedParts = Int32.MinValue;

            } else {


            }
        }
        else if (this.UploadedParts != null && ec.Excludes("uploadedParts",true))
        {
            this.UploadedParts = null;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
    }


    #endregion

    } // class ActiveUpload
    
    #endregion

    public static class ListActiveUploadExtensions
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
            this List<ActiveUpload> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActiveUpload> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActiveUpload> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActiveUpload());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActiveUpload> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types