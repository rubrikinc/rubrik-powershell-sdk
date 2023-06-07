// UserAudit.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region UserAudit
    public class UserAudit: BaseType
    {
        #region members

        //      C# -> UserAuditTypeEnum? AuditType
        // GraphQL -> auditType: UserAuditTypeEnum (enum)
        [JsonProperty("auditType")]
        public UserAuditTypeEnum? AuditType { get; set; }

        //      C# -> UserAuditObjectTypeEnum? ObjectType
        // GraphQL -> objectType: UserAuditObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public UserAuditObjectTypeEnum? ObjectType { get; set; }

        //      C# -> UserAuditSeverityEnum? Severity
        // GraphQL -> severity: UserAuditSeverityEnum (enum)
        [JsonProperty("severity")]
        public UserAuditSeverityEnum? Severity { get; set; }

        //      C# -> UserAuditStatusEnum? Status
        // GraphQL -> status: UserAuditStatusEnum! (enum)
        [JsonProperty("status")]
        public UserAuditStatusEnum? Status { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: ID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String (scalar)
        [JsonProperty("objectName")]
        public System.String? ObjectName { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String (scalar)
        [JsonProperty("orgName")]
        public System.String? OrgName { get; set; }

        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        [JsonProperty("time")]
        public DateTime? Time { get; set; }

        //      C# -> System.String? UserName
        // GraphQL -> userName: String (scalar)
        [JsonProperty("userName")]
        public System.String? UserName { get; set; }

        //      C# -> System.String? UserNote
        // GraphQL -> userNote: String (scalar)
        [JsonProperty("userNote")]
        public System.String? UserNote { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }


        #endregion

    #region methods

    public UserAudit Set(
        UserAuditTypeEnum? AuditType = null,
        UserAuditObjectTypeEnum? ObjectType = null,
        UserAuditSeverityEnum? Severity = null,
        UserAuditStatusEnum? Status = null,
        System.String? Id = null,
        System.String? Message = null,
        System.String? ObjectId = null,
        System.String? ObjectName = null,
        System.String? OrgId = null,
        System.String? OrgName = null,
        DateTime? Time = null,
        System.String? UserName = null,
        System.String? UserNote = null,
        Cluster? Cluster = null
    ) 
    {
        if ( AuditType != null ) {
            this.AuditType = AuditType;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        if ( ObjectName != null ) {
            this.ObjectName = ObjectName;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( OrgName != null ) {
            this.OrgName = OrgName;
        }
        if ( Time != null ) {
            this.Time = Time;
        }
        if ( UserName != null ) {
            this.UserName = UserName;
        }
        if ( UserNote != null ) {
            this.UserNote = UserNote;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
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
        //      C# -> UserAuditTypeEnum? AuditType
        // GraphQL -> auditType: UserAuditTypeEnum (enum)
        if (this.AuditType != null) {
            s += ind + "auditType\n" ;
        }
        //      C# -> UserAuditObjectTypeEnum? ObjectType
        // GraphQL -> objectType: UserAuditObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> UserAuditSeverityEnum? Severity
        // GraphQL -> severity: UserAuditSeverityEnum (enum)
        if (this.Severity != null) {
            s += ind + "severity\n" ;
        }
        //      C# -> UserAuditStatusEnum? Status
        // GraphQL -> status: UserAuditStatusEnum! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: ID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            s += ind + "message\n" ;
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId != null) {
            s += ind + "objectId\n" ;
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String (scalar)
        if (this.ObjectName != null) {
            s += ind + "objectName\n" ;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId != null) {
            s += ind + "orgId\n" ;
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String (scalar)
        if (this.OrgName != null) {
            s += ind + "orgName\n" ;
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        if (this.Time != null) {
            s += ind + "time\n" ;
        }
        //      C# -> System.String? UserName
        // GraphQL -> userName: String (scalar)
        if (this.UserName != null) {
            s += ind + "userName\n" ;
        }
        //      C# -> System.String? UserNote
        // GraphQL -> userNote: String (scalar)
        if (this.UserNote != null) {
            s += ind + "userNote\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster != null) {
            s += ind + "cluster {\n" + this.Cluster.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> UserAuditTypeEnum? AuditType
        // GraphQL -> auditType: UserAuditTypeEnum (enum)
        if (this.AuditType == null && Exploration.Includes(parent + ".auditType", true))
        {
            this.AuditType = new UserAuditTypeEnum();
        }
        //      C# -> UserAuditObjectTypeEnum? ObjectType
        // GraphQL -> objectType: UserAuditObjectTypeEnum! (enum)
        if (this.ObjectType == null && Exploration.Includes(parent + ".objectType", true))
        {
            this.ObjectType = new UserAuditObjectTypeEnum();
        }
        //      C# -> UserAuditSeverityEnum? Severity
        // GraphQL -> severity: UserAuditSeverityEnum (enum)
        if (this.Severity == null && Exploration.Includes(parent + ".severity", true))
        {
            this.Severity = new UserAuditSeverityEnum();
        }
        //      C# -> UserAuditStatusEnum? Status
        // GraphQL -> status: UserAuditStatusEnum! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new UserAuditStatusEnum();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: ID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && Exploration.Includes(parent + ".message", true))
        {
            this.Message = "FETCH";
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId == null && Exploration.Includes(parent + ".objectId", true))
        {
            this.ObjectId = "FETCH";
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String (scalar)
        if (this.ObjectName == null && Exploration.Includes(parent + ".objectName", true))
        {
            this.ObjectName = "FETCH";
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId == null && Exploration.Includes(parent + ".orgId", true))
        {
            this.OrgId = "FETCH";
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String (scalar)
        if (this.OrgName == null && Exploration.Includes(parent + ".orgName", true))
        {
            this.OrgName = "FETCH";
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        if (this.Time == null && Exploration.Includes(parent + ".time", true))
        {
            this.Time = new DateTime();
        }
        //      C# -> System.String? UserName
        // GraphQL -> userName: String (scalar)
        if (this.UserName == null && Exploration.Includes(parent + ".userName", true))
        {
            this.UserName = "FETCH";
        }
        //      C# -> System.String? UserNote
        // GraphQL -> userNote: String (scalar)
        if (this.UserNote == null && Exploration.Includes(parent + ".userNote", true))
        {
            this.UserNote = "FETCH";
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
    }


    #endregion

    } // class UserAudit
    
    #endregion

    public static class ListUserAuditExtensions
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
            this List<UserAudit> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UserAudit> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UserAudit());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types