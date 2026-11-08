// GetApplicationResourceCountResponse.cs
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
    #region GetApplicationResourceCountResponse
    public class GetApplicationResourceCountResponse: BaseType
    {
        #region members

        //      C# -> CloudNativeApplicationRefreshStatus? RefreshStatus
        // GraphQL -> refreshStatus: CloudNativeApplicationRefreshStatus! (enum)
        [JsonProperty("refreshStatus")]
        public CloudNativeApplicationRefreshStatus? RefreshStatus { get; set; }

        //      C# -> System.String? ApplicationName
        // GraphQL -> applicationName: String! (scalar)
        [JsonProperty("applicationName")]
        public System.String? ApplicationName { get; set; }

        //      C# -> System.String? CloudNativeAccountName
        // GraphQL -> cloudNativeAccountName: String! (scalar)
        [JsonProperty("cloudNativeAccountName")]
        public System.String? CloudNativeAccountName { get; set; }

        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        [JsonProperty("count")]
        public System.Int64? Count { get; set; }

        //      C# -> DateTime? LastRefreshedAt
        // GraphQL -> lastRefreshedAt: DateTime (scalar)
        [JsonProperty("lastRefreshedAt")]
        public DateTime? LastRefreshedAt { get; set; }

        //      C# -> List<ApplicationResourceTypeCount>? CountByType
        // GraphQL -> countByType: [ApplicationResourceTypeCount!]! (type)
        [JsonProperty("countByType")]
        public List<ApplicationResourceTypeCount>? CountByType { get; set; }

        //      C# -> List<GranularResourceProtection>? GranularResources
        // GraphQL -> granularResources: [GranularResourceProtection!]! (type)
        [JsonProperty("granularResources")]
        public List<GranularResourceProtection>? GranularResources { get; set; }

        //      C# -> CloudRegion? Region
        // GraphQL -> region: CloudRegion (type)
        [JsonProperty("region")]
        public CloudRegion? Region { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetApplicationResourceCountResponse";
    }

    public GetApplicationResourceCountResponse Set(
        CloudNativeApplicationRefreshStatus? RefreshStatus = null,
        System.String? ApplicationName = null,
        System.String? CloudNativeAccountName = null,
        System.Int64? Count = null,
        DateTime? LastRefreshedAt = null,
        List<ApplicationResourceTypeCount>? CountByType = null,
        List<GranularResourceProtection>? GranularResources = null,
        CloudRegion? Region = null
    ) 
    {
        if ( RefreshStatus != null ) {
            this.RefreshStatus = RefreshStatus;
        }
        if ( ApplicationName != null ) {
            this.ApplicationName = ApplicationName;
        }
        if ( CloudNativeAccountName != null ) {
            this.CloudNativeAccountName = CloudNativeAccountName;
        }
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( LastRefreshedAt != null ) {
            this.LastRefreshedAt = LastRefreshedAt;
        }
        if ( CountByType != null ) {
            this.CountByType = CountByType;
        }
        if ( GranularResources != null ) {
            this.GranularResources = GranularResources;
        }
        if ( Region != null ) {
            this.Region = Region;
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
        //      C# -> CloudNativeApplicationRefreshStatus? RefreshStatus
        // GraphQL -> refreshStatus: CloudNativeApplicationRefreshStatus! (enum)
        if (this.RefreshStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "refreshStatus\n" ;
            } else {
                s += ind + "refreshStatus\n" ;
            }
        }
        //      C# -> System.String? ApplicationName
        // GraphQL -> applicationName: String! (scalar)
        if (this.ApplicationName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "applicationName\n" ;
            } else {
                s += ind + "applicationName\n" ;
            }
        }
        //      C# -> System.String? CloudNativeAccountName
        // GraphQL -> cloudNativeAccountName: String! (scalar)
        if (this.CloudNativeAccountName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudNativeAccountName\n" ;
            } else {
                s += ind + "cloudNativeAccountName\n" ;
            }
        }
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (this.Count != null) {
            if (conf.Flat) {
                s += conf.Prefix + "count\n" ;
            } else {
                s += ind + "count\n" ;
            }
        }
        //      C# -> DateTime? LastRefreshedAt
        // GraphQL -> lastRefreshedAt: DateTime (scalar)
        if (this.LastRefreshedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRefreshedAt\n" ;
            } else {
                s += ind + "lastRefreshedAt\n" ;
            }
        }
        //      C# -> List<ApplicationResourceTypeCount>? CountByType
        // GraphQL -> countByType: [ApplicationResourceTypeCount!]! (type)
        if (this.CountByType != null) {
            var fspec = this.CountByType.AsFieldSpec(conf.Child("countByType"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "countByType" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<GranularResourceProtection>? GranularResources
        // GraphQL -> granularResources: [GranularResourceProtection!]! (type)
        if (this.GranularResources != null) {
            var fspec = this.GranularResources.AsFieldSpec(conf.Child("granularResources"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "granularResources" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CloudRegion? Region
        // GraphQL -> region: CloudRegion (type)
        if (this.Region != null) {
            var fspec = this.Region.AsFieldSpec(conf.Child("region"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "region" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CloudNativeApplicationRefreshStatus? RefreshStatus
        // GraphQL -> refreshStatus: CloudNativeApplicationRefreshStatus! (enum)
        if (ec.Includes("refreshStatus",true))
        {
            if(this.RefreshStatus == null) {

                this.RefreshStatus = new CloudNativeApplicationRefreshStatus();

            } else {


            }
        }
        else if (this.RefreshStatus != null && ec.Excludes("refreshStatus",true))
        {
            this.RefreshStatus = null;
        }
        //      C# -> System.String? ApplicationName
        // GraphQL -> applicationName: String! (scalar)
        if (ec.Includes("applicationName",true))
        {
            if(this.ApplicationName == null) {

                this.ApplicationName = "FETCH";

            } else {


            }
        }
        else if (this.ApplicationName != null && ec.Excludes("applicationName",true))
        {
            this.ApplicationName = null;
        }
        //      C# -> System.String? CloudNativeAccountName
        // GraphQL -> cloudNativeAccountName: String! (scalar)
        if (ec.Includes("cloudNativeAccountName",true))
        {
            if(this.CloudNativeAccountName == null) {

                this.CloudNativeAccountName = "FETCH";

            } else {


            }
        }
        else if (this.CloudNativeAccountName != null && ec.Excludes("cloudNativeAccountName",true))
        {
            this.CloudNativeAccountName = null;
        }
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (ec.Includes("count",true))
        {
            if(this.Count == null) {

                this.Count = new System.Int64();

            } else {


            }
        }
        else if (this.Count != null && ec.Excludes("count",true))
        {
            this.Count = null;
        }
        //      C# -> DateTime? LastRefreshedAt
        // GraphQL -> lastRefreshedAt: DateTime (scalar)
        if (ec.Includes("lastRefreshedAt",true))
        {
            if(this.LastRefreshedAt == null) {

                this.LastRefreshedAt = new DateTime();

            } else {


            }
        }
        else if (this.LastRefreshedAt != null && ec.Excludes("lastRefreshedAt",true))
        {
            this.LastRefreshedAt = null;
        }
        //      C# -> List<ApplicationResourceTypeCount>? CountByType
        // GraphQL -> countByType: [ApplicationResourceTypeCount!]! (type)
        if (ec.Includes("countByType",false))
        {
            if(this.CountByType == null) {

                this.CountByType = new List<ApplicationResourceTypeCount>();
                this.CountByType.ApplyExploratoryFieldSpec(ec.NewChild("countByType"));

            } else {

                this.CountByType.ApplyExploratoryFieldSpec(ec.NewChild("countByType"));

            }
        }
        else if (this.CountByType != null && ec.Excludes("countByType",false))
        {
            this.CountByType = null;
        }
        //      C# -> List<GranularResourceProtection>? GranularResources
        // GraphQL -> granularResources: [GranularResourceProtection!]! (type)
        if (ec.Includes("granularResources",false))
        {
            if(this.GranularResources == null) {

                this.GranularResources = new List<GranularResourceProtection>();
                this.GranularResources.ApplyExploratoryFieldSpec(ec.NewChild("granularResources"));

            } else {

                this.GranularResources.ApplyExploratoryFieldSpec(ec.NewChild("granularResources"));

            }
        }
        else if (this.GranularResources != null && ec.Excludes("granularResources",false))
        {
            this.GranularResources = null;
        }
        //      C# -> CloudRegion? Region
        // GraphQL -> region: CloudRegion (type)
        if (ec.Includes("region",false))
        {
            if(this.Region == null) {

                this.Region = new CloudRegion();
                this.Region.ApplyExploratoryFieldSpec(ec.NewChild("region"));

            } else {

                this.Region.ApplyExploratoryFieldSpec(ec.NewChild("region"));

            }
        }
        else if (this.Region != null && ec.Excludes("region",false))
        {
            this.Region = null;
        }
    }


    #endregion

    } // class GetApplicationResourceCountResponse
    
    #endregion

    public static class ListGetApplicationResourceCountResponseExtensions
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
            this List<GetApplicationResourceCountResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetApplicationResourceCountResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetApplicationResourceCountResponse> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetApplicationResourceCountResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetApplicationResourceCountResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types