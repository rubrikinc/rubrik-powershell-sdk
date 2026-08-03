// ViolationHistoryEntry.cs
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
    #region ViolationHistoryEntry
    public class ViolationHistoryEntry: BaseType
    {
        #region members

        //      C# -> ViolationHistoryEventType? EventType
        // GraphQL -> eventType: ViolationHistoryEventType! (enum)
        [JsonProperty("eventType")]
        public ViolationHistoryEventType? EventType { get; set; }

        //      C# -> System.String? ActorName
        // GraphQL -> actorName: String! (scalar)
        [JsonProperty("actorName")]
        public System.String? ActorName { get; set; }

        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }

        //      C# -> ViolationHistoryDetailsUnion? Details
        // GraphQL -> details: ViolationHistoryDetailsUnion (union)
        [JsonProperty("details")]
        public ViolationHistoryDetailsUnion? Details { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ViolationHistoryEntry";
    }

    public ViolationHistoryEntry Set(
        ViolationHistoryEventType? EventType = null,
        System.String? ActorName = null,
        DateTime? Timestamp = null,
        ViolationHistoryDetailsUnion? Details = null
    ) 
    {
        if ( EventType != null ) {
            this.EventType = EventType;
        }
        if ( ActorName != null ) {
            this.ActorName = ActorName;
        }
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
        }
        if ( Details != null ) {
            this.Details = Details;
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
        //      C# -> ViolationHistoryEventType? EventType
        // GraphQL -> eventType: ViolationHistoryEventType! (enum)
        if (this.EventType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventType\n" ;
            } else {
                s += ind + "eventType\n" ;
            }
        }
        //      C# -> System.String? ActorName
        // GraphQL -> actorName: String! (scalar)
        if (this.ActorName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorName\n" ;
            } else {
                s += ind + "actorName\n" ;
            }
        }
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (this.Timestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timestamp\n" ;
            } else {
                s += ind + "timestamp\n" ;
            }
        }
        //      C# -> ViolationHistoryDetailsUnion? Details
        // GraphQL -> details: ViolationHistoryDetailsUnion (union)
        if (this.Details != null) {
            var fspec = this.Details.AsFieldSpec(conf.Child("details"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "details" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ViolationHistoryEventType? EventType
        // GraphQL -> eventType: ViolationHistoryEventType! (enum)
        if (ec.Includes("eventType",true))
        {
            if(this.EventType == null) {

                this.EventType = new ViolationHistoryEventType();

            } else {


            }
        }
        else if (this.EventType != null && ec.Excludes("eventType",true))
        {
            this.EventType = null;
        }
        //      C# -> System.String? ActorName
        // GraphQL -> actorName: String! (scalar)
        if (ec.Includes("actorName",true))
        {
            if(this.ActorName == null) {

                this.ActorName = "FETCH";

            } else {


            }
        }
        else if (this.ActorName != null && ec.Excludes("actorName",true))
        {
            this.ActorName = null;
        }
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (ec.Includes("timestamp",true))
        {
            if(this.Timestamp == null) {

                this.Timestamp = new DateTime();

            } else {


            }
        }
        else if (this.Timestamp != null && ec.Excludes("timestamp",true))
        {
            this.Timestamp = null;
        }
        //      C# -> ViolationHistoryDetailsUnion? Details
        // GraphQL -> details: ViolationHistoryDetailsUnion (union)
        if (ec.Includes("details",false))
        {
            if(this.Details == null) {

                var impls = new List<ViolationHistoryDetailsUnion>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("details"));
                this.Details = (ViolationHistoryDetailsUnion)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<ViolationHistoryDetailsUnion>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("details"));
                this.Details = (ViolationHistoryDetailsUnion)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.Details != null && ec.Excludes("details",false))
        {
            this.Details = null;
        }
    }


    #endregion

    } // class ViolationHistoryEntry
    
    #endregion

    public static class ListViolationHistoryEntryExtensions
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
            this List<ViolationHistoryEntry> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ViolationHistoryEntry> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ViolationHistoryEntry> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ViolationHistoryEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ViolationHistoryEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types