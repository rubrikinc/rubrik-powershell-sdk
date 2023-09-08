// ConfigProtectionSetupInfo.cs
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
    #region ConfigProtectionSetupInfo
    public class ConfigProtectionSetupInfo: BaseType
    {
        #region members

        //      C# -> CaCertProviderType? CaCertProvider
        // GraphQL -> caCertProvider: CaCertProviderType (enum)
        [JsonProperty("caCertProvider")]
        public CaCertProviderType? CaCertProvider { get; set; }

        //      C# -> UploadLocationType? UploadLocationType
        // GraphQL -> uploadLocationType: UploadLocationType (enum)
        [JsonProperty("uploadLocationType")]
        public UploadLocationType? UploadLocationType { get; set; }

        //      C# -> System.String? CaCertName
        // GraphQL -> caCertName: String (scalar)
        [JsonProperty("caCertName")]
        public System.String? CaCertName { get; set; }

        //      C# -> System.String? CaCertUuid
        // GraphQL -> caCertUuid: UUID (scalar)
        [JsonProperty("caCertUuid")]
        public System.String? CaCertUuid { get; set; }

        //      C# -> System.String? ReplicationTargetName
        // GraphQL -> replicationTargetName: String (scalar)
        [JsonProperty("replicationTargetName")]
        public System.String? ReplicationTargetName { get; set; }

        //      C# -> System.String? ReplicationTargetUuid
        // GraphQL -> replicationTargetUuid: UUID (scalar)
        [JsonProperty("replicationTargetUuid")]
        public System.String? ReplicationTargetUuid { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ConfigProtectionSetupInfo";
    }

    public ConfigProtectionSetupInfo Set(
        CaCertProviderType? CaCertProvider = null,
        UploadLocationType? UploadLocationType = null,
        System.String? CaCertName = null,
        System.String? CaCertUuid = null,
        System.String? ReplicationTargetName = null,
        System.String? ReplicationTargetUuid = null
    ) 
    {
        if ( CaCertProvider != null ) {
            this.CaCertProvider = CaCertProvider;
        }
        if ( UploadLocationType != null ) {
            this.UploadLocationType = UploadLocationType;
        }
        if ( CaCertName != null ) {
            this.CaCertName = CaCertName;
        }
        if ( CaCertUuid != null ) {
            this.CaCertUuid = CaCertUuid;
        }
        if ( ReplicationTargetName != null ) {
            this.ReplicationTargetName = ReplicationTargetName;
        }
        if ( ReplicationTargetUuid != null ) {
            this.ReplicationTargetUuid = ReplicationTargetUuid;
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
        //      C# -> CaCertProviderType? CaCertProvider
        // GraphQL -> caCertProvider: CaCertProviderType (enum)
        if (this.CaCertProvider != null) {
            s += ind + "caCertProvider\n" ;
        }
        //      C# -> UploadLocationType? UploadLocationType
        // GraphQL -> uploadLocationType: UploadLocationType (enum)
        if (this.UploadLocationType != null) {
            s += ind + "uploadLocationType\n" ;
        }
        //      C# -> System.String? CaCertName
        // GraphQL -> caCertName: String (scalar)
        if (this.CaCertName != null) {
            s += ind + "caCertName\n" ;
        }
        //      C# -> System.String? CaCertUuid
        // GraphQL -> caCertUuid: UUID (scalar)
        if (this.CaCertUuid != null) {
            s += ind + "caCertUuid\n" ;
        }
        //      C# -> System.String? ReplicationTargetName
        // GraphQL -> replicationTargetName: String (scalar)
        if (this.ReplicationTargetName != null) {
            s += ind + "replicationTargetName\n" ;
        }
        //      C# -> System.String? ReplicationTargetUuid
        // GraphQL -> replicationTargetUuid: UUID (scalar)
        if (this.ReplicationTargetUuid != null) {
            s += ind + "replicationTargetUuid\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CaCertProviderType? CaCertProvider
        // GraphQL -> caCertProvider: CaCertProviderType (enum)
        if (this.CaCertProvider == null && ec.Includes("caCertProvider",true))
        {
            this.CaCertProvider = new CaCertProviderType();
        }
        //      C# -> UploadLocationType? UploadLocationType
        // GraphQL -> uploadLocationType: UploadLocationType (enum)
        if (this.UploadLocationType == null && ec.Includes("uploadLocationType",true))
        {
            this.UploadLocationType = new UploadLocationType();
        }
        //      C# -> System.String? CaCertName
        // GraphQL -> caCertName: String (scalar)
        if (this.CaCertName == null && ec.Includes("caCertName",true))
        {
            this.CaCertName = "FETCH";
        }
        //      C# -> System.String? CaCertUuid
        // GraphQL -> caCertUuid: UUID (scalar)
        if (this.CaCertUuid == null && ec.Includes("caCertUuid",true))
        {
            this.CaCertUuid = "FETCH";
        }
        //      C# -> System.String? ReplicationTargetName
        // GraphQL -> replicationTargetName: String (scalar)
        if (this.ReplicationTargetName == null && ec.Includes("replicationTargetName",true))
        {
            this.ReplicationTargetName = "FETCH";
        }
        //      C# -> System.String? ReplicationTargetUuid
        // GraphQL -> replicationTargetUuid: UUID (scalar)
        if (this.ReplicationTargetUuid == null && ec.Includes("replicationTargetUuid",true))
        {
            this.ReplicationTargetUuid = "FETCH";
        }
    }


    #endregion

    } // class ConfigProtectionSetupInfo
    
    #endregion

    public static class ListConfigProtectionSetupInfoExtensions
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
            this List<ConfigProtectionSetupInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ConfigProtectionSetupInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ConfigProtectionSetupInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ConfigProtectionSetupInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types