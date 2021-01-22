open System.Diagnostics

let applicationLog = new EventLog ("Application")

// Get first 10 Errors
seq { for e in applicationLog.Entries do e }
|> Seq.filter (fun e -> e.EntryType = EventLogEntryType.Error)
|> Seq.truncate 10
