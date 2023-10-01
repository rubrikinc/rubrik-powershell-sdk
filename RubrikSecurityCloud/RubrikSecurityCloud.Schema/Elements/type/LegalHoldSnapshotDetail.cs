// LegalHoldSnapshotDetail.cs
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
    #region LegalHoldSnapshotDetail
    public class LegalHoldSnapshotDetail: BaseType
    {
        #region members

        //      C# -> List<SnapshotCustomization>? Customizations
        // GraphQL -> customizations: [SnapshotCustomization!]! (enum)
        [JsonProperty("customizations")]
        public List<SnapshotCustomization>? Customizations { get; set; }

        //      C# -> SnapshotTypeEnum? Type
        // GraphQL -> type: SnapshotTypeEnum! (enum)
        [JsonProperty("type")]
        public SnapshotTypeEnum? Type { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? LegalHoldTime
        // GraphQL -> legalHoldTime: DateTime (scalar)
        [JsonProperty("legalHoldTime")]
        public DateTime? LegalHoldTime { get; set; }

        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        [JsonProperty("snapshotTime")]
        public DateTime? SnapshotTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LegalHoldSnapshotDetail";
    }

    public LegalHoldSnapshotDetail Set(
        List<SnapshotCustomization>? Customizations = null,
        SnapshotTypeEnum? Type = null,
        System.String? Id = null,
        DateTime? LegalHoldTime = null,
        DateTime? SnapshotTime = null
    ) 
    {
        if ( Customizations != null ) {
            this.Customizations = Customizations;
        }
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LegalHoldTime != null ) {
            this.LegalHoldTime = LegalHoldTime;
        }
        if ( SnapshotTime != null ) {
            this.SnapshotTime = SnapshotTime;
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
        //      C# -> List<SnapshotCustomization>? Customizations
        // GraphQL -> customizations: [SnapshotCustomization!]! (enum)
        if (this.Customizations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "customizations\n" ;
            } else {
                s += ind + "customizations\n" ;
            }
        }
        //      C# -> SnapshotTypeEnum? Type
        // GraphQL -> type: SnapshotTypeEnum! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
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
        //      C# -> DateTime? LegalHoldTime
        // GraphQL -> legalHoldTime: DateTime (scalar)
        if (this.LegalHoldTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "legalHoldTime\n" ;
            } else {
                s += ind + "legalHoldTime\n" ;
            }
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (this.SnapshotTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotTime\n" ;
            } else {
                s += ind + "snapshotTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<SnapshotCustomization>? Customizations
        // GraphQL -> customizations: [SnapshotCustomization!]! (enum)
        if (ec.Includes("customizations",true))
        {
            if(this.Customizations == null) {

                this.Customizations = new List<SnapshotCustomization>();

            } else {


            }
        }
        else if (this.Customizations != null && ec.Excludes("customizations",true))
        {
            this.Customizations = null;
        }
        //      C# -> SnapshotTypeEnum? Type
        // GraphQL -> type: SnapshotTypeEnum! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new SnapshotTypeEnum();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
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
        //      C# -> DateTime? LegalHoldTime
        // GraphQL -> legalHoldTime: DateTime (scalar)
        if (ec.Includes("legalHoldTime",true))
        {
            if(this.LegalHoldTime == null) {

                this.LegalHoldTime = new DateTime();

            } else {


            }
        }
        else if (this.LegalHoldTime != null && ec.Excludes("legalHoldTime",true))
        {
            this.LegalHoldTime = null;
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (ec.Includes("snapshotTime",true))
        {
            if(this.SnapshotTime == null) {

                this.SnapshotTime = new DateTime();

            } else {


            }
        }
        else if (this.SnapshotTime != null && ec.Excludes("snapshotTime",true))
        {
            this.SnapshotTime = null;
        }
    }


    #endregion

    } // class LegalHoldSnapshotDetail
    
    #endregion

    public static class ListLegalHoldSnapshotDetailExtensions
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
            this List<LegalHoldSnapshotDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<LegalHoldSnapshotDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LegalHoldSnapshotDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LegalHoldSnapshotDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LegalHoldSnapshotDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types