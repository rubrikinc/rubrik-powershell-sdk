// ManagedVolumePatchConfig.cs
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
    #region ManagedVolumePatchConfig
    public class ManagedVolumePatchConfig: BaseType
    {
        #region members

        //      C# -> List<System.String>? HostPatterns
        // GraphQL -> hostPatterns: [String!]! (scalar)
        [JsonProperty("hostPatterns")]
        public List<System.String>? HostPatterns { get; set; }

        //      C# -> List<System.String>? NodeHint
        // GraphQL -> nodeHint: [String!]! (scalar)
        [JsonProperty("nodeHint")]
        public List<System.String>? NodeHint { get; set; }

        //      C# -> System.String? SmbDomainName
        // GraphQL -> smbDomainName: String (scalar)
        [JsonProperty("smbDomainName")]
        public System.String? SmbDomainName { get; set; }

        //      C# -> List<System.String>? SmbValidIps
        // GraphQL -> smbValidIps: [String!]! (scalar)
        [JsonProperty("smbValidIps")]
        public List<System.String>? SmbValidIps { get; set; }

        //      C# -> List<System.String>? SmbValidUsers
        // GraphQL -> smbValidUsers: [String!]! (scalar)
        [JsonProperty("smbValidUsers")]
        public List<System.String>? SmbValidUsers { get; set; }

        //      C# -> ManagedVolumeNfsSettings? NfsSettings
        // GraphQL -> nfsSettings: ManagedVolumeNFSSettings (type)
        [JsonProperty("nfsSettings")]
        public ManagedVolumeNfsSettings? NfsSettings { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManagedVolumePatchConfig";
    }

    public ManagedVolumePatchConfig Set(
        List<System.String>? HostPatterns = null,
        List<System.String>? NodeHint = null,
        System.String? SmbDomainName = null,
        List<System.String>? SmbValidIps = null,
        List<System.String>? SmbValidUsers = null,
        ManagedVolumeNfsSettings? NfsSettings = null
    ) 
    {
        if ( HostPatterns != null ) {
            this.HostPatterns = HostPatterns;
        }
        if ( NodeHint != null ) {
            this.NodeHint = NodeHint;
        }
        if ( SmbDomainName != null ) {
            this.SmbDomainName = SmbDomainName;
        }
        if ( SmbValidIps != null ) {
            this.SmbValidIps = SmbValidIps;
        }
        if ( SmbValidUsers != null ) {
            this.SmbValidUsers = SmbValidUsers;
        }
        if ( NfsSettings != null ) {
            this.NfsSettings = NfsSettings;
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
        //      C# -> List<System.String>? HostPatterns
        // GraphQL -> hostPatterns: [String!]! (scalar)
        if (this.HostPatterns != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostPatterns\n" ;
            } else {
                s += ind + "hostPatterns\n" ;
            }
        }
        //      C# -> List<System.String>? NodeHint
        // GraphQL -> nodeHint: [String!]! (scalar)
        if (this.NodeHint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeHint\n" ;
            } else {
                s += ind + "nodeHint\n" ;
            }
        }
        //      C# -> System.String? SmbDomainName
        // GraphQL -> smbDomainName: String (scalar)
        if (this.SmbDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "smbDomainName\n" ;
            } else {
                s += ind + "smbDomainName\n" ;
            }
        }
        //      C# -> List<System.String>? SmbValidIps
        // GraphQL -> smbValidIps: [String!]! (scalar)
        if (this.SmbValidIps != null) {
            if (conf.Flat) {
                s += conf.Prefix + "smbValidIps\n" ;
            } else {
                s += ind + "smbValidIps\n" ;
            }
        }
        //      C# -> List<System.String>? SmbValidUsers
        // GraphQL -> smbValidUsers: [String!]! (scalar)
        if (this.SmbValidUsers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "smbValidUsers\n" ;
            } else {
                s += ind + "smbValidUsers\n" ;
            }
        }
        //      C# -> ManagedVolumeNfsSettings? NfsSettings
        // GraphQL -> nfsSettings: ManagedVolumeNFSSettings (type)
        if (this.NfsSettings != null) {
            var fspec = this.NfsSettings.AsFieldSpec(conf.Child("nfsSettings"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nfsSettings" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? HostPatterns
        // GraphQL -> hostPatterns: [String!]! (scalar)
        if (ec.Includes("hostPatterns",true))
        {
            if(this.HostPatterns == null) {

                this.HostPatterns = new List<System.String>();

            } else {


            }
        }
        else if (this.HostPatterns != null && ec.Excludes("hostPatterns",true))
        {
            this.HostPatterns = null;
        }
        //      C# -> List<System.String>? NodeHint
        // GraphQL -> nodeHint: [String!]! (scalar)
        if (ec.Includes("nodeHint",true))
        {
            if(this.NodeHint == null) {

                this.NodeHint = new List<System.String>();

            } else {


            }
        }
        else if (this.NodeHint != null && ec.Excludes("nodeHint",true))
        {
            this.NodeHint = null;
        }
        //      C# -> System.String? SmbDomainName
        // GraphQL -> smbDomainName: String (scalar)
        if (ec.Includes("smbDomainName",true))
        {
            if(this.SmbDomainName == null) {

                this.SmbDomainName = "FETCH";

            } else {


            }
        }
        else if (this.SmbDomainName != null && ec.Excludes("smbDomainName",true))
        {
            this.SmbDomainName = null;
        }
        //      C# -> List<System.String>? SmbValidIps
        // GraphQL -> smbValidIps: [String!]! (scalar)
        if (ec.Includes("smbValidIps",true))
        {
            if(this.SmbValidIps == null) {

                this.SmbValidIps = new List<System.String>();

            } else {


            }
        }
        else if (this.SmbValidIps != null && ec.Excludes("smbValidIps",true))
        {
            this.SmbValidIps = null;
        }
        //      C# -> List<System.String>? SmbValidUsers
        // GraphQL -> smbValidUsers: [String!]! (scalar)
        if (ec.Includes("smbValidUsers",true))
        {
            if(this.SmbValidUsers == null) {

                this.SmbValidUsers = new List<System.String>();

            } else {


            }
        }
        else if (this.SmbValidUsers != null && ec.Excludes("smbValidUsers",true))
        {
            this.SmbValidUsers = null;
        }
        //      C# -> ManagedVolumeNfsSettings? NfsSettings
        // GraphQL -> nfsSettings: ManagedVolumeNFSSettings (type)
        if (ec.Includes("nfsSettings",false))
        {
            if(this.NfsSettings == null) {

                this.NfsSettings = new ManagedVolumeNfsSettings();
                this.NfsSettings.ApplyExploratoryFieldSpec(ec.NewChild("nfsSettings"));

            } else {

                this.NfsSettings.ApplyExploratoryFieldSpec(ec.NewChild("nfsSettings"));

            }
        }
        else if (this.NfsSettings != null && ec.Excludes("nfsSettings",false))
        {
            this.NfsSettings = null;
        }
    }


    #endregion

    } // class ManagedVolumePatchConfig
    
    #endregion

    public static class ListManagedVolumePatchConfigExtensions
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
            this List<ManagedVolumePatchConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ManagedVolumePatchConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumePatchConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumePatchConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManagedVolumePatchConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types