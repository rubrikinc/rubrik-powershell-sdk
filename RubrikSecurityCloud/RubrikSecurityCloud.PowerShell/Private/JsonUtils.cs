using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Management.Automation;
using RubrikSecurityCloud.Types;

namespace RubrikSecurityCloud
{
    public static class JsonUtils
    {
        /// <summary>
        /// Convert an object so that it can be serialized to JSON.
        /// - Handles basic types (string, int, etc.) by returning them as-is.
        /// - Unwrap PowerShell PSObjects.
        /// - RSC types pass through.
        /// - Hashtables and Enumerable types are recursively processed.
        /// - Defaults to ToString() on unrecognized types.
        /// </summary>
        public static System.Object JsonReady(System.Object obj)
        {
            // basic types
            if (
                obj == null ||
                obj is string ||
                obj is int ||
                obj is bool ||
                obj is Enum
            )
            {
                return obj;
            }

            // Unwrap PowerShell PSObjects
            // (e.g. non-scalar values in a PowerShell hashtable
            // are wrapped in PSObjects)
            if (obj is PSObject psObject)
            {
                return JsonUtils.JsonReady(psObject.BaseObject);
            }

            // RSC types handle their own serialization
            if (obj is IFieldSpec || obj is IInput)
            {
                return obj;
            }

            // Hashtable
            if (obj is Hashtable hashtable)
            {
                obj = new VarDict(hashtable);
            }
            if (obj is VarDict varDict)
            {
                var vd = new VarDict();
                foreach (KeyValuePair<string, object> entry in varDict)
                {
                    if (entry.Value != null)
                    {
                        vd.Add(
                            (string)entry.Key,
                            JsonUtils.JsonReady(entry.Value));
                    }
                }
                return vd;
            }

            // Enumerable (array, list, etc.)
            if (obj is IEnumerable enumerable)
            {
                var l = new List<object>();
                foreach (var item in enumerable)
                {
                    l.Add(JsonUtils.JsonReady(item));
                }
                return l;
            }

            // default (not ideal, a fallback)
            return obj.ToString();
        }
    }
}