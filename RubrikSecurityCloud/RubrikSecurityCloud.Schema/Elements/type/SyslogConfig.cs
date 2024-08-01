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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> CommonNotificationConfig? NotificationConf
        // GraphQL -> notificationConf: CommonNotificationConfig (type)
        if (this.NotificationConf != null) {
            var fspec = this.NotificationConf.AsFieldSpec(conf.Child("notificationConf"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "notificationConf" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SyslogSetting? SyslogConf
        // GraphQL -> syslogConf: SyslogSetting (type)
        if (this.SyslogConf != null) {
            var fspec = this.SyslogConf.AsFieldSpec(conf.Child("syslogConf"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "syslogConf" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = Int32.MinValue;

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> CommonNotificationConfig? NotificationConf
        // GraphQL -> notificationConf: CommonNotificationConfig (type)
        if (ec.Includes("notificationConf",false))
        {
            if(this.NotificationConf == null) {

                this.NotificationConf = new CommonNotificationConfig();
                this.NotificationConf.ApplyExploratoryFieldSpec(ec.NewChild("notificationConf"));

            } else {

                this.NotificationConf.ApplyExploratoryFieldSpec(ec.NewChild("notificationConf"));

            }
        }
        else if (this.NotificationConf != null && ec.Excludes("notificationConf",false))
        {
            this.NotificationConf = null;
        }
        //      C# -> SyslogSetting? SyslogConf
        // GraphQL -> syslogConf: SyslogSetting (type)
        if (ec.Includes("syslogConf",false))
        {
            if(this.SyslogConf == null) {

                this.SyslogConf = new SyslogSetting();
                this.SyslogConf.ApplyExploratoryFieldSpec(ec.NewChild("syslogConf"));

            } else {

                this.SyslogConf.ApplyExploratoryFieldSpec(ec.NewChild("syslogConf"));

            }
        }
        else if (this.SyslogConf != null && ec.Excludes("syslogConf",false))
        {
            this.SyslogConf = null;
        }
    }


    #endregion

    } // class SyslogConfig
    
    #endregion

    public static class ListSyslogConfigExtensions
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
            this List<SyslogConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SyslogConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<SyslogConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types