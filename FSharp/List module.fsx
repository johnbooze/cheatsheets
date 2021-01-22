// List module
// The Seq and Array modules have similar functions

// https://fsharp.github.io/fsharp-core-docs/reference/fsharp-collections-listmodule.html

List.map
List.filter
List.iter

List.exactlyOne
List.tryFind
List.truncate
List.distinct

List.sort
List.sortDescending

List.max
List.min
List.sum
List.average
// Note: Most of the aggregation functions do not like empty lists! You might consider using one of the fold functions to be safe.

List.groupBy

List.forall
List.exists

[1;2;3;4;5] |> List.pairwise

// https://fsharpforfunandprofit.com/posts/list-module-functions/
