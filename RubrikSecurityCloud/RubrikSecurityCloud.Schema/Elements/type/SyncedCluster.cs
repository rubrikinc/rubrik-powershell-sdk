// SyncedCluster.cs
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
    #region SyncedCluster
    public class SyncedCluster: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsConnected
        // GraphQL -> isConnected: Boolean! (scalar)
        [JsonProperty("isConnected")]
        public System.Boolean? IsConnected { get; set; }

        //      C# -> DateTime? LastSynced
        // GraphQL -> lastSynced: DateTime (scalar)
        [JsonProperty("lastSynced")]
        public DateTime? LastSynced { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SyncedCluster";
    }

    public SyncedCluster Set(
        System.String? Id = null,
        System.Boolean? IsConnected = null,
        DateTime? LastSynced = null,
        System.String? Name = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsConnected != null ) {
            this.IsConnected = IsConnected;
        }
        if ( LastSynced != null ) {
            this.LastSynced = LastSynced;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsConnected
        // GraphQL -> isConnected: Boolean! (scalar)
        if (this.IsConnected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isConnected\n" ;
            } else {
                s += ind + "isConnected\n" ;
            }
        }
        //      C# -> DateTime? LastSynced
        // GraphQL -> lastSynced: DateTime (scalar)
        if (this.LastSynced != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastSynced\n" ;
            } else {
                s += ind + "lastSynced\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> System.Boolean? IsConnected
        // GraphQL -> isConnected: Boolean! (scalar)
        if (ec.Includes("isConnected",true))
        {
            if(this.IsConnected == null) {

                this.IsConnected = true;

            } else {


            }
        }
        else if (this.IsConnected != null && ec.Excludes("isConnected",true))
        {
            this.IsConnected = null;
        }
        //      C# -> DateTime? LastSynced
        // GraphQL -> lastSynced: DateTime (scalar)
        if (ec.Includes("lastSynced",true))
        {
            if(this.LastSynced == null) {

                this.LastSynced = new DateTime();

            } else {


            }
        }
        else if (this.LastSynced != null && ec.Excludes("lastSynced",true))
        {
            this.LastSynced = null;
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
    }


    #endregion

    } // class SyncedCluster
    
    #endregion

    public static class ListSyncedClusterExtensions
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
            this List<SyncedCluster> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SyncedCluster> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SyncedCluster> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SyncedCluster());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SyncedCluster> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types