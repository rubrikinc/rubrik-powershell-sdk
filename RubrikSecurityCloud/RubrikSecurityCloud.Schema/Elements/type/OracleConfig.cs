// OracleConfig.cs
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
    #region OracleConfig
    public class OracleConfig: BaseType
    {
        #region members

        //      C# -> Duration? Frequency
        // GraphQL -> frequency: Duration (type)
        [JsonProperty("frequency")]
        public Duration? Frequency { get; set; }

        //      C# -> Duration? HostLogRetention
        // GraphQL -> hostLogRetention: Duration (type)
        [JsonProperty("hostLogRetention")]
        public Duration? HostLogRetention { get; set; }

        //      C# -> Duration? LogRetention
        // GraphQL -> logRetention: Duration (type)
        [JsonProperty("logRetention")]
        public Duration? LogRetention { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OracleConfig";
    }

    public OracleConfig Set(
        Duration? Frequency = null,
        Duration? HostLogRetention = null,
        Duration? LogRetention = null
    ) 
    {
        if ( Frequency != null ) {
            this.Frequency = Frequency;
        }
        if ( HostLogRetention != null ) {
            this.HostLogRetention = HostLogRetention;
        }
        if ( LogRetention != null ) {
            this.LogRetention = LogRetention;
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
        //      C# -> Duration? Frequency
        // GraphQL -> frequency: Duration (type)
        if (this.Frequency != null) {
            var fspec = this.Frequency.AsFieldSpec(conf.Child("frequency"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "frequency {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Duration? HostLogRetention
        // GraphQL -> hostLogRetention: Duration (type)
        if (this.HostLogRetention != null) {
            var fspec = this.HostLogRetention.AsFieldSpec(conf.Child("hostLogRetention"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hostLogRetention {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Duration? LogRetention
        // GraphQL -> logRetention: Duration (type)
        if (this.LogRetention != null) {
            var fspec = this.LogRetention.AsFieldSpec(conf.Child("logRetention"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "logRetention {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Duration? Frequency
        // GraphQL -> frequency: Duration (type)
        if (ec.Includes("frequency",false))
        {
            if(this.Frequency == null) {

                this.Frequency = new Duration();
                this.Frequency.ApplyExploratoryFieldSpec(ec.NewChild("frequency"));

            } else {

                this.Frequency.ApplyExploratoryFieldSpec(ec.NewChild("frequency"));

            }
        }
        else if (this.Frequency != null && ec.Excludes("frequency",false))
        {
            this.Frequency = null;
        }
        //      C# -> Duration? HostLogRetention
        // GraphQL -> hostLogRetention: Duration (type)
        if (ec.Includes("hostLogRetention",false))
        {
            if(this.HostLogRetention == null) {

                this.HostLogRetention = new Duration();
                this.HostLogRetention.ApplyExploratoryFieldSpec(ec.NewChild("hostLogRetention"));

            } else {

                this.HostLogRetention.ApplyExploratoryFieldSpec(ec.NewChild("hostLogRetention"));

            }
        }
        else if (this.HostLogRetention != null && ec.Excludes("hostLogRetention",false))
        {
            this.HostLogRetention = null;
        }
        //      C# -> Duration? LogRetention
        // GraphQL -> logRetention: Duration (type)
        if (ec.Includes("logRetention",false))
        {
            if(this.LogRetention == null) {

                this.LogRetention = new Duration();
                this.LogRetention.ApplyExploratoryFieldSpec(ec.NewChild("logRetention"));

            } else {

                this.LogRetention.ApplyExploratoryFieldSpec(ec.NewChild("logRetention"));

            }
        }
        else if (this.LogRetention != null && ec.Excludes("logRetention",false))
        {
            this.LogRetention = null;
        }
    }


    #endregion

    } // class OracleConfig
    
    #endregion

    public static class ListOracleConfigExtensions
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
            this List<OracleConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<OracleConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OracleConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OracleConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types