// UserActivityResult.cs
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
    #region UserActivityResult
    public class UserActivityResult: BaseType
    {
        #region members

        //      C# -> System.Int64? NumActivities
        // GraphQL -> numActivities: Long! (scalar)
        [JsonProperty("numActivities")]
        public System.Int64? NumActivities { get; set; }

        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        [JsonProperty("paginationId")]
        public System.String? PaginationId { get; set; }

        //      C# -> List<ActivityResult>? NumActivitiesBreakdown
        // GraphQL -> numActivitiesBreakdown: [ActivityResult!]! (type)
        [JsonProperty("numActivitiesBreakdown")]
        public List<ActivityResult>? NumActivitiesBreakdown { get; set; }

        //      C# -> AccessUser? User
        // GraphQL -> user: AccessUser (type)
        [JsonProperty("user")]
        public AccessUser? User { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UserActivityResult";
    }

    public UserActivityResult Set(
        System.Int64? NumActivities = null,
        System.String? PaginationId = null,
        List<ActivityResult>? NumActivitiesBreakdown = null,
        AccessUser? User = null
    ) 
    {
        if ( NumActivities != null ) {
            this.NumActivities = NumActivities;
        }
        if ( PaginationId != null ) {
            this.PaginationId = PaginationId;
        }
        if ( NumActivitiesBreakdown != null ) {
            this.NumActivitiesBreakdown = NumActivitiesBreakdown;
        }
        if ( User != null ) {
            this.User = User;
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
        //      C# -> System.Int64? NumActivities
        // GraphQL -> numActivities: Long! (scalar)
        if (this.NumActivities != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numActivities\n" ;
            } else {
                s += ind + "numActivities\n" ;
            }
        }
        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        if (this.PaginationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "paginationId\n" ;
            } else {
                s += ind + "paginationId\n" ;
            }
        }
        //      C# -> List<ActivityResult>? NumActivitiesBreakdown
        // GraphQL -> numActivitiesBreakdown: [ActivityResult!]! (type)
        if (this.NumActivitiesBreakdown != null) {
            var fspec = this.NumActivitiesBreakdown.AsFieldSpec(conf.Child("numActivitiesBreakdown"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "numActivitiesBreakdown {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AccessUser? User
        // GraphQL -> user: AccessUser (type)
        if (this.User != null) {
            var fspec = this.User.AsFieldSpec(conf.Child("user"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "user {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? NumActivities
        // GraphQL -> numActivities: Long! (scalar)
        if (ec.Includes("numActivities",true))
        {
            if(this.NumActivities == null) {

                this.NumActivities = new System.Int64();

            } else {


            }
        }
        else if (this.NumActivities != null && ec.Excludes("numActivities",true))
        {
            this.NumActivities = null;
        }
        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        if (ec.Includes("paginationId",true))
        {
            if(this.PaginationId == null) {

                this.PaginationId = "FETCH";

            } else {


            }
        }
        else if (this.PaginationId != null && ec.Excludes("paginationId",true))
        {
            this.PaginationId = null;
        }
        //      C# -> List<ActivityResult>? NumActivitiesBreakdown
        // GraphQL -> numActivitiesBreakdown: [ActivityResult!]! (type)
        if (ec.Includes("numActivitiesBreakdown",false))
        {
            if(this.NumActivitiesBreakdown == null) {

                this.NumActivitiesBreakdown = new List<ActivityResult>();
                this.NumActivitiesBreakdown.ApplyExploratoryFieldSpec(ec.NewChild("numActivitiesBreakdown"));

            } else {

                this.NumActivitiesBreakdown.ApplyExploratoryFieldSpec(ec.NewChild("numActivitiesBreakdown"));

            }
        }
        else if (this.NumActivitiesBreakdown != null && ec.Excludes("numActivitiesBreakdown",false))
        {
            this.NumActivitiesBreakdown = null;
        }
        //      C# -> AccessUser? User
        // GraphQL -> user: AccessUser (type)
        if (ec.Includes("user",false))
        {
            if(this.User == null) {

                this.User = new AccessUser();
                this.User.ApplyExploratoryFieldSpec(ec.NewChild("user"));

            } else {

                this.User.ApplyExploratoryFieldSpec(ec.NewChild("user"));

            }
        }
        else if (this.User != null && ec.Excludes("user",false))
        {
            this.User = null;
        }
    }


    #endregion

    } // class UserActivityResult
    
    #endregion

    public static class ListUserActivityResultExtensions
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
            this List<UserActivityResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UserActivityResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UserActivityResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UserActivityResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UserActivityResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types