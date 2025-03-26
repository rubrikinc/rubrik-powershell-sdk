// O365PhysicalDataSizeTimeStamp.cs
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
    #region O365PhysicalDataSizeTimeStamp
    public class O365PhysicalDataSizeTimeStamp: BaseType
    {
        #region members

        //      C# -> System.Int64? PhysicalDataSizeInBytes
        // GraphQL -> physicalDataSizeInBytes: Long! (scalar)
        [JsonProperty("physicalDataSizeInBytes")]
        public System.Int64? PhysicalDataSizeInBytes { get; set; }

        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365PhysicalDataSizeTimeStamp";
    }

    public O365PhysicalDataSizeTimeStamp Set(
        System.Int64? PhysicalDataSizeInBytes = null,
        DateTime? Timestamp = null
    ) 
    {
        if ( PhysicalDataSizeInBytes != null ) {
            this.PhysicalDataSizeInBytes = PhysicalDataSizeInBytes;
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
        //      C# -> System.Int64? PhysicalDataSizeInBytes
        // GraphQL -> physicalDataSizeInBytes: Long! (scalar)
        if (this.PhysicalDataSizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "physicalDataSizeInBytes\n" ;
            } else {
                s += ind + "physicalDataSizeInBytes\n" ;
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
        //      C# -> System.Int64? PhysicalDataSizeInBytes
        // GraphQL -> physicalDataSizeInBytes: Long! (scalar)
        if (ec.Includes("physicalDataSizeInBytes",true))
        {
            if(this.PhysicalDataSizeInBytes == null) {

                this.PhysicalDataSizeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.PhysicalDataSizeInBytes != null && ec.Excludes("physicalDataSizeInBytes",true))
        {
            this.PhysicalDataSizeInBytes = null;
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

    } // class O365PhysicalDataSizeTimeStamp
    
    #endregion

    public static class ListO365PhysicalDataSizeTimeStampExtensions
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
            this List<O365PhysicalDataSizeTimeStamp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365PhysicalDataSizeTimeStamp> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365PhysicalDataSizeTimeStamp> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365PhysicalDataSizeTimeStamp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365PhysicalDataSizeTimeStamp> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types