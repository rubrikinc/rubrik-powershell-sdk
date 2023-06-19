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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ClusterEncryptionType? EncryptionType
        // GraphQL -> encryptionType: ClusterEncryptionType! (enum)
        if (this.EncryptionType != null) {
            s += ind + "encryptionType\n" ;
        }
        //      C# -> List<ClusterKeyProtection>? SupportedKeyTypes
        // GraphQL -> supportedKeyTypes: [ClusterKeyProtection!]! (enum)
        if (this.SupportedKeyTypes != null) {
            s += ind + "supportedKeyTypes\n" ;
        }
        //      C# -> System.Boolean? CanUserManageCluster
        // GraphQL -> canUserManageCluster: Boolean! (scalar)
        if (this.CanUserManageCluster != null) {
            s += ind + "canUserManageCluster\n" ;
        }
        //      C# -> System.String? Cipher
        // GraphQL -> cipher: String! (scalar)
        if (this.Cipher != null) {
            s += ind + "cipher\n" ;
        }
        //      C# -> System.Boolean? IsConnected
        // GraphQL -> isConnected: Boolean! (scalar)
        if (this.IsConnected != null) {
            s += ind + "isConnected\n" ;
        }
        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        if (this.IsEncrypted != null) {
            s += ind + "isEncrypted\n" ;
        }
        //      C# -> System.Boolean? IsOnCloud
        // GraphQL -> isOnCloud: Boolean! (scalar)
        if (this.IsOnCloud != null) {
            s += ind + "isOnCloud\n" ;
        }
        //      C# -> System.String? KmipClientUsername
        // GraphQL -> kmipClientUsername: String! (scalar)
        if (this.KmipClientUsername != null) {
            s += ind + "kmipClientUsername\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? SoftwareVersion
        // GraphQL -> softwareVersion: String! (scalar)
        if (this.SoftwareVersion != null) {
            s += ind + "softwareVersion\n" ;
        }
        //      C# -> System.Int64? TotalKmipServers
        // GraphQL -> totalKmipServers: Long! (scalar)
        if (this.TotalKmipServers != null) {
            s += ind + "totalKmipServers\n" ;
        }
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: UUID! (scalar)
        if (this.Uuid != null) {
            s += ind + "uuid\n" ;
        }
        //      C# -> ClusterKeyRotation? LatestRotationCompletedInfo
        // GraphQL -> latestRotationCompletedInfo: ClusterKeyRotation (type)
        if (this.LatestRotationCompletedInfo != null) {
            var fspec = this.LatestRotationCompletedInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "latestRotationCompletedInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> RscKeyRotationRequest? MostRecentRscRequest
        // GraphQL -> mostRecentRscRequest: RscKeyRotationRequest (type)
        if (this.MostRecentRscRequest != null) {
            var fspec = this.MostRecentRscRequest.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "mostRecentRscRequest {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ClusterEncryptionType? EncryptionType
        // GraphQL -> encryptionType: ClusterEncryptionType! (enum)
        if (this.EncryptionType == null && Exploration.Includes(parent + ".encryptionType", true))
        {
            this.EncryptionType = new ClusterEncryptionType();
        }
        //      C# -> List<ClusterKeyProtection>? SupportedKeyTypes
        // GraphQL -> supportedKeyTypes: [ClusterKeyProtection!]! (enum)
        if (this.SupportedKeyTypes == null && Exploration.Includes(parent + ".supportedKeyTypes", true))
        {
            this.SupportedKeyTypes = new List<ClusterKeyProtection>();
        }
        //      C# -> System.Boolean? CanUserManageCluster
        // GraphQL -> canUserManageCluster: Boolean! (scalar)
        if (this.CanUserManageCluster == null && Exploration.Includes(parent + ".canUserManageCluster", true))
        {
            this.CanUserManageCluster = true;
        }
        //      C# -> System.String? Cipher
        // GraphQL -> cipher: String! (scalar)
        if (this.Cipher == null && Exploration.Includes(parent + ".cipher", true))
        {
            this.Cipher = "FETCH";
        }
        //      C# -> System.Boolean? IsConnected
        // GraphQL -> isConnected: Boolean! (scalar)
        if (this.IsConnected == null && Exploration.Includes(parent + ".isConnected", true))
        {
            this.IsConnected = true;
        }
        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        if (this.IsEncrypted == null && Exploration.Includes(parent + ".isEncrypted", true))
        {
            this.IsEncrypted = true;
        }
        //      C# -> System.Boolean? IsOnCloud
        // GraphQL -> isOnCloud: Boolean! (scalar)
        if (this.IsOnCloud == null && Exploration.Includes(parent + ".isOnCloud", true))
        {
            this.IsOnCloud = true;
        }
        //      C# -> System.String? KmipClientUsername
        // GraphQL -> kmipClientUsername: String! (scalar)
        if (this.KmipClientUsername == null && Exploration.Includes(parent + ".kmipClientUsername", true))
        {
            this.KmipClientUsername = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? SoftwareVersion
        // GraphQL -> softwareVersion: String! (scalar)
        if (this.SoftwareVersion == null && Exploration.Includes(parent + ".softwareVersion", true))
        {
            this.SoftwareVersion = "FETCH";
        }
        //      C# -> System.Int64? TotalKmipServers
        // GraphQL -> totalKmipServers: Long! (scalar)
        if (this.TotalKmipServers == null && Exploration.Includes(parent + ".totalKmipServers", true))
        {
            this.TotalKmipServers = new System.Int64();
        }
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: UUID! (scalar)
        if (this.Uuid == null && Exploration.Includes(parent + ".uuid", true))
        {
            this.Uuid = "FETCH";
        }
        //      C# -> ClusterKeyRotation? LatestRotationCompletedInfo
        // GraphQL -> latestRotationCompletedInfo: ClusterKeyRotation (type)
        if (this.LatestRotationCompletedInfo == null && Exploration.Includes(parent + ".latestRotationCompletedInfo"))
        {
            this.LatestRotationCompletedInfo = new ClusterKeyRotation();
            this.LatestRotationCompletedInfo.ApplyExploratoryFieldSpec(parent + ".latestRotationCompletedInfo");
        }
        //      C# -> RscKeyRotationRequest? MostRecentRscRequest
        // GraphQL -> mostRecentRscRequest: RscKeyRotationRequest (type)
        if (this.MostRecentRscRequest == null && Exploration.Includes(parent + ".mostRecentRscRequest"))
        {
            this.MostRecentRscRequest = new RscKeyRotationRequest();
            this.MostRecentRscRequest.ApplyExploratoryFieldSpec(parent + ".mostRecentRscRequest");
        }
    }


    #endregion

    } // class ClusterEncryptionInfo
    
    #endregion

    public static class ListClusterEncryptionInfoExtensions
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
            this List<ClusterEncryptionInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterEncryptionInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterEncryptionInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types