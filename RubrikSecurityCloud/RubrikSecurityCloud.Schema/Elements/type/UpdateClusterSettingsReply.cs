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

namespace Rubrik.SecurityCloud.Types
{
    #region UpdateClusterSettingsReply
    public class UpdateClusterSettingsReply: IFragment
    {
        #region members
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

        //      C# -> RegisteredMode? RegisteredMode
        // GraphQL -> registeredMode: RegisteredMode! (enum)
        [JsonProperty("registeredMode")]
        public RegisteredMode? RegisteredMode { get; set; }

        #endregion

    #region methods

    public UpdateClusterSettingsReply Set(
        System.String? AcceptedEulaVersion = null,
        System.String? ApiVersion = null,
        System.String? ClusterUuid = null,
        System.String? LatestEulaVersion = null,
        System.String? Name = null,
        System.String? RubrikUrl = null,
        System.String? Version = null,
        ClusterGeolocation? Geolocation = null,
        ClusterTimezone? Timezone = null,
        RegisteredMode? RegisteredMode = null
    ) 
    {
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
        if ( RegisteredMode != null ) {
            this.RegisteredMode = RegisteredMode;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? AcceptedEulaVersion
            // GraphQL -> acceptedEulaVersion: String! (scalar)
            if (this.AcceptedEulaVersion != null)
            {
                 s += ind + "acceptedEulaVersion\n";

            }
            //      C# -> System.String? ApiVersion
            // GraphQL -> apiVersion: String! (scalar)
            if (this.ApiVersion != null)
            {
                 s += ind + "apiVersion\n";

            }
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: UUID! (scalar)
            if (this.ClusterUuid != null)
            {
                 s += ind + "clusterUuid\n";

            }
            //      C# -> System.String? LatestEulaVersion
            // GraphQL -> latestEulaVersion: String! (scalar)
            if (this.LatestEulaVersion != null)
            {
                 s += ind + "latestEulaVersion\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? RubrikUrl
            // GraphQL -> rubrikUrl: URL! (scalar)
            if (this.RubrikUrl != null)
            {
                 s += ind + "rubrikUrl\n";

            }
            //      C# -> System.String? Version
            // GraphQL -> version: String! (scalar)
            if (this.Version != null)
            {
                 s += ind + "version\n";

            }
            //      C# -> ClusterGeolocation? Geolocation
            // GraphQL -> geolocation: ClusterGeolocation (type)
            if (this.Geolocation != null)
            {
                 s += ind + "geolocation\n";

                 s += ind + "{\n" + 
                 this.Geolocation.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ClusterTimezone? Timezone
            // GraphQL -> timezone: ClusterTimezone (type)
            if (this.Timezone != null)
            {
                 s += ind + "timezone\n";

                 s += ind + "{\n" + 
                 this.Timezone.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> RegisteredMode? RegisteredMode
            // GraphQL -> registeredMode: RegisteredMode! (enum)
            if (this.RegisteredMode != null)
            {
                 s += ind + "registeredMode\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AcceptedEulaVersion
            // GraphQL -> acceptedEulaVersion: String! (scalar)
            if (this.AcceptedEulaVersion == null && Exploration.Includes(parent + ".acceptedEulaVersion$"))
            {
                this.AcceptedEulaVersion = new System.String("FETCH");
            }
            //      C# -> System.String? ApiVersion
            // GraphQL -> apiVersion: String! (scalar)
            if (this.ApiVersion == null && Exploration.Includes(parent + ".apiVersion$"))
            {
                this.ApiVersion = new System.String("FETCH");
            }
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: UUID! (scalar)
            if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid$"))
            {
                this.ClusterUuid = new System.String("FETCH");
            }
            //      C# -> System.String? LatestEulaVersion
            // GraphQL -> latestEulaVersion: String! (scalar)
            if (this.LatestEulaVersion == null && Exploration.Includes(parent + ".latestEulaVersion$"))
            {
                this.LatestEulaVersion = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? RubrikUrl
            // GraphQL -> rubrikUrl: URL! (scalar)
            if (this.RubrikUrl == null && Exploration.Includes(parent + ".rubrikUrl$"))
            {
                this.RubrikUrl = new System.String("FETCH");
            }
            //      C# -> System.String? Version
            // GraphQL -> version: String! (scalar)
            if (this.Version == null && Exploration.Includes(parent + ".version$"))
            {
                this.Version = new System.String("FETCH");
            }
            //      C# -> ClusterGeolocation? Geolocation
            // GraphQL -> geolocation: ClusterGeolocation (type)
            if (this.Geolocation == null && Exploration.Includes(parent + ".geolocation"))
            {
                this.Geolocation = new ClusterGeolocation();
                this.Geolocation.ApplyExploratoryFragment(parent + ".geolocation");
            }
            //      C# -> ClusterTimezone? Timezone
            // GraphQL -> timezone: ClusterTimezone (type)
            if (this.Timezone == null && Exploration.Includes(parent + ".timezone"))
            {
                this.Timezone = new ClusterTimezone();
                this.Timezone.ApplyExploratoryFragment(parent + ".timezone");
            }
            //      C# -> RegisteredMode? RegisteredMode
            // GraphQL -> registeredMode: RegisteredMode! (enum)
            if (this.RegisteredMode == null && Exploration.Includes(parent + ".registeredMode$"))
            {
                this.RegisteredMode = new RegisteredMode();
            }
        }


    #endregion

    } // class UpdateClusterSettingsReply
    #endregion

    public static class ListUpdateClusterSettingsReplyExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<UpdateClusterSettingsReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UpdateClusterSettingsReply> list, 
            String parent = "")
        {
            var item = new UpdateClusterSettingsReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types