// TprConfigurationType.cs
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
    #region TprConfigurationType
    public class TprConfigurationType: BaseType
    {
        #region members

        //      C# -> System.Int32? ExecutionMaxTimeoutHours
        // GraphQL -> executionMaxTimeoutHours: Int! (scalar)
        [JsonProperty("executionMaxTimeoutHours")]
        public System.Int32? ExecutionMaxTimeoutHours { get; set; }

        //      C# -> System.Boolean? IsTprEnabled
        // GraphQL -> isTprEnabled: Boolean! (scalar)
        [JsonProperty("isTprEnabled")]
        public System.Boolean? IsTprEnabled { get; set; }

        //      C# -> System.Int32? ReminderHours
        // GraphQL -> reminderHours: Int! (scalar)
        [JsonProperty("reminderHours")]
        public System.Int32? ReminderHours { get; set; }

        //      C# -> System.Int32? RequestTimeoutHours
        // GraphQL -> requestTimeoutHours: Int! (scalar)
        [JsonProperty("requestTimeoutHours")]
        public System.Int32? RequestTimeoutHours { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprConfigurationType";
    }

    public TprConfigurationType Set(
        System.Int32? ExecutionMaxTimeoutHours = null,
        System.Boolean? IsTprEnabled = null,
        System.Int32? ReminderHours = null,
        System.Int32? RequestTimeoutHours = null
    ) 
    {
        if ( ExecutionMaxTimeoutHours != null ) {
            this.ExecutionMaxTimeoutHours = ExecutionMaxTimeoutHours;
        }
        if ( IsTprEnabled != null ) {
            this.IsTprEnabled = IsTprEnabled;
        }
        if ( ReminderHours != null ) {
            this.ReminderHours = ReminderHours;
        }
        if ( RequestTimeoutHours != null ) {
            this.RequestTimeoutHours = RequestTimeoutHours;
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
        //      C# -> System.Int32? ExecutionMaxTimeoutHours
        // GraphQL -> executionMaxTimeoutHours: Int! (scalar)
        if (this.ExecutionMaxTimeoutHours != null) {
            s += ind + "executionMaxTimeoutHours\n" ;
        }
        //      C# -> System.Boolean? IsTprEnabled
        // GraphQL -> isTprEnabled: Boolean! (scalar)
        if (this.IsTprEnabled != null) {
            s += ind + "isTprEnabled\n" ;
        }
        //      C# -> System.Int32? ReminderHours
        // GraphQL -> reminderHours: Int! (scalar)
        if (this.ReminderHours != null) {
            s += ind + "reminderHours\n" ;
        }
        //      C# -> System.Int32? RequestTimeoutHours
        // GraphQL -> requestTimeoutHours: Int! (scalar)
        if (this.RequestTimeoutHours != null) {
            s += ind + "requestTimeoutHours\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? ExecutionMaxTimeoutHours
        // GraphQL -> executionMaxTimeoutHours: Int! (scalar)
        if (this.ExecutionMaxTimeoutHours == null && Exploration.Includes(parent + ".executionMaxTimeoutHours", true))
        {
            this.ExecutionMaxTimeoutHours = Int32.MinValue;
        }
        //      C# -> System.Boolean? IsTprEnabled
        // GraphQL -> isTprEnabled: Boolean! (scalar)
        if (this.IsTprEnabled == null && Exploration.Includes(parent + ".isTprEnabled", true))
        {
            this.IsTprEnabled = true;
        }
        //      C# -> System.Int32? ReminderHours
        // GraphQL -> reminderHours: Int! (scalar)
        if (this.ReminderHours == null && Exploration.Includes(parent + ".reminderHours", true))
        {
            this.ReminderHours = Int32.MinValue;
        }
        //      C# -> System.Int32? RequestTimeoutHours
        // GraphQL -> requestTimeoutHours: Int! (scalar)
        if (this.RequestTimeoutHours == null && Exploration.Includes(parent + ".requestTimeoutHours", true))
        {
            this.RequestTimeoutHours = Int32.MinValue;
        }
    }


    #endregion

    } // class TprConfigurationType
    
    #endregion

    public static class ListTprConfigurationTypeExtensions
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
            this List<TprConfigurationType> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TprConfigurationType> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new TprConfigurationType());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types