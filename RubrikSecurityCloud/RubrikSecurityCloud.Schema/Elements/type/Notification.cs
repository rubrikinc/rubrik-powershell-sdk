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

        //      C# -> NotificationApplication? Application
        // GraphQL -> application: NotificationApplication! (enum)
        [JsonProperty("application")]
        public NotificationApplication? Application { get; set; }

        //      C# -> NotificationLevel? Level
        // GraphQL -> level: NotificationLevel! (enum)
        [JsonProperty("level")]
        public NotificationLevel? Level { get; set; }

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

        //      C# -> NotificationSubtype? Subtype
        // GraphQL -> subtype: NotificationSubtype! (enum)
        [JsonProperty("subtype")]
        public NotificationSubtype? Subtype { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.String? DefaultAction
        // GraphQL -> defaultAction: String! (scalar)
        [JsonProperty("defaultAction")]
        public System.String? DefaultAction { get; set; }

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

        //      C# -> System.String? Metadata
        // GraphQL -> metadata: String! (scalar)
        [JsonProperty("metadata")]
        public System.String? Metadata { get; set; }

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
        NotificationApplication? Application = null,
        NotificationLevel? Level = null,
        NotificationPriority? Priority = null,
        NotificationResourceSubtype? ResourceSubtype = null,
        NotificationResourceType? ResourceType = null,
        NotificationSubtype? Subtype = null,
        DateTime? CreatedAt = null,
        System.String? DefaultAction = null,
        System.String? Id = null,
        System.Boolean? IsRead = null,
        System.String? Message = null,
        System.String? Metadata = null,
        System.String? ResourceId = null,
        System.String? Variables = null
    ) 
    {
        if ( Application != null ) {
            this.Application = Application;
        }
        if ( Level != null ) {
            this.Level = Level;
        }
        if ( Priority != null ) {
            this.Priority = Priority;
        }
        if ( ResourceSubtype != null ) {
            this.ResourceSubtype = ResourceSubtype;
        }
        if ( ResourceType != null ) {
            this.ResourceType = ResourceType;
        }
        if ( Subtype != null ) {
            this.Subtype = Subtype;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( DefaultAction != null ) {
            this.DefaultAction = DefaultAction;
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
        if ( Metadata != null ) {
            this.Metadata = Metadata;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> NotificationApplication? Application
        // GraphQL -> application: NotificationApplication! (enum)
        if (this.Application != null) {
            if (conf.Flat) {
                s += conf.Prefix + "application\n" ;
            } else {
                s += ind + "application\n" ;
            }
        }
        //      C# -> NotificationLevel? Level
        // GraphQL -> level: NotificationLevel! (enum)
        if (this.Level != null) {
            if (conf.Flat) {
                s += conf.Prefix + "level\n" ;
            } else {
                s += ind + "level\n" ;
            }
        }
        //      C# -> NotificationPriority? Priority
        // GraphQL -> priority: NotificationPriority! (enum)
        if (this.Priority != null) {
            if (conf.Flat) {
                s += conf.Prefix + "priority\n" ;
            } else {
                s += ind + "priority\n" ;
            }
        }
        //      C# -> NotificationResourceSubtype? ResourceSubtype
        // GraphQL -> resourceSubtype: NotificationResourceSubtype! (enum)
        if (this.ResourceSubtype != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceSubtype\n" ;
            } else {
                s += ind + "resourceSubtype\n" ;
            }
        }
        //      C# -> NotificationResourceType? ResourceType
        // GraphQL -> resourceType: NotificationResourceType! (enum)
        if (this.ResourceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceType\n" ;
            } else {
                s += ind + "resourceType\n" ;
            }
        }
        //      C# -> NotificationSubtype? Subtype
        // GraphQL -> subtype: NotificationSubtype! (enum)
        if (this.Subtype != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subtype\n" ;
            } else {
                s += ind + "subtype\n" ;
            }
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdAt\n" ;
            } else {
                s += ind + "createdAt\n" ;
            }
        }
        //      C# -> System.String? DefaultAction
        // GraphQL -> defaultAction: String! (scalar)
        if (this.DefaultAction != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defaultAction\n" ;
            } else {
                s += ind + "defaultAction\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsRead
        // GraphQL -> isRead: Boolean! (scalar)
        if (this.IsRead != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRead\n" ;
            } else {
                s += ind + "isRead\n" ;
            }
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            if (conf.Flat) {
                s += conf.Prefix + "message\n" ;
            } else {
                s += ind + "message\n" ;
            }
        }
        //      C# -> System.String? Metadata
        // GraphQL -> metadata: String! (scalar)
        if (this.Metadata != null) {
            if (conf.Flat) {
                s += conf.Prefix + "metadata\n" ;
            } else {
                s += ind + "metadata\n" ;
            }
        }
        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        if (this.ResourceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceId\n" ;
            } else {
                s += ind + "resourceId\n" ;
            }
        }
        //      C# -> System.String? Variables
        // GraphQL -> variables: String! (scalar)
        if (this.Variables != null) {
            if (conf.Flat) {
                s += conf.Prefix + "variables\n" ;
            } else {
                s += ind + "variables\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> NotificationApplication? Application
        // GraphQL -> application: NotificationApplication! (enum)
        if (ec.Includes("application",true))
        {
            if(this.Application == null) {

                this.Application = new NotificationApplication();

            } else {


            }
        }
        else if (this.Application != null && ec.Excludes("application",true))
        {
            this.Application = null;
        }
        //      C# -> NotificationLevel? Level
        // GraphQL -> level: NotificationLevel! (enum)
        if (ec.Includes("level",true))
        {
            if(this.Level == null) {

                this.Level = new NotificationLevel();

            } else {


            }
        }
        else if (this.Level != null && ec.Excludes("level",true))
        {
            this.Level = null;
        }
        //      C# -> NotificationPriority? Priority
        // GraphQL -> priority: NotificationPriority! (enum)
        if (ec.Includes("priority",true))
        {
            if(this.Priority == null) {

                this.Priority = new NotificationPriority();

            } else {


            }
        }
        else if (this.Priority != null && ec.Excludes("priority",true))
        {
            this.Priority = null;
        }
        //      C# -> NotificationResourceSubtype? ResourceSubtype
        // GraphQL -> resourceSubtype: NotificationResourceSubtype! (enum)
        if (ec.Includes("resourceSubtype",true))
        {
            if(this.ResourceSubtype == null) {

                this.ResourceSubtype = new NotificationResourceSubtype();

            } else {


            }
        }
        else if (this.ResourceSubtype != null && ec.Excludes("resourceSubtype",true))
        {
            this.ResourceSubtype = null;
        }
        //      C# -> NotificationResourceType? ResourceType
        // GraphQL -> resourceType: NotificationResourceType! (enum)
        if (ec.Includes("resourceType",true))
        {
            if(this.ResourceType == null) {

                this.ResourceType = new NotificationResourceType();

            } else {


            }
        }
        else if (this.ResourceType != null && ec.Excludes("resourceType",true))
        {
            this.ResourceType = null;
        }
        //      C# -> NotificationSubtype? Subtype
        // GraphQL -> subtype: NotificationSubtype! (enum)
        if (ec.Includes("subtype",true))
        {
            if(this.Subtype == null) {

                this.Subtype = new NotificationSubtype();

            } else {


            }
        }
        else if (this.Subtype != null && ec.Excludes("subtype",true))
        {
            this.Subtype = null;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (ec.Includes("createdAt",true))
        {
            if(this.CreatedAt == null) {

                this.CreatedAt = new DateTime();

            } else {


            }
        }
        else if (this.CreatedAt != null && ec.Excludes("createdAt",true))
        {
            this.CreatedAt = null;
        }
        //      C# -> System.String? DefaultAction
        // GraphQL -> defaultAction: String! (scalar)
        if (ec.Includes("defaultAction",true))
        {
            if(this.DefaultAction == null) {

                this.DefaultAction = "FETCH";

            } else {


            }
        }
        else if (this.DefaultAction != null && ec.Excludes("defaultAction",true))
        {
            this.DefaultAction = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
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
        //      C# -> System.Boolean? IsRead
        // GraphQL -> isRead: Boolean! (scalar)
        if (ec.Includes("isRead",true))
        {
            if(this.IsRead == null) {

                this.IsRead = true;

            } else {


            }
        }
        else if (this.IsRead != null && ec.Excludes("isRead",true))
        {
            this.IsRead = null;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (ec.Includes("message",true))
        {
            if(this.Message == null) {

                this.Message = "FETCH";

            } else {


            }
        }
        else if (this.Message != null && ec.Excludes("message",true))
        {
            this.Message = null;
        }
        //      C# -> System.String? Metadata
        // GraphQL -> metadata: String! (scalar)
        if (ec.Includes("metadata",true))
        {
            if(this.Metadata == null) {

                this.Metadata = "FETCH";

            } else {


            }
        }
        else if (this.Metadata != null && ec.Excludes("metadata",true))
        {
            this.Metadata = null;
        }
        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        if (ec.Includes("resourceId",true))
        {
            if(this.ResourceId == null) {

                this.ResourceId = "FETCH";

            } else {


            }
        }
        else if (this.ResourceId != null && ec.Excludes("resourceId",true))
        {
            this.ResourceId = null;
        }
        //      C# -> System.String? Variables
        // GraphQL -> variables: String! (scalar)
        if (ec.Includes("variables",true))
        {
            if(this.Variables == null) {

                this.Variables = "FETCH";

            } else {


            }
        }
        else if (this.Variables != null && ec.Excludes("variables",true))
        {
            this.Variables = null;
        }
    }


    #endregion

    } // class Notification
    
    #endregion

    public static class ListNotificationExtensions
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
            this List<Notification> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Notification> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<Notification> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types