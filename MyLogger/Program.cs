using System;
using System.IO;
using Microsoft.Data.Sqlite;
using MyLogger;
var fileLogger = new FileLogger("log.txt");
var consoleLogger = new ConsoleLogger();

var databaseLogger = new DatabaseLogger("Data Source = log.db");

databaseLogger.Log("Application started", LogLevel.Info);
consoleLogger.Log("Doing some work...", LogLevel.Debug);
fileLogger.Log("Application started", LogLevel.Info);
consoleLogger.Log("Application started", LogLevel.Info);
consoleLogger.Log("Doing some work...", LogLevel.Debug);

