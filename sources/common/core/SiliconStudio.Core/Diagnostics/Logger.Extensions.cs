﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
//
// File AUTO-GENERATED, do not edit!
using System;

namespace SiliconStudio.Core.Diagnostics
{
    public abstract partial class Logger
    {
        /// <summary>
        /// Logs the specified verbose message with an exception.
        /// </summary>
        /// <param name="message">The verbose message.</param>
        /// <param name="exception">An exception to log with the message.</param>
        /// <param name="callerInfo">Information about the caller. Default is null, otherwise use <see cref="CallerInfo.Get"/>.</param>
        public void Verbose(string message, Exception exception, CallerInfo callerInfo = null)
        {
            Log(new LogMessage(Module, LogMessageType.Verbose, message, exception, callerInfo));
        }

        /// <summary>
        /// Logs the specified verbose message.
        /// </summary>
        /// <param name="message">The verbose message.</param>
        /// <param name="callerInfo">Information about the caller. Default is null, otherwise use <see cref="CallerInfo.Get"/>.</param>
        public void Verbose(string message, CallerInfo callerInfo = null)
        {
            Verbose(message, null, callerInfo);
        }

        /// <summary>
        /// Logs the specified verbose message.
        /// </summary>
        /// <param name="messageFormat">The verbose message to format.</param>
        /// <param name="parameters">The parameters to used with the <see cref="messageFormat" />. The last parameter can be used to store <see cref="CallerInfo"/></param>
        public void Verbose(string messageFormat, params object[] parameters)
        {
            Verbose(messageFormat, null, parameters);
        }

        /// <summary>
        /// Logs the specified verbose message with an exception.
        /// </summary>
        /// <param name="messageFormat">The verbose message to format.</param>
        /// <param name="exception">An exception to log with the message.</param>
        /// <param name="parameters">The parameters to used with the <see cref="messageFormat" />. The last parameter can be used to store <see cref="CallerInfo"/></param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public void Verbose(string messageFormat, Exception exception, params object[] parameters)
        {
            if (parameters == null) throw new ArgumentNullException("parameters");
            Verbose(string.Format(messageFormat, parameters), exception, ExtractCallerInfo(parameters));
        }
        /// <summary>
        /// Logs the specified debug message with an exception.
        /// </summary>
        /// <param name="message">The debug message.</param>
        /// <param name="exception">An exception to log with the message.</param>
        /// <param name="callerInfo">Information about the caller. Default is null, otherwise use <see cref="CallerInfo.Get"/>.</param>
        public void Debug(string message, Exception exception, CallerInfo callerInfo = null)
        {
            Log(new LogMessage(Module, LogMessageType.Debug, message, exception, callerInfo));
        }

        /// <summary>
        /// Logs the specified debug message.
        /// </summary>
        /// <param name="message">The debug message.</param>
        /// <param name="callerInfo">Information about the caller. Default is null, otherwise use <see cref="CallerInfo.Get"/>.</param>
        public void Debug(string message, CallerInfo callerInfo = null)
        {
            Debug(message, null, callerInfo);
        }

        /// <summary>
        /// Logs the specified debug message.
        /// </summary>
        /// <param name="messageFormat">The debug message to format.</param>
        /// <param name="parameters">The parameters to used with the <see cref="messageFormat" />. The last parameter can be used to store <see cref="CallerInfo"/></param>
        public void Debug(string messageFormat, params object[] parameters)
        {
            Debug(messageFormat, null, parameters);
        }

        /// <summary>
        /// Logs the specified debug message with an exception.
        /// </summary>
        /// <param name="messageFormat">The debug message to format.</param>
        /// <param name="exception">An exception to log with the message.</param>
        /// <param name="parameters">The parameters to used with the <see cref="messageFormat" />. The last parameter can be used to store <see cref="CallerInfo"/></param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public void Debug(string messageFormat, Exception exception, params object[] parameters)
        {
            if (parameters == null) throw new ArgumentNullException("parameters");
            Debug(string.Format(messageFormat, parameters), exception, ExtractCallerInfo(parameters));
        }
        /// <summary>
        /// Logs the specified info message with an exception.
        /// </summary>
        /// <param name="message">The info message.</param>
        /// <param name="exception">An exception to log with the message.</param>
        /// <param name="callerInfo">Information about the caller. Default is null, otherwise use <see cref="CallerInfo.Get"/>.</param>
        public void Info(string message, Exception exception, CallerInfo callerInfo = null)
        {
            Log(new LogMessage(Module, LogMessageType.Info, message, exception, callerInfo));
        }

        /// <summary>
        /// Logs the specified info message.
        /// </summary>
        /// <param name="message">The info message.</param>
        /// <param name="callerInfo">Information about the caller. Default is null, otherwise use <see cref="CallerInfo.Get"/>.</param>
        public void Info(string message, CallerInfo callerInfo = null)
        {
            Info(message, null, callerInfo);
        }

        /// <summary>
        /// Logs the specified info message.
        /// </summary>
        /// <param name="messageFormat">The info message to format.</param>
        /// <param name="parameters">The parameters to used with the <see cref="messageFormat" />. The last parameter can be used to store <see cref="CallerInfo"/></param>
        public void Info(string messageFormat, params object[] parameters)
        {
            Info(messageFormat, null, parameters);
        }

        /// <summary>
        /// Logs the specified info message with an exception.
        /// </summary>
        /// <param name="messageFormat">The info message to format.</param>
        /// <param name="exception">An exception to log with the message.</param>
        /// <param name="parameters">The parameters to used with the <see cref="messageFormat" />. The last parameter can be used to store <see cref="CallerInfo"/></param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public void Info(string messageFormat, Exception exception, params object[] parameters)
        {
            if (parameters == null) throw new ArgumentNullException("parameters");
            Info(string.Format(messageFormat, parameters), exception, ExtractCallerInfo(parameters));
        }
        /// <summary>
        /// Logs the specified warning message with an exception.
        /// </summary>
        /// <param name="message">The warning message.</param>
        /// <param name="exception">An exception to log with the message.</param>
        /// <param name="callerInfo">Information about the caller. Default is null, otherwise use <see cref="CallerInfo.Get"/>.</param>
        public void Warning(string message, Exception exception, CallerInfo callerInfo = null)
        {
            Log(new LogMessage(Module, LogMessageType.Warning, message, exception, callerInfo));
        }

        /// <summary>
        /// Logs the specified warning message.
        /// </summary>
        /// <param name="message">The warning message.</param>
        /// <param name="callerInfo">Information about the caller. Default is null, otherwise use <see cref="CallerInfo.Get"/>.</param>
        public void Warning(string message, CallerInfo callerInfo = null)
        {
            Warning(message, null, callerInfo);
        }

        /// <summary>
        /// Logs the specified warning message.
        /// </summary>
        /// <param name="messageFormat">The warning message to format.</param>
        /// <param name="parameters">The parameters to used with the <see cref="messageFormat" />. The last parameter can be used to store <see cref="CallerInfo"/></param>
        public void Warning(string messageFormat, params object[] parameters)
        {
            Warning(messageFormat, null, parameters);
        }

        /// <summary>
        /// Logs the specified warning message with an exception.
        /// </summary>
        /// <param name="messageFormat">The warning message to format.</param>
        /// <param name="exception">An exception to log with the message.</param>
        /// <param name="parameters">The parameters to used with the <see cref="messageFormat" />. The last parameter can be used to store <see cref="CallerInfo"/></param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public void Warning(string messageFormat, Exception exception, params object[] parameters)
        {
            if (parameters == null) throw new ArgumentNullException("parameters");
            Warning(string.Format(messageFormat, parameters), exception, ExtractCallerInfo(parameters));
        }
        /// <summary>
        /// Logs the specified error message with an exception.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="exception">An exception to log with the message.</param>
        /// <param name="callerInfo">Information about the caller. Default is null, otherwise use <see cref="CallerInfo.Get"/>.</param>
        public void Error(string message, Exception exception, CallerInfo callerInfo = null)
        {
            Log(new LogMessage(Module, LogMessageType.Error, message, exception, callerInfo));
        }

        /// <summary>
        /// Logs the specified error message.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="callerInfo">Information about the caller. Default is null, otherwise use <see cref="CallerInfo.Get"/>.</param>
        public void Error(string message, CallerInfo callerInfo = null)
        {
            Error(message, null, callerInfo);
        }

        /// <summary>
        /// Logs the specified error message.
        /// </summary>
        /// <param name="messageFormat">The error message to format.</param>
        /// <param name="parameters">The parameters to used with the <see cref="messageFormat" />. The last parameter can be used to store <see cref="CallerInfo"/></param>
        public void Error(string messageFormat, params object[] parameters)
        {
            Error(messageFormat, null, parameters);
        }

        /// <summary>
        /// Logs the specified error message with an exception.
        /// </summary>
        /// <param name="messageFormat">The error message to format.</param>
        /// <param name="exception">An exception to log with the message.</param>
        /// <param name="parameters">The parameters to used with the <see cref="messageFormat" />. The last parameter can be used to store <see cref="CallerInfo"/></param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public void Error(string messageFormat, Exception exception, params object[] parameters)
        {
            if (parameters == null) throw new ArgumentNullException("parameters");
            Error(string.Format(messageFormat, parameters), exception, ExtractCallerInfo(parameters));
        }
        /// <summary>
        /// Logs the specified fatal message with an exception.
        /// </summary>
        /// <param name="message">The fatal message.</param>
        /// <param name="exception">An exception to log with the message.</param>
        /// <param name="callerInfo">Information about the caller. Default is null, otherwise use <see cref="CallerInfo.Get"/>.</param>
        public void Fatal(string message, Exception exception, CallerInfo callerInfo = null)
        {
            Log(new LogMessage(Module, LogMessageType.Fatal, message, exception, callerInfo));
        }

        /// <summary>
        /// Logs the specified fatal message.
        /// </summary>
        /// <param name="message">The fatal message.</param>
        /// <param name="callerInfo">Information about the caller. Default is null, otherwise use <see cref="CallerInfo.Get"/>.</param>
        public void Fatal(string message, CallerInfo callerInfo = null)
        {
            Fatal(message, null, callerInfo);
        }

        /// <summary>
        /// Logs the specified fatal message.
        /// </summary>
        /// <param name="messageFormat">The fatal message to format.</param>
        /// <param name="parameters">The parameters to used with the <see cref="messageFormat" />. The last parameter can be used to store <see cref="CallerInfo"/></param>
        public void Fatal(string messageFormat, params object[] parameters)
        {
            Fatal(messageFormat, null, parameters);
        }

        /// <summary>
        /// Logs the specified fatal message with an exception.
        /// </summary>
        /// <param name="messageFormat">The fatal message to format.</param>
        /// <param name="exception">An exception to log with the message.</param>
        /// <param name="parameters">The parameters to used with the <see cref="messageFormat" />. The last parameter can be used to store <see cref="CallerInfo"/></param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public void Fatal(string messageFormat, Exception exception, params object[] parameters)
        {
            if (parameters == null) throw new ArgumentNullException("parameters");
            Fatal(string.Format(messageFormat, parameters), exception, ExtractCallerInfo(parameters));
        }
    }
}