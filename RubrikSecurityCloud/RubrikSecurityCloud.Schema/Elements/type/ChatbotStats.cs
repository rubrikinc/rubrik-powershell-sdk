// ChatbotStats.cs
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
    #region ChatbotStats
    public class ChatbotStats: BaseType
    {
        #region members

        //      C# -> System.Int32? NumObjects
        // GraphQL -> numObjects: Int! (scalar)
        [JsonProperty("numObjects")]
        public System.Int32? NumObjects { get; set; }

        //      C# -> System.Int32? NumObjectsProcessed
        // GraphQL -> numObjectsProcessed: Int! (scalar)
        [JsonProperty("numObjectsProcessed")]
        public System.Int32? NumObjectsProcessed { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ChatbotStats";
    }

    public ChatbotStats Set(
        System.Int32? NumObjects = null,
        System.Int32? NumObjectsProcessed = null
    ) 
    {
        if ( NumObjects != null ) {
            this.NumObjects = NumObjects;
        }
        if ( NumObjectsProcessed != null ) {
            this.NumObjectsProcessed = NumObjectsProcessed;
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
        //      C# -> System.Int32? NumObjects
        // GraphQL -> numObjects: Int! (scalar)
        if (this.NumObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numObjects\n" ;
            } else {
                s += ind + "numObjects\n" ;
            }
        }
        //      C# -> System.Int32? NumObjectsProcessed
        // GraphQL -> numObjectsProcessed: Int! (scalar)
        if (this.NumObjectsProcessed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numObjectsProcessed\n" ;
            } else {
                s += ind + "numObjectsProcessed\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? NumObjects
        // GraphQL -> numObjects: Int! (scalar)
        if (ec.Includes("numObjects",true))
        {
            if(this.NumObjects == null) {

                this.NumObjects = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumObjects != null && ec.Excludes("numObjects",true))
        {
            this.NumObjects = null;
        }
        //      C# -> System.Int32? NumObjectsProcessed
        // GraphQL -> numObjectsProcessed: Int! (scalar)
        if (ec.Includes("numObjectsProcessed",true))
        {
            if(this.NumObjectsProcessed == null) {

                this.NumObjectsProcessed = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumObjectsProcessed != null && ec.Excludes("numObjectsProcessed",true))
        {
            this.NumObjectsProcessed = null;
        }
    }


    #endregion

    } // class ChatbotStats
    
    #endregion

    public static class ListChatbotStatsExtensions
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
            this List<ChatbotStats> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ChatbotStats> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ChatbotStats> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ChatbotStats());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ChatbotStats> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types