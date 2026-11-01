// CloudDirectCopyScheduleDetail.cs
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
    #region CloudDirectCopyScheduleDetail
    public class CloudDirectCopyScheduleDetail: BaseType
    {
        #region members

        //      C# -> CloudDirectCopyScheduleItem? Schedule
        // GraphQL -> schedule: CloudDirectCopyScheduleItem (type)
        [JsonProperty("schedule")]
        public CloudDirectCopyScheduleItem? Schedule { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudDirectCopyScheduleDetail";
    }

    public CloudDirectCopyScheduleDetail Set(
        CloudDirectCopyScheduleItem? Schedule = null
    ) 
    {
        if ( Schedule != null ) {
            this.Schedule = Schedule;
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
        //      C# -> CloudDirectCopyScheduleItem? Schedule
        // GraphQL -> schedule: CloudDirectCopyScheduleItem (type)
        if (this.Schedule != null) {
            var fspec = this.Schedule.AsFieldSpec(conf.Child("schedule"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "schedule" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CloudDirectCopyScheduleItem? Schedule
        // GraphQL -> schedule: CloudDirectCopyScheduleItem (type)
        if (ec.Includes("schedule",false))
        {
            if(this.Schedule == null) {

                this.Schedule = new CloudDirectCopyScheduleItem();
                this.Schedule.ApplyExploratoryFieldSpec(ec.NewChild("schedule"));

            } else {

                this.Schedule.ApplyExploratoryFieldSpec(ec.NewChild("schedule"));

            }
        }
        else if (this.Schedule != null && ec.Excludes("schedule",false))
        {
            this.Schedule = null;
        }
    }


    #endregion

    } // class CloudDirectCopyScheduleDetail
    
    #endregion

    public static class ListCloudDirectCopyScheduleDetailExtensions
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
            this List<CloudDirectCopyScheduleDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudDirectCopyScheduleDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudDirectCopyScheduleDetail> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudDirectCopyScheduleDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudDirectCopyScheduleDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types