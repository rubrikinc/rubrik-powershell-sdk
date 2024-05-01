// StorageArrayDetail.cs
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
    #region StorageArrayDetail
    public class StorageArrayDetail: BaseType
    {
        #region members

        //      C# -> StorageArrayType? ArrayType
        // GraphQL -> arrayType: StorageArrayType! (enum)
        [JsonProperty("arrayType")]
        public StorageArrayType? ArrayType { get; set; }

        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String (scalar)
        [JsonProperty("caCerts")]
        public System.String? CaCerts { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        [JsonProperty("connectionStatus")]
        public RefreshableObjectConnectionStatus? ConnectionStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "StorageArrayDetail";
    }

    public StorageArrayDetail Set(
        StorageArrayType? ArrayType = null,
        System.String? CaCerts = null,
        System.String? Hostname = null,
        System.String? Id = null,
        System.String? Username = null,
        RefreshableObjectConnectionStatus? ConnectionStatus = null
    ) 
    {
        if ( ArrayType != null ) {
            this.ArrayType = ArrayType;
        }
        if ( CaCerts != null ) {
            this.CaCerts = CaCerts;
        }
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
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
        //      C# -> StorageArrayType? ArrayType
        // GraphQL -> arrayType: StorageArrayType! (enum)
        if (this.ArrayType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "arrayType\n" ;
            } else {
                s += ind + "arrayType\n" ;
            }
        }
        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String (scalar)
        if (this.CaCerts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "caCerts\n" ;
            } else {
                s += ind + "caCerts\n" ;
            }
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostname\n" ;
            } else {
                s += ind + "hostname\n" ;
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
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            if (conf.Flat) {
                s += conf.Prefix + "username\n" ;
            } else {
                s += ind + "username\n" ;
            }
        }
        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        if (this.ConnectionStatus != null) {
            var fspec = this.ConnectionStatus.AsFieldSpec(conf.Child("connectionStatus"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "connectionStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> StorageArrayType? ArrayType
        // GraphQL -> arrayType: StorageArrayType! (enum)
        if (ec.Includes("arrayType",true))
        {
            if(this.ArrayType == null) {

                this.ArrayType = new StorageArrayType();

            } else {


            }
        }
        else if (this.ArrayType != null && ec.Excludes("arrayType",true))
        {
            this.ArrayType = null;
        }
        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String (scalar)
        if (ec.Includes("caCerts",true))
        {
            if(this.CaCerts == null) {

                this.CaCerts = "FETCH";

            } else {


            }
        }
        else if (this.CaCerts != null && ec.Excludes("caCerts",true))
        {
            this.CaCerts = null;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (ec.Includes("hostname",true))
        {
            if(this.Hostname == null) {

                this.Hostname = "FETCH";

            } else {


            }
        }
        else if (this.Hostname != null && ec.Excludes("hostname",true))
        {
            this.Hostname = null;
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
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (ec.Includes("username",true))
        {
            if(this.Username == null) {

                this.Username = "FETCH";

            } else {


            }
        }
        else if (this.Username != null && ec.Excludes("username",true))
        {
            this.Username = null;
        }
        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        if (ec.Includes("connectionStatus",false))
        {
            if(this.ConnectionStatus == null) {

                this.ConnectionStatus = new RefreshableObjectConnectionStatus();
                this.ConnectionStatus.ApplyExploratoryFieldSpec(ec.NewChild("connectionStatus"));

            } else {

                this.ConnectionStatus.ApplyExploratoryFieldSpec(ec.NewChild("connectionStatus"));

            }
        }
        else if (this.ConnectionStatus != null && ec.Excludes("connectionStatus",false))
        {
            this.ConnectionStatus = null;
        }
    }


    #endregion

    } // class StorageArrayDetail
    
    #endregion

    public static class ListStorageArrayDetailExtensions
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
            this List<StorageArrayDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<StorageArrayDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<StorageArrayDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new StorageArrayDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<StorageArrayDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types