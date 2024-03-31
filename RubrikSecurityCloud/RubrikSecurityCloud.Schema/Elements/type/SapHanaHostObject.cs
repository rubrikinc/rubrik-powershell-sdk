// SapHanaHostObject.cs
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
    #region SapHanaHostObject
    public class SapHanaHostObject: BaseType
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.String? HostType
        // GraphQL -> hostType: String! (scalar)
        [JsonProperty("hostType")]
        public System.String? HostType { get; set; }

        //      C# -> System.String? HostUuid
        // GraphQL -> hostUuid: String! (scalar)
        [JsonProperty("hostUuid")]
        public System.String? HostUuid { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> PhysicalHost? Host
        // GraphQL -> host: PhysicalHost! (type)
        [JsonProperty("host")]
        public PhysicalHost? Host { get; set; }

        //      C# -> PhysicalHost? SystemHost
        // GraphQL -> systemHost: PhysicalHost (type)
        [JsonProperty("systemHost")]
        public PhysicalHost? SystemHost { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SapHanaHostObject";
    }

    public SapHanaHostObject Set(
        System.String? ClusterUuid = null,
        System.String? HostName = null,
        System.String? HostType = null,
        System.String? HostUuid = null,
        System.String? Status = null,
        PhysicalHost? Host = null,
        PhysicalHost? SystemHost = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( HostType != null ) {
            this.HostType = HostType;
        }
        if ( HostUuid != null ) {
            this.HostUuid = HostUuid;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Host != null ) {
            this.Host = Host;
        }
        if ( SystemHost != null ) {
            this.SystemHost = SystemHost;
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
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostName\n" ;
            } else {
                s += ind + "hostName\n" ;
            }
        }
        //      C# -> System.String? HostType
        // GraphQL -> hostType: String! (scalar)
        if (this.HostType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostType\n" ;
            } else {
                s += ind + "hostType\n" ;
            }
        }
        //      C# -> System.String? HostUuid
        // GraphQL -> hostUuid: String! (scalar)
        if (this.HostUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostUuid\n" ;
            } else {
                s += ind + "hostUuid\n" ;
            }
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> PhysicalHost? Host
        // GraphQL -> host: PhysicalHost! (type)
        if (this.Host != null) {
            var fspec = this.Host.AsFieldSpec(conf.Child("host"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "host {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PhysicalHost? SystemHost
        // GraphQL -> systemHost: PhysicalHost (type)
        if (this.SystemHost != null) {
            var fspec = this.SystemHost.AsFieldSpec(conf.Child("systemHost"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "systemHost {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (ec.Includes("hostName",true))
        {
            if(this.HostName == null) {

                this.HostName = "FETCH";

            } else {


            }
        }
        else if (this.HostName != null && ec.Excludes("hostName",true))
        {
            this.HostName = null;
        }
        //      C# -> System.String? HostType
        // GraphQL -> hostType: String! (scalar)
        if (ec.Includes("hostType",true))
        {
            if(this.HostType == null) {

                this.HostType = "FETCH";

            } else {


            }
        }
        else if (this.HostType != null && ec.Excludes("hostType",true))
        {
            this.HostType = null;
        }
        //      C# -> System.String? HostUuid
        // GraphQL -> hostUuid: String! (scalar)
        if (ec.Includes("hostUuid",true))
        {
            if(this.HostUuid == null) {

                this.HostUuid = "FETCH";

            } else {


            }
        }
        else if (this.HostUuid != null && ec.Excludes("hostUuid",true))
        {
            this.HostUuid = null;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = "FETCH";

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> PhysicalHost? Host
        // GraphQL -> host: PhysicalHost! (type)
        if (ec.Includes("host",false))
        {
            if(this.Host == null) {

                this.Host = new PhysicalHost();
                this.Host.ApplyExploratoryFieldSpec(ec.NewChild("host"));

            } else {

                this.Host.ApplyExploratoryFieldSpec(ec.NewChild("host"));

            }
        }
        else if (this.Host != null && ec.Excludes("host",false))
        {
            this.Host = null;
        }
        //      C# -> PhysicalHost? SystemHost
        // GraphQL -> systemHost: PhysicalHost (type)
        if (ec.Includes("systemHost",false))
        {
            if(this.SystemHost == null) {

                this.SystemHost = new PhysicalHost();
                this.SystemHost.ApplyExploratoryFieldSpec(ec.NewChild("systemHost"));

            } else {

                this.SystemHost.ApplyExploratoryFieldSpec(ec.NewChild("systemHost"));

            }
        }
        else if (this.SystemHost != null && ec.Excludes("systemHost",false))
        {
            this.SystemHost = null;
        }
    }


    #endregion

    } // class SapHanaHostObject
    
    #endregion

    public static class ListSapHanaHostObjectExtensions
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
            this List<SapHanaHostObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SapHanaHostObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaHostObject> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaHostObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SapHanaHostObject> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types