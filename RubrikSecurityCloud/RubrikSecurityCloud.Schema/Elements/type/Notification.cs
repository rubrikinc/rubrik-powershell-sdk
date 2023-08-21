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

        //      C# -> System.String? ResourceSubtype
        // GraphQL -> resourceSubtype: String! (scalar)
        [JsonProperty("resourceSubtype")]
        public System.String? ResourceSubtype { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Notification";
    }

    public Notification Set(
        NotificationPriority? Priority = null,
        NotificationResourceType? ResourceType = null,
        NotificationType? Type = null,
        DateTime? CreatedAt = null,
        System.String? Id = null,
        System.Boolean? IsRead = null,
        System.String? Message = null,
        System.String? ResourceId = null,
        System.String? ResourceSubtype = null
    ) 
    {
        if ( Priority != null ) {
            this.Priority = Priority;
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
        if ( ResourceSubtype != null ) {
            this.ResourceSubtype = ResourceSubtype;
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
        //      C# -> System.String? ResourceSubtype
        // GraphQL -> resourceSubtype: String! (scalar)
        if (this.ResourceSubtype != null) {
            s += ind + "resourceSubtype\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> NotificationPriority? Priority
        // GraphQL -> priority: NotificationPriority! (enum)
        if (this.Priority == null && Exploration.Includes(parent + ".priority", true))
        {
            this.Priority = new NotificationPriority();
        }
        //      C# -> NotificationResourceType? ResourceType
        // GraphQL -> resourceType: NotificationResourceType! (enum)
        if (this.ResourceType == null && Exploration.Includes(parent + ".resourceType", true))
        {
            this.ResourceType = new NotificationResourceType();
        }
        //      C# -> NotificationType? Type
        // GraphQL -> type: NotificationType! (enum)
        if (this.Type == null && Exploration.Includes(parent + ".type", true))
        {
            this.Type = new NotificationType();
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt == null && Exploration.Includes(parent + ".createdAt", true))
        {
            this.CreatedAt = new DateTime();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsRead
        // GraphQL -> isRead: Boolean! (scalar)
        if (this.IsRead == null && Exploration.Includes(parent + ".isRead", true))
        {
            this.IsRead = true;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && Exploration.Includes(parent + ".message", true))
        {
            this.Message = "FETCH";
        }
        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        if (this.ResourceId == null && Exploration.Includes(parent + ".resourceId", true))
        {
            this.ResourceId = "FETCH";
        }
        //      C# -> System.String? ResourceSubtype
        // GraphQL -> resourceSubtype: String! (scalar)
        if (this.ResourceSubtype == null && Exploration.Includes(parent + ".resourceSubtype", true))
        {
            this.ResourceSubtype = "FETCH";
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
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Notification());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types