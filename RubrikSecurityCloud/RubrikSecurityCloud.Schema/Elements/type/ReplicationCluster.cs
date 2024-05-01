// ReplicationCluster.cs
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
    #region ReplicationCluster
    public class ReplicationCluster: BaseType
    {
        #region members

        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        [JsonProperty("accountName")]
        public System.String? AccountName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsCrossAccount
        // GraphQL -> isCrossAccount: Boolean! (scalar)
        [JsonProperty("isCrossAccount")]
        public System.Boolean? IsCrossAccount { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ReplicationCluster";
    }

    public ReplicationCluster Set(
        System.String? AccountName = null,
        System.String? Id = null,
        System.Boolean? IsCrossAccount = null,
        System.String? Name = null,
        System.String? Version = null
    ) 
    {
        if ( AccountName != null ) {
            this.AccountName = AccountName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsCrossAccount != null ) {
            this.IsCrossAccount = IsCrossAccount;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        if (this.AccountName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accountName\n" ;
            } else {
                s += ind + "accountName\n" ;
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
        //      C# -> System.Boolean? IsCrossAccount
        // GraphQL -> isCrossAccount: Boolean! (scalar)
        if (this.IsCrossAccount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isCrossAccount\n" ;
            } else {
                s += ind + "isCrossAccount\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        if (ec.Includes("accountName",true))
        {
            if(this.AccountName == null) {

                this.AccountName = "FETCH";

            } else {


            }
        }
        else if (this.AccountName != null && ec.Excludes("accountName",true))
        {
            this.AccountName = null;
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
        //      C# -> System.Boolean? IsCrossAccount
        // GraphQL -> isCrossAccount: Boolean! (scalar)
        if (ec.Includes("isCrossAccount",true))
        {
            if(this.IsCrossAccount == null) {

                this.IsCrossAccount = true;

            } else {


            }
        }
        else if (this.IsCrossAccount != null && ec.Excludes("isCrossAccount",true))
        {
            this.IsCrossAccount = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
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
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
    }


    #endregion

    } // class ReplicationCluster
    
    #endregion

    public static class ListReplicationClusterExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ReplicationCluster> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ReplicationCluster> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ReplicationCluster> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReplicationCluster());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReplicationCluster> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types