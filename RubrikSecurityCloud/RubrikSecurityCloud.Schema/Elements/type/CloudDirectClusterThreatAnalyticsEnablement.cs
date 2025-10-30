// CloudDirectClusterThreatAnalyticsEnablement.cs
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
    #region CloudDirectClusterThreatAnalyticsEnablement
    public class CloudDirectClusterThreatAnalyticsEnablement: BaseType
    {
        #region members

        //      C# -> System.Boolean? DataThreatAnalyticsEnabled
        // GraphQL -> dataThreatAnalyticsEnabled: Boolean! (scalar)
        [JsonProperty("dataThreatAnalyticsEnabled")]
        public System.Boolean? DataThreatAnalyticsEnabled { get; set; }

        //      C# -> System.Boolean? IsHealthy
        // GraphQL -> isHealthy: Boolean! (scalar)
        [JsonProperty("isHealthy")]
        public System.Boolean? IsHealthy { get; set; }

        //      C# -> System.Boolean? ThreatMonitoringEnabled
        // GraphQL -> threatMonitoringEnabled: Boolean! (scalar)
        [JsonProperty("threatMonitoringEnabled")]
        public System.Boolean? ThreatMonitoringEnabled { get; set; }

        //      C# -> CloudDirectCluster? Cluster
        // GraphQL -> cluster: CloudDirectCluster (type)
        [JsonProperty("cluster")]
        public CloudDirectCluster? Cluster { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudDirectClusterThreatAnalyticsEnablement";
    }

    public CloudDirectClusterThreatAnalyticsEnablement Set(
        System.Boolean? DataThreatAnalyticsEnabled = null,
        System.Boolean? IsHealthy = null,
        System.Boolean? ThreatMonitoringEnabled = null,
        CloudDirectCluster? Cluster = null
    ) 
    {
        if ( DataThreatAnalyticsEnabled != null ) {
            this.DataThreatAnalyticsEnabled = DataThreatAnalyticsEnabled;
        }
        if ( IsHealthy != null ) {
            this.IsHealthy = IsHealthy;
        }
        if ( ThreatMonitoringEnabled != null ) {
            this.ThreatMonitoringEnabled = ThreatMonitoringEnabled;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
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
        //      C# -> System.Boolean? DataThreatAnalyticsEnabled
        // GraphQL -> dataThreatAnalyticsEnabled: Boolean! (scalar)
        if (this.DataThreatAnalyticsEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataThreatAnalyticsEnabled\n" ;
            } else {
                s += ind + "dataThreatAnalyticsEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsHealthy
        // GraphQL -> isHealthy: Boolean! (scalar)
        if (this.IsHealthy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isHealthy\n" ;
            } else {
                s += ind + "isHealthy\n" ;
            }
        }
        //      C# -> System.Boolean? ThreatMonitoringEnabled
        // GraphQL -> threatMonitoringEnabled: Boolean! (scalar)
        if (this.ThreatMonitoringEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "threatMonitoringEnabled\n" ;
            } else {
                s += ind + "threatMonitoringEnabled\n" ;
            }
        }
        //      C# -> CloudDirectCluster? Cluster
        // GraphQL -> cluster: CloudDirectCluster (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? DataThreatAnalyticsEnabled
        // GraphQL -> dataThreatAnalyticsEnabled: Boolean! (scalar)
        if (ec.Includes("dataThreatAnalyticsEnabled",true))
        {
            if(this.DataThreatAnalyticsEnabled == null) {

                this.DataThreatAnalyticsEnabled = true;

            } else {


            }
        }
        else if (this.DataThreatAnalyticsEnabled != null && ec.Excludes("dataThreatAnalyticsEnabled",true))
        {
            this.DataThreatAnalyticsEnabled = null;
        }
        //      C# -> System.Boolean? IsHealthy
        // GraphQL -> isHealthy: Boolean! (scalar)
        if (ec.Includes("isHealthy",true))
        {
            if(this.IsHealthy == null) {

                this.IsHealthy = true;

            } else {


            }
        }
        else if (this.IsHealthy != null && ec.Excludes("isHealthy",true))
        {
            this.IsHealthy = null;
        }
        //      C# -> System.Boolean? ThreatMonitoringEnabled
        // GraphQL -> threatMonitoringEnabled: Boolean! (scalar)
        if (ec.Includes("threatMonitoringEnabled",true))
        {
            if(this.ThreatMonitoringEnabled == null) {

                this.ThreatMonitoringEnabled = true;

            } else {


            }
        }
        else if (this.ThreatMonitoringEnabled != null && ec.Excludes("threatMonitoringEnabled",true))
        {
            this.ThreatMonitoringEnabled = null;
        }
        //      C# -> CloudDirectCluster? Cluster
        // GraphQL -> cluster: CloudDirectCluster (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new CloudDirectCluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
    }


    #endregion

    } // class CloudDirectClusterThreatAnalyticsEnablement
    
    #endregion

    public static class ListCloudDirectClusterThreatAnalyticsEnablementExtensions
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
            this List<CloudDirectClusterThreatAnalyticsEnablement> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudDirectClusterThreatAnalyticsEnablement> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudDirectClusterThreatAnalyticsEnablement> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudDirectClusterThreatAnalyticsEnablement());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudDirectClusterThreatAnalyticsEnablement> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types