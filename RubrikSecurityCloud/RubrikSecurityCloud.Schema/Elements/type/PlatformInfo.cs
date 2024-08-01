// PlatformInfo.cs
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
    #region PlatformInfo
    public class PlatformInfo: BaseType
    {
        #region members

        //      C# -> TicketingPlatformConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: TicketingPlatformConnectionStatus (enum)
        [JsonProperty("connectionStatus")]
        public TicketingPlatformConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> PlatformConfig? PlatformConfig
        // GraphQL -> platformConfig: PlatformConfig (type)
        [JsonProperty("platformConfig")]
        public PlatformConfig? PlatformConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PlatformInfo";
    }

    public PlatformInfo Set(
        TicketingPlatformConnectionStatus? ConnectionStatus = null,
        PlatformConfig? PlatformConfig = null
    ) 
    {
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( PlatformConfig != null ) {
            this.PlatformConfig = PlatformConfig;
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
        //      C# -> TicketingPlatformConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: TicketingPlatformConnectionStatus (enum)
        if (this.ConnectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "connectionStatus\n" ;
            } else {
                s += ind + "connectionStatus\n" ;
            }
        }
        //      C# -> PlatformConfig? PlatformConfig
        // GraphQL -> platformConfig: PlatformConfig (type)
        if (this.PlatformConfig != null) {
            var fspec = this.PlatformConfig.AsFieldSpec(conf.Child("platformConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "platformConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TicketingPlatformConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: TicketingPlatformConnectionStatus (enum)
        if (ec.Includes("connectionStatus",true))
        {
            if(this.ConnectionStatus == null) {

                this.ConnectionStatus = new TicketingPlatformConnectionStatus();

            } else {


            }
        }
        else if (this.ConnectionStatus != null && ec.Excludes("connectionStatus",true))
        {
            this.ConnectionStatus = null;
        }
        //      C# -> PlatformConfig? PlatformConfig
        // GraphQL -> platformConfig: PlatformConfig (type)
        if (ec.Includes("platformConfig",false))
        {
            if(this.PlatformConfig == null) {

                this.PlatformConfig = new PlatformConfig();
                this.PlatformConfig.ApplyExploratoryFieldSpec(ec.NewChild("platformConfig"));

            } else {

                this.PlatformConfig.ApplyExploratoryFieldSpec(ec.NewChild("platformConfig"));

            }
        }
        else if (this.PlatformConfig != null && ec.Excludes("platformConfig",false))
        {
            this.PlatformConfig = null;
        }
    }


    #endregion

    } // class PlatformInfo
    
    #endregion

    public static class ListPlatformInfoExtensions
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
            this List<PlatformInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PlatformInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PlatformInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PlatformInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PlatformInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types