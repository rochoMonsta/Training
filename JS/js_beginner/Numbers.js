// //Number in javaScript

// const number1 = 69 //integer
// const number2 = 69.69 //float
// const number3 = 2e2 //pow - 2 + 2(0)

// const result = Math.pow(2, 2)


// function checkNumber(number){
//     if (number > Number.MAX_SAFE_INTEGER){
//         console.log('This number is to big! Set to default value')
//         number = Number.MAX_SAFE_INTEGER

//         return number
//     }else{
//         console.log('This number get normal value.')
//         return number
//     }
// }
// console.log('MIN_SAFE_INTEGER', Number.MIN_SAFE_INTEGER)
// console.log('MAX_SAFE_INTEGER', Number.MAX_SAFE_INTEGER)
// console.log('POSITIVE_INFINITY', Number.POSITIVE_INFINITY)
// console.log('NEGATIVE_INFINITY', Number.NEGATIVE_INFINITY)
// console.log('MAX_VALUE', Number.MAX_VALUE)
// console.log('MIN_VALUE', Number.MIN_VALUE)
// console.log('NaN', Number.NaN)

// const weird = 2 / undefined
// console.log(isNaN(weird))

// console.log('42' + 2)
// console.log(Number.parseInt('40') + 2) //Convert.ToInt32(...)
// console.log('42.42' + 2)
// console.log(Number.parseFloat('40.42') + 2) //Convert.ToFloat(...)

// console.log(+'42' + 2) //Convert.ToInt32(...)
// console.log(+'42.42' + 2) //Convert.ToFloat(...)

// function getNumber(number){
//     if (Number.isInteger(number)){
//         return parseInt(number)
//     }else{
//         return parseFloat(number)
//     }
// }
// console.log(getNumber('42.424242'))

// console.log(0.4 + 0.2)
// console.log(parseFloat((0.4 + 0.2).toFixed(1)))
// console.log(+((0.4 + 0.2).toFixed(1)))

//BigInt

// console.log(Number.MAX_SAFE_INTEGER)
// console.log(typeof(9007199254740991)) //number
// console.log(typeof(9007199254740991n)) //bigint
// console.log(9007199254740991n - 9007199254740990n)

// console.log(10n - BigInt(4))

// function getNumber(number){
//     if (number > Number.MAX_SAFE_INTEGER){
//         return BigInt(parseInt(number + 'n'))
//     }else{
//         return parseInt(number)
//     }
// }
// console.log(getNumber('90071992312321312321231312312312312'))

//Math

// console.log('Math E:', Math.E)
// console.log('Math PI:', Math.PI)

// console.log('pow', Math.pow(2, 2))
// console.log('sqrt', Math.sqrt(25))
// console.log(Math.abs(-421))

// const numbers = [10, 22, 13, 111, -1, 0, 256]
// console.log(Math.max(10, 22, 13, 111, -1, 0, 256))
// console.log(Math.min(10, 22, 13, 111, -1, 0, 256))
// console.log('Math max array:', Math.max(...numbers))
// console.log('Math min array:', Math.min(...numbers))

// console.log(Math.floor(4.6)) // округляє в меншу сторону
// console.log(Math.ceil(4.6)) // округляє в більшу сторону
// console.log(Math.round(4.49)) // округляє число до більшого від 50 і до меншого від 49 <

// function getRandomBetween(min, max){
//     return Math.floor(Math.random() * (max - min + 1) + min)
// }
// console.log(getRandomBetween(1, 100))

// function getFibonacci(count){
//     if (count <= 0){
//         console.log('The value of Fibonacci cannot be negative')
//         return Number.NaN
//     }else if (count === 1){
//         return 0
//     }else{
//         let firstNumber = 0, secondNumber = 1
//         for (let i = 2; i < count; ++i){
//             const nextNumber = firstNumber + secondNumber
//             firstNumber = secondNumber
//             secondNumber = nextNumber
//         }
//         return secondNumber
//     }
// }
// console.log(getFibonacci(-1))


// function getParseNumber(number){
//     if (number > Number.MAX_SAFE_INTEGER){
//         return BigInt(parseInt(number + 'n'))
//     }else{
//         if (Number.isInteger(number)){
//             return parseInt(number)
//         }else{
//             return parseFloat(number)
//         }
//     }
// }
// console.log(getParseNumber('3213.22'));

// const cars = ['Mazda', 'BMW', 'Audi', 'Porsche', 'Lada']

// function showElementFrom(collections){
//     for (let i = 0; i < collections.length; ++i){
//         console.log(collections[i])
//     }
// }
// showElementFrom(cars)