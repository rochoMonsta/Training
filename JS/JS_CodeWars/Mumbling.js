// CodeWars - https://www.codewars.com/kata/5667e8f4e3f572a8f2000039/javascript

// This time no story, no theory. The examples below show you how to write function accum:

//Examples:

//accum("abcd") -> "A-Bb-Ccc-Dddd"
//accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
//accum("cwAt") -> "C-Ww-Aaa-Tttt"

function accum(s) {
    let result = ''
    for (let letter = 0; letter < s.length; ++letter){
        result += s[letter].toUpperCase()
        for (let symbol = 1; symbol <= letter; ++symbol){
            result += s[letter].toLowerCase()
        }
        if (letter + 1 != s.length){
            result += '-'
        }
    }
    return result
}

function accumVersion2(s) {
    return s.split('').map((c, i) => (c.toUpperCase() + c.toLowerCase().repeat(i))).join('-');
}

console.log(accum('ZpglnRxqenU'))