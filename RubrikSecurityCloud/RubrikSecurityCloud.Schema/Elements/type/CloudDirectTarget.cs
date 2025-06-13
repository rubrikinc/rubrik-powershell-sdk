// CloudDirectTarget.cs
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
    #region CloudDirectTarget
    public class CloudDirectTarget: BaseType
    {
        #region members

        //      C# -> System.String? ArchivalLocationId
        // GraphQL -> archivalLocationId: UUID (scalar)
        [JsonProperty("archivalLocationId")]
        public System.String? ArchivalLocationId { get; set; }

        //      C# -> System.String? CloudDirectId
        // GraphQL -> cloudDirectId: String! (scalar)
        [JsonProperty("cloudDirectId")]
        public System.String? CloudDirectId { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? DataBucket
        // GraphQL -> dataBucket: String! (scalar)
        [JsonProperty("dataBucket")]
        public System.String? DataBucket { get; set; }

        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        [JsonProperty("host")]
        public System.String? Host { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Provider
        // GraphQL -> provider: String! (scalar)
        [JsonProperty("provider")]
        public System.String? Provider { get; set; }

        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        [JsonProperty("region")]
        public System.String? Region { get; set; }

        //      C# -> System.String? Tier
        // GraphQL -> tier: String! (scalar)
        [JsonProperty("tier")]
        public System.String? Tier { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudDirectTarget";
    }

    public CloudDirectTarget Set(
        System.String? ArchivalLocationId = null,
        System.String? CloudDirectId = null,
        System.String? ClusterUuid = null,
        System.String? DataBucket = null,
        System.String? Host = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? Provider = null,
        System.String? Region = null,
        System.String? Tier = null
    ) 
    {
        if ( ArchivalLocationId != null ) {
            this.ArchivalLocationId = ArchivalLocationId;
        }
        if ( CloudDirectId != null ) {
            this.CloudDirectId = CloudDirectId;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( DataBucket != null ) {
            this.DataBucket = DataBucket;
        }
        if ( Host != null ) {
            this.Host = Host;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Provider != null ) {
            this.Provider = Provider;
        }
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( Tier != null ) {
            this.Tier = Tier;
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
        //      C# -> System.String? ArchivalLocationId
        // GraphQL -> archivalLocationId: UUID (scalar)
        if (this.ArchivalLocationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archivalLocationId\n" ;
            } else {
                s += ind + "archivalLocationId\n" ;
            }
        }
        //      C# -> System.String? CloudDirectId
        // GraphQL -> cloudDirectId: String! (scalar)
        if (this.CloudDirectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudDirectId\n" ;
            } else {
                s += ind + "cloudDirectId\n" ;
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
        //      C# -> System.String? DataBucket
        // GraphQL -> dataBucket: String! (scalar)
        if (this.DataBucket != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataBucket\n" ;
            } else {
                s += ind + "dataBucket\n" ;
            }
        }
        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        if (this.Host != null) {
            if (conf.Flat) {
                s += conf.Prefix + "host\n" ;
            } else {
                s += ind + "host\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
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
        //      C# -> System.String? Provider
        // GraphQL -> provider: String! (scalar)
        if (this.Provider != null) {
            if (conf.Flat) {
                s += conf.Prefix + "provider\n" ;
            } else {
                s += ind + "provider\n" ;
            }
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> System.String? Tier
        // GraphQL -> tier: String! (scalar)
        if (this.Tier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tier\n" ;
            } else {
                s += ind + "tier\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ArchivalLocationId
        // GraphQL -> archivalLocationId: UUID (scalar)
        if (ec.Includes("archivalLocationId",true))
        {
            if(this.ArchivalLocationId == null) {

                this.ArchivalLocationId = "FETCH";

            } else {


            }
        }
        else if (this.ArchivalLocationId != null && ec.Excludes("archivalLocationId",true))
        {
            this.ArchivalLocationId = null;
        }
        //      C# -> System.String? CloudDirectId
        // GraphQL -> cloudDirectId: String! (scalar)
        if (ec.Includes("cloudDirectId",true))
        {
            if(this.CloudDirectId == null) {

                this.CloudDirectId = "FETCH";

            } else {


            }
        }
        else if (this.CloudDirectId != null && ec.Excludes("cloudDirectId",true))
        {
            this.CloudDirectId = null;
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
        //      C# -> System.String? DataBucket
        // GraphQL -> dataBucket: String! (scalar)
        if (ec.Includes("dataBucket",true))
        {
            if(this.DataBucket == null) {

                this.DataBucket = "FETCH";

            } else {


            }
        }
        else if (this.DataBucket != null && ec.Excludes("dataBucket",true))
        {
            this.DataBucket = null;
        }
        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        if (ec.Includes("host",true))
        {
            if(this.Host == null) {

                this.Host = "FETCH";

            } else {


            }
        }
        else if (this.Host != null && ec.Excludes("host",true))
        {
            this.Host = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
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
        //      C# -> System.String? Provider
        // GraphQL -> provider: String! (scalar)
        if (ec.Includes("provider",true))
        {
            if(this.Provider == null) {

                this.Provider = "FETCH";

            } else {


            }
        }
        else if (this.Provider != null && ec.Excludes("provider",true))
        {
            this.Provider = null;
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = "FETCH";

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> System.String? Tier
        // GraphQL -> tier: String! (scalar)
        if (ec.Includes("tier",true))
        {
            if(this.Tier == null) {

                this.Tier = "FETCH";

            } else {


            }
        }
        else if (this.Tier != null && ec.Excludes("tier",true))
        {
            this.Tier = null;
        }
    }


    #endregion

    } // class CloudDirectTarget
    
    #endregion

    public static class ListCloudDirectTargetExtensions
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
            this List<CloudDirectTarget> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudDirectTarget> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudDirectTarget> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudDirectTarget());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudDirectTarget> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types