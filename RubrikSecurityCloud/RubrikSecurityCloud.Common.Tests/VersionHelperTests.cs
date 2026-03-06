using System;
using NUnit.Framework;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.Tests
{
    [TestFixture]
    public class VersionHelperTests
    {
        // ── ExtractDate ─────────────────────────────────────────────

        [Test]
        public void ExtractDate_StandardFormat()
        {
            var date = VersionHelper.ExtractDate("v20260223-52");
            Assert.IsNotNull(date);
            Assert.AreEqual(new DateTime(2026, 2, 23), date.Value);
        }

        [Test]
        public void ExtractDate_WithoutPrefix()
        {
            var date = VersionHelper.ExtractDate("20260223-52");
            Assert.IsNotNull(date);
            Assert.AreEqual(new DateTime(2026, 2, 23), date.Value);
        }

        [Test]
        public void ExtractDate_NoBuildSuffix()
        {
            var date = VersionHelper.ExtractDate("v20230101");
            Assert.IsNotNull(date);
            Assert.AreEqual(new DateTime(2023, 1, 1), date.Value);
        }

        [Test]
        public void ExtractDate_NullReturnsNull()
        {
            Assert.IsNull(VersionHelper.ExtractDate(null));
        }

        [Test]
        public void ExtractDate_EmptyReturnsNull()
        {
            Assert.IsNull(VersionHelper.ExtractDate(""));
        }

        [Test]
        public void ExtractDate_GarbageReturnsNull()
        {
            Assert.IsNull(VersionHelper.ExtractDate("not-a-version"));
        }

        [Test]
        public void ExtractDate_InvalidDateReturnsNull()
        {
            // 13th month doesn't exist
            Assert.IsNull(VersionHelper.ExtractDate("v20231301-1"));
        }

        // ── Compare ─────────────────────────────────────────────────

        [Test]
        public void Compare_SdkOlder()
        {
            var result = VersionHelper.Compare("v20260101-10", "v20260301-20");
            Assert.AreEqual(VersionHelper.Direction.SdkOlder, result.Direction);
            Assert.IsNotNull(result.Delta);
            Assert.AreEqual(59, (int)result.Delta.Value.TotalDays);
        }

        [Test]
        public void Compare_SdkNewer()
        {
            var result = VersionHelper.Compare("v20260301-20", "v20260101-10");
            Assert.AreEqual(VersionHelper.Direction.SdkNewer, result.Direction);
            Assert.IsNotNull(result.Delta);
            Assert.AreEqual(59, (int)result.Delta.Value.TotalDays);
        }

        [Test]
        public void Compare_Equal()
        {
            var result = VersionHelper.Compare("v20260223-52", "v20260223-99");
            Assert.AreEqual(VersionHelper.Direction.Equal, result.Direction);
            Assert.AreEqual(TimeSpan.Zero, result.Delta);
        }

        [Test]
        public void Compare_UnknownWhenBothInvalid()
        {
            var result = VersionHelper.Compare("garbage", "trash");
            Assert.AreEqual(VersionHelper.Direction.Unknown, result.Direction);
            Assert.IsNull(result.Delta);
        }

        [Test]
        public void Compare_UnknownWhenOneNull()
        {
            var result = VersionHelper.Compare(null, "v20260101-1");
            Assert.AreEqual(VersionHelper.Direction.Unknown, result.Direction);
            Assert.IsNull(result.Delta);
        }

        // ── IsSignificant ───────────────────────────────────────────

        [Test]
        public void IsSignificant_UnderThreshold()
        {
            // 10 days apart — should be Info, not significant
            var result = VersionHelper.Compare("v20260101-1", "v20260111-1");
            Assert.IsFalse(VersionHelper.IsSignificant(result));
        }

        [Test]
        public void IsSignificant_OverThreshold()
        {
            // 60 days apart — should be Warning
            var result = VersionHelper.Compare("v20260101-1", "v20260302-1");
            Assert.IsTrue(VersionHelper.IsSignificant(result));
        }

        [Test]
        public void IsSignificant_ExactlyAtThreshold()
        {
            // Exactly 30 days — should be Warning (>=)
            var result = VersionHelper.Compare("v20260101-1", "v20260131-1");
            Assert.IsTrue(VersionHelper.IsSignificant(result));
        }

        [Test]
        public void IsSignificant_UnknownAlwaysSignificant()
        {
            var result = VersionHelper.Compare("garbage", "trash");
            Assert.IsTrue(VersionHelper.IsSignificant(result));
        }

        [Test]
        public void IsSignificant_EqualNotSignificant()
        {
            var result = VersionHelper.Compare("v20260101-1", "v20260101-5");
            Assert.IsFalse(VersionHelper.IsSignificant(result));
        }
    }
}
