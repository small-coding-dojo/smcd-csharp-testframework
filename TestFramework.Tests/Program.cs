// See https://aka.ms/new-console-template for more information
// Tests
// Pseudo Code for our current approach:
// Run the test runner
// Verify that the test runner printed "0 tests executed successfully"

using System.Diagnostics;

Console.WriteLine(Directory.GetCurrentDirectory());

var testrunner = new Process();
testrunner.StartInfo.FileName = "/Users/stefan/source/small-coding-dojo/smcd-csharp-testframework/TestFramework/bin/Debug/net8.0/TestFramework";
testrunner.StartInfo.UseShellExecute = false;
testrunner.StartInfo.WorkingDirectory = "/Users/stefan/source/small-coding-dojo/smcd-csharp-testframework/TestFramework/bin/Debug/net8.0";

testrunner.Start();