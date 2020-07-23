// String

// const name = 'Чолкан Роман'
// const age = 20

// const person = {
//     firstName: 'Роман',
//     lastName: 'Чолкан',
//     age: 20,
//     getFullName: function(){
//         return `${this.firstName} ${this.lastName}`
//     }
// }

// console.log(typeof name) //string
//const output = 'Привіт мене звуть ' + name + ' і мені ' + age + ' років.' //не використовувати

// const output = `Привіт мене звуть ${person.getFullName()} і мені ${person.age} років.`
// //Приклад прописування логіки в середині ${}
// const output2 = `${person.age > 18 ? 'Вам дозволено увійти' : 'Вам заборонено увійти'} в це приміщення.`

// console.log(output)
// console.log(output2)

//Можна використовувати ``для того щоб динамічно передавати параметри та зберігати всі відступи тощо.

// const output3 = `
//     <h1>Привіт сусіди</h1>
// `
// console.log(output3)

// const firstName = 'Roman'
// console.log(firstName.length);
// console.log(firstName.toUpperCase())
// console.log(firstName.toLowerCase())
// console.log(firstName.charAt(2)) //m отримування char під індексом.
// console.log(firstName.indexOf('h')) //3... показує індекс з якого починається вхідна строка якщо вона присутня в firstName (-1) - якщо ні
// console.log(firstName.startsWith('ro')) //false
// console.log(firstName.startsWith('Ro')) //true
// console.log(firstName.endsWith('man')) //true
// console.log(firstName.endsWith('gg')) // false
// console.log(firstName.repeat(3))

// const spaceString = '       password      '
// console.log(spaceString.trim())

// function isHave(word, coincidence){
//     if (word.indexOf(coincidence) > 0){
//         return word.replace(coincidence, 'DOG')
//     }else{
//         return word
//     }
// }
// console.log(isHave(firstName, 'man'))


function logPerson(s, fullName, personAge){
    if (personAge < 0){
        personAge = 'Ще не народився'
    }
    if (fullName === null || fullName.trim() === ''){
        fullName = 'Не вказано'
    }
    return `${s[0]}${fullName}${s[1]}${personAge}${s[2]}`
}

const nameSurname = 'Roman Cholkan', age = 20
const output = logPerson`Ім'я: ${nameSurname}. Вік: ${age}.`

console.log(output)