// EventDigest.cs
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
    #region EventDigest
    public class EventDigest: BaseType
    {
        #region members

        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        [JsonProperty("account")]
        public System.String? Account { get; set; }

        //      C# -> List<System.String>? ClusterUuids
        // GraphQL -> clusterUuids: [UUID!]! (scalar)
        [JsonProperty("clusterUuids")]
        public List<System.String>? ClusterUuids { get; set; }

        //      C# -> System.String? CreatorEmailAddress
        // GraphQL -> creatorEmailAddress: String! (scalar)
        [JsonProperty("creatorEmailAddress")]
        public System.String? CreatorEmailAddress { get; set; }

        //      C# -> System.Int32? DigestId
        // GraphQL -> digestId: Int! (scalar)
        [JsonProperty("digestId")]
        public System.Int32? DigestId { get; set; }

        //      C# -> System.String? DigestName
        // GraphQL -> digestName: String! (scalar)
        [JsonProperty("digestName")]
        public System.String? DigestName { get; set; }

        //      C# -> System.String? EventDigestConfigJson
        // GraphQL -> eventDigestConfigJson: String! (scalar)
        [JsonProperty("eventDigestConfigJson")]
        public System.String? EventDigestConfigJson { get; set; }

        //      C# -> System.Int32? Frequency
        // GraphQL -> frequency: Int! (scalar)
        [JsonProperty("frequency")]
        public System.Int32? Frequency { get; set; }

        //      C# -> System.Boolean? IncludeAudits
        // GraphQL -> includeAudits: Boolean! (scalar)
        [JsonProperty("includeAudits")]
        public System.Boolean? IncludeAudits { get; set; }

        //      C# -> System.Boolean? IncludeEvents
        // GraphQL -> includeEvents: Boolean! (scalar)
        [JsonProperty("includeEvents")]
        public System.Boolean? IncludeEvents { get; set; }

        //      C# -> System.Boolean? IsImmediate
        // GraphQL -> isImmediate: Boolean! (scalar)
        [JsonProperty("isImmediate")]
        public System.Boolean? IsImmediate { get; set; }

        //      C# -> System.String? RecipientUserId
        // GraphQL -> recipientUserId: String! (scalar)
        [JsonProperty("recipientUserId")]
        public System.String? RecipientUserId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EventDigest";
    }

    public EventDigest Set(
        System.String? Account = null,
        List<System.String>? ClusterUuids = null,
        System.String? CreatorEmailAddress = null,
        System.Int32? DigestId = null,
        System.String? DigestName = null,
        System.String? EventDigestConfigJson = null,
        System.Int32? Frequency = null,
        System.Boolean? IncludeAudits = null,
        System.Boolean? IncludeEvents = null,
        System.Boolean? IsImmediate = null,
        System.String? RecipientUserId = null
    ) 
    {
        if ( Account != null ) {
            this.Account = Account;
        }
        if ( ClusterUuids != null ) {
            this.ClusterUuids = ClusterUuids;
        }
        if ( CreatorEmailAddress != null ) {
            this.CreatorEmailAddress = CreatorEmailAddress;
        }
        if ( DigestId != null ) {
            this.DigestId = DigestId;
        }
        if ( DigestName != null ) {
            this.DigestName = DigestName;
        }
        if ( EventDigestConfigJson != null ) {
            this.EventDigestConfigJson = EventDigestConfigJson;
        }
        if ( Frequency != null ) {
            this.Frequency = Frequency;
        }
        if ( IncludeAudits != null ) {
            this.IncludeAudits = IncludeAudits;
        }
        if ( IncludeEvents != null ) {
            this.IncludeEvents = IncludeEvents;
        }
        if ( IsImmediate != null ) {
            this.IsImmediate = IsImmediate;
        }
        if ( RecipientUserId != null ) {
            this.RecipientUserId = RecipientUserId;
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
        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        if (this.Account != null) {
            if (conf.Flat) {
                s += conf.Prefix + "account\n" ;
            } else {
                s += ind + "account\n" ;
            }
        }
        //      C# -> List<System.String>? ClusterUuids
        // GraphQL -> clusterUuids: [UUID!]! (scalar)
        if (this.ClusterUuids != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuids\n" ;
            } else {
                s += ind + "clusterUuids\n" ;
            }
        }
        //      C# -> System.String? CreatorEmailAddress
        // GraphQL -> creatorEmailAddress: String! (scalar)
        if (this.CreatorEmailAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "creatorEmailAddress\n" ;
            } else {
                s += ind + "creatorEmailAddress\n" ;
            }
        }
        //      C# -> System.Int32? DigestId
        // GraphQL -> digestId: Int! (scalar)
        if (this.DigestId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "digestId\n" ;
            } else {
                s += ind + "digestId\n" ;
            }
        }
        //      C# -> System.String? DigestName
        // GraphQL -> digestName: String! (scalar)
        if (this.DigestName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "digestName\n" ;
            } else {
                s += ind + "digestName\n" ;
            }
        }
        //      C# -> System.String? EventDigestConfigJson
        // GraphQL -> eventDigestConfigJson: String! (scalar)
        if (this.EventDigestConfigJson != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventDigestConfigJson\n" ;
            } else {
                s += ind + "eventDigestConfigJson\n" ;
            }
        }
        //      C# -> System.Int32? Frequency
        // GraphQL -> frequency: Int! (scalar)
        if (this.Frequency != null) {
            if (conf.Flat) {
                s += conf.Prefix + "frequency\n" ;
            } else {
                s += ind + "frequency\n" ;
            }
        }
        //      C# -> System.Boolean? IncludeAudits
        // GraphQL -> includeAudits: Boolean! (scalar)
        if (this.IncludeAudits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "includeAudits\n" ;
            } else {
                s += ind + "includeAudits\n" ;
            }
        }
        //      C# -> System.Boolean? IncludeEvents
        // GraphQL -> includeEvents: Boolean! (scalar)
        if (this.IncludeEvents != null) {
            if (conf.Flat) {
                s += conf.Prefix + "includeEvents\n" ;
            } else {
                s += ind + "includeEvents\n" ;
            }
        }
        //      C# -> System.Boolean? IsImmediate
        // GraphQL -> isImmediate: Boolean! (scalar)
        if (this.IsImmediate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isImmediate\n" ;
            } else {
                s += ind + "isImmediate\n" ;
            }
        }
        //      C# -> System.String? RecipientUserId
        // GraphQL -> recipientUserId: String! (scalar)
        if (this.RecipientUserId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recipientUserId\n" ;
            } else {
                s += ind + "recipientUserId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        if (ec.Includes("account",true))
        {
            if(this.Account == null) {

                this.Account = "FETCH";

            } else {


            }
        }
        else if (this.Account != null && ec.Excludes("account",true))
        {
            this.Account = null;
        }
        //      C# -> List<System.String>? ClusterUuids
        // GraphQL -> clusterUuids: [UUID!]! (scalar)
        if (ec.Includes("clusterUuids",true))
        {
            if(this.ClusterUuids == null) {

                this.ClusterUuids = new List<System.String>();

            } else {


            }
        }
        else if (this.ClusterUuids != null && ec.Excludes("clusterUuids",true))
        {
            this.ClusterUuids = null;
        }
        //      C# -> System.String? CreatorEmailAddress
        // GraphQL -> creatorEmailAddress: String! (scalar)
        if (ec.Includes("creatorEmailAddress",true))
        {
            if(this.CreatorEmailAddress == null) {

                this.CreatorEmailAddress = "FETCH";

            } else {


            }
        }
        else if (this.CreatorEmailAddress != null && ec.Excludes("creatorEmailAddress",true))
        {
            this.CreatorEmailAddress = null;
        }
        //      C# -> System.Int32? DigestId
        // GraphQL -> digestId: Int! (scalar)
        if (ec.Includes("digestId",true))
        {
            if(this.DigestId == null) {

                this.DigestId = Int32.MinValue;

            } else {


            }
        }
        else if (this.DigestId != null && ec.Excludes("digestId",true))
        {
            this.DigestId = null;
        }
        //      C# -> System.String? DigestName
        // GraphQL -> digestName: String! (scalar)
        if (ec.Includes("digestName",true))
        {
            if(this.DigestName == null) {

                this.DigestName = "FETCH";

            } else {


            }
        }
        else if (this.DigestName != null && ec.Excludes("digestName",true))
        {
            this.DigestName = null;
        }
        //      C# -> System.String? EventDigestConfigJson
        // GraphQL -> eventDigestConfigJson: String! (scalar)
        if (ec.Includes("eventDigestConfigJson",true))
        {
            if(this.EventDigestConfigJson == null) {

                this.EventDigestConfigJson = "FETCH";

            } else {


            }
        }
        else if (this.EventDigestConfigJson != null && ec.Excludes("eventDigestConfigJson",true))
        {
            this.EventDigestConfigJson = null;
        }
        //      C# -> System.Int32? Frequency
        // GraphQL -> frequency: Int! (scalar)
        if (ec.Includes("frequency",true))
        {
            if(this.Frequency == null) {

                this.Frequency = Int32.MinValue;

            } else {


            }
        }
        else if (this.Frequency != null && ec.Excludes("frequency",true))
        {
            this.Frequency = null;
        }
        //      C# -> System.Boolean? IncludeAudits
        // GraphQL -> includeAudits: Boolean! (scalar)
        if (ec.Includes("includeAudits",true))
        {
            if(this.IncludeAudits == null) {

                this.IncludeAudits = true;

            } else {


            }
        }
        else if (this.IncludeAudits != null && ec.Excludes("includeAudits",true))
        {
            this.IncludeAudits = null;
        }
        //      C# -> System.Boolean? IncludeEvents
        // GraphQL -> includeEvents: Boolean! (scalar)
        if (ec.Includes("includeEvents",true))
        {
            if(this.IncludeEvents == null) {

                this.IncludeEvents = true;

            } else {


            }
        }
        else if (this.IncludeEvents != null && ec.Excludes("includeEvents",true))
        {
            this.IncludeEvents = null;
        }
        //      C# -> System.Boolean? IsImmediate
        // GraphQL -> isImmediate: Boolean! (scalar)
        if (ec.Includes("isImmediate",true))
        {
            if(this.IsImmediate == null) {

                this.IsImmediate = true;

            } else {


            }
        }
        else if (this.IsImmediate != null && ec.Excludes("isImmediate",true))
        {
            this.IsImmediate = null;
        }
        //      C# -> System.String? RecipientUserId
        // GraphQL -> recipientUserId: String! (scalar)
        if (ec.Includes("recipientUserId",true))
        {
            if(this.RecipientUserId == null) {

                this.RecipientUserId = "FETCH";

            } else {


            }
        }
        else if (this.RecipientUserId != null && ec.Excludes("recipientUserId",true))
        {
            this.RecipientUserId = null;
        }
    }


    #endregion

    } // class EventDigest
    
    #endregion

    public static class ListEventDigestExtensions
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
            this List<EventDigest> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EventDigest> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EventDigest> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EventDigest());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EventDigest> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types