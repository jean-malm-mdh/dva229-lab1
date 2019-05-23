module Lab1



// val add10 : int -> int
// Given an integer m, it returns m + 10.



// let add10...



// val add20 : int -> int
// Given an integer m, it returns m + 20.
//
// Note:
//   * Define add20 using add10.
//   * You cannot use arithmetic operators.



// let add20...



// val add_mn : int -> int -> int
// Given one integer m and one non-negative integer n, it returns m + 10 * n.
//
// Note:
//   * Define add_mn using add10.
//   * You cannot use arithmetic operators to directly compute the return
//     value.



let rec add_mn _ = failwith "Error @ add_mn: Not implemented!"



// val vSum : (float * float) list -> float * float
// Given a non-empty list of 2D-vectors, it returns their sum.
// If the input list is empty, vSum throws an exception.
//
// Note:
//   * Define vSum using vAdd.
//   * You cannot use arithmetic operators.



let vAdd (x1, y1) (x2, y2) : float * float = (x1 + x2, y1 + y2)



let rec vSum _ = failwith "Error @ vSum: Not implemented!"
