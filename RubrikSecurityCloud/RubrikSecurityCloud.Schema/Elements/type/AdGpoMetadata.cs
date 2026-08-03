// AdGpoMetadata.cs
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
    #region AdGpoMetadata
 
    public class AdGpoMetadata: BaseType, OnPremAdPrincipalTypeSpecificMetadata
    {
        #region members

        //      C# -> GpoLinkingStatusEnum? LinkingStatus
        // GraphQL -> linkingStatus: GPOLinkingStatusEnum! (enum)
        [JsonProperty("linkingStatus")]
        public GpoLinkingStatusEnum? LinkingStatus { get; set; }

        //      C# -> GpoStatusEnum? Status
        // GraphQL -> status: GpoStatusEnum! (enum)
        [JsonProperty("status")]
        public GpoStatusEnum? Status { get; set; }

        //      C# -> System.Int32? ComputerVersion
        // GraphQL -> computerVersion: Int! (scalar)
        [JsonProperty("computerVersion")]
        public System.Int32? ComputerVersion { get; set; }

        //      C# -> System.String? FileSysPath
        // GraphQL -> fileSysPath: String! (scalar)
        [JsonProperty("fileSysPath")]
        public System.String? FileSysPath { get; set; }

        //      C# -> System.Int32? FunctionalityVersion
        // GraphQL -> functionalityVersion: Int! (scalar)
        [JsonProperty("functionalityVersion")]
        public System.Int32? FunctionalityVersion { get; set; }

        //      C# -> System.Int64? LastModified
        // GraphQL -> lastModified: Long! (scalar)
        [JsonProperty("lastModified")]
        public System.Int64? LastModified { get; set; }

        //      C# -> System.Int32? UserVersion
        // GraphQL -> userVersion: Int! (scalar)
        [JsonProperty("userVersion")]
        public System.Int32? UserVersion { get; set; }

        //      C# -> System.Int64? VersionNumber
        // GraphQL -> versionNumber: Long! (scalar)
        [JsonProperty("versionNumber")]
        public System.Int64? VersionNumber { get; set; }

        //      C# -> List<PrincipalEntity>? Editors
        // GraphQL -> editors: [PrincipalEntity!]! (type)
        [JsonProperty("editors")]
        public List<PrincipalEntity>? Editors { get; set; }

        //      C# -> List<PrincipalEntity>? Owners
        // GraphQL -> owners: [PrincipalEntity!]! (type)
        [JsonProperty("owners")]
        public List<PrincipalEntity>? Owners { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AdGpoMetadata";
    }

    public AdGpoMetadata Set(
        GpoLinkingStatusEnum? LinkingStatus = null,
        GpoStatusEnum? Status = null,
        System.Int32? ComputerVersion = null,
        System.String? FileSysPath = null,
        System.Int32? FunctionalityVersion = null,
        System.Int64? LastModified = null,
        System.Int32? UserVersion = null,
        System.Int64? VersionNumber = null,
        List<PrincipalEntity>? Editors = null,
        List<PrincipalEntity>? Owners = null
    ) 
    {
        if ( LinkingStatus != null ) {
            this.LinkingStatus = LinkingStatus;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( ComputerVersion != null ) {
            this.ComputerVersion = ComputerVersion;
        }
        if ( FileSysPath != null ) {
            this.FileSysPath = FileSysPath;
        }
        if ( FunctionalityVersion != null ) {
            this.FunctionalityVersion = FunctionalityVersion;
        }
        if ( LastModified != null ) {
            this.LastModified = LastModified;
        }
        if ( UserVersion != null ) {
            this.UserVersion = UserVersion;
        }
        if ( VersionNumber != null ) {
            this.VersionNumber = VersionNumber;
        }
        if ( Editors != null ) {
            this.Editors = Editors;
        }
        if ( Owners != null ) {
            this.Owners = Owners;
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
        //      C# -> GpoLinkingStatusEnum? LinkingStatus
        // GraphQL -> linkingStatus: GPOLinkingStatusEnum! (enum)
        if (this.LinkingStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "linkingStatus\n" ;
            } else {
                s += ind + "linkingStatus\n" ;
            }
        }
        //      C# -> GpoStatusEnum? Status
        // GraphQL -> status: GpoStatusEnum! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.Int32? ComputerVersion
        // GraphQL -> computerVersion: Int! (scalar)
        if (this.ComputerVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "computerVersion\n" ;
            } else {
                s += ind + "computerVersion\n" ;
            }
        }
        //      C# -> System.String? FileSysPath
        // GraphQL -> fileSysPath: String! (scalar)
        if (this.FileSysPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileSysPath\n" ;
            } else {
                s += ind + "fileSysPath\n" ;
            }
        }
        //      C# -> System.Int32? FunctionalityVersion
        // GraphQL -> functionalityVersion: Int! (scalar)
        if (this.FunctionalityVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "functionalityVersion\n" ;
            } else {
                s += ind + "functionalityVersion\n" ;
            }
        }
        //      C# -> System.Int64? LastModified
        // GraphQL -> lastModified: Long! (scalar)
        if (this.LastModified != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastModified\n" ;
            } else {
                s += ind + "lastModified\n" ;
            }
        }
        //      C# -> System.Int32? UserVersion
        // GraphQL -> userVersion: Int! (scalar)
        if (this.UserVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userVersion\n" ;
            } else {
                s += ind + "userVersion\n" ;
            }
        }
        //      C# -> System.Int64? VersionNumber
        // GraphQL -> versionNumber: Long! (scalar)
        if (this.VersionNumber != null) {
            if (conf.Flat) {
                s += conf.Prefix + "versionNumber\n" ;
            } else {
                s += ind + "versionNumber\n" ;
            }
        }
        //      C# -> List<PrincipalEntity>? Editors
        // GraphQL -> editors: [PrincipalEntity!]! (type)
        if (this.Editors != null) {
            var fspec = this.Editors.AsFieldSpec(conf.Child("editors"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "editors" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PrincipalEntity>? Owners
        // GraphQL -> owners: [PrincipalEntity!]! (type)
        if (this.Owners != null) {
            var fspec = this.Owners.AsFieldSpec(conf.Child("owners"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "owners" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> GpoLinkingStatusEnum? LinkingStatus
        // GraphQL -> linkingStatus: GPOLinkingStatusEnum! (enum)
        if (ec.Includes("linkingStatus",true))
        {
            if(this.LinkingStatus == null) {

                this.LinkingStatus = new GpoLinkingStatusEnum();

            } else {


            }
        }
        else if (this.LinkingStatus != null && ec.Excludes("linkingStatus",true))
        {
            this.LinkingStatus = null;
        }
        //      C# -> GpoStatusEnum? Status
        // GraphQL -> status: GpoStatusEnum! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new GpoStatusEnum();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.Int32? ComputerVersion
        // GraphQL -> computerVersion: Int! (scalar)
        if (ec.Includes("computerVersion",true))
        {
            if(this.ComputerVersion == null) {

                this.ComputerVersion = Int32.MinValue;

            } else {


            }
        }
        else if (this.ComputerVersion != null && ec.Excludes("computerVersion",true))
        {
            this.ComputerVersion = null;
        }
        //      C# -> System.String? FileSysPath
        // GraphQL -> fileSysPath: String! (scalar)
        if (ec.Includes("fileSysPath",true))
        {
            if(this.FileSysPath == null) {

                this.FileSysPath = "FETCH";

            } else {


            }
        }
        else if (this.FileSysPath != null && ec.Excludes("fileSysPath",true))
        {
            this.FileSysPath = null;
        }
        //      C# -> System.Int32? FunctionalityVersion
        // GraphQL -> functionalityVersion: Int! (scalar)
        if (ec.Includes("functionalityVersion",true))
        {
            if(this.FunctionalityVersion == null) {

                this.FunctionalityVersion = Int32.MinValue;

            } else {


            }
        }
        else if (this.FunctionalityVersion != null && ec.Excludes("functionalityVersion",true))
        {
            this.FunctionalityVersion = null;
        }
        //      C# -> System.Int64? LastModified
        // GraphQL -> lastModified: Long! (scalar)
        if (ec.Includes("lastModified",true))
        {
            if(this.LastModified == null) {

                this.LastModified = new System.Int64();

            } else {


            }
        }
        else if (this.LastModified != null && ec.Excludes("lastModified",true))
        {
            this.LastModified = null;
        }
        //      C# -> System.Int32? UserVersion
        // GraphQL -> userVersion: Int! (scalar)
        if (ec.Includes("userVersion",true))
        {
            if(this.UserVersion == null) {

                this.UserVersion = Int32.MinValue;

            } else {


            }
        }
        else if (this.UserVersion != null && ec.Excludes("userVersion",true))
        {
            this.UserVersion = null;
        }
        //      C# -> System.Int64? VersionNumber
        // GraphQL -> versionNumber: Long! (scalar)
        if (ec.Includes("versionNumber",true))
        {
            if(this.VersionNumber == null) {

                this.VersionNumber = new System.Int64();

            } else {


            }
        }
        else if (this.VersionNumber != null && ec.Excludes("versionNumber",true))
        {
            this.VersionNumber = null;
        }
        //      C# -> List<PrincipalEntity>? Editors
        // GraphQL -> editors: [PrincipalEntity!]! (type)
        if (ec.Includes("editors",false))
        {
            if(this.Editors == null) {

                this.Editors = new List<PrincipalEntity>();
                this.Editors.ApplyExploratoryFieldSpec(ec.NewChild("editors"));

            } else {

                this.Editors.ApplyExploratoryFieldSpec(ec.NewChild("editors"));

            }
        }
        else if (this.Editors != null && ec.Excludes("editors",false))
        {
            this.Editors = null;
        }
        //      C# -> List<PrincipalEntity>? Owners
        // GraphQL -> owners: [PrincipalEntity!]! (type)
        if (ec.Includes("owners",false))
        {
            if(this.Owners == null) {

                this.Owners = new List<PrincipalEntity>();
                this.Owners.ApplyExploratoryFieldSpec(ec.NewChild("owners"));

            } else {

                this.Owners.ApplyExploratoryFieldSpec(ec.NewChild("owners"));

            }
        }
        else if (this.Owners != null && ec.Excludes("owners",false))
        {
            this.Owners = null;
        }
    }


    #endregion

    } // class AdGpoMetadata
    
    #endregion

    public static class ListAdGpoMetadataExtensions
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
            this List<AdGpoMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AdGpoMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AdGpoMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AdGpoMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AdGpoMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types