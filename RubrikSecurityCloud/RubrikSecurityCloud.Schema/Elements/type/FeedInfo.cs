// FeedInfo.cs
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
    #region FeedInfo
    public class FeedInfo: BaseType
    {
        #region members

        //      C# -> FeedStatus? FeedStatus
        // GraphQL -> feedStatus: FeedStatus! (enum)
        [JsonProperty("feedStatus")]
        public FeedStatus? FeedStatus { get; set; }

        //      C# -> System.String? AddedBy
        // GraphQL -> addedBy: String! (scalar)
        [JsonProperty("addedBy")]
        public System.String? AddedBy { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> DateTime? LastUpdatedTime
        // GraphQL -> lastUpdatedTime: DateTime (scalar)
        [JsonProperty("lastUpdatedTime")]
        public DateTime? LastUpdatedTime { get; set; }

        //      C# -> FeedSummaryStats? FeedStats
        // GraphQL -> feedStats: FeedSummaryStats (type)
        [JsonProperty("feedStats")]
        public FeedSummaryStats? FeedStats { get; set; }

        //      C# -> ProviderInfo? ProviderInfo
        // GraphQL -> providerInfo: ProviderInfo (type)
        [JsonProperty("providerInfo")]
        public ProviderInfo? ProviderInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FeedInfo";
    }

    public FeedInfo Set(
        FeedStatus? FeedStatus = null,
        System.String? AddedBy = null,
        System.String? Description = null,
        DateTime? LastUpdatedTime = null,
        FeedSummaryStats? FeedStats = null,
        ProviderInfo? ProviderInfo = null
    ) 
    {
        if ( FeedStatus != null ) {
            this.FeedStatus = FeedStatus;
        }
        if ( AddedBy != null ) {
            this.AddedBy = AddedBy;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( LastUpdatedTime != null ) {
            this.LastUpdatedTime = LastUpdatedTime;
        }
        if ( FeedStats != null ) {
            this.FeedStats = FeedStats;
        }
        if ( ProviderInfo != null ) {
            this.ProviderInfo = ProviderInfo;
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
        //      C# -> FeedStatus? FeedStatus
        // GraphQL -> feedStatus: FeedStatus! (enum)
        if (this.FeedStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "feedStatus\n" ;
            } else {
                s += ind + "feedStatus\n" ;
            }
        }
        //      C# -> System.String? AddedBy
        // GraphQL -> addedBy: String! (scalar)
        if (this.AddedBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "addedBy\n" ;
            } else {
                s += ind + "addedBy\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> DateTime? LastUpdatedTime
        // GraphQL -> lastUpdatedTime: DateTime (scalar)
        if (this.LastUpdatedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastUpdatedTime\n" ;
            } else {
                s += ind + "lastUpdatedTime\n" ;
            }
        }
        //      C# -> FeedSummaryStats? FeedStats
        // GraphQL -> feedStats: FeedSummaryStats (type)
        if (this.FeedStats != null) {
            var fspec = this.FeedStats.AsFieldSpec(conf.Child("feedStats"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "feedStats" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ProviderInfo? ProviderInfo
        // GraphQL -> providerInfo: ProviderInfo (type)
        if (this.ProviderInfo != null) {
            var fspec = this.ProviderInfo.AsFieldSpec(conf.Child("providerInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "providerInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> FeedStatus? FeedStatus
        // GraphQL -> feedStatus: FeedStatus! (enum)
        if (ec.Includes("feedStatus",true))
        {
            if(this.FeedStatus == null) {

                this.FeedStatus = new FeedStatus();

            } else {


            }
        }
        else if (this.FeedStatus != null && ec.Excludes("feedStatus",true))
        {
            this.FeedStatus = null;
        }
        //      C# -> System.String? AddedBy
        // GraphQL -> addedBy: String! (scalar)
        if (ec.Includes("addedBy",true))
        {
            if(this.AddedBy == null) {

                this.AddedBy = "FETCH";

            } else {


            }
        }
        else if (this.AddedBy != null && ec.Excludes("addedBy",true))
        {
            this.AddedBy = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
        }
        //      C# -> DateTime? LastUpdatedTime
        // GraphQL -> lastUpdatedTime: DateTime (scalar)
        if (ec.Includes("lastUpdatedTime",true))
        {
            if(this.LastUpdatedTime == null) {

                this.LastUpdatedTime = new DateTime();

            } else {


            }
        }
        else if (this.LastUpdatedTime != null && ec.Excludes("lastUpdatedTime",true))
        {
            this.LastUpdatedTime = null;
        }
        //      C# -> FeedSummaryStats? FeedStats
        // GraphQL -> feedStats: FeedSummaryStats (type)
        if (ec.Includes("feedStats",false))
        {
            if(this.FeedStats == null) {

                this.FeedStats = new FeedSummaryStats();
                this.FeedStats.ApplyExploratoryFieldSpec(ec.NewChild("feedStats"));

            } else {

                this.FeedStats.ApplyExploratoryFieldSpec(ec.NewChild("feedStats"));

            }
        }
        else if (this.FeedStats != null && ec.Excludes("feedStats",false))
        {
            this.FeedStats = null;
        }
        //      C# -> ProviderInfo? ProviderInfo
        // GraphQL -> providerInfo: ProviderInfo (type)
        if (ec.Includes("providerInfo",false))
        {
            if(this.ProviderInfo == null) {

                this.ProviderInfo = new ProviderInfo();
                this.ProviderInfo.ApplyExploratoryFieldSpec(ec.NewChild("providerInfo"));

            } else {

                this.ProviderInfo.ApplyExploratoryFieldSpec(ec.NewChild("providerInfo"));

            }
        }
        else if (this.ProviderInfo != null && ec.Excludes("providerInfo",false))
        {
            this.ProviderInfo = null;
        }
    }


    #endregion

    } // class FeedInfo
    
    #endregion

    public static class ListFeedInfoExtensions
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
            this List<FeedInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FeedInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FeedInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FeedInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FeedInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types