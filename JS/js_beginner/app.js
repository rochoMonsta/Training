const person = {
    name: 'Roman',
    surname: 'Cholkan',
    age: 20,
    languages: ['Ru', 'En', 'Ukr'],
    personInfo(){
        console.log(`${this.name} - ${this.surname} - ${this.age}`)
    },
    getLanguage(){
        for (let language of this.languages){
            console.log(language)
        }
    },
    'phone number': '+380636881341',
    ['key_' + (1 + 3)]: 'Some info' //key_4
}
// //Можна звертатись до полів по їх назві
// console.log(person.name)
// console.log(person['name'])

// //Можна звертатись до полів за допомогою окремих зміних який присвоїли ім'я поля
// const personPhoneNumber = 'phone number'
// console.log(person[personPhoneNumber])

// console.log(person['phone number'])

// person.personInfo()
// person.getLanguage()

// person.age++
// person.languages.push('Pl')
// console.log(person)

// person['key_4'] = undefined
// //Видалення полів з об'єкту
// delete person['key_4']


// const name = person.name
// const surname = person.surname
// const age = person.age

// const {name, surname, age, languages} = person //отримуємо значення з полів певного об'єкта "накшталт (out c#)"
// //or Можемо перевизначити імена вказавши поля які хочемо витягнути з об'єкту та їхню нову назву
// //також можна виставляти значення по замовчуванню (age: personAge = 16)
// const {name: personName, languages: personLanguage, age: personAge = 16} = person
// console.log(personLanguage, personName)

// console.log(name, surname, age, languages)


//Цикл в якому через оператор in ми отримуємо ключі об'єкту person, після чого ми можемо звертатись до полів за ключами
// for (let key in person){
//     //перевірка чи ключ є ключом об'єкта щоб не використовувати ключі прототипа
//     if (person.hasOwnProperty(key)){
//         console.log(`key: ${key}, value: ${person[key]}`)
//     }
// }
// const personKeys = Object.keys(person) // отримуємо всі ключі заданого об'єкту
// for (let key of personKeys){
//     console.log(`key: ${key}, value: ${person[key]}`)
// }
// personKeys.forEach(key => console.log(`key: ${key}; value: ${person[key]}`))
// Object.keys(person).forEach(key => console.log(`key: ${key}; value: ${person[key]}`))
// console.log(person)

//Context
const logger = {
    getKeys(){
        console.log('Object keys: ', Object.keys(this))
    },
    getKeysAndValues(){
        Object.keys(this).forEach(key => console.log(`key: ${key} - value: ${this[key]}`))
    },
    withParams(start = false, between = false, end = false){
        if (start){
            console.log('---------- start ----------')
        }
        Object.keys(this).forEach((key, index, array) => {
            console.log(`key: "${key}" - value: "${this[key]}"`)
            if (between && index != array.length - 1){
                console.log('--------------------')
            }
        })
        if (end){
            console.log('---------- end ----------')
        }
    }
}
// const bound = logger.getKeys.bind(person) // bind означає, що ми замість параметра this передаємо наш об'єкт    
// bound()

// //те ж саме що bind тільки в цьому випадку, ми вже не створюємо функцію а одразу її застосовуємо
// logger.getKeys.call(person)
// logger.getKeysAndValues.call(person)
//logger.withParams.call(person, true, true, true)
logger.withParams.apply(person, [true, true, true]) // передаємо наш контекст та ті елементи, які передаються разом з ним в форматі масиву