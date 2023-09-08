// SyslogConfig.cs
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
    #region SyslogConfig
    public class SyslogConfig: BaseType
    {
        #region members

        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        [JsonProperty("id")]
        public System.Int32? Id { get; set; }

        //      C# -> CommonNotificationConfig? NotificationConf
        // GraphQL -> notificationConf: CommonNotificationConfig (type)
        [JsonProperty("notificationConf")]
        public CommonNotificationConfig? NotificationConf { get; set; }

        //      C# -> SyslogSetting? SyslogConf
        // GraphQL -> syslogConf: SyslogSetting (type)
        [JsonProperty("syslogConf")]
        public SyslogSetting? SyslogConf { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SyslogConfig";
    }

    public SyslogConfig Set(
        System.Int32? Id = null,
        CommonNotificationConfig? NotificationConf = null,
        SyslogSetting? SyslogConf = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( NotificationConf != null ) {
            this.NotificationConf = NotificationConf;
        }
        if ( SyslogConf != null ) {
            this.SyslogConf = SyslogConf;
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
        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> CommonNotificationConfig? NotificationConf
        // GraphQL -> notificationConf: CommonNotificationConfig (type)
        if (this.NotificationConf != null) {
            var fspec = this.NotificationConf.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "notificationConf {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SyslogSetting? SyslogConf
        // GraphQL -> syslogConf: SyslogSetting (type)
        if (this.SyslogConf != null) {
            var fspec = this.SyslogConf.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "syslogConf {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = Int32.MinValue;
        }
        //      C# -> CommonNotificationConfig? NotificationConf
        // GraphQL -> notificationConf: CommonNotificationConfig (type)
        if (this.NotificationConf == null && ec.Includes("notificationConf",false))
        {
            this.NotificationConf = new CommonNotificationConfig();
            this.NotificationConf.ApplyExploratoryFieldSpec(ec.NewChild("notificationConf"));
        }
        //      C# -> SyslogSetting? SyslogConf
        // GraphQL -> syslogConf: SyslogSetting (type)
        if (this.SyslogConf == null && ec.Includes("syslogConf",false))
        {
            this.SyslogConf = new SyslogSetting();
            this.SyslogConf.ApplyExploratoryFieldSpec(ec.NewChild("syslogConf"));
        }
    }


    #endregion

    } // class SyslogConfig
    
    #endregion

    public static class ListSyslogConfigExtensions
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
            this List<SyslogConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SyslogConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SyslogConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SyslogConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types