// CdmApiMetric.cs
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
    #region CdmApiMetric
    public class CdmApiMetric: BaseType
    {
        #region members

        //      C# -> HttpMethod? Method
        // GraphQL -> method: HttpMethod! (enum)
        [JsonProperty("method")]
        public HttpMethod? Method { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Mandatory
        // GraphQL -> mandatory: String! (scalar)
        [JsonProperty("mandatory")]
        public System.String? Mandatory { get; set; }

        //      C# -> DateTime? RecentRequestTimestamp
        // GraphQL -> recentRequestTimestamp: DateTime (scalar)
        [JsonProperty("recentRequestTimestamp")]
        public DateTime? RecentRequestTimestamp { get; set; }

        //      C# -> System.String? Referrer
        // GraphQL -> referrer: String! (scalar)
        [JsonProperty("referrer")]
        public System.String? Referrer { get; set; }

        //      C# -> System.String? RequestUri
        // GraphQL -> requestUri: String! (scalar)
        [JsonProperty("requestUri")]
        public System.String? RequestUri { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmApiMetric";
    }

    public CdmApiMetric Set(
        HttpMethod? Method = null,
        System.String? ClusterUuid = null,
        System.String? Mandatory = null,
        DateTime? RecentRequestTimestamp = null,
        System.String? Referrer = null,
        System.String? RequestUri = null
    ) 
    {
        if ( Method != null ) {
            this.Method = Method;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( Mandatory != null ) {
            this.Mandatory = Mandatory;
        }
        if ( RecentRequestTimestamp != null ) {
            this.RecentRequestTimestamp = RecentRequestTimestamp;
        }
        if ( Referrer != null ) {
            this.Referrer = Referrer;
        }
        if ( RequestUri != null ) {
            this.RequestUri = RequestUri;
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
        //      C# -> HttpMethod? Method
        // GraphQL -> method: HttpMethod! (enum)
        if (this.Method != null) {
            if (conf.Flat) {
                s += conf.Prefix + "method\n" ;
            } else {
                s += ind + "method\n" ;
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
        //      C# -> System.String? Mandatory
        // GraphQL -> mandatory: String! (scalar)
        if (this.Mandatory != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mandatory\n" ;
            } else {
                s += ind + "mandatory\n" ;
            }
        }
        //      C# -> DateTime? RecentRequestTimestamp
        // GraphQL -> recentRequestTimestamp: DateTime (scalar)
        if (this.RecentRequestTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recentRequestTimestamp\n" ;
            } else {
                s += ind + "recentRequestTimestamp\n" ;
            }
        }
        //      C# -> System.String? Referrer
        // GraphQL -> referrer: String! (scalar)
        if (this.Referrer != null) {
            if (conf.Flat) {
                s += conf.Prefix + "referrer\n" ;
            } else {
                s += ind + "referrer\n" ;
            }
        }
        //      C# -> System.String? RequestUri
        // GraphQL -> requestUri: String! (scalar)
        if (this.RequestUri != null) {
            if (conf.Flat) {
                s += conf.Prefix + "requestUri\n" ;
            } else {
                s += ind + "requestUri\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HttpMethod? Method
        // GraphQL -> method: HttpMethod! (enum)
        if (ec.Includes("method",true))
        {
            if(this.Method == null) {

                this.Method = new HttpMethod();

            } else {


            }
        }
        else if (this.Method != null && ec.Excludes("method",true))
        {
            this.Method = null;
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
        //      C# -> System.String? Mandatory
        // GraphQL -> mandatory: String! (scalar)
        if (ec.Includes("mandatory",true))
        {
            if(this.Mandatory == null) {

                this.Mandatory = "FETCH";

            } else {


            }
        }
        else if (this.Mandatory != null && ec.Excludes("mandatory",true))
        {
            this.Mandatory = null;
        }
        //      C# -> DateTime? RecentRequestTimestamp
        // GraphQL -> recentRequestTimestamp: DateTime (scalar)
        if (ec.Includes("recentRequestTimestamp",true))
        {
            if(this.RecentRequestTimestamp == null) {

                this.RecentRequestTimestamp = new DateTime();

            } else {


            }
        }
        else if (this.RecentRequestTimestamp != null && ec.Excludes("recentRequestTimestamp",true))
        {
            this.RecentRequestTimestamp = null;
        }
        //      C# -> System.String? Referrer
        // GraphQL -> referrer: String! (scalar)
        if (ec.Includes("referrer",true))
        {
            if(this.Referrer == null) {

                this.Referrer = "FETCH";

            } else {


            }
        }
        else if (this.Referrer != null && ec.Excludes("referrer",true))
        {
            this.Referrer = null;
        }
        //      C# -> System.String? RequestUri
        // GraphQL -> requestUri: String! (scalar)
        if (ec.Includes("requestUri",true))
        {
            if(this.RequestUri == null) {

                this.RequestUri = "FETCH";

            } else {


            }
        }
        else if (this.RequestUri != null && ec.Excludes("requestUri",true))
        {
            this.RequestUri = null;
        }
    }


    #endregion

    } // class CdmApiMetric
    
    #endregion

    public static class ListCdmApiMetricExtensions
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
            this List<CdmApiMetric> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmApiMetric> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmApiMetric> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmApiMetric());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmApiMetric> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types