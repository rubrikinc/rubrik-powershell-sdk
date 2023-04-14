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

namespace Rubrik.SecurityCloud.Types
{
    #region UserAudit
    public class UserAudit: IFragment
    {
        #region members
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

        #endregion

    #region methods

    public UserAudit Set(
        System.String? Id = null,
        System.String? Message = null,
        System.String? ObjectId = null,
        System.String? ObjectName = null,
        System.String? OrgId = null,
        System.String? OrgName = null,
        DateTime? Time = null,
        System.String? UserName = null,
        System.String? UserNote = null,
        Cluster? Cluster = null,
        UserAuditTypeEnum? AuditType = null,
        UserAuditObjectTypeEnum? ObjectType = null,
        UserAuditSeverityEnum? Severity = null,
        UserAuditStatusEnum? Status = null
    ) 
    {
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
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? Id
            // GraphQL -> id: ID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Message
            // GraphQL -> message: String! (scalar)
            if (this.Message != null)
            {
                 s += ind + "message\n";

            }
            //      C# -> System.String? ObjectId
            // GraphQL -> objectId: String! (scalar)
            if (this.ObjectId != null)
            {
                 s += ind + "objectId\n";

            }
            //      C# -> System.String? ObjectName
            // GraphQL -> objectName: String (scalar)
            if (this.ObjectName != null)
            {
                 s += ind + "objectName\n";

            }
            //      C# -> System.String? OrgId
            // GraphQL -> orgId: String! (scalar)
            if (this.OrgId != null)
            {
                 s += ind + "orgId\n";

            }
            //      C# -> System.String? OrgName
            // GraphQL -> orgName: String (scalar)
            if (this.OrgName != null)
            {
                 s += ind + "orgName\n";

            }
            //      C# -> DateTime? Time
            // GraphQL -> time: DateTime! (scalar)
            if (this.Time != null)
            {
                 s += ind + "time\n";

            }
            //      C# -> System.String? UserName
            // GraphQL -> userName: String (scalar)
            if (this.UserName != null)
            {
                 s += ind + "userName\n";

            }
            //      C# -> System.String? UserNote
            // GraphQL -> userNote: String (scalar)
            if (this.UserNote != null)
            {
                 s += ind + "userNote\n";

            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster (type)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

                 s += ind + "{\n" + 
                 this.Cluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> UserAuditTypeEnum? AuditType
            // GraphQL -> auditType: UserAuditTypeEnum (enum)
            if (this.AuditType != null)
            {
                 s += ind + "auditType\n";

            }
            //      C# -> UserAuditObjectTypeEnum? ObjectType
            // GraphQL -> objectType: UserAuditObjectTypeEnum! (enum)
            if (this.ObjectType != null)
            {
                 s += ind + "objectType\n";

            }
            //      C# -> UserAuditSeverityEnum? Severity
            // GraphQL -> severity: UserAuditSeverityEnum (enum)
            if (this.Severity != null)
            {
                 s += ind + "severity\n";

            }
            //      C# -> UserAuditStatusEnum? Status
            // GraphQL -> status: UserAuditStatusEnum! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: ID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Message
            // GraphQL -> message: String! (scalar)
            if (this.Message == null && Exploration.Includes(parent + ".message$"))
            {
                this.Message = new System.String("FETCH");
            }
            //      C# -> System.String? ObjectId
            // GraphQL -> objectId: String! (scalar)
            if (this.ObjectId == null && Exploration.Includes(parent + ".objectId$"))
            {
                this.ObjectId = new System.String("FETCH");
            }
            //      C# -> System.String? ObjectName
            // GraphQL -> objectName: String (scalar)
            if (this.ObjectName == null && Exploration.Includes(parent + ".objectName$"))
            {
                this.ObjectName = new System.String("FETCH");
            }
            //      C# -> System.String? OrgId
            // GraphQL -> orgId: String! (scalar)
            if (this.OrgId == null && Exploration.Includes(parent + ".orgId$"))
            {
                this.OrgId = new System.String("FETCH");
            }
            //      C# -> System.String? OrgName
            // GraphQL -> orgName: String (scalar)
            if (this.OrgName == null && Exploration.Includes(parent + ".orgName$"))
            {
                this.OrgName = new System.String("FETCH");
            }
            //      C# -> DateTime? Time
            // GraphQL -> time: DateTime! (scalar)
            if (this.Time == null && Exploration.Includes(parent + ".time$"))
            {
                this.Time = new DateTime();
            }
            //      C# -> System.String? UserName
            // GraphQL -> userName: String (scalar)
            if (this.UserName == null && Exploration.Includes(parent + ".userName$"))
            {
                this.UserName = new System.String("FETCH");
            }
            //      C# -> System.String? UserNote
            // GraphQL -> userNote: String (scalar)
            if (this.UserNote == null && Exploration.Includes(parent + ".userNote$"))
            {
                this.UserNote = new System.String("FETCH");
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> UserAuditTypeEnum? AuditType
            // GraphQL -> auditType: UserAuditTypeEnum (enum)
            if (this.AuditType == null && Exploration.Includes(parent + ".auditType$"))
            {
                this.AuditType = new UserAuditTypeEnum();
            }
            //      C# -> UserAuditObjectTypeEnum? ObjectType
            // GraphQL -> objectType: UserAuditObjectTypeEnum! (enum)
            if (this.ObjectType == null && Exploration.Includes(parent + ".objectType$"))
            {
                this.ObjectType = new UserAuditObjectTypeEnum();
            }
            //      C# -> UserAuditSeverityEnum? Severity
            // GraphQL -> severity: UserAuditSeverityEnum (enum)
            if (this.Severity == null && Exploration.Includes(parent + ".severity$"))
            {
                this.Severity = new UserAuditSeverityEnum();
            }
            //      C# -> UserAuditStatusEnum? Status
            // GraphQL -> status: UserAuditStatusEnum! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new UserAuditStatusEnum();
            }
        }


    #endregion

    } // class UserAudit
    #endregion

    public static class ListUserAuditExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<UserAudit> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UserAudit> list, 
            String parent = "")
        {
            var item = new UserAudit();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types