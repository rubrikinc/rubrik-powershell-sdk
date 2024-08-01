// IocFeedEntry.cs
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
    #region IocFeedEntry
    public class IocFeedEntry: BaseType
    {
        #region members

        //      C# -> FeedEntryStatus? IocStatus
        // GraphQL -> iocStatus: FeedEntryStatus! (enum)
        [JsonProperty("iocStatus")]
        public FeedEntryStatus? IocStatus { get; set; }

        //      C# -> ThreatFeedType? IocType
        // GraphQL -> iocType: ThreatFeedType! (enum)
        [JsonProperty("iocType")]
        public ThreatFeedType? IocType { get; set; }

        //      C# -> System.String? Author
        // GraphQL -> author: String! (scalar)
        [JsonProperty("author")]
        public System.String? Author { get; set; }

        //      C# -> System.String? IntelId
        // GraphQL -> intelId: String! (scalar)
        [JsonProperty("intelId")]
        public System.String? IntelId { get; set; }

        //      C# -> DateTime? LastUpdatedTime
        // GraphQL -> lastUpdatedTime: DateTime (scalar)
        [JsonProperty("lastUpdatedTime")]
        public DateTime? LastUpdatedTime { get; set; }

        //      C# -> System.String? ProviderIocId
        // GraphQL -> providerIocId: String! (scalar)
        [JsonProperty("providerIocId")]
        public System.String? ProviderIocId { get; set; }

        //      C# -> System.String? ProviderMalwareId
        // GraphQL -> providerMalwareId: String! (scalar)
        [JsonProperty("providerMalwareId")]
        public System.String? ProviderMalwareId { get; set; }

        //      C# -> System.String? ThreatFamily
        // GraphQL -> threatFamily: String! (scalar)
        [JsonProperty("threatFamily")]
        public System.String? ThreatFamily { get; set; }

        //      C# -> DisabledInfo? DisabledInfo
        // GraphQL -> disabledInfo: DisabledInfo (type)
        [JsonProperty("disabledInfo")]
        public DisabledInfo? DisabledInfo { get; set; }

        //      C# -> HashInfo? HashInfo
        // GraphQL -> hashInfo: HashInfo (type)
        [JsonProperty("hashInfo")]
        public HashInfo? HashInfo { get; set; }

        //      C# -> ProviderInfo? ProviderInfo
        // GraphQL -> providerInfo: ProviderInfo (type)
        [JsonProperty("providerInfo")]
        public ProviderInfo? ProviderInfo { get; set; }

        //      C# -> YaraInfo? YaraInfo
        // GraphQL -> yaraInfo: YaraInfo (type)
        [JsonProperty("yaraInfo")]
        public YaraInfo? YaraInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IocFeedEntry";
    }

    public IocFeedEntry Set(
        FeedEntryStatus? IocStatus = null,
        ThreatFeedType? IocType = null,
        System.String? Author = null,
        System.String? IntelId = null,
        DateTime? LastUpdatedTime = null,
        System.String? ProviderIocId = null,
        System.String? ProviderMalwareId = null,
        System.String? ThreatFamily = null,
        DisabledInfo? DisabledInfo = null,
        HashInfo? HashInfo = null,
        ProviderInfo? ProviderInfo = null,
        YaraInfo? YaraInfo = null
    ) 
    {
        if ( IocStatus != null ) {
            this.IocStatus = IocStatus;
        }
        if ( IocType != null ) {
            this.IocType = IocType;
        }
        if ( Author != null ) {
            this.Author = Author;
        }
        if ( IntelId != null ) {
            this.IntelId = IntelId;
        }
        if ( LastUpdatedTime != null ) {
            this.LastUpdatedTime = LastUpdatedTime;
        }
        if ( ProviderIocId != null ) {
            this.ProviderIocId = ProviderIocId;
        }
        if ( ProviderMalwareId != null ) {
            this.ProviderMalwareId = ProviderMalwareId;
        }
        if ( ThreatFamily != null ) {
            this.ThreatFamily = ThreatFamily;
        }
        if ( DisabledInfo != null ) {
            this.DisabledInfo = DisabledInfo;
        }
        if ( HashInfo != null ) {
            this.HashInfo = HashInfo;
        }
        if ( ProviderInfo != null ) {
            this.ProviderInfo = ProviderInfo;
        }
        if ( YaraInfo != null ) {
            this.YaraInfo = YaraInfo;
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
        //      C# -> FeedEntryStatus? IocStatus
        // GraphQL -> iocStatus: FeedEntryStatus! (enum)
        if (this.IocStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "iocStatus\n" ;
            } else {
                s += ind + "iocStatus\n" ;
            }
        }
        //      C# -> ThreatFeedType? IocType
        // GraphQL -> iocType: ThreatFeedType! (enum)
        if (this.IocType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "iocType\n" ;
            } else {
                s += ind + "iocType\n" ;
            }
        }
        //      C# -> System.String? Author
        // GraphQL -> author: String! (scalar)
        if (this.Author != null) {
            if (conf.Flat) {
                s += conf.Prefix + "author\n" ;
            } else {
                s += ind + "author\n" ;
            }
        }
        //      C# -> System.String? IntelId
        // GraphQL -> intelId: String! (scalar)
        if (this.IntelId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "intelId\n" ;
            } else {
                s += ind + "intelId\n" ;
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
        //      C# -> System.String? ProviderIocId
        // GraphQL -> providerIocId: String! (scalar)
        if (this.ProviderIocId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "providerIocId\n" ;
            } else {
                s += ind + "providerIocId\n" ;
            }
        }
        //      C# -> System.String? ProviderMalwareId
        // GraphQL -> providerMalwareId: String! (scalar)
        if (this.ProviderMalwareId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "providerMalwareId\n" ;
            } else {
                s += ind + "providerMalwareId\n" ;
            }
        }
        //      C# -> System.String? ThreatFamily
        // GraphQL -> threatFamily: String! (scalar)
        if (this.ThreatFamily != null) {
            if (conf.Flat) {
                s += conf.Prefix + "threatFamily\n" ;
            } else {
                s += ind + "threatFamily\n" ;
            }
        }
        //      C# -> DisabledInfo? DisabledInfo
        // GraphQL -> disabledInfo: DisabledInfo (type)
        if (this.DisabledInfo != null) {
            var fspec = this.DisabledInfo.AsFieldSpec(conf.Child("disabledInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "disabledInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> HashInfo? HashInfo
        // GraphQL -> hashInfo: HashInfo (type)
        if (this.HashInfo != null) {
            var fspec = this.HashInfo.AsFieldSpec(conf.Child("hashInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hashInfo" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> YaraInfo? YaraInfo
        // GraphQL -> yaraInfo: YaraInfo (type)
        if (this.YaraInfo != null) {
            var fspec = this.YaraInfo.AsFieldSpec(conf.Child("yaraInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "yaraInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> FeedEntryStatus? IocStatus
        // GraphQL -> iocStatus: FeedEntryStatus! (enum)
        if (ec.Includes("iocStatus",true))
        {
            if(this.IocStatus == null) {

                this.IocStatus = new FeedEntryStatus();

            } else {


            }
        }
        else if (this.IocStatus != null && ec.Excludes("iocStatus",true))
        {
            this.IocStatus = null;
        }
        //      C# -> ThreatFeedType? IocType
        // GraphQL -> iocType: ThreatFeedType! (enum)
        if (ec.Includes("iocType",true))
        {
            if(this.IocType == null) {

                this.IocType = new ThreatFeedType();

            } else {


            }
        }
        else if (this.IocType != null && ec.Excludes("iocType",true))
        {
            this.IocType = null;
        }
        //      C# -> System.String? Author
        // GraphQL -> author: String! (scalar)
        if (ec.Includes("author",true))
        {
            if(this.Author == null) {

                this.Author = "FETCH";

            } else {


            }
        }
        else if (this.Author != null && ec.Excludes("author",true))
        {
            this.Author = null;
        }
        //      C# -> System.String? IntelId
        // GraphQL -> intelId: String! (scalar)
        if (ec.Includes("intelId",true))
        {
            if(this.IntelId == null) {

                this.IntelId = "FETCH";

            } else {


            }
        }
        else if (this.IntelId != null && ec.Excludes("intelId",true))
        {
            this.IntelId = null;
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
        //      C# -> System.String? ProviderIocId
        // GraphQL -> providerIocId: String! (scalar)
        if (ec.Includes("providerIocId",true))
        {
            if(this.ProviderIocId == null) {

                this.ProviderIocId = "FETCH";

            } else {


            }
        }
        else if (this.ProviderIocId != null && ec.Excludes("providerIocId",true))
        {
            this.ProviderIocId = null;
        }
        //      C# -> System.String? ProviderMalwareId
        // GraphQL -> providerMalwareId: String! (scalar)
        if (ec.Includes("providerMalwareId",true))
        {
            if(this.ProviderMalwareId == null) {

                this.ProviderMalwareId = "FETCH";

            } else {


            }
        }
        else if (this.ProviderMalwareId != null && ec.Excludes("providerMalwareId",true))
        {
            this.ProviderMalwareId = null;
        }
        //      C# -> System.String? ThreatFamily
        // GraphQL -> threatFamily: String! (scalar)
        if (ec.Includes("threatFamily",true))
        {
            if(this.ThreatFamily == null) {

                this.ThreatFamily = "FETCH";

            } else {


            }
        }
        else if (this.ThreatFamily != null && ec.Excludes("threatFamily",true))
        {
            this.ThreatFamily = null;
        }
        //      C# -> DisabledInfo? DisabledInfo
        // GraphQL -> disabledInfo: DisabledInfo (type)
        if (ec.Includes("disabledInfo",false))
        {
            if(this.DisabledInfo == null) {

                this.DisabledInfo = new DisabledInfo();
                this.DisabledInfo.ApplyExploratoryFieldSpec(ec.NewChild("disabledInfo"));

            } else {

                this.DisabledInfo.ApplyExploratoryFieldSpec(ec.NewChild("disabledInfo"));

            }
        }
        else if (this.DisabledInfo != null && ec.Excludes("disabledInfo",false))
        {
            this.DisabledInfo = null;
        }
        //      C# -> HashInfo? HashInfo
        // GraphQL -> hashInfo: HashInfo (type)
        if (ec.Includes("hashInfo",false))
        {
            if(this.HashInfo == null) {

                this.HashInfo = new HashInfo();
                this.HashInfo.ApplyExploratoryFieldSpec(ec.NewChild("hashInfo"));

            } else {

                this.HashInfo.ApplyExploratoryFieldSpec(ec.NewChild("hashInfo"));

            }
        }
        else if (this.HashInfo != null && ec.Excludes("hashInfo",false))
        {
            this.HashInfo = null;
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
        //      C# -> YaraInfo? YaraInfo
        // GraphQL -> yaraInfo: YaraInfo (type)
        if (ec.Includes("yaraInfo",false))
        {
            if(this.YaraInfo == null) {

                this.YaraInfo = new YaraInfo();
                this.YaraInfo.ApplyExploratoryFieldSpec(ec.NewChild("yaraInfo"));

            } else {

                this.YaraInfo.ApplyExploratoryFieldSpec(ec.NewChild("yaraInfo"));

            }
        }
        else if (this.YaraInfo != null && ec.Excludes("yaraInfo",false))
        {
            this.YaraInfo = null;
        }
    }


    #endregion

    } // class IocFeedEntry
    
    #endregion

    public static class ListIocFeedEntryExtensions
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
            this List<IocFeedEntry> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IocFeedEntry> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IocFeedEntry> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IocFeedEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IocFeedEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types