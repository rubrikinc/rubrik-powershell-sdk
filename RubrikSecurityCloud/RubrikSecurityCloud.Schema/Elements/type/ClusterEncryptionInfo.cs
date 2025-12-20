// ClusterEncryptionInfo.cs
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
    #region ClusterEncryptionInfo
    public class ClusterEncryptionInfo: BaseType
    {
        #region members

        //      C# -> ClusterEncryptionType? EncryptionType
        // GraphQL -> encryptionType: ClusterEncryptionType! (enum)
        [JsonProperty("encryptionType")]
        public ClusterEncryptionType? EncryptionType { get; set; }

        //      C# -> List<ClusterKeyProtection>? SupportedKeyTypes
        // GraphQL -> supportedKeyTypes: [ClusterKeyProtection!]! (enum)
        [JsonProperty("supportedKeyTypes")]
        public List<ClusterKeyProtection>? SupportedKeyTypes { get; set; }

        //      C# -> System.Boolean? CanUserManageCluster
        // GraphQL -> canUserManageCluster: Boolean! (scalar)
        [JsonProperty("canUserManageCluster")]
        public System.Boolean? CanUserManageCluster { get; set; }

        //      C# -> System.String? Cipher
        // GraphQL -> cipher: String! (scalar)
        [JsonProperty("cipher")]
        public System.String? Cipher { get; set; }

        //      C# -> System.Boolean? IsConnected
        // GraphQL -> isConnected: Boolean! (scalar)
        [JsonProperty("isConnected")]
        public System.Boolean? IsConnected { get; set; }

        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        [JsonProperty("isEncrypted")]
        public System.Boolean? IsEncrypted { get; set; }

        //      C# -> System.Boolean? IsOnCloud
        // GraphQL -> isOnCloud: Boolean! (scalar)
        [JsonProperty("isOnCloud")]
        public System.Boolean? IsOnCloud { get; set; }

        //      C# -> System.String? KmipClientUsername
        // GraphQL -> kmipClientUsername: String! (scalar)
        [JsonProperty("kmipClientUsername")]
        public System.String? KmipClientUsername { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? SoftwareVersion
        // GraphQL -> softwareVersion: String! (scalar)
        [JsonProperty("softwareVersion")]
        public System.String? SoftwareVersion { get; set; }

        //      C# -> System.Int64? TotalKmipServers
        // GraphQL -> totalKmipServers: Long! (scalar)
        [JsonProperty("totalKmipServers")]
        public System.Int64? TotalKmipServers { get; set; }

        //      C# -> System.String? Uuid
        // GraphQL -> uuid: UUID! (scalar)
        [JsonProperty("uuid")]
        public System.String? Uuid { get; set; }

        //      C# -> ClusterKeyRotation? LatestRotationCompletedInfo
        // GraphQL -> latestRotationCompletedInfo: ClusterKeyRotation (type)
        [JsonProperty("latestRotationCompletedInfo")]
        public ClusterKeyRotation? LatestRotationCompletedInfo { get; set; }

        //      C# -> RscKeyRotationRequest? MostRecentRscRequest
        // GraphQL -> mostRecentRscRequest: RscKeyRotationRequest (type)
        [JsonProperty("mostRecentRscRequest")]
        public RscKeyRotationRequest? MostRecentRscRequest { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterEncryptionInfo";
    }

    public ClusterEncryptionInfo Set(
        ClusterEncryptionType? EncryptionType = null,
        List<ClusterKeyProtection>? SupportedKeyTypes = null,
        System.Boolean? CanUserManageCluster = null,
        System.String? Cipher = null,
        System.Boolean? IsConnected = null,
        System.Boolean? IsEncrypted = null,
        System.Boolean? IsOnCloud = null,
        System.String? KmipClientUsername = null,
        System.String? Name = null,
        System.String? SoftwareVersion = null,
        System.Int64? TotalKmipServers = null,
        System.String? Uuid = null,
        ClusterKeyRotation? LatestRotationCompletedInfo = null,
        RscKeyRotationRequest? MostRecentRscRequest = null
    ) 
    {
        if ( EncryptionType != null ) {
            this.EncryptionType = EncryptionType;
        }
        if ( SupportedKeyTypes != null ) {
            this.SupportedKeyTypes = SupportedKeyTypes;
        }
        if ( CanUserManageCluster != null ) {
            this.CanUserManageCluster = CanUserManageCluster;
        }
        if ( Cipher != null ) {
            this.Cipher = Cipher;
        }
        if ( IsConnected != null ) {
            this.IsConnected = IsConnected;
        }
        if ( IsEncrypted != null ) {
            this.IsEncrypted = IsEncrypted;
        }
        if ( IsOnCloud != null ) {
            this.IsOnCloud = IsOnCloud;
        }
        if ( KmipClientUsername != null ) {
            this.KmipClientUsername = KmipClientUsername;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( SoftwareVersion != null ) {
            this.SoftwareVersion = SoftwareVersion;
        }
        if ( TotalKmipServers != null ) {
            this.TotalKmipServers = TotalKmipServers;
        }
        if ( Uuid != null ) {
            this.Uuid = Uuid;
        }
        if ( LatestRotationCompletedInfo != null ) {
            this.LatestRotationCompletedInfo = LatestRotationCompletedInfo;
        }
        if ( MostRecentRscRequest != null ) {
            this.MostRecentRscRequest = MostRecentRscRequest;
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
        //      C# -> ClusterEncryptionType? EncryptionType
        // GraphQL -> encryptionType: ClusterEncryptionType! (enum)
        if (this.EncryptionType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "encryptionType\n" ;
            } else {
                s += ind + "encryptionType\n" ;
            }
        }
        //      C# -> List<ClusterKeyProtection>? SupportedKeyTypes
        // GraphQL -> supportedKeyTypes: [ClusterKeyProtection!]! (enum)
        if (this.SupportedKeyTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "supportedKeyTypes\n" ;
            } else {
                s += ind + "supportedKeyTypes\n" ;
            }
        }
        //      C# -> System.Boolean? CanUserManageCluster
        // GraphQL -> canUserManageCluster: Boolean! (scalar)
        if (this.CanUserManageCluster != null) {
            if (conf.Flat) {
                s += conf.Prefix + "canUserManageCluster\n" ;
            } else {
                s += ind + "canUserManageCluster\n" ;
            }
        }
        //      C# -> System.String? Cipher
        // GraphQL -> cipher: String! (scalar)
        if (this.Cipher != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cipher\n" ;
            } else {
                s += ind + "cipher\n" ;
            }
        }
        //      C# -> System.Boolean? IsConnected
        // GraphQL -> isConnected: Boolean! (scalar)
        if (this.IsConnected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isConnected\n" ;
            } else {
                s += ind + "isConnected\n" ;
            }
        }
        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        if (this.IsEncrypted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEncrypted\n" ;
            } else {
                s += ind + "isEncrypted\n" ;
            }
        }
        //      C# -> System.Boolean? IsOnCloud
        // GraphQL -> isOnCloud: Boolean! (scalar)
        if (this.IsOnCloud != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOnCloud\n" ;
            } else {
                s += ind + "isOnCloud\n" ;
            }
        }
        //      C# -> System.String? KmipClientUsername
        // GraphQL -> kmipClientUsername: String! (scalar)
        if (this.KmipClientUsername != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kmipClientUsername\n" ;
            } else {
                s += ind + "kmipClientUsername\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? SoftwareVersion
        // GraphQL -> softwareVersion: String! (scalar)
        if (this.SoftwareVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "softwareVersion\n" ;
            } else {
                s += ind + "softwareVersion\n" ;
            }
        }
        //      C# -> System.Int64? TotalKmipServers
        // GraphQL -> totalKmipServers: Long! (scalar)
        if (this.TotalKmipServers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalKmipServers\n" ;
            } else {
                s += ind + "totalKmipServers\n" ;
            }
        }
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: UUID! (scalar)
        if (this.Uuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uuid\n" ;
            } else {
                s += ind + "uuid\n" ;
            }
        }
        //      C# -> ClusterKeyRotation? LatestRotationCompletedInfo
        // GraphQL -> latestRotationCompletedInfo: ClusterKeyRotation (type)
        if (this.LatestRotationCompletedInfo != null) {
            var fspec = this.LatestRotationCompletedInfo.AsFieldSpec(conf.Child("latestRotationCompletedInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "latestRotationCompletedInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RscKeyRotationRequest? MostRecentRscRequest
        // GraphQL -> mostRecentRscRequest: RscKeyRotationRequest (type)
        if (this.MostRecentRscRequest != null) {
            var fspec = this.MostRecentRscRequest.AsFieldSpec(conf.Child("mostRecentRscRequest"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mostRecentRscRequest" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ClusterEncryptionType? EncryptionType
        // GraphQL -> encryptionType: ClusterEncryptionType! (enum)
        if (ec.Includes("encryptionType",true))
        {
            if(this.EncryptionType == null) {

                this.EncryptionType = new ClusterEncryptionType();

            } else {


            }
        }
        else if (this.EncryptionType != null && ec.Excludes("encryptionType",true))
        {
            this.EncryptionType = null;
        }
        //      C# -> List<ClusterKeyProtection>? SupportedKeyTypes
        // GraphQL -> supportedKeyTypes: [ClusterKeyProtection!]! (enum)
        if (ec.Includes("supportedKeyTypes",true))
        {
            if(this.SupportedKeyTypes == null) {

                this.SupportedKeyTypes = new List<ClusterKeyProtection>();

            } else {


            }
        }
        else if (this.SupportedKeyTypes != null && ec.Excludes("supportedKeyTypes",true))
        {
            this.SupportedKeyTypes = null;
        }
        //      C# -> System.Boolean? CanUserManageCluster
        // GraphQL -> canUserManageCluster: Boolean! (scalar)
        if (ec.Includes("canUserManageCluster",true))
        {
            if(this.CanUserManageCluster == null) {

                this.CanUserManageCluster = true;

            } else {


            }
        }
        else if (this.CanUserManageCluster != null && ec.Excludes("canUserManageCluster",true))
        {
            this.CanUserManageCluster = null;
        }
        //      C# -> System.String? Cipher
        // GraphQL -> cipher: String! (scalar)
        if (ec.Includes("cipher",true))
        {
            if(this.Cipher == null) {

                this.Cipher = "FETCH";

            } else {


            }
        }
        else if (this.Cipher != null && ec.Excludes("cipher",true))
        {
            this.Cipher = null;
        }
        //      C# -> System.Boolean? IsConnected
        // GraphQL -> isConnected: Boolean! (scalar)
        if (ec.Includes("isConnected",true))
        {
            if(this.IsConnected == null) {

                this.IsConnected = true;

            } else {


            }
        }
        else if (this.IsConnected != null && ec.Excludes("isConnected",true))
        {
            this.IsConnected = null;
        }
        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        if (ec.Includes("isEncrypted",true))
        {
            if(this.IsEncrypted == null) {

                this.IsEncrypted = true;

            } else {


            }
        }
        else if (this.IsEncrypted != null && ec.Excludes("isEncrypted",true))
        {
            this.IsEncrypted = null;
        }
        //      C# -> System.Boolean? IsOnCloud
        // GraphQL -> isOnCloud: Boolean! (scalar)
        if (ec.Includes("isOnCloud",true))
        {
            if(this.IsOnCloud == null) {

                this.IsOnCloud = true;

            } else {


            }
        }
        else if (this.IsOnCloud != null && ec.Excludes("isOnCloud",true))
        {
            this.IsOnCloud = null;
        }
        //      C# -> System.String? KmipClientUsername
        // GraphQL -> kmipClientUsername: String! (scalar)
        if (ec.Includes("kmipClientUsername",true))
        {
            if(this.KmipClientUsername == null) {

                this.KmipClientUsername = "FETCH";

            } else {


            }
        }
        else if (this.KmipClientUsername != null && ec.Excludes("kmipClientUsername",true))
        {
            this.KmipClientUsername = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? SoftwareVersion
        // GraphQL -> softwareVersion: String! (scalar)
        if (ec.Includes("softwareVersion",true))
        {
            if(this.SoftwareVersion == null) {

                this.SoftwareVersion = "FETCH";

            } else {


            }
        }
        else if (this.SoftwareVersion != null && ec.Excludes("softwareVersion",true))
        {
            this.SoftwareVersion = null;
        }
        //      C# -> System.Int64? TotalKmipServers
        // GraphQL -> totalKmipServers: Long! (scalar)
        if (ec.Includes("totalKmipServers",true))
        {
            if(this.TotalKmipServers == null) {

                this.TotalKmipServers = new System.Int64();

            } else {


            }
        }
        else if (this.TotalKmipServers != null && ec.Excludes("totalKmipServers",true))
        {
            this.TotalKmipServers = null;
        }
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: UUID! (scalar)
        if (ec.Includes("uuid",true))
        {
            if(this.Uuid == null) {

                this.Uuid = "FETCH";

            } else {


            }
        }
        else if (this.Uuid != null && ec.Excludes("uuid",true))
        {
            this.Uuid = null;
        }
        //      C# -> ClusterKeyRotation? LatestRotationCompletedInfo
        // GraphQL -> latestRotationCompletedInfo: ClusterKeyRotation (type)
        if (ec.Includes("latestRotationCompletedInfo",false))
        {
            if(this.LatestRotationCompletedInfo == null) {

                this.LatestRotationCompletedInfo = new ClusterKeyRotation();
                this.LatestRotationCompletedInfo.ApplyExploratoryFieldSpec(ec.NewChild("latestRotationCompletedInfo"));

            } else {

                this.LatestRotationCompletedInfo.ApplyExploratoryFieldSpec(ec.NewChild("latestRotationCompletedInfo"));

            }
        }
        else if (this.LatestRotationCompletedInfo != null && ec.Excludes("latestRotationCompletedInfo",false))
        {
            this.LatestRotationCompletedInfo = null;
        }
        //      C# -> RscKeyRotationRequest? MostRecentRscRequest
        // GraphQL -> mostRecentRscRequest: RscKeyRotationRequest (type)
        if (ec.Includes("mostRecentRscRequest",false))
        {
            if(this.MostRecentRscRequest == null) {

                this.MostRecentRscRequest = new RscKeyRotationRequest();
                this.MostRecentRscRequest.ApplyExploratoryFieldSpec(ec.NewChild("mostRecentRscRequest"));

            } else {

                this.MostRecentRscRequest.ApplyExploratoryFieldSpec(ec.NewChild("mostRecentRscRequest"));

            }
        }
        else if (this.MostRecentRscRequest != null && ec.Excludes("mostRecentRscRequest",false))
        {
            this.MostRecentRscRequest = null;
        }
    }


    #endregion

    } // class ClusterEncryptionInfo
    
    #endregion

    public static class ListClusterEncryptionInfoExtensions
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
            this List<ClusterEncryptionInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterEncryptionInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterEncryptionInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterEncryptionInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterEncryptionInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types