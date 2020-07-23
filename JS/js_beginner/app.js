// 1 Функції

//function declaration
//можна викликати в будь якому місці коду, навіть до створення функції
// function getGreet(name){
//     console.log('Hello, ', name)
// }
//function expression
//можна звератись тільки тоді, коли функція створена, тобто якщо виклик функції знаходиться на 3 рядку, а сама функція після 3 рядка
//то виникне помилка
// const greet = function(name){ //анонімна функція яка запакована в змінну
//     console.log('Hello2, ', name)
// }
// const greet3 = function greetName(name){
//     console.log('Hello greetName func ', name)
// }
// getGreet('Roman')
// greet('Roman')
// greet3('Roman')

// 2 Анонімні функції

// let counter = 1
// const interval = setInterval(function(){
//     if (counter === 10){
//         clearInterval(interval)
//     }else{
//         console.log(counter++)
//     }
// }, 1000)

// 3 Стрєлочние функції

// function getGreet(name){
//     console.log('Hello, ', name)
// }

// const arrow = (name) => {
//     console.log('Hello, ', name)
// }
// const arrow2 = name => console.log('Hello, ', name) // same

// const pow2 = num => {
//     return num ** 2 //Math.pow(num, 2)
// }
// const pow22 = num => num ** 2 //same to pow2

// getGreet('Roman') //same
// arrow('Roman') //same
// arrow2('Roman')

// console.log(pow2(5))
// console.log(pow22(5))

// 4 параметри по замовчуванню

// const sum = (a, b) => a + b
// console.log(sum(41, 1)) //якщо не передати 1 з чисел отримаємо NaN

//Ми можемо задати значення по замовчуванню наступним чином, в параметрах прописати значення яке буде застосовуватись в випадку
// відсутності параметра b = 1
// const sum2 = (a, b = 1) => a + b
// console.log(sum2(41)) // 42

// const sum3 = (a = 1, b = 1) => a + b
// console.log(sum3()) //2

// const sum4 = (a = 2, b = a * 2) => a + b
// console.log(sum4()) //6

// const greet = (name, age) => console.log(`Вітаємо, ${name}. Тобі вже ${age} років!`)
// greet('Roman', 20)

// const greet1 = (name = 'User', age = '16') => console.log(`Вітаємо, ${name}. Тобі вже ${age} років!`)
// greet1()

//... - те ж саме що params c# (...name) - групує всі вхідні елементи в масив під назвою name
// function sumAll(...all){
//     let result = 0
//     for (let element of all){
//         result += element
//     }
//     return result
// }
// console.log(sumAll(1,2,3,4,5,6,7,8))

// 5 Замикання

function createMember(name){
    return function(lastName){ //Отримуємо функцію яка зберігає в собі параметр name після чого працює завжди з ним
        console.log(name + ' ' + lastName)
    }
}
const logWithFirstName = createMember('Roman')
console.log(logWithFirstName('Cholkan'))
console.log(logWithFirstName('Black'))
console.log(logWithFirstName('Stone'))