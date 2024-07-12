// CustomerFacingFile.cs
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
    #region CustomerFacingFile
    public class CustomerFacingFile: BaseType
    {
        #region members

        //      C# -> FileStateEnumType? State
        // GraphQL -> state: FileStateEnumType! (enum)
        [JsonProperty("state")]
        public FileStateEnumType? State { get; set; }

        //      C# -> FileTypeEnumType? Type
        // GraphQL -> type: FileTypeEnumType! (enum)
        [JsonProperty("type")]
        public FileTypeEnumType? Type { get; set; }

        //      C# -> DateTime? CompletedAt
        // GraphQL -> completedAt: DateTime (scalar)
        [JsonProperty("completedAt")]
        public DateTime? CompletedAt { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.String? Creator
        // GraphQL -> creator: String! (scalar)
        [JsonProperty("creator")]
        public System.String? Creator { get; set; }

        //      C# -> DateTime? ExpiresAt
        // GraphQL -> expiresAt: DateTime (scalar)
        [JsonProperty("expiresAt")]
        public DateTime? ExpiresAt { get; set; }

        //      C# -> System.String? ExternalId
        // GraphQL -> externalId: String! (scalar)
        [JsonProperty("externalId")]
        public System.String? ExternalId { get; set; }

        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        [JsonProperty("filename")]
        public System.String? Filename { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CustomerFacingFile";
    }

    public CustomerFacingFile Set(
        FileStateEnumType? State = null,
        FileTypeEnumType? Type = null,
        DateTime? CompletedAt = null,
        DateTime? CreatedAt = null,
        System.String? Creator = null,
        DateTime? ExpiresAt = null,
        System.String? ExternalId = null,
        System.String? Filename = null
    ) 
    {
        if ( State != null ) {
            this.State = State;
        }
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( CompletedAt != null ) {
            this.CompletedAt = CompletedAt;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( Creator != null ) {
            this.Creator = Creator;
        }
        if ( ExpiresAt != null ) {
            this.ExpiresAt = ExpiresAt;
        }
        if ( ExternalId != null ) {
            this.ExternalId = ExternalId;
        }
        if ( Filename != null ) {
            this.Filename = Filename;
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
        //      C# -> FileStateEnumType? State
        // GraphQL -> state: FileStateEnumType! (enum)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> FileTypeEnumType? Type
        // GraphQL -> type: FileTypeEnumType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> DateTime? CompletedAt
        // GraphQL -> completedAt: DateTime (scalar)
        if (this.CompletedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "completedAt\n" ;
            } else {
                s += ind + "completedAt\n" ;
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
        //      C# -> System.String? Creator
        // GraphQL -> creator: String! (scalar)
        if (this.Creator != null) {
            if (conf.Flat) {
                s += conf.Prefix + "creator\n" ;
            } else {
                s += ind + "creator\n" ;
            }
        }
        //      C# -> DateTime? ExpiresAt
        // GraphQL -> expiresAt: DateTime (scalar)
        if (this.ExpiresAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expiresAt\n" ;
            } else {
                s += ind + "expiresAt\n" ;
            }
        }
        //      C# -> System.String? ExternalId
        // GraphQL -> externalId: String! (scalar)
        if (this.ExternalId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "externalId\n" ;
            } else {
                s += ind + "externalId\n" ;
            }
        }
        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        if (this.Filename != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filename\n" ;
            } else {
                s += ind + "filename\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> FileStateEnumType? State
        // GraphQL -> state: FileStateEnumType! (enum)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = new FileStateEnumType();

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> FileTypeEnumType? Type
        // GraphQL -> type: FileTypeEnumType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new FileTypeEnumType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> DateTime? CompletedAt
        // GraphQL -> completedAt: DateTime (scalar)
        if (ec.Includes("completedAt",true))
        {
            if(this.CompletedAt == null) {

                this.CompletedAt = new DateTime();

            } else {


            }
        }
        else if (this.CompletedAt != null && ec.Excludes("completedAt",true))
        {
            this.CompletedAt = null;
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
        //      C# -> System.String? Creator
        // GraphQL -> creator: String! (scalar)
        if (ec.Includes("creator",true))
        {
            if(this.Creator == null) {

                this.Creator = "FETCH";

            } else {


            }
        }
        else if (this.Creator != null && ec.Excludes("creator",true))
        {
            this.Creator = null;
        }
        //      C# -> DateTime? ExpiresAt
        // GraphQL -> expiresAt: DateTime (scalar)
        if (ec.Includes("expiresAt",true))
        {
            if(this.ExpiresAt == null) {

                this.ExpiresAt = new DateTime();

            } else {


            }
        }
        else if (this.ExpiresAt != null && ec.Excludes("expiresAt",true))
        {
            this.ExpiresAt = null;
        }
        //      C# -> System.String? ExternalId
        // GraphQL -> externalId: String! (scalar)
        if (ec.Includes("externalId",true))
        {
            if(this.ExternalId == null) {

                this.ExternalId = "FETCH";

            } else {


            }
        }
        else if (this.ExternalId != null && ec.Excludes("externalId",true))
        {
            this.ExternalId = null;
        }
        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        if (ec.Includes("filename",true))
        {
            if(this.Filename == null) {

                this.Filename = "FETCH";

            } else {


            }
        }
        else if (this.Filename != null && ec.Excludes("filename",true))
        {
            this.Filename = null;
        }
    }


    #endregion

    } // class CustomerFacingFile
    
    #endregion

    public static class ListCustomerFacingFileExtensions
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
            this List<CustomerFacingFile> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CustomerFacingFile> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CustomerFacingFile> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CustomerFacingFile());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CustomerFacingFile> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types