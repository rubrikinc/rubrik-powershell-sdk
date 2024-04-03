// MssqlLogShippingSummary.cs
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
    #region MssqlLogShippingSummary
    public class MssqlLogShippingSummary: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int64? LagTime
        // GraphQL -> lagTime: Long (scalar)
        [JsonProperty("lagTime")]
        public System.Int64? LagTime { get; set; }

        //      C# -> DateTime? LastAppliedPoint
        // GraphQL -> lastAppliedPoint: DateTime (scalar)
        [JsonProperty("lastAppliedPoint")]
        public DateTime? LastAppliedPoint { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.String? PrimaryDatabaseId
        // GraphQL -> primaryDatabaseId: String! (scalar)
        [JsonProperty("primaryDatabaseId")]
        public System.String? PrimaryDatabaseId { get; set; }

        //      C# -> System.Int64? PrimaryDatabaseLogBackupFrequency
        // GraphQL -> primaryDatabaseLogBackupFrequency: Long (scalar)
        [JsonProperty("primaryDatabaseLogBackupFrequency")]
        public System.Int64? PrimaryDatabaseLogBackupFrequency { get; set; }

        //      C# -> System.String? PrimaryDatabaseName
        // GraphQL -> primaryDatabaseName: String! (scalar)
        [JsonProperty("primaryDatabaseName")]
        public System.String? PrimaryDatabaseName { get; set; }

        //      C# -> System.String? SecondaryDatabaseId
        // GraphQL -> secondaryDatabaseId: String (scalar)
        [JsonProperty("secondaryDatabaseId")]
        public System.String? SecondaryDatabaseId { get; set; }

        //      C# -> System.String? SecondaryDatabaseName
        // GraphQL -> secondaryDatabaseName: String! (scalar)
        [JsonProperty("secondaryDatabaseName")]
        public System.String? SecondaryDatabaseName { get; set; }

        //      C# -> System.String? State
        // GraphQL -> state: String (scalar)
        [JsonProperty("state")]
        public System.String? State { get; set; }

        //      C# -> MssqlLogShippingStatusInfo? Status
        // GraphQL -> status: MssqlLogShippingStatusInfo (type)
        [JsonProperty("status")]
        public MssqlLogShippingStatusInfo? Status { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlLogShippingSummary";
    }

    public MssqlLogShippingSummary Set(
        System.String? Id = null,
        System.Int64? LagTime = null,
        DateTime? LastAppliedPoint = null,
        System.String? Location = null,
        System.String? PrimaryDatabaseId = null,
        System.Int64? PrimaryDatabaseLogBackupFrequency = null,
        System.String? PrimaryDatabaseName = null,
        System.String? SecondaryDatabaseId = null,
        System.String? SecondaryDatabaseName = null,
        System.String? State = null,
        MssqlLogShippingStatusInfo? Status = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LagTime != null ) {
            this.LagTime = LagTime;
        }
        if ( LastAppliedPoint != null ) {
            this.LastAppliedPoint = LastAppliedPoint;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( PrimaryDatabaseId != null ) {
            this.PrimaryDatabaseId = PrimaryDatabaseId;
        }
        if ( PrimaryDatabaseLogBackupFrequency != null ) {
            this.PrimaryDatabaseLogBackupFrequency = PrimaryDatabaseLogBackupFrequency;
        }
        if ( PrimaryDatabaseName != null ) {
            this.PrimaryDatabaseName = PrimaryDatabaseName;
        }
        if ( SecondaryDatabaseId != null ) {
            this.SecondaryDatabaseId = SecondaryDatabaseId;
        }
        if ( SecondaryDatabaseName != null ) {
            this.SecondaryDatabaseName = SecondaryDatabaseName;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        //      C# -> System.Int64? LagTime
        // GraphQL -> lagTime: Long (scalar)
        if (this.LagTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lagTime\n" ;
            } else {
                s += ind + "lagTime\n" ;
            }
        }
        //      C# -> DateTime? LastAppliedPoint
        // GraphQL -> lastAppliedPoint: DateTime (scalar)
        if (this.LastAppliedPoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastAppliedPoint\n" ;
            } else {
                s += ind + "lastAppliedPoint\n" ;
            }
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location != null) {
            if (conf.Flat) {
                s += conf.Prefix + "location\n" ;
            } else {
                s += ind + "location\n" ;
            }
        }
        //      C# -> System.String? PrimaryDatabaseId
        // GraphQL -> primaryDatabaseId: String! (scalar)
        if (this.PrimaryDatabaseId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryDatabaseId\n" ;
            } else {
                s += ind + "primaryDatabaseId\n" ;
            }
        }
        //      C# -> System.Int64? PrimaryDatabaseLogBackupFrequency
        // GraphQL -> primaryDatabaseLogBackupFrequency: Long (scalar)
        if (this.PrimaryDatabaseLogBackupFrequency != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryDatabaseLogBackupFrequency\n" ;
            } else {
                s += ind + "primaryDatabaseLogBackupFrequency\n" ;
            }
        }
        //      C# -> System.String? PrimaryDatabaseName
        // GraphQL -> primaryDatabaseName: String! (scalar)
        if (this.PrimaryDatabaseName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryDatabaseName\n" ;
            } else {
                s += ind + "primaryDatabaseName\n" ;
            }
        }
        //      C# -> System.String? SecondaryDatabaseId
        // GraphQL -> secondaryDatabaseId: String (scalar)
        if (this.SecondaryDatabaseId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "secondaryDatabaseId\n" ;
            } else {
                s += ind + "secondaryDatabaseId\n" ;
            }
        }
        //      C# -> System.String? SecondaryDatabaseName
        // GraphQL -> secondaryDatabaseName: String! (scalar)
        if (this.SecondaryDatabaseName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "secondaryDatabaseName\n" ;
            } else {
                s += ind + "secondaryDatabaseName\n" ;
            }
        }
        //      C# -> System.String? State
        // GraphQL -> state: String (scalar)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> MssqlLogShippingStatusInfo? Status
        // GraphQL -> status: MssqlLogShippingStatusInfo (type)
        if (this.Status != null) {
            var fspec = this.Status.AsFieldSpec(conf.Child("status"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "status" + " " + "{\n" + fspec + ind + "}\n" ;
                }
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
        //      C# -> System.Int64? LagTime
        // GraphQL -> lagTime: Long (scalar)
        if (ec.Includes("lagTime",true))
        {
            if(this.LagTime == null) {

                this.LagTime = new System.Int64();

            } else {


            }
        }
        else if (this.LagTime != null && ec.Excludes("lagTime",true))
        {
            this.LagTime = null;
        }
        //      C# -> DateTime? LastAppliedPoint
        // GraphQL -> lastAppliedPoint: DateTime (scalar)
        if (ec.Includes("lastAppliedPoint",true))
        {
            if(this.LastAppliedPoint == null) {

                this.LastAppliedPoint = new DateTime();

            } else {


            }
        }
        else if (this.LastAppliedPoint != null && ec.Excludes("lastAppliedPoint",true))
        {
            this.LastAppliedPoint = null;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (ec.Includes("location",true))
        {
            if(this.Location == null) {

                this.Location = "FETCH";

            } else {


            }
        }
        else if (this.Location != null && ec.Excludes("location",true))
        {
            this.Location = null;
        }
        //      C# -> System.String? PrimaryDatabaseId
        // GraphQL -> primaryDatabaseId: String! (scalar)
        if (ec.Includes("primaryDatabaseId",true))
        {
            if(this.PrimaryDatabaseId == null) {

                this.PrimaryDatabaseId = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryDatabaseId != null && ec.Excludes("primaryDatabaseId",true))
        {
            this.PrimaryDatabaseId = null;
        }
        //      C# -> System.Int64? PrimaryDatabaseLogBackupFrequency
        // GraphQL -> primaryDatabaseLogBackupFrequency: Long (scalar)
        if (ec.Includes("primaryDatabaseLogBackupFrequency",true))
        {
            if(this.PrimaryDatabaseLogBackupFrequency == null) {

                this.PrimaryDatabaseLogBackupFrequency = new System.Int64();

            } else {


            }
        }
        else if (this.PrimaryDatabaseLogBackupFrequency != null && ec.Excludes("primaryDatabaseLogBackupFrequency",true))
        {
            this.PrimaryDatabaseLogBackupFrequency = null;
        }
        //      C# -> System.String? PrimaryDatabaseName
        // GraphQL -> primaryDatabaseName: String! (scalar)
        if (ec.Includes("primaryDatabaseName",true))
        {
            if(this.PrimaryDatabaseName == null) {

                this.PrimaryDatabaseName = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryDatabaseName != null && ec.Excludes("primaryDatabaseName",true))
        {
            this.PrimaryDatabaseName = null;
        }
        //      C# -> System.String? SecondaryDatabaseId
        // GraphQL -> secondaryDatabaseId: String (scalar)
        if (ec.Includes("secondaryDatabaseId",true))
        {
            if(this.SecondaryDatabaseId == null) {

                this.SecondaryDatabaseId = "FETCH";

            } else {


            }
        }
        else if (this.SecondaryDatabaseId != null && ec.Excludes("secondaryDatabaseId",true))
        {
            this.SecondaryDatabaseId = null;
        }
        //      C# -> System.String? SecondaryDatabaseName
        // GraphQL -> secondaryDatabaseName: String! (scalar)
        if (ec.Includes("secondaryDatabaseName",true))
        {
            if(this.SecondaryDatabaseName == null) {

                this.SecondaryDatabaseName = "FETCH";

            } else {


            }
        }
        else if (this.SecondaryDatabaseName != null && ec.Excludes("secondaryDatabaseName",true))
        {
            this.SecondaryDatabaseName = null;
        }
        //      C# -> System.String? State
        // GraphQL -> state: String (scalar)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = "FETCH";

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> MssqlLogShippingStatusInfo? Status
        // GraphQL -> status: MssqlLogShippingStatusInfo (type)
        if (ec.Includes("status",false))
        {
            if(this.Status == null) {

                this.Status = new MssqlLogShippingStatusInfo();
                this.Status.ApplyExploratoryFieldSpec(ec.NewChild("status"));

            } else {

                this.Status.ApplyExploratoryFieldSpec(ec.NewChild("status"));

            }
        }
        else if (this.Status != null && ec.Excludes("status",false))
        {
            this.Status = null;
        }
    }


    #endregion

    } // class MssqlLogShippingSummary
    
    #endregion

    public static class ListMssqlLogShippingSummaryExtensions
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
            this List<MssqlLogShippingSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MssqlLogShippingSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MssqlLogShippingSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlLogShippingSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlLogShippingSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types