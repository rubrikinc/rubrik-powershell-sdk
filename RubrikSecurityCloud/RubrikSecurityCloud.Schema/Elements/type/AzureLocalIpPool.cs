// AzureLocalIpPool.cs
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
    #region AzureLocalIpPool
    public class AzureLocalIpPool: BaseType
    {
        #region members

        //      C# -> System.Int64? Available
        // GraphQL -> available: Long! (scalar)
        [JsonProperty("available")]
        public System.Int64? Available { get; set; }

        //      C# -> System.String? End
        // GraphQL -> end: String! (scalar)
        [JsonProperty("end")]
        public System.String? End { get; set; }

        //      C# -> System.String? Start
        // GraphQL -> start: String! (scalar)
        [JsonProperty("start")]
        public System.String? Start { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureLocalIpPool";
    }

    public AzureLocalIpPool Set(
        System.Int64? Available = null,
        System.String? End = null,
        System.String? Start = null
    ) 
    {
        if ( Available != null ) {
            this.Available = Available;
        }
        if ( End != null ) {
            this.End = End;
        }
        if ( Start != null ) {
            this.Start = Start;
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
        //      C# -> System.Int64? Available
        // GraphQL -> available: Long! (scalar)
        if (this.Available != null) {
            if (conf.Flat) {
                s += conf.Prefix + "available\n" ;
            } else {
                s += ind + "available\n" ;
            }
        }
        //      C# -> System.String? End
        // GraphQL -> end: String! (scalar)
        if (this.End != null) {
            if (conf.Flat) {
                s += conf.Prefix + "end\n" ;
            } else {
                s += ind + "end\n" ;
            }
        }
        //      C# -> System.String? Start
        // GraphQL -> start: String! (scalar)
        if (this.Start != null) {
            if (conf.Flat) {
                s += conf.Prefix + "start\n" ;
            } else {
                s += ind + "start\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? Available
        // GraphQL -> available: Long! (scalar)
        if (ec.Includes("available",true))
        {
            if(this.Available == null) {

                this.Available = new System.Int64();

            } else {


            }
        }
        else if (this.Available != null && ec.Excludes("available",true))
        {
            this.Available = null;
        }
        //      C# -> System.String? End
        // GraphQL -> end: String! (scalar)
        if (ec.Includes("end",true))
        {
            if(this.End == null) {

                this.End = "FETCH";

            } else {


            }
        }
        else if (this.End != null && ec.Excludes("end",true))
        {
            this.End = null;
        }
        //      C# -> System.String? Start
        // GraphQL -> start: String! (scalar)
        if (ec.Includes("start",true))
        {
            if(this.Start == null) {

                this.Start = "FETCH";

            } else {


            }
        }
        else if (this.Start != null && ec.Excludes("start",true))
        {
            this.Start = null;
        }
    }


    #endregion

    } // class AzureLocalIpPool
    
    #endregion

    public static class ListAzureLocalIpPoolExtensions
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
            this List<AzureLocalIpPool> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureLocalIpPool> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureLocalIpPool> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureLocalIpPool());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureLocalIpPool> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types