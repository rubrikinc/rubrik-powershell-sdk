// UpdateClusterSettingsReply.cs
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
    #region UpdateClusterSettingsReply
    public class UpdateClusterSettingsReply: BaseType
    {
        #region members

        //      C# -> RegisteredMode? RegisteredMode
        // GraphQL -> registeredMode: RegisteredMode! (enum)
        [JsonProperty("registeredMode")]
        public RegisteredMode? RegisteredMode { get; set; }

        //      C# -> System.String? AcceptedEulaVersion
        // GraphQL -> acceptedEulaVersion: String! (scalar)
        [JsonProperty("acceptedEulaVersion")]
        public System.String? AcceptedEulaVersion { get; set; }

        //      C# -> System.String? ApiVersion
        // GraphQL -> apiVersion: String! (scalar)
        [JsonProperty("apiVersion")]
        public System.String? ApiVersion { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? LatestEulaVersion
        // GraphQL -> latestEulaVersion: String! (scalar)
        [JsonProperty("latestEulaVersion")]
        public System.String? LatestEulaVersion { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? RubrikUrl
        // GraphQL -> rubrikUrl: URL! (scalar)
        [JsonProperty("rubrikUrl")]
        public System.String? RubrikUrl { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> ClusterGeolocation? Geolocation
        // GraphQL -> geolocation: ClusterGeolocation (type)
        [JsonProperty("geolocation")]
        public ClusterGeolocation? Geolocation { get; set; }

        //      C# -> ClusterTimezone? Timezone
        // GraphQL -> timezone: ClusterTimezone (type)
        [JsonProperty("timezone")]
        public ClusterTimezone? Timezone { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateClusterSettingsReply";
    }

    public UpdateClusterSettingsReply Set(
        RegisteredMode? RegisteredMode = null,
        System.String? AcceptedEulaVersion = null,
        System.String? ApiVersion = null,
        System.String? ClusterUuid = null,
        System.String? LatestEulaVersion = null,
        System.String? Name = null,
        System.String? RubrikUrl = null,
        System.String? Version = null,
        ClusterGeolocation? Geolocation = null,
        ClusterTimezone? Timezone = null
    ) 
    {
        if ( RegisteredMode != null ) {
            this.RegisteredMode = RegisteredMode;
        }
        if ( AcceptedEulaVersion != null ) {
            this.AcceptedEulaVersion = AcceptedEulaVersion;
        }
        if ( ApiVersion != null ) {
            this.ApiVersion = ApiVersion;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( LatestEulaVersion != null ) {
            this.LatestEulaVersion = LatestEulaVersion;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( RubrikUrl != null ) {
            this.RubrikUrl = RubrikUrl;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( Geolocation != null ) {
            this.Geolocation = Geolocation;
        }
        if ( Timezone != null ) {
            this.Timezone = Timezone;
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
        //      C# -> RegisteredMode? RegisteredMode
        // GraphQL -> registeredMode: RegisteredMode! (enum)
        if (this.RegisteredMode != null) {
            s += ind + "registeredMode\n" ;
        }
        //      C# -> System.String? AcceptedEulaVersion
        // GraphQL -> acceptedEulaVersion: String! (scalar)
        if (this.AcceptedEulaVersion != null) {
            s += ind + "acceptedEulaVersion\n" ;
        }
        //      C# -> System.String? ApiVersion
        // GraphQL -> apiVersion: String! (scalar)
        if (this.ApiVersion != null) {
            s += ind + "apiVersion\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.String? LatestEulaVersion
        // GraphQL -> latestEulaVersion: String! (scalar)
        if (this.LatestEulaVersion != null) {
            s += ind + "latestEulaVersion\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? RubrikUrl
        // GraphQL -> rubrikUrl: URL! (scalar)
        if (this.RubrikUrl != null) {
            s += ind + "rubrikUrl\n" ;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        //      C# -> ClusterGeolocation? Geolocation
        // GraphQL -> geolocation: ClusterGeolocation (type)
        if (this.Geolocation != null) {
            var fspec = this.Geolocation.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "geolocation {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ClusterTimezone? Timezone
        // GraphQL -> timezone: ClusterTimezone (type)
        if (this.Timezone != null) {
            var fspec = this.Timezone.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "timezone {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RegisteredMode? RegisteredMode
        // GraphQL -> registeredMode: RegisteredMode! (enum)
        if (this.RegisteredMode == null && ec.Includes("registeredMode",true))
        {
            this.RegisteredMode = new RegisteredMode();
        }
        //      C# -> System.String? AcceptedEulaVersion
        // GraphQL -> acceptedEulaVersion: String! (scalar)
        if (this.AcceptedEulaVersion == null && ec.Includes("acceptedEulaVersion",true))
        {
            this.AcceptedEulaVersion = "FETCH";
        }
        //      C# -> System.String? ApiVersion
        // GraphQL -> apiVersion: String! (scalar)
        if (this.ApiVersion == null && ec.Includes("apiVersion",true))
        {
            this.ApiVersion = "FETCH";
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && ec.Includes("clusterUuid",true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> System.String? LatestEulaVersion
        // GraphQL -> latestEulaVersion: String! (scalar)
        if (this.LatestEulaVersion == null && ec.Includes("latestEulaVersion",true))
        {
            this.LatestEulaVersion = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? RubrikUrl
        // GraphQL -> rubrikUrl: URL! (scalar)
        if (this.RubrikUrl == null && ec.Includes("rubrikUrl",true))
        {
            this.RubrikUrl = "FETCH";
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version == null && ec.Includes("version",true))
        {
            this.Version = "FETCH";
        }
        //      C# -> ClusterGeolocation? Geolocation
        // GraphQL -> geolocation: ClusterGeolocation (type)
        if (this.Geolocation == null && ec.Includes("geolocation",false))
        {
            this.Geolocation = new ClusterGeolocation();
            this.Geolocation.ApplyExploratoryFieldSpec(ec.NewChild("geolocation"));
        }
        //      C# -> ClusterTimezone? Timezone
        // GraphQL -> timezone: ClusterTimezone (type)
        if (this.Timezone == null && ec.Includes("timezone",false))
        {
            this.Timezone = new ClusterTimezone();
            this.Timezone.ApplyExploratoryFieldSpec(ec.NewChild("timezone"));
        }
    }


    #endregion

    } // class UpdateClusterSettingsReply
    
    #endregion

    public static class ListUpdateClusterSettingsReplyExtensions
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
            this List<UpdateClusterSettingsReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateClusterSettingsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateClusterSettingsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateClusterSettingsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types