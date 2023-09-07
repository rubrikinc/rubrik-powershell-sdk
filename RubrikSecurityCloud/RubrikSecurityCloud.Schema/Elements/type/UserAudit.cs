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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "UserAudit";
    }

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
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> UserAuditTypeEnum? AuditType
        // GraphQL -> auditType: UserAuditTypeEnum (enum)
        if (this.AuditType == null && ec.Includes("auditType",true))
        {
            this.AuditType = new UserAuditTypeEnum();
        }
        //      C# -> UserAuditObjectTypeEnum? ObjectType
        // GraphQL -> objectType: UserAuditObjectTypeEnum! (enum)
        if (this.ObjectType == null && ec.Includes("objectType",true))
        {
            this.ObjectType = new UserAuditObjectTypeEnum();
        }
        //      C# -> UserAuditSeverityEnum? Severity
        // GraphQL -> severity: UserAuditSeverityEnum (enum)
        if (this.Severity == null && ec.Includes("severity",true))
        {
            this.Severity = new UserAuditSeverityEnum();
        }
        //      C# -> UserAuditStatusEnum? Status
        // GraphQL -> status: UserAuditStatusEnum! (enum)
        if (this.Status == null && ec.Includes("status",true))
        {
            this.Status = new UserAuditStatusEnum();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: ID! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && ec.Includes("message",true))
        {
            this.Message = "FETCH";
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId == null && ec.Includes("objectId",true))
        {
            this.ObjectId = "FETCH";
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String (scalar)
        if (this.ObjectName == null && ec.Includes("objectName",true))
        {
            this.ObjectName = "FETCH";
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId == null && ec.Includes("orgId",true))
        {
            this.OrgId = "FETCH";
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String (scalar)
        if (this.OrgName == null && ec.Includes("orgName",true))
        {
            this.OrgName = "FETCH";
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        if (this.Time == null && ec.Includes("time",true))
        {
            this.Time = new DateTime();
        }
        //      C# -> System.String? UserName
        // GraphQL -> userName: String (scalar)
        if (this.UserName == null && ec.Includes("userName",true))
        {
            this.UserName = "FETCH";
        }
        //      C# -> System.String? UserNote
        // GraphQL -> userNote: String (scalar)
        if (this.UserNote == null && ec.Includes("userNote",true))
        {
            this.UserNote = "FETCH";
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster == null && ec.Includes("cluster",false))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));
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
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UserAudit> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UserAudit());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<UserAudit> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types