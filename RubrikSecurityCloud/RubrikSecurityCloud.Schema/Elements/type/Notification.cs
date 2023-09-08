// Notification.cs
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
    #region Notification
    public class Notification: BaseType
    {
        #region members

        //      C# -> NotificationPriority? Priority
        // GraphQL -> priority: NotificationPriority! (enum)
        [JsonProperty("priority")]
        public NotificationPriority? Priority { get; set; }

        //      C# -> NotificationResourceSubtype? ResourceSubtype
        // GraphQL -> resourceSubtype: NotificationResourceSubtype! (enum)
        [JsonProperty("resourceSubtype")]
        public NotificationResourceSubtype? ResourceSubtype { get; set; }

        //      C# -> NotificationResourceType? ResourceType
        // GraphQL -> resourceType: NotificationResourceType! (enum)
        [JsonProperty("resourceType")]
        public NotificationResourceType? ResourceType { get; set; }

        //      C# -> NotificationType? Type
        // GraphQL -> type: NotificationType! (enum)
        [JsonProperty("type")]
        public NotificationType? Type { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsRead
        // GraphQL -> isRead: Boolean! (scalar)
        [JsonProperty("isRead")]
        public System.Boolean? IsRead { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        [JsonProperty("resourceId")]
        public System.String? ResourceId { get; set; }

        //      C# -> System.String? Variables
        // GraphQL -> variables: String! (scalar)
        [JsonProperty("variables")]
        public System.String? Variables { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Notification";
    }

    public Notification Set(
        NotificationPriority? Priority = null,
        NotificationResourceSubtype? ResourceSubtype = null,
        NotificationResourceType? ResourceType = null,
        NotificationType? Type = null,
        DateTime? CreatedAt = null,
        System.String? Id = null,
        System.Boolean? IsRead = null,
        System.String? Message = null,
        System.String? ResourceId = null,
        System.String? Variables = null
    ) 
    {
        if ( Priority != null ) {
            this.Priority = Priority;
        }
        if ( ResourceSubtype != null ) {
            this.ResourceSubtype = ResourceSubtype;
        }
        if ( ResourceType != null ) {
            this.ResourceType = ResourceType;
        }
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsRead != null ) {
            this.IsRead = IsRead;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( ResourceId != null ) {
            this.ResourceId = ResourceId;
        }
        if ( Variables != null ) {
            this.Variables = Variables;
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
        //      C# -> NotificationPriority? Priority
        // GraphQL -> priority: NotificationPriority! (enum)
        if (this.Priority != null) {
            s += ind + "priority\n" ;
        }
        //      C# -> NotificationResourceSubtype? ResourceSubtype
        // GraphQL -> resourceSubtype: NotificationResourceSubtype! (enum)
        if (this.ResourceSubtype != null) {
            s += ind + "resourceSubtype\n" ;
        }
        //      C# -> NotificationResourceType? ResourceType
        // GraphQL -> resourceType: NotificationResourceType! (enum)
        if (this.ResourceType != null) {
            s += ind + "resourceType\n" ;
        }
        //      C# -> NotificationType? Type
        // GraphQL -> type: NotificationType! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            s += ind + "createdAt\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsRead
        // GraphQL -> isRead: Boolean! (scalar)
        if (this.IsRead != null) {
            s += ind + "isRead\n" ;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            s += ind + "message\n" ;
        }
        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        if (this.ResourceId != null) {
            s += ind + "resourceId\n" ;
        }
        //      C# -> System.String? Variables
        // GraphQL -> variables: String! (scalar)
        if (this.Variables != null) {
            s += ind + "variables\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> NotificationPriority? Priority
        // GraphQL -> priority: NotificationPriority! (enum)
        if (this.Priority == null && ec.Includes("priority",true))
        {
            this.Priority = new NotificationPriority();
        }
        //      C# -> NotificationResourceSubtype? ResourceSubtype
        // GraphQL -> resourceSubtype: NotificationResourceSubtype! (enum)
        if (this.ResourceSubtype == null && ec.Includes("resourceSubtype",true))
        {
            this.ResourceSubtype = new NotificationResourceSubtype();
        }
        //      C# -> NotificationResourceType? ResourceType
        // GraphQL -> resourceType: NotificationResourceType! (enum)
        if (this.ResourceType == null && ec.Includes("resourceType",true))
        {
            this.ResourceType = new NotificationResourceType();
        }
        //      C# -> NotificationType? Type
        // GraphQL -> type: NotificationType! (enum)
        if (this.Type == null && ec.Includes("type",true))
        {
            this.Type = new NotificationType();
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt == null && ec.Includes("createdAt",true))
        {
            this.CreatedAt = new DateTime();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsRead
        // GraphQL -> isRead: Boolean! (scalar)
        if (this.IsRead == null && ec.Includes("isRead",true))
        {
            this.IsRead = true;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && ec.Includes("message",true))
        {
            this.Message = "FETCH";
        }
        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        if (this.ResourceId == null && ec.Includes("resourceId",true))
        {
            this.ResourceId = "FETCH";
        }
        //      C# -> System.String? Variables
        // GraphQL -> variables: String! (scalar)
        if (this.Variables == null && ec.Includes("variables",true))
        {
            this.Variables = "FETCH";
        }
    }


    #endregion

    } // class Notification
    
    #endregion

    public static class ListNotificationExtensions
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
            this List<Notification> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Notification> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Notification());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<Notification> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types