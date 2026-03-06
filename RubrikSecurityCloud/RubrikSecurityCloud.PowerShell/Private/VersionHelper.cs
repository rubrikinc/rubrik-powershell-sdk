using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("RubrikSecurityCloud.Common.Tests")]

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Private
{
	/// <summary>
	/// Pure helper for parsing and comparing SDK/server schema versions.
	/// Versions follow the format "v20230524-16" (vYYYYMMDD-build).
	/// </summary>
	internal static class VersionHelper
	{
		/// <summary>
		/// Threshold: version drift below this is informational,
		/// above is a warning.
		/// </summary>
		internal static readonly TimeSpan WarningThreshold = TimeSpan.FromDays(30);

		internal enum Direction
		{
			SdkOlder,
			SdkNewer,
			Equal,
			Unknown
		}

		internal struct CompareResult
		{
			public Direction Direction;
			public TimeSpan? Delta;
		}

		/// <summary>
		/// Compares SDK and server versions by their embedded dates.
		/// </summary>
		internal static CompareResult Compare(string sdkVersion, string serverVersion)
		{
			var sdkDate = ExtractDate(sdkVersion);
			var serverDate = ExtractDate(serverVersion);

			if (sdkDate.HasValue && serverDate.HasValue)
			{
				if (sdkDate.Value == serverDate.Value)
					return new CompareResult { Direction = Direction.Equal, Delta = TimeSpan.Zero };

				var delta = (serverDate.Value - sdkDate.Value).Duration();
				var dir = sdkDate.Value < serverDate.Value
					? Direction.SdkOlder
					: Direction.SdkNewer;
				return new CompareResult { Direction = dir, Delta = delta };
			}

			return new CompareResult { Direction = Direction.Unknown, Delta = null };
		}

		/// <summary>
		/// Extracts the date from a version string like "v20230524-16".
		/// Returns null if the format is not recognized.
		/// </summary>
		internal static DateTime? ExtractDate(string version)
		{
			if (string.IsNullOrEmpty(version))
				return null;

			var match = System.Text.RegularExpressions.Regex.Match(
				version, @"v?(\d{8})");
			if (match.Success && match.Groups.Count > 1)
			{
				if (DateTime.TryParseExact(
					match.Groups[1].Value, "yyyyMMdd",
					null, System.Globalization.DateTimeStyles.None,
					out DateTime date))
				{
					return date;
				}
			}

			return null;
		}

		/// <summary>
		/// Returns true if the delta is significant enough to warrant a warning.
		/// </summary>
		internal static bool IsSignificant(CompareResult result)
		{
			if (result.Direction == Direction.Unknown)
				return true;
			return result.Delta.HasValue &&
				result.Delta.Value >= WarningThreshold;
		}
	}
}
