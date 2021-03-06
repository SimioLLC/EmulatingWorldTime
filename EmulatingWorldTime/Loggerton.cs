﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// This is just a helper to show logs.
/// The logs are kept in a singleton.
/// </summary>
namespace LoggertonHelpers
{

    [Flags]
    public enum EnumLogFlags
    {
        None = 0,
        Information = 1,
        Event = 2,
        Warning = 4,
        Error = 8,
        All = 0xffff
    }

    /// <summary>
    /// A single log event/entry
    /// </summary>
    public class LogEntry
    {
        public EnumLogFlags Flags { get; set; }

        /// <summary>
        /// Time of creation. Stored as DateTimeOffset
        /// </summary>
        public DateTimeOffset TimeStamp { get; set; }

        /// <summary>
        /// The logged message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Has this message been excluded by regex excludes?
        /// </summary>
        public bool IsExcluded { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="flags"></param>
        /// <param name="msg"></param>
        public LogEntry(EnumLogFlags flags, String msg)
        {
            Flags = flags;
            TimeStamp = DateTime.Now;
            Message = msg;
        }

        public override string ToString()
        {
            return $"{Flags}:{TimeStamp.ToString("HH:mm:ss.ff")} {Message}";
        }
    }

    public sealed class Loggerton
    {
        private static readonly Loggerton instance = new Loggerton();
        public static Loggerton Instance { get { return instance; } }

        static Loggerton()
        {
        }
        private Loggerton()
        {
            // Display the log window
            logForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            logForm.Show();
            logForm.Visible = false;

        }

        public bool IsEnabled = true;

        private List<LogEntry> Logs = new List<LogEntry>();

        private FormLoggerton logForm = new FormLoggerton();

        public void ToggleFormVisibility()
        {
            logForm.Visible = !logForm.Visible;
        }

        private List<string> excludesList = new List<string>();

        public void SetExcludes( string commalist )
        {
            excludesList.Clear();
            excludesList = commalist.Split(',').ToList();

            // Reevaluate all the logs
            foreach (LogEntry le in Logs)
            {
                le.IsExcluded = false;
                foreach (string expr in excludesList)
                {
                    if (Regex.IsMatch(le.Message, expr, RegexOptions.IgnoreCase))
                    {
                        le.IsExcluded = true;
                        goto GetNextLogEntry;
                    }
                }
                GetNextLogEntry:;
            }
        }

        /// <summary>
        /// Get all logs that should be displayed.
        /// </summary>
        /// <param name="flags"></param>
        /// <param name="excludes"></param>
        /// <returns></returns>
        public string GetLogs(EnumLogFlags flags)
        {
            List<LogEntry> filteredLogs = Logs
                .Where(rr => (rr.Flags & flags) != 0)
                .Where(rr => !rr.IsExcluded )
                .OrderByDescending(rr => rr.TimeStamp)
                .ToList();

            StringBuilder sb = new StringBuilder();
            foreach (LogEntry le in filteredLogs)
            {
                sb.AppendLine($"{le}");
            }

            return sb.ToString();
        }

        public void ClearLogs()
        {
            Logs.Clear();
        }

        public string ShowLogs()
        {
            return Logs.ToString();
        }

        public void WriteLogs(string path)
        {
            File.WriteAllText(path, Logs.ToString());
        }


        /// <summary>
        /// Log the message.
        /// </summary>
        /// <param name="logType"></param>
        /// <param name="message"></param>
        public void LogIt(EnumLogFlags logType, string message)
        {
            if (!IsEnabled)
                return;

            bool isExcluded = false;
            foreach (string expr in excludesList)
            {
                if (Regex.IsMatch(message, expr, RegexOptions.IgnoreCase))
                {
                    isExcluded = true;
                    break;
                }
            }

            LogEntry entry = new LogEntry(logType, message);
            entry.IsExcluded = isExcluded;
            Logs.Add(entry);
        }

    }
}

