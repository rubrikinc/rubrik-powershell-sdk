// PhoenixRolloutProgress.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region PhoenixRolloutProgress
    public class PhoenixRolloutProgress: BaseType
    {
        #region members

        //      C# -> System.Int32? NumEnabled
        // GraphQL -> numEnabled: Int! (scalar)
        [JsonProperty("numEnabled")]
        public System.Int32? NumEnabled { get; set; }

        //      C# -> System.Int32? NumInProcess
        // GraphQL -> numInProcess: Int! (scalar)
        [JsonProperty("numInProcess")]
        public System.Int32? NumInProcess { get; set; }

        //      C# -> System.Int32? NumIncompleteFirstFull
        // GraphQL -> numIncompleteFirstFull: Int! (scalar)
        [JsonProperty("numIncompleteFirstFull")]
        public System.Int32? NumIncompleteFirstFull { get; set; }

        //      C# -> System.Int32? NumNotEnabled
        // GraphQL -> numNotEnabled: Int! (scalar)
        [JsonProperty("numNotEnabled")]
        public System.Int32? NumNotEnabled { get; set; }


        #endregion

    #region methods

    public PhoenixRolloutProgress Set(
        System.Int32? NumEnabled = null,
        System.Int32? NumInProcess = null,
        System.Int32? NumIncompleteFirstFull = null,
        System.Int32? NumNotEnabled = null
    ) 
    {
        if ( NumEnabled != null ) {
            this.NumEnabled = NumEnabled;
        }
        if ( NumInProcess != null ) {
            this.NumInProcess = NumInProcess;
        }
        if ( NumIncompleteFirstFull != null ) {
            this.NumIncompleteFirstFull = NumIncompleteFirstFull;
        }
        if ( NumNotEnabled != null ) {
            this.NumNotEnabled = NumNotEnabled;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int32? NumEnabled
        // GraphQL -> numEnabled: Int! (scalar)
        if (this.NumEnabled != null) {
            s += ind + "numEnabled\n" ;
        }
        //      C# -> System.Int32? NumInProcess
        // GraphQL -> numInProcess: Int! (scalar)
        if (this.NumInProcess != null) {
            s += ind + "numInProcess\n" ;
        }
        //      C# -> System.Int32? NumIncompleteFirstFull
        // GraphQL -> numIncompleteFirstFull: Int! (scalar)
        if (this.NumIncompleteFirstFull != null) {
            s += ind + "numIncompleteFirstFull\n" ;
        }
        //      C# -> System.Int32? NumNotEnabled
        // GraphQL -> numNotEnabled: Int! (scalar)
        if (this.NumNotEnabled != null) {
            s += ind + "numNotEnabled\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? NumEnabled
        // GraphQL -> numEnabled: Int! (scalar)
        if (this.NumEnabled == null && Exploration.Includes(parent + ".numEnabled", true))
        {
            this.NumEnabled = Int32.MinValue;
        }
        //      C# -> System.Int32? NumInProcess
        // GraphQL -> numInProcess: Int! (scalar)
        if (this.NumInProcess == null && Exploration.Includes(parent + ".numInProcess", true))
        {
            this.NumInProcess = Int32.MinValue;
        }
        //      C# -> System.Int32? NumIncompleteFirstFull
        // GraphQL -> numIncompleteFirstFull: Int! (scalar)
        if (this.NumIncompleteFirstFull == null && Exploration.Includes(parent + ".numIncompleteFirstFull", true))
        {
            this.NumIncompleteFirstFull = Int32.MinValue;
        }
        //      C# -> System.Int32? NumNotEnabled
        // GraphQL -> numNotEnabled: Int! (scalar)
        if (this.NumNotEnabled == null && Exploration.Includes(parent + ".numNotEnabled", true))
        {
            this.NumNotEnabled = Int32.MinValue;
        }
    }


    #endregion

    } // class PhoenixRolloutProgress
    
    #endregion

    public static class ListPhoenixRolloutProgressExtensions
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
            this List<PhoenixRolloutProgress> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PhoenixRolloutProgress> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PhoenixRolloutProgress());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types