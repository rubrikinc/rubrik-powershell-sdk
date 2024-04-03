// O365CalendarEvent.cs
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
    #region O365CalendarEvent
 
    public class O365CalendarEvent: BaseType, O365ExchangeObject
    {
        #region members

        //      C# -> CalendarEventType? EventType
        // GraphQL -> eventType: CalendarEventType! (enum)
        [JsonProperty("eventType")]
        public CalendarEventType? EventType { get; set; }

        //      C# -> List<System.String>? Attendees
        // GraphQL -> attendees: [String!]! (scalar)
        [JsonProperty("attendees")]
        public List<System.String>? Attendees { get; set; }

        //      C# -> DateTime? EndDateTime
        // GraphQL -> endDateTime: DateTime (scalar)
        [JsonProperty("endDateTime")]
        public DateTime? EndDateTime { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Organizer
        // GraphQL -> organizer: String (scalar)
        [JsonProperty("organizer")]
        public System.String? Organizer { get; set; }

        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        [JsonProperty("parentFolderId")]
        public System.String? ParentFolderId { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        [JsonProperty("snapshotTime")]
        public DateTime? SnapshotTime { get; set; }

        //      C# -> DateTime? StartDateTime
        // GraphQL -> startDateTime: DateTime (scalar)
        [JsonProperty("startDateTime")]
        public DateTime? StartDateTime { get; set; }

        //      C# -> System.String? VersionStartSnapshotId
        // GraphQL -> versionStartSnapshotId: UUID (scalar)
        [JsonProperty("versionStartSnapshotId")]
        public System.String? VersionStartSnapshotId { get; set; }

        //      C# -> O365CalendarEventRecurrence? Recurrence
        // GraphQL -> recurrence: O365CalendarEventRecurrence (type)
        [JsonProperty("recurrence")]
        public O365CalendarEventRecurrence? Recurrence { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365CalendarEvent";
    }

    public O365CalendarEvent Set(
        CalendarEventType? EventType = null,
        List<System.String>? Attendees = null,
        DateTime? EndDateTime = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? Organizer = null,
        System.String? ParentFolderId = null,
        System.String? SnapshotId = null,
        DateTime? SnapshotTime = null,
        DateTime? StartDateTime = null,
        System.String? VersionStartSnapshotId = null,
        O365CalendarEventRecurrence? Recurrence = null
    ) 
    {
        if ( EventType != null ) {
            this.EventType = EventType;
        }
        if ( Attendees != null ) {
            this.Attendees = Attendees;
        }
        if ( EndDateTime != null ) {
            this.EndDateTime = EndDateTime;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Organizer != null ) {
            this.Organizer = Organizer;
        }
        if ( ParentFolderId != null ) {
            this.ParentFolderId = ParentFolderId;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( SnapshotTime != null ) {
            this.SnapshotTime = SnapshotTime;
        }
        if ( StartDateTime != null ) {
            this.StartDateTime = StartDateTime;
        }
        if ( VersionStartSnapshotId != null ) {
            this.VersionStartSnapshotId = VersionStartSnapshotId;
        }
        if ( Recurrence != null ) {
            this.Recurrence = Recurrence;
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
        //      C# -> CalendarEventType? EventType
        // GraphQL -> eventType: CalendarEventType! (enum)
        if (this.EventType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventType\n" ;
            } else {
                s += ind + "eventType\n" ;
            }
        }
        //      C# -> List<System.String>? Attendees
        // GraphQL -> attendees: [String!]! (scalar)
        if (this.Attendees != null) {
            if (conf.Flat) {
                s += conf.Prefix + "attendees\n" ;
            } else {
                s += ind + "attendees\n" ;
            }
        }
        //      C# -> DateTime? EndDateTime
        // GraphQL -> endDateTime: DateTime (scalar)
        if (this.EndDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endDateTime\n" ;
            } else {
                s += ind + "endDateTime\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? Organizer
        // GraphQL -> organizer: String (scalar)
        if (this.Organizer != null) {
            if (conf.Flat) {
                s += conf.Prefix + "organizer\n" ;
            } else {
                s += ind + "organizer\n" ;
            }
        }
        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        if (this.ParentFolderId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "parentFolderId\n" ;
            } else {
                s += ind + "parentFolderId\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (this.SnapshotTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotTime\n" ;
            } else {
                s += ind + "snapshotTime\n" ;
            }
        }
        //      C# -> DateTime? StartDateTime
        // GraphQL -> startDateTime: DateTime (scalar)
        if (this.StartDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startDateTime\n" ;
            } else {
                s += ind + "startDateTime\n" ;
            }
        }
        //      C# -> System.String? VersionStartSnapshotId
        // GraphQL -> versionStartSnapshotId: UUID (scalar)
        if (this.VersionStartSnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "versionStartSnapshotId\n" ;
            } else {
                s += ind + "versionStartSnapshotId\n" ;
            }
        }
        //      C# -> O365CalendarEventRecurrence? Recurrence
        // GraphQL -> recurrence: O365CalendarEventRecurrence (type)
        if (this.Recurrence != null) {
            var fspec = this.Recurrence.AsFieldSpec(conf.Child("recurrence"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recurrence" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CalendarEventType? EventType
        // GraphQL -> eventType: CalendarEventType! (enum)
        if (ec.Includes("eventType",true))
        {
            if(this.EventType == null) {

                this.EventType = new CalendarEventType();

            } else {


            }
        }
        else if (this.EventType != null && ec.Excludes("eventType",true))
        {
            this.EventType = null;
        }
        //      C# -> List<System.String>? Attendees
        // GraphQL -> attendees: [String!]! (scalar)
        if (ec.Includes("attendees",true))
        {
            if(this.Attendees == null) {

                this.Attendees = new List<System.String>();

            } else {


            }
        }
        else if (this.Attendees != null && ec.Excludes("attendees",true))
        {
            this.Attendees = null;
        }
        //      C# -> DateTime? EndDateTime
        // GraphQL -> endDateTime: DateTime (scalar)
        if (ec.Includes("endDateTime",true))
        {
            if(this.EndDateTime == null) {

                this.EndDateTime = new DateTime();

            } else {


            }
        }
        else if (this.EndDateTime != null && ec.Excludes("endDateTime",true))
        {
            this.EndDateTime = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
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
        // GraphQL -> name: String (scalar)
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
        //      C# -> System.String? Organizer
        // GraphQL -> organizer: String (scalar)
        if (ec.Includes("organizer",true))
        {
            if(this.Organizer == null) {

                this.Organizer = "FETCH";

            } else {


            }
        }
        else if (this.Organizer != null && ec.Excludes("organizer",true))
        {
            this.Organizer = null;
        }
        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        if (ec.Includes("parentFolderId",true))
        {
            if(this.ParentFolderId == null) {

                this.ParentFolderId = "FETCH";

            } else {


            }
        }
        else if (this.ParentFolderId != null && ec.Excludes("parentFolderId",true))
        {
            this.ParentFolderId = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (ec.Includes("snapshotTime",true))
        {
            if(this.SnapshotTime == null) {

                this.SnapshotTime = new DateTime();

            } else {


            }
        }
        else if (this.SnapshotTime != null && ec.Excludes("snapshotTime",true))
        {
            this.SnapshotTime = null;
        }
        //      C# -> DateTime? StartDateTime
        // GraphQL -> startDateTime: DateTime (scalar)
        if (ec.Includes("startDateTime",true))
        {
            if(this.StartDateTime == null) {

                this.StartDateTime = new DateTime();

            } else {


            }
        }
        else if (this.StartDateTime != null && ec.Excludes("startDateTime",true))
        {
            this.StartDateTime = null;
        }
        //      C# -> System.String? VersionStartSnapshotId
        // GraphQL -> versionStartSnapshotId: UUID (scalar)
        if (ec.Includes("versionStartSnapshotId",true))
        {
            if(this.VersionStartSnapshotId == null) {

                this.VersionStartSnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.VersionStartSnapshotId != null && ec.Excludes("versionStartSnapshotId",true))
        {
            this.VersionStartSnapshotId = null;
        }
        //      C# -> O365CalendarEventRecurrence? Recurrence
        // GraphQL -> recurrence: O365CalendarEventRecurrence (type)
        if (ec.Includes("recurrence",false))
        {
            if(this.Recurrence == null) {

                this.Recurrence = new O365CalendarEventRecurrence();
                this.Recurrence.ApplyExploratoryFieldSpec(ec.NewChild("recurrence"));

            } else {

                this.Recurrence.ApplyExploratoryFieldSpec(ec.NewChild("recurrence"));

            }
        }
        else if (this.Recurrence != null && ec.Excludes("recurrence",false))
        {
            this.Recurrence = null;
        }
    }


    #endregion

    } // class O365CalendarEvent
    
    #endregion

    public static class ListO365CalendarEventExtensions
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
            this List<O365CalendarEvent> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365CalendarEvent> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365CalendarEvent> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365CalendarEvent());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365CalendarEvent> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types