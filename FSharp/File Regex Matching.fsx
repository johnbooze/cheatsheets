open System.IO
open System.Text.RegularExpressions

let logFile = FileInfo (@"C:\PathToYour\file.txt")
// Example line:
// [Tue 10/17/2017  2:30:40.19] Logging text
let logFilePattern = Regex (@"\[(?<DateTime>.+ (\d\d/\d\d/\d\d\d\d) ( |\d)(\d:\d\d:\d\d\.\d\d))] (?<LogText>.*)")

let logLines =
    File.ReadLines(logFile.FullName)
    |> Seq.mapi (fun i line -> (i + 1, line, logFilePattern.Match line))
    |> Seq.filter (fun (lineNumber,line,m) -> m.Success)
    |> Seq.map (fun (lineNumber,line,m) -> (lineNumber, m.Groups.["DateTime"].Value, m.Groups.["LogText"].Value ) )

for logline in logLines do
    printfn "%A" logline
