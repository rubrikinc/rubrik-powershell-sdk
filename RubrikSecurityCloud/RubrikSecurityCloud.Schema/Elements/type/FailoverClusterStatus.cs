// FailoverClusterStatus.cs
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
    #region FailoverClusterStatus
    public class FailoverClusterStatus: BaseType
    {
        #region members

        //      C# -> FailoverClusterConnectivityStatus? Connectivity
        // GraphQL -> connectivity: FailoverClusterConnectivityStatus! (enum)
        [JsonProperty("connectivity")]
        public FailoverClusterConnectivityStatus? Connectivity { get; set; }

        //      C# -> DateTime? TimestampMillis
        // GraphQL -> timestampMillis: DateTime (scalar)
        [JsonProperty("timestampMillis")]
        public DateTime? TimestampMillis { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailoverClusterStatus";
    }

    public FailoverClusterStatus Set(
        FailoverClusterConnectivityStatus? Connectivity = null,
        DateTime? TimestampMillis = null
    ) 
    {
        if ( Connectivity != null ) {
            this.Connectivity = Connectivity;
        }
        if ( TimestampMillis != null ) {
            this.TimestampMillis = TimestampMillis;
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
        //      C# -> FailoverClusterConnectivityStatus? Connectivity
        // GraphQL -> connectivity: FailoverClusterConnectivityStatus! (enum)
        if (this.Connectivity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "connectivity\n" ;
            } else {
                s += ind + "connectivity\n" ;
            }
        }
        //      C# -> DateTime? TimestampMillis
        // GraphQL -> timestampMillis: DateTime (scalar)
        if (this.TimestampMillis != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timestampMillis\n" ;
            } else {
                s += ind + "timestampMillis\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> FailoverClusterConnectivityStatus? Connectivity
        // GraphQL -> connectivity: FailoverClusterConnectivityStatus! (enum)
        if (ec.Includes("connectivity",true))
        {
            if(this.Connectivity == null) {

                this.Connectivity = new FailoverClusterConnectivityStatus();

            } else {


            }
        }
        else if (this.Connectivity != null && ec.Excludes("connectivity",true))
        {
            this.Connectivity = null;
        }
        //      C# -> DateTime? TimestampMillis
        // GraphQL -> timestampMillis: DateTime (scalar)
        if (ec.Includes("timestampMillis",true))
        {
            if(this.TimestampMillis == null) {

                this.TimestampMillis = new DateTime();

            } else {


            }
        }
        else if (this.TimestampMillis != null && ec.Excludes("timestampMillis",true))
        {
            this.TimestampMillis = null;
        }
    }


    #endregion

    } // class FailoverClusterStatus
    
    #endregion

    public static class ListFailoverClusterStatusExtensions
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
            this List<FailoverClusterStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FailoverClusterStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FailoverClusterStatus> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverClusterStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FailoverClusterStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types