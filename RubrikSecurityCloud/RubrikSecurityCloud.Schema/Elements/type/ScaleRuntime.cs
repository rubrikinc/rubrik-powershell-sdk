// ScaleRuntime.cs
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
    #region ScaleRuntime
    public class ScaleRuntime: BaseType
    {
        #region members

        //      C# -> DateTime? Deadline
        // GraphQL -> deadline: DateTime (scalar)
        [JsonProperty("deadline")]
        public DateTime? Deadline { get; set; }

        //      C# -> System.Int32? NewCount
        // GraphQL -> newCount: Int! (scalar)
        [JsonProperty("newCount")]
        public System.Int32? NewCount { get; set; }

        //      C# -> System.Int32? OldCount
        // GraphQL -> oldCount: Int! (scalar)
        [JsonProperty("oldCount")]
        public System.Int32? OldCount { get; set; }

        //      C# -> System.String? TaskchainUuid
        // GraphQL -> taskchainUuid: String! (scalar)
        [JsonProperty("taskchainUuid")]
        public System.String? TaskchainUuid { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ScaleRuntime";
    }

    public ScaleRuntime Set(
        DateTime? Deadline = null,
        System.Int32? NewCount = null,
        System.Int32? OldCount = null,
        System.String? TaskchainUuid = null
    ) 
    {
        if ( Deadline != null ) {
            this.Deadline = Deadline;
        }
        if ( NewCount != null ) {
            this.NewCount = NewCount;
        }
        if ( OldCount != null ) {
            this.OldCount = OldCount;
        }
        if ( TaskchainUuid != null ) {
            this.TaskchainUuid = TaskchainUuid;
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
        //      C# -> DateTime? Deadline
        // GraphQL -> deadline: DateTime (scalar)
        if (this.Deadline != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deadline\n" ;
            } else {
                s += ind + "deadline\n" ;
            }
        }
        //      C# -> System.Int32? NewCount
        // GraphQL -> newCount: Int! (scalar)
        if (this.NewCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newCount\n" ;
            } else {
                s += ind + "newCount\n" ;
            }
        }
        //      C# -> System.Int32? OldCount
        // GraphQL -> oldCount: Int! (scalar)
        if (this.OldCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldCount\n" ;
            } else {
                s += ind + "oldCount\n" ;
            }
        }
        //      C# -> System.String? TaskchainUuid
        // GraphQL -> taskchainUuid: String! (scalar)
        if (this.TaskchainUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "taskchainUuid\n" ;
            } else {
                s += ind + "taskchainUuid\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DateTime? Deadline
        // GraphQL -> deadline: DateTime (scalar)
        if (ec.Includes("deadline",true))
        {
            if(this.Deadline == null) {

                this.Deadline = new DateTime();

            } else {


            }
        }
        else if (this.Deadline != null && ec.Excludes("deadline",true))
        {
            this.Deadline = null;
        }
        //      C# -> System.Int32? NewCount
        // GraphQL -> newCount: Int! (scalar)
        if (ec.Includes("newCount",true))
        {
            if(this.NewCount == null) {

                this.NewCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.NewCount != null && ec.Excludes("newCount",true))
        {
            this.NewCount = null;
        }
        //      C# -> System.Int32? OldCount
        // GraphQL -> oldCount: Int! (scalar)
        if (ec.Includes("oldCount",true))
        {
            if(this.OldCount == null) {

                this.OldCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.OldCount != null && ec.Excludes("oldCount",true))
        {
            this.OldCount = null;
        }
        //      C# -> System.String? TaskchainUuid
        // GraphQL -> taskchainUuid: String! (scalar)
        if (ec.Includes("taskchainUuid",true))
        {
            if(this.TaskchainUuid == null) {

                this.TaskchainUuid = "FETCH";

            } else {


            }
        }
        else if (this.TaskchainUuid != null && ec.Excludes("taskchainUuid",true))
        {
            this.TaskchainUuid = null;
        }
    }


    #endregion

    } // class ScaleRuntime
    
    #endregion

    public static class ListScaleRuntimeExtensions
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
            this List<ScaleRuntime> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ScaleRuntime> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ScaleRuntime> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ScaleRuntime());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ScaleRuntime> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types