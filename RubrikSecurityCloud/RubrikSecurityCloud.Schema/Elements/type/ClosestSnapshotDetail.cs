// ClosestSnapshotDetail.cs
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
    #region ClosestSnapshotDetail
    public class ClosestSnapshotDetail: BaseType
    {
        #region members

        //      C# -> GenericSnapshot? SnapshotDetail
        // GraphQL -> snapshotDetail: GenericSnapshot (interface)
        [JsonProperty("snapshotDetail")]
        public GenericSnapshot? SnapshotDetail { get; set; }

        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean! (scalar)
        [JsonProperty("isAnomaly")]
        public System.Boolean? IsAnomaly { get; set; }

        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        [JsonProperty("isQuarantined")]
        public System.Boolean? IsQuarantined { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClosestSnapshotDetail";
    }

    public ClosestSnapshotDetail Set(
        GenericSnapshot? SnapshotDetail = null,
        DateTime? Date = null,
        System.String? Id = null,
        System.Boolean? IsAnomaly = null,
        System.Boolean? IsQuarantined = null
    ) 
    {
        if ( SnapshotDetail != null ) {
            this.SnapshotDetail = SnapshotDetail;
        }
        if ( Date != null ) {
            this.Date = Date;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsAnomaly != null ) {
            this.IsAnomaly = IsAnomaly;
        }
        if ( IsQuarantined != null ) {
            this.IsQuarantined = IsQuarantined;
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
        //      C# -> GenericSnapshot? SnapshotDetail
        // GraphQL -> snapshotDetail: GenericSnapshot (interface)
        if (this.SnapshotDetail != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.SnapshotDetail, conf.Child("snapshotDetail"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotDetail" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        if (this.Date != null) {
            if (conf.Flat) {
                s += conf.Prefix + "date\n" ;
            } else {
                s += ind + "date\n" ;
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
        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean! (scalar)
        if (this.IsAnomaly != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAnomaly\n" ;
            } else {
                s += ind + "isAnomaly\n" ;
            }
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (this.IsQuarantined != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isQuarantined\n" ;
            } else {
                s += ind + "isQuarantined\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> GenericSnapshot? SnapshotDetail
        // GraphQL -> snapshotDetail: GenericSnapshot (interface)
        if (ec.Includes("snapshotDetail",false))
        {
            if(this.SnapshotDetail == null) {

                var impls = new List<GenericSnapshot>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("snapshotDetail"));
                this.SnapshotDetail = (GenericSnapshot)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<GenericSnapshot>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("snapshotDetail"));
                this.SnapshotDetail = (GenericSnapshot)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.SnapshotDetail != null && ec.Excludes("snapshotDetail",false))
        {
            this.SnapshotDetail = null;
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        if (ec.Includes("date",true))
        {
            if(this.Date == null) {

                this.Date = new DateTime();

            } else {


            }
        }
        else if (this.Date != null && ec.Excludes("date",true))
        {
            this.Date = null;
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
        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean! (scalar)
        if (ec.Includes("isAnomaly",true))
        {
            if(this.IsAnomaly == null) {

                this.IsAnomaly = true;

            } else {


            }
        }
        else if (this.IsAnomaly != null && ec.Excludes("isAnomaly",true))
        {
            this.IsAnomaly = null;
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (ec.Includes("isQuarantined",true))
        {
            if(this.IsQuarantined == null) {

                this.IsQuarantined = true;

            } else {


            }
        }
        else if (this.IsQuarantined != null && ec.Excludes("isQuarantined",true))
        {
            this.IsQuarantined = null;
        }
    }


    #endregion

    } // class ClosestSnapshotDetail
    
    #endregion

    public static class ListClosestSnapshotDetailExtensions
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
            this List<ClosestSnapshotDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClosestSnapshotDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClosestSnapshotDetail> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClosestSnapshotDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClosestSnapshotDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types