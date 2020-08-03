// CodeWars - https://www.codewars.com/kata/58aed2cafab8faca1d000e20/javascript

//You are provided with array of positive non-zero ints and int n representing n-th power (n >= 2).
//For the given array, calculate the sum of each value to the n-th power. Then subtract the sum of the original array.
//Example 1: Input: {1, 2, 3}, 3 --> (1 ^ 3 + 2 ^ 3 + 3 ^ 3 ) - (1 + 2 + 3) --> 36 - 6 --> Output: 30

function modifiedSum(a, n) {
    // let pow = 0
    // for(let element of a){
    //     pow += Math.pow(element, n)
    // }
    // return pow - a.reduce((result, value) => result + value)
    return a.reduce((s, c) => s + Math.pow(c, n) - c, 0);
}
console.log(modifiedSum([1, 2, 3], 3))