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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> CaCertProviderType? CaCertProvider
        // GraphQL -> caCertProvider: CaCertProviderType (enum)
        if (this.CaCertProvider != null) {
            if (conf.Flat) {
                s += conf.Prefix + "caCertProvider\n" ;
            } else {
                s += ind + "caCertProvider\n" ;
            }
        }
        //      C# -> UploadLocationType? UploadLocationType
        // GraphQL -> uploadLocationType: UploadLocationType (enum)
        if (this.UploadLocationType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uploadLocationType\n" ;
            } else {
                s += ind + "uploadLocationType\n" ;
            }
        }
        //      C# -> System.String? CaCertName
        // GraphQL -> caCertName: String (scalar)
        if (this.CaCertName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "caCertName\n" ;
            } else {
                s += ind + "caCertName\n" ;
            }
        }
        //      C# -> System.String? CaCertUuid
        // GraphQL -> caCertUuid: UUID (scalar)
        if (this.CaCertUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "caCertUuid\n" ;
            } else {
                s += ind + "caCertUuid\n" ;
            }
        }
        //      C# -> System.String? ReplicationTargetName
        // GraphQL -> replicationTargetName: String (scalar)
        if (this.ReplicationTargetName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicationTargetName\n" ;
            } else {
                s += ind + "replicationTargetName\n" ;
            }
        }
        //      C# -> System.String? ReplicationTargetUuid
        // GraphQL -> replicationTargetUuid: UUID (scalar)
        if (this.ReplicationTargetUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicationTargetUuid\n" ;
            } else {
                s += ind + "replicationTargetUuid\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CaCertProviderType? CaCertProvider
        // GraphQL -> caCertProvider: CaCertProviderType (enum)
        if (ec.Includes("caCertProvider",true))
        {
            if(this.CaCertProvider == null) {

                this.CaCertProvider = new CaCertProviderType();

            } else {


            }
        }
        else if (this.CaCertProvider != null && ec.Excludes("caCertProvider",true))
        {
            this.CaCertProvider = null;
        }
        //      C# -> UploadLocationType? UploadLocationType
        // GraphQL -> uploadLocationType: UploadLocationType (enum)
        if (ec.Includes("uploadLocationType",true))
        {
            if(this.UploadLocationType == null) {

                this.UploadLocationType = new UploadLocationType();

            } else {


            }
        }
        else if (this.UploadLocationType != null && ec.Excludes("uploadLocationType",true))
        {
            this.UploadLocationType = null;
        }
        //      C# -> System.String? CaCertName
        // GraphQL -> caCertName: String (scalar)
        if (ec.Includes("caCertName",true))
        {
            if(this.CaCertName == null) {

                this.CaCertName = "FETCH";

            } else {


            }
        }
        else if (this.CaCertName != null && ec.Excludes("caCertName",true))
        {
            this.CaCertName = null;
        }
        //      C# -> System.String? CaCertUuid
        // GraphQL -> caCertUuid: UUID (scalar)
        if (ec.Includes("caCertUuid",true))
        {
            if(this.CaCertUuid == null) {

                this.CaCertUuid = "FETCH";

            } else {


            }
        }
        else if (this.CaCertUuid != null && ec.Excludes("caCertUuid",true))
        {
            this.CaCertUuid = null;
        }
        //      C# -> System.String? ReplicationTargetName
        // GraphQL -> replicationTargetName: String (scalar)
        if (ec.Includes("replicationTargetName",true))
        {
            if(this.ReplicationTargetName == null) {

                this.ReplicationTargetName = "FETCH";

            } else {


            }
        }
        else if (this.ReplicationTargetName != null && ec.Excludes("replicationTargetName",true))
        {
            this.ReplicationTargetName = null;
        }
        //      C# -> System.String? ReplicationTargetUuid
        // GraphQL -> replicationTargetUuid: UUID (scalar)
        if (ec.Includes("replicationTargetUuid",true))
        {
            if(this.ReplicationTargetUuid == null) {

                this.ReplicationTargetUuid = "FETCH";

            } else {


            }
        }
        else if (this.ReplicationTargetUuid != null && ec.Excludes("replicationTargetUuid",true))
        {
            this.ReplicationTargetUuid = null;
        }
    }


    #endregion

    } // class ConfigProtectionSetupInfo
    
    #endregion

    public static class ListConfigProtectionSetupInfoExtensions
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
            this List<ConfigProtectionSetupInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ConfigProtectionSetupInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<ConfigProtectionSetupInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types