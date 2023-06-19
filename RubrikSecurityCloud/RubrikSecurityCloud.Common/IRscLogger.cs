using System.Runtime.CompilerServices;

namespace RubrikSecurityCloud
{
    public interface IRscLogger
    {
        public void Debug(
            string message,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string filePath = "",
            [CallerLineNumber] int lineNumber = 0
        );

        public void Verbose(string message);
        public void Info(string message);
        public void Warning(string message);
        public void Flush();
    }
}
