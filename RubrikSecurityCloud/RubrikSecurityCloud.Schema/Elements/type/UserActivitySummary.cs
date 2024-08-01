// UserActivitySummary.cs
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
    #region UserActivitySummary
    public class UserActivitySummary: BaseType
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Sid
        // GraphQL -> sid: String! (scalar)
        [JsonProperty("sid")]
        public System.String? Sid { get; set; }

        //      C# -> ActivitySummary? ActivitySummary
        // GraphQL -> activitySummary: ActivitySummary (type)
        [JsonProperty("activitySummary")]
        public ActivitySummary? ActivitySummary { get; set; }

        //      C# -> ActivitySummary? DeltaActivitySummary
        // GraphQL -> deltaActivitySummary: ActivitySummary (type)
        [JsonProperty("deltaActivitySummary")]
        public ActivitySummary? DeltaActivitySummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UserActivitySummary";
    }

    public UserActivitySummary Set(
        System.String? Name = null,
        System.String? Sid = null,
        ActivitySummary? ActivitySummary = null,
        ActivitySummary? DeltaActivitySummary = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Sid != null ) {
            this.Sid = Sid;
        }
        if ( ActivitySummary != null ) {
            this.ActivitySummary = ActivitySummary;
        }
        if ( DeltaActivitySummary != null ) {
            this.DeltaActivitySummary = DeltaActivitySummary;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? Sid
        // GraphQL -> sid: String! (scalar)
        if (this.Sid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sid\n" ;
            } else {
                s += ind + "sid\n" ;
            }
        }
        //      C# -> ActivitySummary? ActivitySummary
        // GraphQL -> activitySummary: ActivitySummary (type)
        if (this.ActivitySummary != null) {
            var fspec = this.ActivitySummary.AsFieldSpec(conf.Child("activitySummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "activitySummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ActivitySummary? DeltaActivitySummary
        // GraphQL -> deltaActivitySummary: ActivitySummary (type)
        if (this.DeltaActivitySummary != null) {
            var fspec = this.DeltaActivitySummary.AsFieldSpec(conf.Child("deltaActivitySummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "deltaActivitySummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> System.String? Sid
        // GraphQL -> sid: String! (scalar)
        if (ec.Includes("sid",true))
        {
            if(this.Sid == null) {

                this.Sid = "FETCH";

            } else {


            }
        }
        else if (this.Sid != null && ec.Excludes("sid",true))
        {
            this.Sid = null;
        }
        //      C# -> ActivitySummary? ActivitySummary
        // GraphQL -> activitySummary: ActivitySummary (type)
        if (ec.Includes("activitySummary",false))
        {
            if(this.ActivitySummary == null) {

                this.ActivitySummary = new ActivitySummary();
                this.ActivitySummary.ApplyExploratoryFieldSpec(ec.NewChild("activitySummary"));

            } else {

                this.ActivitySummary.ApplyExploratoryFieldSpec(ec.NewChild("activitySummary"));

            }
        }
        else if (this.ActivitySummary != null && ec.Excludes("activitySummary",false))
        {
            this.ActivitySummary = null;
        }
        //      C# -> ActivitySummary? DeltaActivitySummary
        // GraphQL -> deltaActivitySummary: ActivitySummary (type)
        if (ec.Includes("deltaActivitySummary",false))
        {
            if(this.DeltaActivitySummary == null) {

                this.DeltaActivitySummary = new ActivitySummary();
                this.DeltaActivitySummary.ApplyExploratoryFieldSpec(ec.NewChild("deltaActivitySummary"));

            } else {

                this.DeltaActivitySummary.ApplyExploratoryFieldSpec(ec.NewChild("deltaActivitySummary"));

            }
        }
        else if (this.DeltaActivitySummary != null && ec.Excludes("deltaActivitySummary",false))
        {
            this.DeltaActivitySummary = null;
        }
    }


    #endregion

    } // class UserActivitySummary
    
    #endregion

    public static class ListUserActivitySummaryExtensions
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
            this List<UserActivitySummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UserActivitySummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UserActivitySummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UserActivitySummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UserActivitySummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types