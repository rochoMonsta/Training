//alert - спливаюче вікно з текстом який ми передаємо як параметр
//alert(1)

//const - значення не міняються
// const nameSurname = 'Roman Cholkan' //string

//let - будь які значення які в процесі розробки можуть мінятись
//let age = 20 //number

//const isProgrammer = true //boolean

//console.log(параметри) - виведення елементів в консоль які передані як параметри
//console.log('Людина: ' + nameSurname + ', а вік людини: ' + age)
//console.log(age.toString())

//prompt(параметр) - функція яка дозволяє викликати інтерактивне спливаюче вікно в яке можна ввести дані які
//                   приствоєні певному значенню
// const enterInput = prompt('Введіть імя: ')
// console.log(enterInput)

// const birthDate = 2000
// const currentDate = 2020
// const age = currentDate - birthDate


// const firstVar = 10
// const secondVar = 10
// console.log(firstVar == secondVar)

// const fullName = 'Roman Cholkan'
// const isProgrammer = true
// const age = 20
// let none

// console.log(typeof fullName)
// console.log(typeof isProgrammer)
// console.log(typeof age)
// console.log(typeof none)

// const courseStatus = 'pending' //ready, fail, done

// if (courseStatus === 'pending'){
//     console.log('Курс наразі знаходиться в процесі виконання.')
// }else if (courseStatus === 'ready'){
//     console.log('Курс готовий для проходження.')
// }else if (courseStatus === 'fail'){
//     console.log('Курс провалений.')
// }else{
//     console.log('Курс не існує або не був пройдений.')
// }

// switch(courseStatus){
//     case 'pending': console.log('Курс наразі знаходиться в процесі виконання.'); break;
//     case 'ready': console.log('Курс готовий для проходження.'); break;
//     case 'fail': console.log('Курс провалений.'); break;
//     default: console.log('Статус курсу не підвердежний.');
// }

// const number1 = 42
// const number2 = '42'
// == - виконує приведення типів до стрінга та перевіряє стрінги на однаковість
// === - виконує перевірку типів даних та значень даних
// console.log(number1 === number2)


// const isReady = true
// isReady ? console.log('Ready.') : console.log('Not ready.')
// const bigerNumber = 42 > 20 ? 42 : 20
// console.log(bigerNumber)

// const number1 = 8, number3 = 9
// const number2 = 7

// if (number1 >= 10 || number2 >= 10 || number3 >= 10){
//     console.log('Всі числа більше 10')
// }
// const isProgrammer = true
// console.log(!!!isProgrammer)

//----------------------------------------------------------------------------------------------------------
//Функції...

// function calculateAge(year){
//     return 2020 - year
// }

// function getNumbersFrom(startNumber, endNumber){
//     for(startNumber; startNumber <= endNumber; ++startNumber){
//         console.log('Your number: ' + startNumber)
//     }
// }

// function getInfoAboutPerson(name, year){
//     const age = calculateAge(year)
//     return name + ', ' + age
// }
// const personAge = calculateAge(2000)

// console.log('Person age: ' + personAge)

// console.log(getInfoAboutPerson('Roman Cholkan', 2000))
// getNumbersFrom(1, 10)

//----------------------------------------------------------------------------------------------------------
//Масиви
// const cars = ['БМВ', 'Мерседес', 'Ауди', 'Ферарри']
// // const cars = new Array('БМВ', 'Мерседес', 'Ауди', 'Ферарри')
// console.log(cars)

// function getElementFromArray(array){
//     array.forEach(element => {
//         console.log(element)
//     });
// }

// cars[0] = 'Порш'
// cars[cars.length] = 'Mazda'
// console.log(cars)


//----------------------------------------------------------------------------------------------------------
//цикли
// const cars = ['БМВ', 'Мерседес', 'Ауди', 'Ферарри']

// for (let i = 0; i < cars.length; ++i){
//     console.log(cars[i]);
// }
// for (let car of cars){
//     console.log(car)
// }

//----------------------------------------------------------------------------------------------------------
//об'єети

// const person = {
//     firstName: 'Roman',
//     lastName: 'Cholkan',
//     age: 20,
//     language: ['Ru', 'Ukr', 'En'],
//     hasGirlfriend: false,
//     getInfo: function(){
//         console.log(this.firstName + ' ' + this.lastName + ' ' + this.age);
//     }
// }
// person.getInfo()

// console.log(person.firstName)
// console.log(person['firstName'])
// const key = 'firstName'
// console.log(person[key])

// person.isProgrammer = true
// console.log(person)