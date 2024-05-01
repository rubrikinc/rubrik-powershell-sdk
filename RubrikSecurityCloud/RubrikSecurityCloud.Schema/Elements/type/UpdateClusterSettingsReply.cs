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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> RegisteredMode? RegisteredMode
        // GraphQL -> registeredMode: RegisteredMode! (enum)
        if (this.RegisteredMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "registeredMode\n" ;
            } else {
                s += ind + "registeredMode\n" ;
            }
        }
        //      C# -> System.String? AcceptedEulaVersion
        // GraphQL -> acceptedEulaVersion: String! (scalar)
        if (this.AcceptedEulaVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "acceptedEulaVersion\n" ;
            } else {
                s += ind + "acceptedEulaVersion\n" ;
            }
        }
        //      C# -> System.String? ApiVersion
        // GraphQL -> apiVersion: String! (scalar)
        if (this.ApiVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "apiVersion\n" ;
            } else {
                s += ind + "apiVersion\n" ;
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.String? LatestEulaVersion
        // GraphQL -> latestEulaVersion: String! (scalar)
        if (this.LatestEulaVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestEulaVersion\n" ;
            } else {
                s += ind + "latestEulaVersion\n" ;
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
        //      C# -> System.String? RubrikUrl
        // GraphQL -> rubrikUrl: URL! (scalar)
        if (this.RubrikUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rubrikUrl\n" ;
            } else {
                s += ind + "rubrikUrl\n" ;
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
        //      C# -> ClusterGeolocation? Geolocation
        // GraphQL -> geolocation: ClusterGeolocation (type)
        if (this.Geolocation != null) {
            var fspec = this.Geolocation.AsFieldSpec(conf.Child("geolocation"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "geolocation" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ClusterTimezone? Timezone
        // GraphQL -> timezone: ClusterTimezone (type)
        if (this.Timezone != null) {
            var fspec = this.Timezone.AsFieldSpec(conf.Child("timezone"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "timezone" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RegisteredMode? RegisteredMode
        // GraphQL -> registeredMode: RegisteredMode! (enum)
        if (ec.Includes("registeredMode",true))
        {
            if(this.RegisteredMode == null) {

                this.RegisteredMode = new RegisteredMode();

            } else {


            }
        }
        else if (this.RegisteredMode != null && ec.Excludes("registeredMode",true))
        {
            this.RegisteredMode = null;
        }
        //      C# -> System.String? AcceptedEulaVersion
        // GraphQL -> acceptedEulaVersion: String! (scalar)
        if (ec.Includes("acceptedEulaVersion",true))
        {
            if(this.AcceptedEulaVersion == null) {

                this.AcceptedEulaVersion = "FETCH";

            } else {


            }
        }
        else if (this.AcceptedEulaVersion != null && ec.Excludes("acceptedEulaVersion",true))
        {
            this.AcceptedEulaVersion = null;
        }
        //      C# -> System.String? ApiVersion
        // GraphQL -> apiVersion: String! (scalar)
        if (ec.Includes("apiVersion",true))
        {
            if(this.ApiVersion == null) {

                this.ApiVersion = "FETCH";

            } else {


            }
        }
        else if (this.ApiVersion != null && ec.Excludes("apiVersion",true))
        {
            this.ApiVersion = null;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.String? LatestEulaVersion
        // GraphQL -> latestEulaVersion: String! (scalar)
        if (ec.Includes("latestEulaVersion",true))
        {
            if(this.LatestEulaVersion == null) {

                this.LatestEulaVersion = "FETCH";

            } else {


            }
        }
        else if (this.LatestEulaVersion != null && ec.Excludes("latestEulaVersion",true))
        {
            this.LatestEulaVersion = null;
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
        //      C# -> System.String? RubrikUrl
        // GraphQL -> rubrikUrl: URL! (scalar)
        if (ec.Includes("rubrikUrl",true))
        {
            if(this.RubrikUrl == null) {

                this.RubrikUrl = "FETCH";

            } else {


            }
        }
        else if (this.RubrikUrl != null && ec.Excludes("rubrikUrl",true))
        {
            this.RubrikUrl = null;
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
        //      C# -> ClusterGeolocation? Geolocation
        // GraphQL -> geolocation: ClusterGeolocation (type)
        if (ec.Includes("geolocation",false))
        {
            if(this.Geolocation == null) {

                this.Geolocation = new ClusterGeolocation();
                this.Geolocation.ApplyExploratoryFieldSpec(ec.NewChild("geolocation"));

            } else {

                this.Geolocation.ApplyExploratoryFieldSpec(ec.NewChild("geolocation"));

            }
        }
        else if (this.Geolocation != null && ec.Excludes("geolocation",false))
        {
            this.Geolocation = null;
        }
        //      C# -> ClusterTimezone? Timezone
        // GraphQL -> timezone: ClusterTimezone (type)
        if (ec.Includes("timezone",false))
        {
            if(this.Timezone == null) {

                this.Timezone = new ClusterTimezone();
                this.Timezone.ApplyExploratoryFieldSpec(ec.NewChild("timezone"));

            } else {

                this.Timezone.ApplyExploratoryFieldSpec(ec.NewChild("timezone"));

            }
        }
        else if (this.Timezone != null && ec.Excludes("timezone",false))
        {
            this.Timezone = null;
        }
    }


    #endregion

    } // class UpdateClusterSettingsReply
    
    #endregion

    public static class ListUpdateClusterSettingsReplyExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<UpdateClusterSettingsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpdateClusterSettingsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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