// HaPolicy.cs
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
    #region HaPolicy
    public class HaPolicy: BaseType
    {
        #region members

        //      C# -> FailoverGroupStatus? Status
        // GraphQL -> status: FailoverGroupStatus! (enum)
        [JsonProperty("status")]
        public FailoverGroupStatus? Status { get; set; }

        //      C# -> System.Int32? ArchivalLocationCount
        // GraphQL -> archivalLocationCount: Int! (scalar)
        [JsonProperty("archivalLocationCount")]
        public System.Int32? ArchivalLocationCount { get; set; }

        //      C# -> System.String? CreationTime
        // GraphQL -> creationTime: String! (scalar)
        [JsonProperty("creationTime")]
        public System.String? CreationTime { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.Int32? HostCount
        // GraphQL -> hostCount: Int! (scalar)
        [JsonProperty("hostCount")]
        public System.Int32? HostCount { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? LastUpdatedTime
        // GraphQL -> lastUpdatedTime: String! (scalar)
        [JsonProperty("lastUpdatedTime")]
        public System.String? LastUpdatedTime { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PrimaryClusterUuid
        // GraphQL -> primaryClusterUuid: UUID! (scalar)
        [JsonProperty("primaryClusterUuid")]
        public System.String? PrimaryClusterUuid { get; set; }

        //      C# -> List<System.String>? SecondaryClusterUuids
        // GraphQL -> secondaryClusterUuids: [UUID!]! (scalar)
        [JsonProperty("secondaryClusterUuids")]
        public List<System.String>? SecondaryClusterUuids { get; set; }

        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        [JsonProperty("statusMessage")]
        public System.String? StatusMessage { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HaPolicy";
    }

    public HaPolicy Set(
        FailoverGroupStatus? Status = null,
        System.Int32? ArchivalLocationCount = null,
        System.String? CreationTime = null,
        System.String? Description = null,
        System.Int32? HostCount = null,
        System.String? Id = null,
        System.String? LastUpdatedTime = null,
        System.String? Name = null,
        System.String? PrimaryClusterUuid = null,
        List<System.String>? SecondaryClusterUuids = null,
        System.String? StatusMessage = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( ArchivalLocationCount != null ) {
            this.ArchivalLocationCount = ArchivalLocationCount;
        }
        if ( CreationTime != null ) {
            this.CreationTime = CreationTime;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( HostCount != null ) {
            this.HostCount = HostCount;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LastUpdatedTime != null ) {
            this.LastUpdatedTime = LastUpdatedTime;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PrimaryClusterUuid != null ) {
            this.PrimaryClusterUuid = PrimaryClusterUuid;
        }
        if ( SecondaryClusterUuids != null ) {
            this.SecondaryClusterUuids = SecondaryClusterUuids;
        }
        if ( StatusMessage != null ) {
            this.StatusMessage = StatusMessage;
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
        //      C# -> FailoverGroupStatus? Status
        // GraphQL -> status: FailoverGroupStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.Int32? ArchivalLocationCount
        // GraphQL -> archivalLocationCount: Int! (scalar)
        if (this.ArchivalLocationCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archivalLocationCount\n" ;
            } else {
                s += ind + "archivalLocationCount\n" ;
            }
        }
        //      C# -> System.String? CreationTime
        // GraphQL -> creationTime: String! (scalar)
        if (this.CreationTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "creationTime\n" ;
            } else {
                s += ind + "creationTime\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> System.Int32? HostCount
        // GraphQL -> hostCount: Int! (scalar)
        if (this.HostCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostCount\n" ;
            } else {
                s += ind + "hostCount\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? LastUpdatedTime
        // GraphQL -> lastUpdatedTime: String! (scalar)
        if (this.LastUpdatedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastUpdatedTime\n" ;
            } else {
                s += ind + "lastUpdatedTime\n" ;
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
        //      C# -> System.String? PrimaryClusterUuid
        // GraphQL -> primaryClusterUuid: UUID! (scalar)
        if (this.PrimaryClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryClusterUuid\n" ;
            } else {
                s += ind + "primaryClusterUuid\n" ;
            }
        }
        //      C# -> List<System.String>? SecondaryClusterUuids
        // GraphQL -> secondaryClusterUuids: [UUID!]! (scalar)
        if (this.SecondaryClusterUuids != null) {
            if (conf.Flat) {
                s += conf.Prefix + "secondaryClusterUuids\n" ;
            } else {
                s += ind + "secondaryClusterUuids\n" ;
            }
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        if (this.StatusMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "statusMessage\n" ;
            } else {
                s += ind + "statusMessage\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> FailoverGroupStatus? Status
        // GraphQL -> status: FailoverGroupStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new FailoverGroupStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.Int32? ArchivalLocationCount
        // GraphQL -> archivalLocationCount: Int! (scalar)
        if (ec.Includes("archivalLocationCount",true))
        {
            if(this.ArchivalLocationCount == null) {

                this.ArchivalLocationCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ArchivalLocationCount != null && ec.Excludes("archivalLocationCount",true))
        {
            this.ArchivalLocationCount = null;
        }
        //      C# -> System.String? CreationTime
        // GraphQL -> creationTime: String! (scalar)
        if (ec.Includes("creationTime",true))
        {
            if(this.CreationTime == null) {

                this.CreationTime = "FETCH";

            } else {


            }
        }
        else if (this.CreationTime != null && ec.Excludes("creationTime",true))
        {
            this.CreationTime = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
        }
        //      C# -> System.Int32? HostCount
        // GraphQL -> hostCount: Int! (scalar)
        if (ec.Includes("hostCount",true))
        {
            if(this.HostCount == null) {

                this.HostCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.HostCount != null && ec.Excludes("hostCount",true))
        {
            this.HostCount = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
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
        //      C# -> System.String? LastUpdatedTime
        // GraphQL -> lastUpdatedTime: String! (scalar)
        if (ec.Includes("lastUpdatedTime",true))
        {
            if(this.LastUpdatedTime == null) {

                this.LastUpdatedTime = "FETCH";

            } else {


            }
        }
        else if (this.LastUpdatedTime != null && ec.Excludes("lastUpdatedTime",true))
        {
            this.LastUpdatedTime = null;
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
        //      C# -> System.String? PrimaryClusterUuid
        // GraphQL -> primaryClusterUuid: UUID! (scalar)
        if (ec.Includes("primaryClusterUuid",true))
        {
            if(this.PrimaryClusterUuid == null) {

                this.PrimaryClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryClusterUuid != null && ec.Excludes("primaryClusterUuid",true))
        {
            this.PrimaryClusterUuid = null;
        }
        //      C# -> List<System.String>? SecondaryClusterUuids
        // GraphQL -> secondaryClusterUuids: [UUID!]! (scalar)
        if (ec.Includes("secondaryClusterUuids",true))
        {
            if(this.SecondaryClusterUuids == null) {

                this.SecondaryClusterUuids = new List<System.String>();

            } else {


            }
        }
        else if (this.SecondaryClusterUuids != null && ec.Excludes("secondaryClusterUuids",true))
        {
            this.SecondaryClusterUuids = null;
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        if (ec.Includes("statusMessage",true))
        {
            if(this.StatusMessage == null) {

                this.StatusMessage = "FETCH";

            } else {


            }
        }
        else if (this.StatusMessage != null && ec.Excludes("statusMessage",true))
        {
            this.StatusMessage = null;
        }
    }


    #endregion

    } // class HaPolicy
    
    #endregion

    public static class ListHaPolicyExtensions
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
            this List<HaPolicy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HaPolicy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HaPolicy> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HaPolicy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HaPolicy> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types