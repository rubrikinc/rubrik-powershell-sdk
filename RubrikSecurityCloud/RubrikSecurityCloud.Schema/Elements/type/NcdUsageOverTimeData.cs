// NcdUsageOverTimeData.cs
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
    #region NcdUsageOverTimeData
    public class NcdUsageOverTimeData: BaseType
    {
        #region members

        //      C# -> System.Int64? ChangeInBytes
        // GraphQL -> changeInBytes: Long! (scalar)
        [JsonProperty("changeInBytes")]
        public System.Int64? ChangeInBytes { get; set; }

        //      C# -> System.Int64? NewInBytes
        // GraphQL -> newInBytes: Long! (scalar)
        [JsonProperty("newInBytes")]
        public System.Int64? NewInBytes { get; set; }

        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NcdUsageOverTimeData";
    }

    public NcdUsageOverTimeData Set(
        System.Int64? ChangeInBytes = null,
        System.Int64? NewInBytes = null,
        DateTime? Timestamp = null
    ) 
    {
        if ( ChangeInBytes != null ) {
            this.ChangeInBytes = ChangeInBytes;
        }
        if ( NewInBytes != null ) {
            this.NewInBytes = NewInBytes;
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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int64? ChangeInBytes
        // GraphQL -> changeInBytes: Long! (scalar)
        if (this.ChangeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "changeInBytes\n" ;
            } else {
                s += ind + "changeInBytes\n" ;
            }
        }
        //      C# -> System.Int64? NewInBytes
        // GraphQL -> newInBytes: Long! (scalar)
        if (this.NewInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newInBytes\n" ;
            } else {
                s += ind + "newInBytes\n" ;
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? ChangeInBytes
        // GraphQL -> changeInBytes: Long! (scalar)
        if (ec.Includes("changeInBytes",true))
        {
            if(this.ChangeInBytes == null) {

                this.ChangeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.ChangeInBytes != null && ec.Excludes("changeInBytes",true))
        {
            this.ChangeInBytes = null;
        }
        //      C# -> System.Int64? NewInBytes
        // GraphQL -> newInBytes: Long! (scalar)
        if (ec.Includes("newInBytes",true))
        {
            if(this.NewInBytes == null) {

                this.NewInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.NewInBytes != null && ec.Excludes("newInBytes",true))
        {
            this.NewInBytes = null;
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

    } // class NcdUsageOverTimeData
    
    #endregion

    public static class ListNcdUsageOverTimeDataExtensions
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
            this List<NcdUsageOverTimeData> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NcdUsageOverTimeData> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NcdUsageOverTimeData> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NcdUsageOverTimeData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NcdUsageOverTimeData> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types