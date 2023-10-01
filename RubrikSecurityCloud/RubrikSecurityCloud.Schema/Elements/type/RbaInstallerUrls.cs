// RbaInstallerUrls.cs
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
    #region RbaInstallerUrls
    public class RbaInstallerUrls: BaseType
    {
        #region members

        //      C# -> System.String? DebianHashSha256
        // GraphQL -> debianHashSha256: String! (scalar)
        [JsonProperty("debianHashSha256")]
        public System.String? DebianHashSha256 { get; set; }

        //      C# -> System.String? DebianUrl
        // GraphQL -> debianUrl: String! (scalar)
        [JsonProperty("debianUrl")]
        public System.String? DebianUrl { get; set; }

        //      C# -> System.String? RpmHashSha256
        // GraphQL -> rpmHashSha256: String! (scalar)
        [JsonProperty("rpmHashSha256")]
        public System.String? RpmHashSha256 { get; set; }

        //      C# -> System.String? RpmUrl
        // GraphQL -> rpmUrl: String! (scalar)
        [JsonProperty("rpmUrl")]
        public System.String? RpmUrl { get; set; }

        //      C# -> System.String? WindowsHashSha256
        // GraphQL -> windowsHashSha256: String! (scalar)
        [JsonProperty("windowsHashSha256")]
        public System.String? WindowsHashSha256 { get; set; }

        //      C# -> System.String? WindowsUrl
        // GraphQL -> windowsUrl: String! (scalar)
        [JsonProperty("windowsUrl")]
        public System.String? WindowsUrl { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RbaInstallerUrls";
    }

    public RbaInstallerUrls Set(
        System.String? DebianHashSha256 = null,
        System.String? DebianUrl = null,
        System.String? RpmHashSha256 = null,
        System.String? RpmUrl = null,
        System.String? WindowsHashSha256 = null,
        System.String? WindowsUrl = null
    ) 
    {
        if ( DebianHashSha256 != null ) {
            this.DebianHashSha256 = DebianHashSha256;
        }
        if ( DebianUrl != null ) {
            this.DebianUrl = DebianUrl;
        }
        if ( RpmHashSha256 != null ) {
            this.RpmHashSha256 = RpmHashSha256;
        }
        if ( RpmUrl != null ) {
            this.RpmUrl = RpmUrl;
        }
        if ( WindowsHashSha256 != null ) {
            this.WindowsHashSha256 = WindowsHashSha256;
        }
        if ( WindowsUrl != null ) {
            this.WindowsUrl = WindowsUrl;
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
        //      C# -> System.String? DebianHashSha256
        // GraphQL -> debianHashSha256: String! (scalar)
        if (this.DebianHashSha256 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "debianHashSha256\n" ;
            } else {
                s += ind + "debianHashSha256\n" ;
            }
        }
        //      C# -> System.String? DebianUrl
        // GraphQL -> debianUrl: String! (scalar)
        if (this.DebianUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "debianUrl\n" ;
            } else {
                s += ind + "debianUrl\n" ;
            }
        }
        //      C# -> System.String? RpmHashSha256
        // GraphQL -> rpmHashSha256: String! (scalar)
        if (this.RpmHashSha256 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rpmHashSha256\n" ;
            } else {
                s += ind + "rpmHashSha256\n" ;
            }
        }
        //      C# -> System.String? RpmUrl
        // GraphQL -> rpmUrl: String! (scalar)
        if (this.RpmUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rpmUrl\n" ;
            } else {
                s += ind + "rpmUrl\n" ;
            }
        }
        //      C# -> System.String? WindowsHashSha256
        // GraphQL -> windowsHashSha256: String! (scalar)
        if (this.WindowsHashSha256 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "windowsHashSha256\n" ;
            } else {
                s += ind + "windowsHashSha256\n" ;
            }
        }
        //      C# -> System.String? WindowsUrl
        // GraphQL -> windowsUrl: String! (scalar)
        if (this.WindowsUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "windowsUrl\n" ;
            } else {
                s += ind + "windowsUrl\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? DebianHashSha256
        // GraphQL -> debianHashSha256: String! (scalar)
        if (ec.Includes("debianHashSha256",true))
        {
            if(this.DebianHashSha256 == null) {

                this.DebianHashSha256 = "FETCH";

            } else {


            }
        }
        else if (this.DebianHashSha256 != null && ec.Excludes("debianHashSha256",true))
        {
            this.DebianHashSha256 = null;
        }
        //      C# -> System.String? DebianUrl
        // GraphQL -> debianUrl: String! (scalar)
        if (ec.Includes("debianUrl",true))
        {
            if(this.DebianUrl == null) {

                this.DebianUrl = "FETCH";

            } else {


            }
        }
        else if (this.DebianUrl != null && ec.Excludes("debianUrl",true))
        {
            this.DebianUrl = null;
        }
        //      C# -> System.String? RpmHashSha256
        // GraphQL -> rpmHashSha256: String! (scalar)
        if (ec.Includes("rpmHashSha256",true))
        {
            if(this.RpmHashSha256 == null) {

                this.RpmHashSha256 = "FETCH";

            } else {


            }
        }
        else if (this.RpmHashSha256 != null && ec.Excludes("rpmHashSha256",true))
        {
            this.RpmHashSha256 = null;
        }
        //      C# -> System.String? RpmUrl
        // GraphQL -> rpmUrl: String! (scalar)
        if (ec.Includes("rpmUrl",true))
        {
            if(this.RpmUrl == null) {

                this.RpmUrl = "FETCH";

            } else {


            }
        }
        else if (this.RpmUrl != null && ec.Excludes("rpmUrl",true))
        {
            this.RpmUrl = null;
        }
        //      C# -> System.String? WindowsHashSha256
        // GraphQL -> windowsHashSha256: String! (scalar)
        if (ec.Includes("windowsHashSha256",true))
        {
            if(this.WindowsHashSha256 == null) {

                this.WindowsHashSha256 = "FETCH";

            } else {


            }
        }
        else if (this.WindowsHashSha256 != null && ec.Excludes("windowsHashSha256",true))
        {
            this.WindowsHashSha256 = null;
        }
        //      C# -> System.String? WindowsUrl
        // GraphQL -> windowsUrl: String! (scalar)
        if (ec.Includes("windowsUrl",true))
        {
            if(this.WindowsUrl == null) {

                this.WindowsUrl = "FETCH";

            } else {


            }
        }
        else if (this.WindowsUrl != null && ec.Excludes("windowsUrl",true))
        {
            this.WindowsUrl = null;
        }
    }


    #endregion

    } // class RbaInstallerUrls
    
    #endregion

    public static class ListRbaInstallerUrlsExtensions
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
            this List<RbaInstallerUrls> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<RbaInstallerUrls> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RbaInstallerUrls> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RbaInstallerUrls());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RbaInstallerUrls> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types