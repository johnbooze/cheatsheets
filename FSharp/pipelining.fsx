open Printf

// .. specifies a range
let oneThruTen = seq { 1 .. 5 }

// |> is the pipeline operator
// Seq,List, and Array define many functions that work well with pipelining
oneThruTen |> Seq.map (fun n -> sprintf "Processing %i" n)

// Seq.iter expects unit output so use that if just printing out the values
oneThruTen |> Seq.iter (fun n -> printfn "Processing %i" n)

// Multiply every item by 2
oneThruTen |> Seq.map (fun n -> n * 2)

// Filter to items greater than 3
oneThruTen |> Seq.filter (fun n -> n > 3)

// You can of course bind the outputs with let
let numbersTimesTwo = oneThruTen |> Seq.map (fun n -> n * 2)
let numbersTimesTwoGreaterThanThree = numbersTimesTwo |> Seq.filter (fun n -> n > 3)
let processingOutput = numbersTimesTwoGreaterThanThree |> Seq.map (fun n -> sprintf "Processing %i" n)
processingOutput |> Seq.iter (fun s -> System.Console.WriteLine(s))

// Pipelining really shines when chaining together
oneThruTen
    |> Seq.map (fun n -> n * 2)
    |> Seq.filter (fun n -> n > 3)
    |> Seq.map (fun n -> sprintf "Processing %i" n)
    |> Seq.iter (fun s -> printfn "%s" s )

// Official docs on Function composition and pipelining:
// https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/functions/#function-composition-and-pipelining
