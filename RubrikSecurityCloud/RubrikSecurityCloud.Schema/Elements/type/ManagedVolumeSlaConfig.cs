// ManagedVolumeSlaConfig.cs
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
    #region ManagedVolumeSlaConfig
    public class ManagedVolumeSlaConfig: BaseType
    {
        #region members

        //      C# -> Duration? LogRetention
        // GraphQL -> logRetention: Duration (type)
        [JsonProperty("logRetention")]
        public Duration? LogRetention { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManagedVolumeSlaConfig";
    }

    public ManagedVolumeSlaConfig Set(
        Duration? LogRetention = null
    ) 
    {
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
        //      C# -> Duration? LogRetention
        // GraphQL -> logRetention: Duration (type)
        if (this.LogRetention != null) {
            var fspec = this.LogRetention.AsFieldSpec(conf.Child("logRetention"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "logRetention" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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

    } // class ManagedVolumeSlaConfig
    
    #endregion

    public static class ListManagedVolumeSlaConfigExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ManagedVolumeSlaConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ManagedVolumeSlaConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeSlaConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeSlaConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManagedVolumeSlaConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types