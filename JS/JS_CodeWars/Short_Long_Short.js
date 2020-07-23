// CodeWars - https://www.codewars.com/kata/50654ddff44f800200000007/javascript

//Given 2 strings, a and b, return a string of the form short+long+short, 
//with the shorter string on the outside and the longer string on the inside. 
//The strings will not be the same length, but they may be empty ( length 0 ).


// First solution
function solution(a, b){
    let shortWord, longWord
    if (a.length > b.length){
        shortWord = b
        longWord = a
    }else{
        shortWord = a
        longWord = b
    }
    return `${shortWord}${longWord}${shortWord}`
}

// Second solution
function solution2(a, b){
    return a.length > b.length ? b + a + b : a + b + a
}
 console.log(solution2('1', '22')) 