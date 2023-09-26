using System;
using System.Management.Automation;
using System.Runtime.CompilerServices;
using RubrikSecurityCloud.Client;
using System.Collections.Generic;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Private
{
    public class RscLogger : IRscLogger
    {
        private readonly PSCmdlet _cmdlet;
        private readonly Queue<string> _logQueue;
        public string name { get; set; }

        // Initialize Logger with an optional PSCmdlet to that
        // we can use its WriteVerbose() and WriteDebug() methods.
        // If no PSCmdlet is provided, we will use Console.WriteLine()
        public RscLogger(PSCmdlet cmdlet = null)
        {
            this._cmdlet = cmdlet;
            this.name = cmdlet.GetType().Name;
            // we need a queue for log messages because the PSCmdlet's
            // Write methods are not always available. So we queue
            // the messages and write them when the PSCmdlet's Write
            // methods are available.
            _logQueue = new Queue<string>();
        }
        public void Debug(
        string message,
        [CallerMemberName] string memberName = "",
        [CallerFilePath] string filePath = "",
        [CallerLineNumber] int lineNumber = 0)
        {
            var m = ($"[{name}] {System.IO.Path.GetFileName(filePath)}:{lineNumber}:{memberName}()\n  {message.Replace("\n", "\n  ")}");
            if (_cmdlet != null)
            {
                this._logQueue.Enqueue("D" + m);
                this.Flush();
            }
            else
            {
                Console.WriteLine($"DEBUG: {m}");
            }

        }
        public void Verbose(string message)
        {
            var m = ($"{name}: {message}");
            if (_cmdlet != null)
            {
                this._logQueue.Enqueue("V" + m);
                this.Flush();
            }
            else
            {
                Console.WriteLine($"VERBOSE: {m}");
            }
        }

        public void Info(string message)
        {
            var m = ($"{name}: {message}");
            if (_cmdlet != null)
            {
                this._logQueue.Enqueue("I" + m);
                this.Flush();
            }
            else
            {
                Console.WriteLine($"INFO: {m}");
            }
        }

        public void Warning(string message)
        {
            var m = ($"{name}: {message}");
            if (_cmdlet != null)
            {
                this._logQueue.Enqueue("W" + m);
                this.Flush();
            }
            else
            {
                Console.WriteLine($"WARNING: {m}");
            }
        }

        public void Error(string message)
        {
            var m = ($"{name}: {message}");
            if (_cmdlet != null)
            {
                this._logQueue.Enqueue("E" + m);
                this.Flush();
            }
            else
            {
                Console.WriteLine($"ERROR: {m}");
            }
        }

        public void Flush()
        {
            if (_cmdlet == null)
            {
                return;
            }
            while (_logQueue.Count > 0)
            {
                // Peek at the next message in the queue
                var m = _logQueue.Peek();
                var method = m[0];
                var message = m.Substring(1);

                // Try to use the PSCmdlet's WriteDebug() method
                // to write the debug message to the PowerShell
                // console.
                try
                {
                    switch (method)
                    {
                        case 'V':
                            _cmdlet.WriteVerbose(message);
                            break;
                        case 'D':
                            _cmdlet.WriteDebug(message);
                            break;
                        case 'W':
                            _cmdlet.WriteWarning(message);
                            break;
                        case 'E':
                            _cmdlet.WriteError(
                                new ErrorRecord(
                                    new Exception(message),
                                    "RscError",
                                    ErrorCategory.NotSpecified,
                                    null));
                            break;
                        case 'I':
                            _cmdlet.WriteInformation(
                                new InformationRecord(message, name));
                            break;

                        default:
                            break;
                    }
                }
                catch (Exception)
                {
                    // However it may not be possible because
                    // the Write methods cannot be called from
                    // outside the overridden BeginProcessing(),
                    // ProcessRecord(), and EndProcessing() methods,
                    // and they can only be called from within
                    // the same thread as the PSCmdlet.
                    // In this case, we leave the message in the 
                    // queue and try again later.
                    return;
                }

                // Pop the message from the queue
                _logQueue.Dequeue();
            }

        }


    }
}

