// CompletedUpload.cs
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
    #region CompletedUpload
    public class CompletedUpload: BaseType
    {
        #region members

        //      C# -> UpgradePackageUploadErrorCode? ErrorCode
        // GraphQL -> errorCode: UpgradePackageUploadErrorCode! (enum)
        [JsonProperty("errorCode")]
        public UpgradePackageUploadErrorCode? ErrorCode { get; set; }

        //      C# -> UpgradePackageUploadStatus? Status
        // GraphQL -> status: UpgradePackageUploadStatus! (enum)
        [JsonProperty("status")]
        public UpgradePackageUploadStatus? Status { get; set; }

        //      C# -> System.String? Md5Checksum
        // GraphQL -> md5Checksum: String! (scalar)
        [JsonProperty("md5Checksum")]
        public System.String? Md5Checksum { get; set; }

        //      C# -> DateTime? PackageExpiresAt
        // GraphQL -> packageExpiresAt: DateTime (scalar)
        [JsonProperty("packageExpiresAt")]
        public DateTime? PackageExpiresAt { get; set; }

        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        [JsonProperty("sessionId")]
        public System.String? SessionId { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> DateTime? UploadStartTime
        // GraphQL -> uploadStartTime: DateTime (scalar)
        [JsonProperty("uploadStartTime")]
        public DateTime? UploadStartTime { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CompletedUpload";
    }

    public CompletedUpload Set(
        UpgradePackageUploadErrorCode? ErrorCode = null,
        UpgradePackageUploadStatus? Status = null,
        System.String? Md5Checksum = null,
        DateTime? PackageExpiresAt = null,
        System.String? SessionId = null,
        System.Int64? Size = null,
        DateTime? UploadStartTime = null,
        System.String? Version = null
    ) 
    {
        if ( ErrorCode != null ) {
            this.ErrorCode = ErrorCode;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Md5Checksum != null ) {
            this.Md5Checksum = Md5Checksum;
        }
        if ( PackageExpiresAt != null ) {
            this.PackageExpiresAt = PackageExpiresAt;
        }
        if ( SessionId != null ) {
            this.SessionId = SessionId;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( UploadStartTime != null ) {
            this.UploadStartTime = UploadStartTime;
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
        //      C# -> UpgradePackageUploadErrorCode? ErrorCode
        // GraphQL -> errorCode: UpgradePackageUploadErrorCode! (enum)
        if (this.ErrorCode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorCode\n" ;
            } else {
                s += ind + "errorCode\n" ;
            }
        }
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
        //      C# -> DateTime? PackageExpiresAt
        // GraphQL -> packageExpiresAt: DateTime (scalar)
        if (this.PackageExpiresAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "packageExpiresAt\n" ;
            } else {
                s += ind + "packageExpiresAt\n" ;
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
        //      C# -> DateTime? UploadStartTime
        // GraphQL -> uploadStartTime: DateTime (scalar)
        if (this.UploadStartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uploadStartTime\n" ;
            } else {
                s += ind + "uploadStartTime\n" ;
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
        //      C# -> UpgradePackageUploadErrorCode? ErrorCode
        // GraphQL -> errorCode: UpgradePackageUploadErrorCode! (enum)
        if (ec.Includes("errorCode",true))
        {
            if(this.ErrorCode == null) {

                this.ErrorCode = new UpgradePackageUploadErrorCode();

            } else {


            }
        }
        else if (this.ErrorCode != null && ec.Excludes("errorCode",true))
        {
            this.ErrorCode = null;
        }
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
        //      C# -> DateTime? PackageExpiresAt
        // GraphQL -> packageExpiresAt: DateTime (scalar)
        if (ec.Includes("packageExpiresAt",true))
        {
            if(this.PackageExpiresAt == null) {

                this.PackageExpiresAt = new DateTime();

            } else {


            }
        }
        else if (this.PackageExpiresAt != null && ec.Excludes("packageExpiresAt",true))
        {
            this.PackageExpiresAt = null;
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

    } // class CompletedUpload
    
    #endregion

    public static class ListCompletedUploadExtensions
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
            this List<CompletedUpload> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CompletedUpload> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CompletedUpload> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CompletedUpload());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CompletedUpload> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types