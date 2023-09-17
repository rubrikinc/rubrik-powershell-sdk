using System.Runtime.CompilerServices;

namespace RubrikSecurityCloud
{
    public interface IRscLogger
    {
        /// <summary>
        /// Log a debug message. The message will be logged with the
        /// caller's member name, file path, and line number.
        /// Debug-level messages are displayed when the cmdlet is
        /// called with the `-Debug` parameter or when
        /// `$DebugPreference = 'Continue'`
        /// is set in the session.
        /// </summary>
        public void Debug(
            string message,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string filePath = "",
            [CallerLineNumber] int lineNumber = 0
        );

        /// <summary>
        /// Log a verbose message.
        /// Verbose-level messages are displayed when the cmdlet is
        /// called with the `-Verbose` parameter or when
        /// `$VerbosePreference = 'Continue'` is set in the session.
        /// </summary>
        public void Verbose(string message);

        /// <summary>
        /// Log an informational message.
        /// Informational messages are displayed when the cmdlet is
        /// called with `-InformationAction Continue` or when
        /// `$InformationPreference = 'Continue'` is set in the session.
        /// </summary>
        public void Info(string message);

        /// <summary>
        /// Log a warning message.
        /// Warning messages are always displayed unless
        /// `$WarningPreference = 'SilentlyContinue'` is set in the session.
        /// </summary>
        public void Warning(string message);

        /// <summary>
        /// Log an error message.
        /// Error messages are always displayed unless
        /// `$ErrorActionPreference = 'SilentlyContinue'` is set in the session.
        /// </summary>
        public void Error(string message);
        public void Flush();
    }
}
