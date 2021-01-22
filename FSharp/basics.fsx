// In Visual Studio use Alt + Enter to evaluate a line

// let binds a name to a simple value or expression
let x = 32
// val x : int = 32

// Arrays are defined with [| |]
// Elements on the same line are separated by semicolons
[| 1; 2; 3; |]
// val it : int [] = [|1; 2; 3|]

// A linked list is defined with [ ]
[ 8; 9; 10 ]
// val it : int list = [8; 9; 10]

// A sequence is defined with seq { }
// Sequences are lazily evaulated
seq { 14; 15; 16 }

// Functions use spaces to separate arguments
let add x y = x + y
add 3 8

// A tuple is a grouping of unnamed but ordered values, possibly of different types
let explicitTuple : int * string = (4, "bar")
let implicitTyple = (5, "foo")

// Records are immutable and have structural equality
type Person =
    { name : string
      age : int }
let jack =
    { name = "Jack"
      age = 25 }
let olderJack = { jack with age = jack.age + 1 }

// The fun keyword defines an anonymous function aka a lambda expression
fun (name:string) -> "Hello " + name
