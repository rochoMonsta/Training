const cars = ['Mazda', 'Ford', 'BMW', 'Mercedes']
const fib = [0, 1, 1, 2, 3, 5, 8, 13]
const people = [
    {name: 'Роман', surname: 'Чолкан', budget: 4200},
    {name: 'Вадім', surname: 'Яковлєв', budget: 3750},
    {name: 'Антон', surname: 'Ломовацький', budget: 1900},
    {name: 'Соломія', surname: 'Сорокотяга', budget: 12000},
    {name: 'Ірена', surname: 'Сорокотяга', budget: 1240}
]

// cars.push('Lada') // додаємо елемент в кінець масиву
// cars.unshift('Porche') // додаємо елемент на початок масиву

// console.log(cars)

// const firstCar = cars.shift() // забирає перший елемент з масиву та вертає його
// const lastCar = cars.pop() // забирає останній елемент з масиву та вертає його

// console.log('First car: ' + firstCar)
// console.log('Last car: ' + lastCar)

// console.log(cars)
// console.log(cars.reverse())

// const palindrome = (word) => {
//     return word.toLowerCase() === word.toLowerCase().split('').reverse().join('') ? true : false
// }
// console.log(palindrome('Aba'))

// cars[cars.indexOf('BMW')] = 'Lada' // отримуємо індекс заданого елементу та міняємо значення по індексу
// console.log(cars)

// const index = people.findIndex(function(person){
//     return person.surname === 'Чолкан'
// })
// const some = people.find(function(person){
//     return person.surname === 'Сорокотяга'
// })
// console.log(people[index])
// console.log(some)

// function getPerson(personSurname){
//     for (const person of people){
//         if (person.surname === personSurname){
//             return person
//         }
//     }
//     return -1
// }
// const person = people.find((person) => {
//     return person.surname === 'Сорокотяга'
// })

// console.log(person)
// console.log(getPerson('Сорокотяга'))

// const personSurname = 'Сорокотяга'
// const person = people.find(x => x.surname === personSurname)

// console.log(cars.includes('BMW')) // includes - повертає true/false - якщо переданий елемен є наявний в масиві
// console.log(person)
// console.log((typeof person) === 'undefined')

// const upperCaseCars = cars.map(x => x.toUpperCase())
// console.log(upperCaseCars)

// const fib2Pow = fib.map(number => number ** 2)
// console.log(fib2Pow)

// const fibonacci = number => number ** 2
// const sqrt = number => Math.sqrt(number)

// const fibonacci2 = fib.map(fibonacci).map(sqrt)
// console.log(fibonacci2)

// const family = people.filter(person => person.surname === 'Сорокотяга')
// console.log(family)

// const evenNumbers = fib.filter(x => x % 2 === 0)
// console.log(evenNumbers)

const allBudget = people.reduce((budget, person) => {
    if (person.budget > 2000){
        budget += person.budget
    }
    return budget
}, 0)

const allBudget2 = people.filter(person => person.budget > 2000)
    .reduce((budget, person) => {
        budget += person.budget
        return budget
    }, 0)

console.log(allBudget)
console.log(allBudget2)