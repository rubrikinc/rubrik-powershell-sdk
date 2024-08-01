// ObjectActivityDetails.cs
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
    #region ObjectActivityDetails
    public class ObjectActivityDetails: BaseType
    {
        #region members

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> List<PolicyActivitySummary>? ActivitySummariesPerPolicy
        // GraphQL -> activitySummariesPerPolicy: [PolicyActivitySummary!]! (type)
        [JsonProperty("activitySummariesPerPolicy")]
        public List<PolicyActivitySummary>? ActivitySummariesPerPolicy { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ObjectActivityDetails";
    }

    public ObjectActivityDetails Set(
        System.String? ObjectId = null,
        List<PolicyActivitySummary>? ActivitySummariesPerPolicy = null
    ) 
    {
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        if ( ActivitySummariesPerPolicy != null ) {
            this.ActivitySummariesPerPolicy = ActivitySummariesPerPolicy;
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
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectId\n" ;
            } else {
                s += ind + "objectId\n" ;
            }
        }
        //      C# -> List<PolicyActivitySummary>? ActivitySummariesPerPolicy
        // GraphQL -> activitySummariesPerPolicy: [PolicyActivitySummary!]! (type)
        if (this.ActivitySummariesPerPolicy != null) {
            var fspec = this.ActivitySummariesPerPolicy.AsFieldSpec(conf.Child("activitySummariesPerPolicy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "activitySummariesPerPolicy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> List<PolicyActivitySummary>? ActivitySummariesPerPolicy
        // GraphQL -> activitySummariesPerPolicy: [PolicyActivitySummary!]! (type)
        if (ec.Includes("activitySummariesPerPolicy",false))
        {
            if(this.ActivitySummariesPerPolicy == null) {

                this.ActivitySummariesPerPolicy = new List<PolicyActivitySummary>();
                this.ActivitySummariesPerPolicy.ApplyExploratoryFieldSpec(ec.NewChild("activitySummariesPerPolicy"));

            } else {

                this.ActivitySummariesPerPolicy.ApplyExploratoryFieldSpec(ec.NewChild("activitySummariesPerPolicy"));

            }
        }
        else if (this.ActivitySummariesPerPolicy != null && ec.Excludes("activitySummariesPerPolicy",false))
        {
            this.ActivitySummariesPerPolicy = null;
        }
    }


    #endregion

    } // class ObjectActivityDetails
    
    #endregion

    public static class ListObjectActivityDetailsExtensions
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
            this List<ObjectActivityDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ObjectActivityDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ObjectActivityDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ObjectActivityDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ObjectActivityDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types