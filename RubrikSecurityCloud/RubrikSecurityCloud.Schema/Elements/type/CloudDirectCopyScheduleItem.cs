// CloudDirectCopyScheduleItem.cs
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
    #region CloudDirectCopyScheduleItem
    public class CloudDirectCopyScheduleItem: BaseType
    {
        #region members

        //      C# -> CopyScheduleFrequency? Frequency
        // GraphQL -> frequency: CopyScheduleFrequency! (enum)
        [JsonProperty("frequency")]
        public CopyScheduleFrequency? Frequency { get; set; }

        //      C# -> CopyScheduleTargetType? TargetType
        // GraphQL -> targetType: CopyScheduleTargetType! (enum)
        [JsonProperty("targetType")]
        public CopyScheduleTargetType? TargetType { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Int32? DayOfMonth
        // GraphQL -> dayOfMonth: Int (scalar)
        [JsonProperty("dayOfMonth")]
        public System.Int32? DayOfMonth { get; set; }

        //      C# -> System.Int32? DayOfWeek
        // GraphQL -> dayOfWeek: Int (scalar)
        [JsonProperty("dayOfWeek")]
        public System.Int32? DayOfWeek { get; set; }

        //      C# -> System.Int32? FrequencyValue
        // GraphQL -> frequencyValue: Int! (scalar)
        [JsonProperty("frequencyValue")]
        public System.Int32? FrequencyValue { get; set; }

        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        [JsonProperty("isEnabled")]
        public System.Boolean? IsEnabled { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ScheduleId
        // GraphQL -> scheduleId: UUID! (scalar)
        [JsonProperty("scheduleId")]
        public System.String? ScheduleId { get; set; }

        //      C# -> System.String? StartTime
        // GraphQL -> startTime: String! (scalar)
        [JsonProperty("startTime")]
        public System.String? StartTime { get; set; }

        //      C# -> CopyScheduleDestinationOutput? Destination
        // GraphQL -> destination: CopyScheduleDestinationOutput (type)
        [JsonProperty("destination")]
        public CopyScheduleDestinationOutput? Destination { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudDirectCopyScheduleItem";
    }

    public CloudDirectCopyScheduleItem Set(
        CopyScheduleFrequency? Frequency = null,
        CopyScheduleTargetType? TargetType = null,
        System.String? ClusterUuid = null,
        System.Int32? DayOfMonth = null,
        System.Int32? DayOfWeek = null,
        System.Int32? FrequencyValue = null,
        System.Boolean? IsEnabled = null,
        System.String? Name = null,
        System.String? ScheduleId = null,
        System.String? StartTime = null,
        CopyScheduleDestinationOutput? Destination = null
    ) 
    {
        if ( Frequency != null ) {
            this.Frequency = Frequency;
        }
        if ( TargetType != null ) {
            this.TargetType = TargetType;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( DayOfMonth != null ) {
            this.DayOfMonth = DayOfMonth;
        }
        if ( DayOfWeek != null ) {
            this.DayOfWeek = DayOfWeek;
        }
        if ( FrequencyValue != null ) {
            this.FrequencyValue = FrequencyValue;
        }
        if ( IsEnabled != null ) {
            this.IsEnabled = IsEnabled;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ScheduleId != null ) {
            this.ScheduleId = ScheduleId;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( Destination != null ) {
            this.Destination = Destination;
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
        //      C# -> CopyScheduleFrequency? Frequency
        // GraphQL -> frequency: CopyScheduleFrequency! (enum)
        if (this.Frequency != null) {
            if (conf.Flat) {
                s += conf.Prefix + "frequency\n" ;
            } else {
                s += ind + "frequency\n" ;
            }
        }
        //      C# -> CopyScheduleTargetType? TargetType
        // GraphQL -> targetType: CopyScheduleTargetType! (enum)
        if (this.TargetType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetType\n" ;
            } else {
                s += ind + "targetType\n" ;
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.Int32? DayOfMonth
        // GraphQL -> dayOfMonth: Int (scalar)
        if (this.DayOfMonth != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dayOfMonth\n" ;
            } else {
                s += ind + "dayOfMonth\n" ;
            }
        }
        //      C# -> System.Int32? DayOfWeek
        // GraphQL -> dayOfWeek: Int (scalar)
        if (this.DayOfWeek != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dayOfWeek\n" ;
            } else {
                s += ind + "dayOfWeek\n" ;
            }
        }
        //      C# -> System.Int32? FrequencyValue
        // GraphQL -> frequencyValue: Int! (scalar)
        if (this.FrequencyValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "frequencyValue\n" ;
            } else {
                s += ind + "frequencyValue\n" ;
            }
        }
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (this.IsEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEnabled\n" ;
            } else {
                s += ind + "isEnabled\n" ;
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
        //      C# -> System.String? ScheduleId
        // GraphQL -> scheduleId: UUID! (scalar)
        if (this.ScheduleId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scheduleId\n" ;
            } else {
                s += ind + "scheduleId\n" ;
            }
        }
        //      C# -> System.String? StartTime
        // GraphQL -> startTime: String! (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> CopyScheduleDestinationOutput? Destination
        // GraphQL -> destination: CopyScheduleDestinationOutput (type)
        if (this.Destination != null) {
            var fspec = this.Destination.AsFieldSpec(conf.Child("destination"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "destination" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CopyScheduleFrequency? Frequency
        // GraphQL -> frequency: CopyScheduleFrequency! (enum)
        if (ec.Includes("frequency",true))
        {
            if(this.Frequency == null) {

                this.Frequency = new CopyScheduleFrequency();

            } else {


            }
        }
        else if (this.Frequency != null && ec.Excludes("frequency",true))
        {
            this.Frequency = null;
        }
        //      C# -> CopyScheduleTargetType? TargetType
        // GraphQL -> targetType: CopyScheduleTargetType! (enum)
        if (ec.Includes("targetType",true))
        {
            if(this.TargetType == null) {

                this.TargetType = new CopyScheduleTargetType();

            } else {


            }
        }
        else if (this.TargetType != null && ec.Excludes("targetType",true))
        {
            this.TargetType = null;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.Int32? DayOfMonth
        // GraphQL -> dayOfMonth: Int (scalar)
        if (ec.Includes("dayOfMonth",true))
        {
            if(this.DayOfMonth == null) {

                this.DayOfMonth = Int32.MinValue;

            } else {


            }
        }
        else if (this.DayOfMonth != null && ec.Excludes("dayOfMonth",true))
        {
            this.DayOfMonth = null;
        }
        //      C# -> System.Int32? DayOfWeek
        // GraphQL -> dayOfWeek: Int (scalar)
        if (ec.Includes("dayOfWeek",true))
        {
            if(this.DayOfWeek == null) {

                this.DayOfWeek = Int32.MinValue;

            } else {


            }
        }
        else if (this.DayOfWeek != null && ec.Excludes("dayOfWeek",true))
        {
            this.DayOfWeek = null;
        }
        //      C# -> System.Int32? FrequencyValue
        // GraphQL -> frequencyValue: Int! (scalar)
        if (ec.Includes("frequencyValue",true))
        {
            if(this.FrequencyValue == null) {

                this.FrequencyValue = Int32.MinValue;

            } else {


            }
        }
        else if (this.FrequencyValue != null && ec.Excludes("frequencyValue",true))
        {
            this.FrequencyValue = null;
        }
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (ec.Includes("isEnabled",true))
        {
            if(this.IsEnabled == null) {

                this.IsEnabled = true;

            } else {


            }
        }
        else if (this.IsEnabled != null && ec.Excludes("isEnabled",true))
        {
            this.IsEnabled = null;
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
        //      C# -> System.String? ScheduleId
        // GraphQL -> scheduleId: UUID! (scalar)
        if (ec.Includes("scheduleId",true))
        {
            if(this.ScheduleId == null) {

                this.ScheduleId = "FETCH";

            } else {


            }
        }
        else if (this.ScheduleId != null && ec.Excludes("scheduleId",true))
        {
            this.ScheduleId = null;
        }
        //      C# -> System.String? StartTime
        // GraphQL -> startTime: String! (scalar)
        if (ec.Includes("startTime",true))
        {
            if(this.StartTime == null) {

                this.StartTime = "FETCH";

            } else {


            }
        }
        else if (this.StartTime != null && ec.Excludes("startTime",true))
        {
            this.StartTime = null;
        }
        //      C# -> CopyScheduleDestinationOutput? Destination
        // GraphQL -> destination: CopyScheduleDestinationOutput (type)
        if (ec.Includes("destination",false))
        {
            if(this.Destination == null) {

                this.Destination = new CopyScheduleDestinationOutput();
                this.Destination.ApplyExploratoryFieldSpec(ec.NewChild("destination"));

            } else {

                this.Destination.ApplyExploratoryFieldSpec(ec.NewChild("destination"));

            }
        }
        else if (this.Destination != null && ec.Excludes("destination",false))
        {
            this.Destination = null;
        }
    }


    #endregion

    } // class CloudDirectCopyScheduleItem
    
    #endregion

    public static class ListCloudDirectCopyScheduleItemExtensions
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
            this List<CloudDirectCopyScheduleItem> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudDirectCopyScheduleItem> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudDirectCopyScheduleItem> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudDirectCopyScheduleItem());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudDirectCopyScheduleItem> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types