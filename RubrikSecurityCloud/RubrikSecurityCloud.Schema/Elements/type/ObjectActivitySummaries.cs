// ObjectActivitySummaries.cs
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
    #region ObjectActivitySummaries
    public class ObjectActivitySummaries: BaseType
    {
        #region members

        //      C# -> ObjectActivitySummariesObjectType? ObjectActivitySummariesObjectType
        // GraphQL -> objectActivitySummariesObjectType: ObjectActivitySummariesObjectType! (enum)
        [JsonProperty("objectActivitySummariesObjectType")]
        public ObjectActivitySummariesObjectType? ObjectActivitySummariesObjectType { get; set; }

        //      C# -> RiskLevelType? ObjectRisk
        // GraphQL -> objectRisk: RiskLevelType! (enum)
        [JsonProperty("objectRisk")]
        public RiskLevelType? ObjectRisk { get; set; }

        //      C# -> System.Int32? DeltaNumUsersWithActivity
        // GraphQL -> deltaNumUsersWithActivity: Int! (scalar)
        [JsonProperty("deltaNumUsersWithActivity")]
        public System.Int32? DeltaNumUsersWithActivity { get; set; }

        //      C# -> System.Int32? NumUsersWithActivity
        // GraphQL -> numUsersWithActivity: Int! (scalar)
        [JsonProperty("numUsersWithActivity")]
        public System.Int32? NumUsersWithActivity { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        [JsonProperty("objectName")]
        public System.String? ObjectName { get; set; }

        //      C# -> ActivitySummary? CurrentActivitySummary
        // GraphQL -> currentActivitySummary: ActivitySummary (type)
        [JsonProperty("currentActivitySummary")]
        public ActivitySummary? CurrentActivitySummary { get; set; }

        //      C# -> ActivitySummary? DeltaActivitySummary
        // GraphQL -> deltaActivitySummary: ActivitySummary (type)
        [JsonProperty("deltaActivitySummary")]
        public ActivitySummary? DeltaActivitySummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ObjectActivitySummaries";
    }

    public ObjectActivitySummaries Set(
        ObjectActivitySummariesObjectType? ObjectActivitySummariesObjectType = null,
        RiskLevelType? ObjectRisk = null,
        System.Int32? DeltaNumUsersWithActivity = null,
        System.Int32? NumUsersWithActivity = null,
        System.String? ObjectId = null,
        System.String? ObjectName = null,
        ActivitySummary? CurrentActivitySummary = null,
        ActivitySummary? DeltaActivitySummary = null
    ) 
    {
        if ( ObjectActivitySummariesObjectType != null ) {
            this.ObjectActivitySummariesObjectType = ObjectActivitySummariesObjectType;
        }
        if ( ObjectRisk != null ) {
            this.ObjectRisk = ObjectRisk;
        }
        if ( DeltaNumUsersWithActivity != null ) {
            this.DeltaNumUsersWithActivity = DeltaNumUsersWithActivity;
        }
        if ( NumUsersWithActivity != null ) {
            this.NumUsersWithActivity = NumUsersWithActivity;
        }
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        if ( ObjectName != null ) {
            this.ObjectName = ObjectName;
        }
        if ( CurrentActivitySummary != null ) {
            this.CurrentActivitySummary = CurrentActivitySummary;
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
        //      C# -> ObjectActivitySummariesObjectType? ObjectActivitySummariesObjectType
        // GraphQL -> objectActivitySummariesObjectType: ObjectActivitySummariesObjectType! (enum)
        if (this.ObjectActivitySummariesObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectActivitySummariesObjectType\n" ;
            } else {
                s += ind + "objectActivitySummariesObjectType\n" ;
            }
        }
        //      C# -> RiskLevelType? ObjectRisk
        // GraphQL -> objectRisk: RiskLevelType! (enum)
        if (this.ObjectRisk != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectRisk\n" ;
            } else {
                s += ind + "objectRisk\n" ;
            }
        }
        //      C# -> System.Int32? DeltaNumUsersWithActivity
        // GraphQL -> deltaNumUsersWithActivity: Int! (scalar)
        if (this.DeltaNumUsersWithActivity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deltaNumUsersWithActivity\n" ;
            } else {
                s += ind + "deltaNumUsersWithActivity\n" ;
            }
        }
        //      C# -> System.Int32? NumUsersWithActivity
        // GraphQL -> numUsersWithActivity: Int! (scalar)
        if (this.NumUsersWithActivity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numUsersWithActivity\n" ;
            } else {
                s += ind + "numUsersWithActivity\n" ;
            }
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectId\n" ;
            } else {
                s += ind + "objectId\n" ;
            }
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (this.ObjectName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectName\n" ;
            } else {
                s += ind + "objectName\n" ;
            }
        }
        //      C# -> ActivitySummary? CurrentActivitySummary
        // GraphQL -> currentActivitySummary: ActivitySummary (type)
        if (this.CurrentActivitySummary != null) {
            var fspec = this.CurrentActivitySummary.AsFieldSpec(conf.Child("currentActivitySummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "currentActivitySummary" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> ObjectActivitySummariesObjectType? ObjectActivitySummariesObjectType
        // GraphQL -> objectActivitySummariesObjectType: ObjectActivitySummariesObjectType! (enum)
        if (ec.Includes("objectActivitySummariesObjectType",true))
        {
            if(this.ObjectActivitySummariesObjectType == null) {

                this.ObjectActivitySummariesObjectType = new ObjectActivitySummariesObjectType();

            } else {


            }
        }
        else if (this.ObjectActivitySummariesObjectType != null && ec.Excludes("objectActivitySummariesObjectType",true))
        {
            this.ObjectActivitySummariesObjectType = null;
        }
        //      C# -> RiskLevelType? ObjectRisk
        // GraphQL -> objectRisk: RiskLevelType! (enum)
        if (ec.Includes("objectRisk",true))
        {
            if(this.ObjectRisk == null) {

                this.ObjectRisk = new RiskLevelType();

            } else {


            }
        }
        else if (this.ObjectRisk != null && ec.Excludes("objectRisk",true))
        {
            this.ObjectRisk = null;
        }
        //      C# -> System.Int32? DeltaNumUsersWithActivity
        // GraphQL -> deltaNumUsersWithActivity: Int! (scalar)
        if (ec.Includes("deltaNumUsersWithActivity",true))
        {
            if(this.DeltaNumUsersWithActivity == null) {

                this.DeltaNumUsersWithActivity = Int32.MinValue;

            } else {


            }
        }
        else if (this.DeltaNumUsersWithActivity != null && ec.Excludes("deltaNumUsersWithActivity",true))
        {
            this.DeltaNumUsersWithActivity = null;
        }
        //      C# -> System.Int32? NumUsersWithActivity
        // GraphQL -> numUsersWithActivity: Int! (scalar)
        if (ec.Includes("numUsersWithActivity",true))
        {
            if(this.NumUsersWithActivity == null) {

                this.NumUsersWithActivity = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumUsersWithActivity != null && ec.Excludes("numUsersWithActivity",true))
        {
            this.NumUsersWithActivity = null;
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (ec.Includes("objectId",true))
        {
            if(this.ObjectId == null) {

                this.ObjectId = "FETCH";

            } else {


            }
        }
        else if (this.ObjectId != null && ec.Excludes("objectId",true))
        {
            this.ObjectId = null;
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (ec.Includes("objectName",true))
        {
            if(this.ObjectName == null) {

                this.ObjectName = "FETCH";

            } else {


            }
        }
        else if (this.ObjectName != null && ec.Excludes("objectName",true))
        {
            this.ObjectName = null;
        }
        //      C# -> ActivitySummary? CurrentActivitySummary
        // GraphQL -> currentActivitySummary: ActivitySummary (type)
        if (ec.Includes("currentActivitySummary",false))
        {
            if(this.CurrentActivitySummary == null) {

                this.CurrentActivitySummary = new ActivitySummary();
                this.CurrentActivitySummary.ApplyExploratoryFieldSpec(ec.NewChild("currentActivitySummary"));

            } else {

                this.CurrentActivitySummary.ApplyExploratoryFieldSpec(ec.NewChild("currentActivitySummary"));

            }
        }
        else if (this.CurrentActivitySummary != null && ec.Excludes("currentActivitySummary",false))
        {
            this.CurrentActivitySummary = null;
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

    } // class ObjectActivitySummaries
    
    #endregion

    public static class ListObjectActivitySummariesExtensions
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
            this List<ObjectActivitySummaries> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ObjectActivitySummaries> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ObjectActivitySummaries> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ObjectActivitySummaries());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ObjectActivitySummaries> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types