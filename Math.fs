module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =  
    let mutable count = 0
    let mutable num = int64 n

    while num <> 1L do 
        if num % 2L = 0L then
            num <- num / 2L
        else
            num <- 3L * num + 1L
        count <- count + 1

    count
