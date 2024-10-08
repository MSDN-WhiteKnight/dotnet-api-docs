﻿module batouint32

//<Snippet2>
open System

let print obj1 obj2 obj3 = printfn $"{obj1,5}{obj2,17}{obj3,15}"

// Convert four byte array elements to a uint and display it.
let BAToUInt32 bytes index =
    let value = BitConverter.ToUInt32(bytes, index)

    print index (BitConverter.ToString(bytes, index, 4)) value

let byteArray =
    [| 15uy; 0uy; 0uy; 0uy; 0uy; 16uy; 0uy; 255uy; 3uy; 0uy
       0uy; 202uy; 154uy; 59uy; 255uy; 255uy; 255uy; 255uy; 127uy |]

printfn "This example of the BitConverter.ToUInt32(byte [], int) \nmethod generates the following output. It converts elements \nof a byte array to uint values.\n"
printfn "initial byte array"
printfn "------------------"
printfn $"{BitConverter.ToString byteArray}\n"
print "index" "array elements" "uint"
print "-----" "--------------" "----"

// Convert byte array elements to uint values.
BAToUInt32 byteArray 1
BAToUInt32 byteArray 0
BAToUInt32 byteArray 7
BAToUInt32 byteArray 3
BAToUInt32 byteArray 10
BAToUInt32 byteArray 15
BAToUInt32 byteArray 14


// This example of the BitConverter.ToUInt32(byte [], int)
// method generates the following output. It converts elements
// of a byte array to uint values.
//
// initial byte array
// ------------------
// 0F-00-00-00-00-10-00-FF-03-00-00-CA-9A-3B-FF-FF-FF-FF-7F
//
// index   array elements           uint
// -----   --------------           ----
//     1      00-00-00-00              0
//     0      0F-00-00-00             15
//     7      FF-03-00-00           1023
//     3      00-00-10-00        1048576
//    10      00-CA-9A-3B     1000000000
//    15      FF-FF-FF-7F     2147483647
//    14      FF-FF-FF-FF     4294967295
//</Snippet2>