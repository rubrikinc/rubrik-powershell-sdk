// CloudNativeSnapshotInfo.cs
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
    #region CloudNativeSnapshotInfo
    public class CloudNativeSnapshotInfo: BaseType
    {
        #region members

        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        [JsonProperty("isOnDemandSnapshot")]
        public System.Boolean? IsOnDemandSnapshot { get; set; }

        //      C# -> System.Boolean? IsQuarantineProcessing
        // GraphQL -> isQuarantineProcessing: Boolean! (scalar)
        [JsonProperty("isQuarantineProcessing")]
        public System.Boolean? IsQuarantineProcessing { get; set; }

        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        [JsonProperty("isQuarantined")]
        public System.Boolean? IsQuarantined { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudNativeSnapshotInfo";
    }

    public CloudNativeSnapshotInfo Set(
        DateTime? Date = null,
        System.String? Id = null,
        System.Boolean? IsOnDemandSnapshot = null,
        System.Boolean? IsQuarantineProcessing = null,
        System.Boolean? IsQuarantined = null
    ) 
    {
        if ( Date != null ) {
            this.Date = Date;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsOnDemandSnapshot != null ) {
            this.IsOnDemandSnapshot = IsOnDemandSnapshot;
        }
        if ( IsQuarantineProcessing != null ) {
            this.IsQuarantineProcessing = IsQuarantineProcessing;
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
        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        if (this.IsOnDemandSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOnDemandSnapshot\n" ;
            } else {
                s += ind + "isOnDemandSnapshot\n" ;
            }
        }
        //      C# -> System.Boolean? IsQuarantineProcessing
        // GraphQL -> isQuarantineProcessing: Boolean! (scalar)
        if (this.IsQuarantineProcessing != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isQuarantineProcessing\n" ;
            } else {
                s += ind + "isQuarantineProcessing\n" ;
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
        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        if (ec.Includes("isOnDemandSnapshot",true))
        {
            if(this.IsOnDemandSnapshot == null) {

                this.IsOnDemandSnapshot = true;

            } else {


            }
        }
        else if (this.IsOnDemandSnapshot != null && ec.Excludes("isOnDemandSnapshot",true))
        {
            this.IsOnDemandSnapshot = null;
        }
        //      C# -> System.Boolean? IsQuarantineProcessing
        // GraphQL -> isQuarantineProcessing: Boolean! (scalar)
        if (ec.Includes("isQuarantineProcessing",true))
        {
            if(this.IsQuarantineProcessing == null) {

                this.IsQuarantineProcessing = true;

            } else {


            }
        }
        else if (this.IsQuarantineProcessing != null && ec.Excludes("isQuarantineProcessing",true))
        {
            this.IsQuarantineProcessing = null;
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

    } // class CloudNativeSnapshotInfo
    
    #endregion

    public static class ListCloudNativeSnapshotInfoExtensions
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
            this List<CloudNativeSnapshotInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudNativeSnapshotInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeSnapshotInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeSnapshotInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudNativeSnapshotInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types