// NcdSlaComplianceData.cs
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
    #region NcdSlaComplianceData
    public class NcdSlaComplianceData: BaseType
    {
        #region members

        //      C# -> System.Int32? JobsFailing
        // GraphQL -> jobsFailing: Int! (scalar)
        [JsonProperty("jobsFailing")]
        public System.Int32? JobsFailing { get; set; }

        //      C# -> System.Int32? JobsPassing
        // GraphQL -> jobsPassing: Int! (scalar)
        [JsonProperty("jobsPassing")]
        public System.Int32? JobsPassing { get; set; }

        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NcdSlaComplianceData";
    }

    public NcdSlaComplianceData Set(
        System.Int32? JobsFailing = null,
        System.Int32? JobsPassing = null,
        DateTime? Timestamp = null
    ) 
    {
        if ( JobsFailing != null ) {
            this.JobsFailing = JobsFailing;
        }
        if ( JobsPassing != null ) {
            this.JobsPassing = JobsPassing;
        }
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int32? JobsFailing
        // GraphQL -> jobsFailing: Int! (scalar)
        if (this.JobsFailing != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobsFailing\n" ;
            } else {
                s += ind + "jobsFailing\n" ;
            }
        }
        //      C# -> System.Int32? JobsPassing
        // GraphQL -> jobsPassing: Int! (scalar)
        if (this.JobsPassing != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobsPassing\n" ;
            } else {
                s += ind + "jobsPassing\n" ;
            }
        }
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (this.Timestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timestamp\n" ;
            } else {
                s += ind + "timestamp\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? JobsFailing
        // GraphQL -> jobsFailing: Int! (scalar)
        if (ec.Includes("jobsFailing",true))
        {
            if(this.JobsFailing == null) {

                this.JobsFailing = Int32.MinValue;

            } else {


            }
        }
        else if (this.JobsFailing != null && ec.Excludes("jobsFailing",true))
        {
            this.JobsFailing = null;
        }
        //      C# -> System.Int32? JobsPassing
        // GraphQL -> jobsPassing: Int! (scalar)
        if (ec.Includes("jobsPassing",true))
        {
            if(this.JobsPassing == null) {

                this.JobsPassing = Int32.MinValue;

            } else {


            }
        }
        else if (this.JobsPassing != null && ec.Excludes("jobsPassing",true))
        {
            this.JobsPassing = null;
        }
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (ec.Includes("timestamp",true))
        {
            if(this.Timestamp == null) {

                this.Timestamp = new DateTime();

            } else {


            }
        }
        else if (this.Timestamp != null && ec.Excludes("timestamp",true))
        {
            this.Timestamp = null;
        }
    }


    #endregion

    } // class NcdSlaComplianceData
    
    #endregion

    public static class ListNcdSlaComplianceDataExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<NcdSlaComplianceData> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NcdSlaComplianceData> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NcdSlaComplianceData> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NcdSlaComplianceData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NcdSlaComplianceData> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types