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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> CalendarEventType? EventType
        // GraphQL -> eventType: CalendarEventType! (enum)
        if (this.EventType != null) {
            s += ind + "eventType\n" ;
        }
        //      C# -> List<System.String>? Attendees
        // GraphQL -> attendees: [String!]! (scalar)
        if (this.Attendees != null) {
            s += ind + "attendees\n" ;
        }
        //      C# -> DateTime? EndDateTime
        // GraphQL -> endDateTime: DateTime (scalar)
        if (this.EndDateTime != null) {
            s += ind + "endDateTime\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? Organizer
        // GraphQL -> organizer: String (scalar)
        if (this.Organizer != null) {
            s += ind + "organizer\n" ;
        }
        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        if (this.ParentFolderId != null) {
            s += ind + "parentFolderId\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (this.SnapshotTime != null) {
            s += ind + "snapshotTime\n" ;
        }
        //      C# -> DateTime? StartDateTime
        // GraphQL -> startDateTime: DateTime (scalar)
        if (this.StartDateTime != null) {
            s += ind + "startDateTime\n" ;
        }
        //      C# -> System.String? VersionStartSnapshotId
        // GraphQL -> versionStartSnapshotId: UUID (scalar)
        if (this.VersionStartSnapshotId != null) {
            s += ind + "versionStartSnapshotId\n" ;
        }
        //      C# -> O365CalendarEventRecurrence? Recurrence
        // GraphQL -> recurrence: O365CalendarEventRecurrence (type)
        if (this.Recurrence != null) {
            var fspec = this.Recurrence.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "recurrence {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CalendarEventType? EventType
        // GraphQL -> eventType: CalendarEventType! (enum)
        if (this.EventType == null && ec.Includes("eventType",true))
        {
            this.EventType = new CalendarEventType();
        }
        //      C# -> List<System.String>? Attendees
        // GraphQL -> attendees: [String!]! (scalar)
        if (this.Attendees == null && ec.Includes("attendees",true))
        {
            this.Attendees = new List<System.String>();
        }
        //      C# -> DateTime? EndDateTime
        // GraphQL -> endDateTime: DateTime (scalar)
        if (this.EndDateTime == null && ec.Includes("endDateTime",true))
        {
            this.EndDateTime = new DateTime();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? Organizer
        // GraphQL -> organizer: String (scalar)
        if (this.Organizer == null && ec.Includes("organizer",true))
        {
            this.Organizer = "FETCH";
        }
        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        if (this.ParentFolderId == null && ec.Includes("parentFolderId",true))
        {
            this.ParentFolderId = "FETCH";
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        if (this.SnapshotId == null && ec.Includes("snapshotId",true))
        {
            this.SnapshotId = "FETCH";
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (this.SnapshotTime == null && ec.Includes("snapshotTime",true))
        {
            this.SnapshotTime = new DateTime();
        }
        //      C# -> DateTime? StartDateTime
        // GraphQL -> startDateTime: DateTime (scalar)
        if (this.StartDateTime == null && ec.Includes("startDateTime",true))
        {
            this.StartDateTime = new DateTime();
        }
        //      C# -> System.String? VersionStartSnapshotId
        // GraphQL -> versionStartSnapshotId: UUID (scalar)
        if (this.VersionStartSnapshotId == null && ec.Includes("versionStartSnapshotId",true))
        {
            this.VersionStartSnapshotId = "FETCH";
        }
        //      C# -> O365CalendarEventRecurrence? Recurrence
        // GraphQL -> recurrence: O365CalendarEventRecurrence (type)
        if (this.Recurrence == null && ec.Includes("recurrence",false))
        {
            this.Recurrence = new O365CalendarEventRecurrence();
            this.Recurrence.ApplyExploratoryFieldSpec(ec.NewChild("recurrence"));
        }
    }


    #endregion

    } // class O365CalendarEvent
    
    #endregion

    public static class ListO365CalendarEventExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<O365CalendarEvent> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<O365CalendarEvent> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types