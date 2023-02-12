using System;
using System.IO;
using Microsoft.Data.Sqlite;
using MyLogger;
var fileLogger = new FileLogger("log.txt");
var consoleLogger = new ConsoleLogger();
fileLogger.Log("Application started", LogLevel.Info);
consoleLogger.Log("Application started", LogLevel.Info);
consoleLogger.Log("Doing some work...", LogLevel.Debug);

