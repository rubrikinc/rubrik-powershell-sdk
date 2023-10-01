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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
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
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<ScaleRuntime> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ScaleRuntime> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ScaleRuntime> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ScaleRuntime());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ScaleRuntime> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types