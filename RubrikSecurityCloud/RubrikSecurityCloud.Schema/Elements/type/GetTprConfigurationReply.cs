// GetTprConfigurationReply.cs
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
    #region GetTprConfigurationReply
    public class GetTprConfigurationReply: BaseType
    {
        #region members

        //      C# -> System.Int32? ExecutionMaxTimeoutHours
        // GraphQL -> executionMaxTimeoutHours: Int (scalar)
        [JsonProperty("executionMaxTimeoutHours")]
        public System.Int32? ExecutionMaxTimeoutHours { get; set; }

        //      C# -> System.Boolean? IsTprEnabled
        // GraphQL -> isTprEnabled: Boolean! (scalar)
        [JsonProperty("isTprEnabled")]
        public System.Boolean? IsTprEnabled { get; set; }

        //      C# -> System.Int32? ReminderHours
        // GraphQL -> reminderHours: Int (scalar)
        [JsonProperty("reminderHours")]
        public System.Int32? ReminderHours { get; set; }

        //      C# -> System.Int32? RequestTimeoutHours
        // GraphQL -> requestTimeoutHours: Int (scalar)
        [JsonProperty("requestTimeoutHours")]
        public System.Int32? RequestTimeoutHours { get; set; }

        //      C# -> System.Int32? StaticQuorumRequirement
        // GraphQL -> staticQuorumRequirement: Int! (scalar)
        [JsonProperty("staticQuorumRequirement")]
        public System.Int32? StaticQuorumRequirement { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetTprConfigurationReply";
    }

    public GetTprConfigurationReply Set(
        System.Int32? ExecutionMaxTimeoutHours = null,
        System.Boolean? IsTprEnabled = null,
        System.Int32? ReminderHours = null,
        System.Int32? RequestTimeoutHours = null,
        System.Int32? StaticQuorumRequirement = null
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
        if ( StaticQuorumRequirement != null ) {
            this.StaticQuorumRequirement = StaticQuorumRequirement;
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
        //      C# -> System.Int32? ExecutionMaxTimeoutHours
        // GraphQL -> executionMaxTimeoutHours: Int (scalar)
        if (this.ExecutionMaxTimeoutHours != null) {
            if (conf.Flat) {
                s += conf.Prefix + "executionMaxTimeoutHours\n" ;
            } else {
                s += ind + "executionMaxTimeoutHours\n" ;
            }
        }
        //      C# -> System.Boolean? IsTprEnabled
        // GraphQL -> isTprEnabled: Boolean! (scalar)
        if (this.IsTprEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isTprEnabled\n" ;
            } else {
                s += ind + "isTprEnabled\n" ;
            }
        }
        //      C# -> System.Int32? ReminderHours
        // GraphQL -> reminderHours: Int (scalar)
        if (this.ReminderHours != null) {
            if (conf.Flat) {
                s += conf.Prefix + "reminderHours\n" ;
            } else {
                s += ind + "reminderHours\n" ;
            }
        }
        //      C# -> System.Int32? RequestTimeoutHours
        // GraphQL -> requestTimeoutHours: Int (scalar)
        if (this.RequestTimeoutHours != null) {
            if (conf.Flat) {
                s += conf.Prefix + "requestTimeoutHours\n" ;
            } else {
                s += ind + "requestTimeoutHours\n" ;
            }
        }
        //      C# -> System.Int32? StaticQuorumRequirement
        // GraphQL -> staticQuorumRequirement: Int! (scalar)
        if (this.StaticQuorumRequirement != null) {
            if (conf.Flat) {
                s += conf.Prefix + "staticQuorumRequirement\n" ;
            } else {
                s += ind + "staticQuorumRequirement\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? ExecutionMaxTimeoutHours
        // GraphQL -> executionMaxTimeoutHours: Int (scalar)
        if (ec.Includes("executionMaxTimeoutHours",true))
        {
            if(this.ExecutionMaxTimeoutHours == null) {

                this.ExecutionMaxTimeoutHours = Int32.MinValue;

            } else {


            }
        }
        else if (this.ExecutionMaxTimeoutHours != null && ec.Excludes("executionMaxTimeoutHours",true))
        {
            this.ExecutionMaxTimeoutHours = null;
        }
        //      C# -> System.Boolean? IsTprEnabled
        // GraphQL -> isTprEnabled: Boolean! (scalar)
        if (ec.Includes("isTprEnabled",true))
        {
            if(this.IsTprEnabled == null) {

                this.IsTprEnabled = true;

            } else {


            }
        }
        else if (this.IsTprEnabled != null && ec.Excludes("isTprEnabled",true))
        {
            this.IsTprEnabled = null;
        }
        //      C# -> System.Int32? ReminderHours
        // GraphQL -> reminderHours: Int (scalar)
        if (ec.Includes("reminderHours",true))
        {
            if(this.ReminderHours == null) {

                this.ReminderHours = Int32.MinValue;

            } else {


            }
        }
        else if (this.ReminderHours != null && ec.Excludes("reminderHours",true))
        {
            this.ReminderHours = null;
        }
        //      C# -> System.Int32? RequestTimeoutHours
        // GraphQL -> requestTimeoutHours: Int (scalar)
        if (ec.Includes("requestTimeoutHours",true))
        {
            if(this.RequestTimeoutHours == null) {

                this.RequestTimeoutHours = Int32.MinValue;

            } else {


            }
        }
        else if (this.RequestTimeoutHours != null && ec.Excludes("requestTimeoutHours",true))
        {
            this.RequestTimeoutHours = null;
        }
        //      C# -> System.Int32? StaticQuorumRequirement
        // GraphQL -> staticQuorumRequirement: Int! (scalar)
        if (ec.Includes("staticQuorumRequirement",true))
        {
            if(this.StaticQuorumRequirement == null) {

                this.StaticQuorumRequirement = Int32.MinValue;

            } else {


            }
        }
        else if (this.StaticQuorumRequirement != null && ec.Excludes("staticQuorumRequirement",true))
        {
            this.StaticQuorumRequirement = null;
        }
    }


    #endregion

    } // class GetTprConfigurationReply
    
    #endregion

    public static class ListGetTprConfigurationReplyExtensions
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
            this List<GetTprConfigurationReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetTprConfigurationReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetTprConfigurationReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetTprConfigurationReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetTprConfigurationReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types