// ActiveDirectoryGpoSettingsData.cs
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
    #region ActiveDirectoryGpoSettingsData
    public class ActiveDirectoryGpoSettingsData: BaseType
    {
        #region members

        //      C# -> System.String? Data
        // GraphQL -> data: String! (scalar)
        [JsonProperty("data")]
        public System.String? Data { get; set; }

        //      C# -> System.String? DomainSid
        // GraphQL -> domainSid: String! (scalar)
        [JsonProperty("domainSid")]
        public System.String? DomainSid { get; set; }

        //      C# -> System.String? GpoId
        // GraphQL -> gpoId: String! (scalar)
        [JsonProperty("gpoId")]
        public System.String? GpoId { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActiveDirectoryGpoSettingsData";
    }

    public ActiveDirectoryGpoSettingsData Set(
        System.String? Data = null,
        System.String? DomainSid = null,
        System.String? GpoId = null,
        System.String? SnapshotId = null
    ) 
    {
        if ( Data != null ) {
            this.Data = Data;
        }
        if ( DomainSid != null ) {
            this.DomainSid = DomainSid;
        }
        if ( GpoId != null ) {
            this.GpoId = GpoId;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
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
        //      C# -> System.String? Data
        // GraphQL -> data: String! (scalar)
        if (this.Data != null) {
            if (conf.Flat) {
                s += conf.Prefix + "data\n" ;
            } else {
                s += ind + "data\n" ;
            }
        }
        //      C# -> System.String? DomainSid
        // GraphQL -> domainSid: String! (scalar)
        if (this.DomainSid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainSid\n" ;
            } else {
                s += ind + "domainSid\n" ;
            }
        }
        //      C# -> System.String? GpoId
        // GraphQL -> gpoId: String! (scalar)
        if (this.GpoId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "gpoId\n" ;
            } else {
                s += ind + "gpoId\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Data
        // GraphQL -> data: String! (scalar)
        if (ec.Includes("data",true))
        {
            if(this.Data == null) {

                this.Data = "FETCH";

            } else {


            }
        }
        else if (this.Data != null && ec.Excludes("data",true))
        {
            this.Data = null;
        }
        //      C# -> System.String? DomainSid
        // GraphQL -> domainSid: String! (scalar)
        if (ec.Includes("domainSid",true))
        {
            if(this.DomainSid == null) {

                this.DomainSid = "FETCH";

            } else {


            }
        }
        else if (this.DomainSid != null && ec.Excludes("domainSid",true))
        {
            this.DomainSid = null;
        }
        //      C# -> System.String? GpoId
        // GraphQL -> gpoId: String! (scalar)
        if (ec.Includes("gpoId",true))
        {
            if(this.GpoId == null) {

                this.GpoId = "FETCH";

            } else {


            }
        }
        else if (this.GpoId != null && ec.Excludes("gpoId",true))
        {
            this.GpoId = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
    }


    #endregion

    } // class ActiveDirectoryGpoSettingsData
    
    #endregion

    public static class ListActiveDirectoryGpoSettingsDataExtensions
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
            this List<ActiveDirectoryGpoSettingsData> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActiveDirectoryGpoSettingsData> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActiveDirectoryGpoSettingsData> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActiveDirectoryGpoSettingsData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActiveDirectoryGpoSettingsData> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types