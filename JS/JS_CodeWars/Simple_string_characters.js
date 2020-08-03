function solve(s){
    let array = [0, 0, 0, 0]
    for(let letter of s){
        if (letter.toLowerCase() > letter){ array[0]++ }
        else if (letter.toUpperCase() < letter){ array[1]++ }
        else if (letter >= 0 && letter <= 9){ array[2]++ }
        else{ array[3]++ }
    }
    return array
}
console.log(solve('Codewars@codewars123.com'))