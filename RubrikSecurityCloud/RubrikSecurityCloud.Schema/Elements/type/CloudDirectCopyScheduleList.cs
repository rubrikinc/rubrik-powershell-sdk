// CloudDirectCopyScheduleList.cs
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
    #region CloudDirectCopyScheduleList
    public class CloudDirectCopyScheduleList: BaseType
    {
        #region members

        //      C# -> System.String? NextPageCursor
        // GraphQL -> nextPageCursor: String! (scalar)
        [JsonProperty("nextPageCursor")]
        public System.String? NextPageCursor { get; set; }

        //      C# -> List<CloudDirectCopyScheduleItem>? Schedules
        // GraphQL -> schedules: [CloudDirectCopyScheduleItem!]! (type)
        [JsonProperty("schedules")]
        public List<CloudDirectCopyScheduleItem>? Schedules { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudDirectCopyScheduleList";
    }

    public CloudDirectCopyScheduleList Set(
        System.String? NextPageCursor = null,
        List<CloudDirectCopyScheduleItem>? Schedules = null
    ) 
    {
        if ( NextPageCursor != null ) {
            this.NextPageCursor = NextPageCursor;
        }
        if ( Schedules != null ) {
            this.Schedules = Schedules;
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
        //      C# -> System.String? NextPageCursor
        // GraphQL -> nextPageCursor: String! (scalar)
        if (this.NextPageCursor != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nextPageCursor\n" ;
            } else {
                s += ind + "nextPageCursor\n" ;
            }
        }
        //      C# -> List<CloudDirectCopyScheduleItem>? Schedules
        // GraphQL -> schedules: [CloudDirectCopyScheduleItem!]! (type)
        if (this.Schedules != null) {
            var fspec = this.Schedules.AsFieldSpec(conf.Child("schedules"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "schedules" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? NextPageCursor
        // GraphQL -> nextPageCursor: String! (scalar)
        if (ec.Includes("nextPageCursor",true))
        {
            if(this.NextPageCursor == null) {

                this.NextPageCursor = "FETCH";

            } else {


            }
        }
        else if (this.NextPageCursor != null && ec.Excludes("nextPageCursor",true))
        {
            this.NextPageCursor = null;
        }
        //      C# -> List<CloudDirectCopyScheduleItem>? Schedules
        // GraphQL -> schedules: [CloudDirectCopyScheduleItem!]! (type)
        if (ec.Includes("schedules",false))
        {
            if(this.Schedules == null) {

                this.Schedules = new List<CloudDirectCopyScheduleItem>();
                this.Schedules.ApplyExploratoryFieldSpec(ec.NewChild("schedules"));

            } else {

                this.Schedules.ApplyExploratoryFieldSpec(ec.NewChild("schedules"));

            }
        }
        else if (this.Schedules != null && ec.Excludes("schedules",false))
        {
            this.Schedules = null;
        }
    }


    #endregion

    } // class CloudDirectCopyScheduleList
    
    #endregion

    public static class ListCloudDirectCopyScheduleListExtensions
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
            this List<CloudDirectCopyScheduleList> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudDirectCopyScheduleList> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudDirectCopyScheduleList> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudDirectCopyScheduleList());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudDirectCopyScheduleList> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types