var orderedCount = function (text) {
    let list = []
    for (let letter of text){
        list.push([letter, 1])
    }
    return list
}
console.log(orderedCount('abbcd'))