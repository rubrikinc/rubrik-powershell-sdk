// FailoverGroupArchivalLocation.cs
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
    #region FailoverGroupArchivalLocation
    public class FailoverGroupArchivalLocation: BaseType
    {
        #region members

        //      C# -> ArchivalLocationStatus? SourceLocationStatus
        // GraphQL -> sourceLocationStatus: ArchivalLocationStatus! (enum)
        [JsonProperty("sourceLocationStatus")]
        public ArchivalLocationStatus? SourceLocationStatus { get; set; }

        //      C# -> ArchivalLocationStatus? TargetLocationStatus
        // GraphQL -> targetLocationStatus: ArchivalLocationStatus! (enum)
        [JsonProperty("targetLocationStatus")]
        public ArchivalLocationStatus? TargetLocationStatus { get; set; }

        //      C# -> System.String? SourceLocationId
        // GraphQL -> sourceLocationId: UUID! (scalar)
        [JsonProperty("sourceLocationId")]
        public System.String? SourceLocationId { get; set; }

        //      C# -> System.String? SourceLocationName
        // GraphQL -> sourceLocationName: String! (scalar)
        [JsonProperty("sourceLocationName")]
        public System.String? SourceLocationName { get; set; }

        //      C# -> DateTime? TargetLastRefreshTime
        // GraphQL -> targetLastRefreshTime: DateTime (scalar)
        [JsonProperty("targetLastRefreshTime")]
        public DateTime? TargetLastRefreshTime { get; set; }

        //      C# -> System.String? TargetLocationId
        // GraphQL -> targetLocationId: UUID! (scalar)
        [JsonProperty("targetLocationId")]
        public System.String? TargetLocationId { get; set; }

        //      C# -> System.String? TargetLocationName
        // GraphQL -> targetLocationName: String! (scalar)
        [JsonProperty("targetLocationName")]
        public System.String? TargetLocationName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailoverGroupArchivalLocation";
    }

    public FailoverGroupArchivalLocation Set(
        ArchivalLocationStatus? SourceLocationStatus = null,
        ArchivalLocationStatus? TargetLocationStatus = null,
        System.String? SourceLocationId = null,
        System.String? SourceLocationName = null,
        DateTime? TargetLastRefreshTime = null,
        System.String? TargetLocationId = null,
        System.String? TargetLocationName = null
    ) 
    {
        if ( SourceLocationStatus != null ) {
            this.SourceLocationStatus = SourceLocationStatus;
        }
        if ( TargetLocationStatus != null ) {
            this.TargetLocationStatus = TargetLocationStatus;
        }
        if ( SourceLocationId != null ) {
            this.SourceLocationId = SourceLocationId;
        }
        if ( SourceLocationName != null ) {
            this.SourceLocationName = SourceLocationName;
        }
        if ( TargetLastRefreshTime != null ) {
            this.TargetLastRefreshTime = TargetLastRefreshTime;
        }
        if ( TargetLocationId != null ) {
            this.TargetLocationId = TargetLocationId;
        }
        if ( TargetLocationName != null ) {
            this.TargetLocationName = TargetLocationName;
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
        //      C# -> ArchivalLocationStatus? SourceLocationStatus
        // GraphQL -> sourceLocationStatus: ArchivalLocationStatus! (enum)
        if (this.SourceLocationStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceLocationStatus\n" ;
            } else {
                s += ind + "sourceLocationStatus\n" ;
            }
        }
        //      C# -> ArchivalLocationStatus? TargetLocationStatus
        // GraphQL -> targetLocationStatus: ArchivalLocationStatus! (enum)
        if (this.TargetLocationStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetLocationStatus\n" ;
            } else {
                s += ind + "targetLocationStatus\n" ;
            }
        }
        //      C# -> System.String? SourceLocationId
        // GraphQL -> sourceLocationId: UUID! (scalar)
        if (this.SourceLocationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceLocationId\n" ;
            } else {
                s += ind + "sourceLocationId\n" ;
            }
        }
        //      C# -> System.String? SourceLocationName
        // GraphQL -> sourceLocationName: String! (scalar)
        if (this.SourceLocationName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceLocationName\n" ;
            } else {
                s += ind + "sourceLocationName\n" ;
            }
        }
        //      C# -> DateTime? TargetLastRefreshTime
        // GraphQL -> targetLastRefreshTime: DateTime (scalar)
        if (this.TargetLastRefreshTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetLastRefreshTime\n" ;
            } else {
                s += ind + "targetLastRefreshTime\n" ;
            }
        }
        //      C# -> System.String? TargetLocationId
        // GraphQL -> targetLocationId: UUID! (scalar)
        if (this.TargetLocationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetLocationId\n" ;
            } else {
                s += ind + "targetLocationId\n" ;
            }
        }
        //      C# -> System.String? TargetLocationName
        // GraphQL -> targetLocationName: String! (scalar)
        if (this.TargetLocationName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetLocationName\n" ;
            } else {
                s += ind + "targetLocationName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ArchivalLocationStatus? SourceLocationStatus
        // GraphQL -> sourceLocationStatus: ArchivalLocationStatus! (enum)
        if (ec.Includes("sourceLocationStatus",true))
        {
            if(this.SourceLocationStatus == null) {

                this.SourceLocationStatus = new ArchivalLocationStatus();

            } else {


            }
        }
        else if (this.SourceLocationStatus != null && ec.Excludes("sourceLocationStatus",true))
        {
            this.SourceLocationStatus = null;
        }
        //      C# -> ArchivalLocationStatus? TargetLocationStatus
        // GraphQL -> targetLocationStatus: ArchivalLocationStatus! (enum)
        if (ec.Includes("targetLocationStatus",true))
        {
            if(this.TargetLocationStatus == null) {

                this.TargetLocationStatus = new ArchivalLocationStatus();

            } else {


            }
        }
        else if (this.TargetLocationStatus != null && ec.Excludes("targetLocationStatus",true))
        {
            this.TargetLocationStatus = null;
        }
        //      C# -> System.String? SourceLocationId
        // GraphQL -> sourceLocationId: UUID! (scalar)
        if (ec.Includes("sourceLocationId",true))
        {
            if(this.SourceLocationId == null) {

                this.SourceLocationId = "FETCH";

            } else {


            }
        }
        else if (this.SourceLocationId != null && ec.Excludes("sourceLocationId",true))
        {
            this.SourceLocationId = null;
        }
        //      C# -> System.String? SourceLocationName
        // GraphQL -> sourceLocationName: String! (scalar)
        if (ec.Includes("sourceLocationName",true))
        {
            if(this.SourceLocationName == null) {

                this.SourceLocationName = "FETCH";

            } else {


            }
        }
        else if (this.SourceLocationName != null && ec.Excludes("sourceLocationName",true))
        {
            this.SourceLocationName = null;
        }
        //      C# -> DateTime? TargetLastRefreshTime
        // GraphQL -> targetLastRefreshTime: DateTime (scalar)
        if (ec.Includes("targetLastRefreshTime",true))
        {
            if(this.TargetLastRefreshTime == null) {

                this.TargetLastRefreshTime = new DateTime();

            } else {


            }
        }
        else if (this.TargetLastRefreshTime != null && ec.Excludes("targetLastRefreshTime",true))
        {
            this.TargetLastRefreshTime = null;
        }
        //      C# -> System.String? TargetLocationId
        // GraphQL -> targetLocationId: UUID! (scalar)
        if (ec.Includes("targetLocationId",true))
        {
            if(this.TargetLocationId == null) {

                this.TargetLocationId = "FETCH";

            } else {


            }
        }
        else if (this.TargetLocationId != null && ec.Excludes("targetLocationId",true))
        {
            this.TargetLocationId = null;
        }
        //      C# -> System.String? TargetLocationName
        // GraphQL -> targetLocationName: String! (scalar)
        if (ec.Includes("targetLocationName",true))
        {
            if(this.TargetLocationName == null) {

                this.TargetLocationName = "FETCH";

            } else {


            }
        }
        else if (this.TargetLocationName != null && ec.Excludes("targetLocationName",true))
        {
            this.TargetLocationName = null;
        }
    }


    #endregion

    } // class FailoverGroupArchivalLocation
    
    #endregion

    public static class ListFailoverGroupArchivalLocationExtensions
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
            this List<FailoverGroupArchivalLocation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FailoverGroupArchivalLocation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FailoverGroupArchivalLocation> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverGroupArchivalLocation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FailoverGroupArchivalLocation> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types