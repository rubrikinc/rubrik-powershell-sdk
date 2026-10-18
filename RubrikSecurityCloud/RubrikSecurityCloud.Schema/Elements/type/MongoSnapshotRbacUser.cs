// MongoSnapshotRbacUser.cs
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
    #region MongoSnapshotRbacUser
    public class MongoSnapshotRbacUser: BaseType
    {
        #region members

        //      C# -> System.String? Db
        // GraphQL -> db: String! (scalar)
        [JsonProperty("db")]
        public System.String? Db { get; set; }

        //      C# -> System.String? User
        // GraphQL -> user: String! (scalar)
        [JsonProperty("user")]
        public System.String? User { get; set; }

        //      C# -> List<MongoSnapshotRbacRoleAssignment>? Roles
        // GraphQL -> roles: [MongoSnapshotRbacRoleAssignment!]! (type)
        [JsonProperty("roles")]
        public List<MongoSnapshotRbacRoleAssignment>? Roles { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MongoSnapshotRbacUser";
    }

    public MongoSnapshotRbacUser Set(
        System.String? Db = null,
        System.String? User = null,
        List<MongoSnapshotRbacRoleAssignment>? Roles = null
    ) 
    {
        if ( Db != null ) {
            this.Db = Db;
        }
        if ( User != null ) {
            this.User = User;
        }
        if ( Roles != null ) {
            this.Roles = Roles;
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
        //      C# -> System.String? Db
        // GraphQL -> db: String! (scalar)
        if (this.Db != null) {
            if (conf.Flat) {
                s += conf.Prefix + "db\n" ;
            } else {
                s += ind + "db\n" ;
            }
        }
        //      C# -> System.String? User
        // GraphQL -> user: String! (scalar)
        if (this.User != null) {
            if (conf.Flat) {
                s += conf.Prefix + "user\n" ;
            } else {
                s += ind + "user\n" ;
            }
        }
        //      C# -> List<MongoSnapshotRbacRoleAssignment>? Roles
        // GraphQL -> roles: [MongoSnapshotRbacRoleAssignment!]! (type)
        if (this.Roles != null) {
            var fspec = this.Roles.AsFieldSpec(conf.Child("roles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "roles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Db
        // GraphQL -> db: String! (scalar)
        if (ec.Includes("db",true))
        {
            if(this.Db == null) {

                this.Db = "FETCH";

            } else {


            }
        }
        else if (this.Db != null && ec.Excludes("db",true))
        {
            this.Db = null;
        }
        //      C# -> System.String? User
        // GraphQL -> user: String! (scalar)
        if (ec.Includes("user",true))
        {
            if(this.User == null) {

                this.User = "FETCH";

            } else {


            }
        }
        else if (this.User != null && ec.Excludes("user",true))
        {
            this.User = null;
        }
        //      C# -> List<MongoSnapshotRbacRoleAssignment>? Roles
        // GraphQL -> roles: [MongoSnapshotRbacRoleAssignment!]! (type)
        if (ec.Includes("roles",false))
        {
            if(this.Roles == null) {

                this.Roles = new List<MongoSnapshotRbacRoleAssignment>();
                this.Roles.ApplyExploratoryFieldSpec(ec.NewChild("roles"));

            } else {

                this.Roles.ApplyExploratoryFieldSpec(ec.NewChild("roles"));

            }
        }
        else if (this.Roles != null && ec.Excludes("roles",false))
        {
            this.Roles = null;
        }
    }


    #endregion

    } // class MongoSnapshotRbacUser
    
    #endregion

    public static class ListMongoSnapshotRbacUserExtensions
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
            this List<MongoSnapshotRbacUser> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MongoSnapshotRbacUser> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MongoSnapshotRbacUser> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MongoSnapshotRbacUser());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MongoSnapshotRbacUser> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types