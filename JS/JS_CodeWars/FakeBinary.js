// CodeWars - https://www.codewars.com/kata/57eae65a4321032ce000002d/javascript

//Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. 
//Return the resulting string.

// First solution
function fakeBin(x){
    let result = ''
    for (let i = 0; i < x.length; ++i){
        if (x[i] >= 5){
            result += '1'
        }else if (x[i] < 5){
            result += '0'
        }
    }
    return result
}

// Second solution
function changeString(someElement){
    return someElement.split('').map(n => n < 5 ? 0 : 1).join('')
}
console.log(changeString('45385593107843568') === '01011110001100111') // true
console.log(fakeBin('45385593107843568') === '01011110001100111') // true
