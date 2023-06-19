// LatestUserNote.cs
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
    #region LatestUserNote
    public class LatestUserNote: BaseType
    {
        #region members

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        [JsonProperty("time")]
        public DateTime? Time { get; set; }

        //      C# -> System.String? UserName
        // GraphQL -> userName: String (scalar)
        [JsonProperty("userName")]
        public System.String? UserName { get; set; }

        //      C# -> System.String? UserNote
        // GraphQL -> userNote: String (scalar)
        [JsonProperty("userNote")]
        public System.String? UserNote { get; set; }


        #endregion

    #region methods

    public LatestUserNote Set(
        System.String? ObjectId = null,
        DateTime? Time = null,
        System.String? UserName = null,
        System.String? UserNote = null
    ) 
    {
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        if ( Time != null ) {
            this.Time = Time;
        }
        if ( UserName != null ) {
            this.UserName = UserName;
        }
        if ( UserNote != null ) {
            this.UserNote = UserNote;
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
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId != null) {
            s += ind + "objectId\n" ;
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        if (this.Time != null) {
            s += ind + "time\n" ;
        }
        //      C# -> System.String? UserName
        // GraphQL -> userName: String (scalar)
        if (this.UserName != null) {
            s += ind + "userName\n" ;
        }
        //      C# -> System.String? UserNote
        // GraphQL -> userNote: String (scalar)
        if (this.UserNote != null) {
            s += ind + "userNote\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId == null && Exploration.Includes(parent + ".objectId", true))
        {
            this.ObjectId = "FETCH";
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        if (this.Time == null && Exploration.Includes(parent + ".time", true))
        {
            this.Time = new DateTime();
        }
        //      C# -> System.String? UserName
        // GraphQL -> userName: String (scalar)
        if (this.UserName == null && Exploration.Includes(parent + ".userName", true))
        {
            this.UserName = "FETCH";
        }
        //      C# -> System.String? UserNote
        // GraphQL -> userNote: String (scalar)
        if (this.UserNote == null && Exploration.Includes(parent + ".userNote", true))
        {
            this.UserNote = "FETCH";
        }
    }


    #endregion

    } // class LatestUserNote
    
    #endregion

    public static class ListLatestUserNoteExtensions
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
            this List<LatestUserNote> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<LatestUserNote> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new LatestUserNote());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types