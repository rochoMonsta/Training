function solve(arr){
    // for(let number of arr){
    //     if (!arr.includes(number * -1)){
    //         return number
    //     }
    // }
    // return -1
    return arr.filter(x => !arr.includes(x * - 1))[0]
}

const solve2 = arr => arr.find(number => !arr.includes(-number))

console.log(solve2([-3,1,2,3,-1,-4,-2]))