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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> StorageArrayType? ArrayType
        // GraphQL -> arrayType: StorageArrayType! (enum)
        if (this.ArrayType != null) {
            s += ind + "arrayType\n" ;
        }
        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String (scalar)
        if (this.CaCerts != null) {
            s += ind + "caCerts\n" ;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            s += ind + "hostname\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            s += ind + "username\n" ;
        }
        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        if (this.ConnectionStatus != null) {
            var fspec = this.ConnectionStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "connectionStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> StorageArrayType? ArrayType
        // GraphQL -> arrayType: StorageArrayType! (enum)
        if (this.ArrayType == null && ec.Includes("arrayType",true))
        {
            this.ArrayType = new StorageArrayType();
        }
        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String (scalar)
        if (this.CaCerts == null && ec.Includes("caCerts",true))
        {
            this.CaCerts = "FETCH";
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname == null && ec.Includes("hostname",true))
        {
            this.Hostname = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username == null && ec.Includes("username",true))
        {
            this.Username = "FETCH";
        }
        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        if (this.ConnectionStatus == null && ec.Includes("connectionStatus",false))
        {
            this.ConnectionStatus = new RefreshableObjectConnectionStatus();
            this.ConnectionStatus.ApplyExploratoryFieldSpec(ec.NewChild("connectionStatus"));
        }
    }


    #endregion

    } // class StorageArrayDetail
    
    #endregion

    public static class ListStorageArrayDetailExtensions
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
            this List<StorageArrayDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<StorageArrayDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types