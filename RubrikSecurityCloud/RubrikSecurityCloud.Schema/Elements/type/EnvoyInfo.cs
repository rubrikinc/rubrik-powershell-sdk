// EnvoyInfo.cs
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
    #region EnvoyInfo
    public class EnvoyInfo: BaseType
    {
        #region members

        //      C# -> EnvoyStatusField? EnvoyStatus
        // GraphQL -> envoyStatus: EnvoyStatusField! (enum)
        [JsonProperty("envoyStatus")]
        public EnvoyStatusField? EnvoyStatus { get; set; }

        //      C# -> System.String? EnvoyHostname
        // GraphQL -> envoyHostname: String! (scalar)
        [JsonProperty("envoyHostname")]
        public System.String? EnvoyHostname { get; set; }

        //      C# -> List<System.String>? EnvoyIps
        // GraphQL -> envoyIps: [String!]! (scalar)
        [JsonProperty("envoyIps")]
        public List<System.String>? EnvoyIps { get; set; }

        //      C# -> System.String? EnvoyUuid
        // GraphQL -> envoyUuid: UUID! (scalar)
        [JsonProperty("envoyUuid")]
        public System.String? EnvoyUuid { get; set; }

        //      C# -> System.String? EnvoyVersion
        // GraphQL -> envoyVersion: String! (scalar)
        [JsonProperty("envoyVersion")]
        public System.String? EnvoyVersion { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EnvoyInfo";
    }

    public EnvoyInfo Set(
        EnvoyStatusField? EnvoyStatus = null,
        System.String? EnvoyHostname = null,
        List<System.String>? EnvoyIps = null,
        System.String? EnvoyUuid = null,
        System.String? EnvoyVersion = null
    ) 
    {
        if ( EnvoyStatus != null ) {
            this.EnvoyStatus = EnvoyStatus;
        }
        if ( EnvoyHostname != null ) {
            this.EnvoyHostname = EnvoyHostname;
        }
        if ( EnvoyIps != null ) {
            this.EnvoyIps = EnvoyIps;
        }
        if ( EnvoyUuid != null ) {
            this.EnvoyUuid = EnvoyUuid;
        }
        if ( EnvoyVersion != null ) {
            this.EnvoyVersion = EnvoyVersion;
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
        //      C# -> EnvoyStatusField? EnvoyStatus
        // GraphQL -> envoyStatus: EnvoyStatusField! (enum)
        if (this.EnvoyStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "envoyStatus\n" ;
            } else {
                s += ind + "envoyStatus\n" ;
            }
        }
        //      C# -> System.String? EnvoyHostname
        // GraphQL -> envoyHostname: String! (scalar)
        if (this.EnvoyHostname != null) {
            if (conf.Flat) {
                s += conf.Prefix + "envoyHostname\n" ;
            } else {
                s += ind + "envoyHostname\n" ;
            }
        }
        //      C# -> List<System.String>? EnvoyIps
        // GraphQL -> envoyIps: [String!]! (scalar)
        if (this.EnvoyIps != null) {
            if (conf.Flat) {
                s += conf.Prefix + "envoyIps\n" ;
            } else {
                s += ind + "envoyIps\n" ;
            }
        }
        //      C# -> System.String? EnvoyUuid
        // GraphQL -> envoyUuid: UUID! (scalar)
        if (this.EnvoyUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "envoyUuid\n" ;
            } else {
                s += ind + "envoyUuid\n" ;
            }
        }
        //      C# -> System.String? EnvoyVersion
        // GraphQL -> envoyVersion: String! (scalar)
        if (this.EnvoyVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "envoyVersion\n" ;
            } else {
                s += ind + "envoyVersion\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> EnvoyStatusField? EnvoyStatus
        // GraphQL -> envoyStatus: EnvoyStatusField! (enum)
        if (ec.Includes("envoyStatus",true))
        {
            if(this.EnvoyStatus == null) {

                this.EnvoyStatus = new EnvoyStatusField();

            } else {


            }
        }
        else if (this.EnvoyStatus != null && ec.Excludes("envoyStatus",true))
        {
            this.EnvoyStatus = null;
        }
        //      C# -> System.String? EnvoyHostname
        // GraphQL -> envoyHostname: String! (scalar)
        if (ec.Includes("envoyHostname",true))
        {
            if(this.EnvoyHostname == null) {

                this.EnvoyHostname = "FETCH";

            } else {


            }
        }
        else if (this.EnvoyHostname != null && ec.Excludes("envoyHostname",true))
        {
            this.EnvoyHostname = null;
        }
        //      C# -> List<System.String>? EnvoyIps
        // GraphQL -> envoyIps: [String!]! (scalar)
        if (ec.Includes("envoyIps",true))
        {
            if(this.EnvoyIps == null) {

                this.EnvoyIps = new List<System.String>();

            } else {


            }
        }
        else if (this.EnvoyIps != null && ec.Excludes("envoyIps",true))
        {
            this.EnvoyIps = null;
        }
        //      C# -> System.String? EnvoyUuid
        // GraphQL -> envoyUuid: UUID! (scalar)
        if (ec.Includes("envoyUuid",true))
        {
            if(this.EnvoyUuid == null) {

                this.EnvoyUuid = "FETCH";

            } else {


            }
        }
        else if (this.EnvoyUuid != null && ec.Excludes("envoyUuid",true))
        {
            this.EnvoyUuid = null;
        }
        //      C# -> System.String? EnvoyVersion
        // GraphQL -> envoyVersion: String! (scalar)
        if (ec.Includes("envoyVersion",true))
        {
            if(this.EnvoyVersion == null) {

                this.EnvoyVersion = "FETCH";

            } else {


            }
        }
        else if (this.EnvoyVersion != null && ec.Excludes("envoyVersion",true))
        {
            this.EnvoyVersion = null;
        }
    }


    #endregion

    } // class EnvoyInfo
    
    #endregion

    public static class ListEnvoyInfoExtensions
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
            this List<EnvoyInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EnvoyInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EnvoyInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EnvoyInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EnvoyInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types