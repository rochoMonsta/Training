// CodeWars - https://www.codewars.com/kata/5a0be7ea8ba914fc9c00006b

//Suppose that the falling speed of a petal is 5 centimeters per second (5 cm/s), 
//and it takes 80 seconds for the petal to reach the ground from a certain branch.
//Write a function that receives the speed (in cm/s) of a petal as input, 
//and returns the time it takes for that petal to reach the ground from the same branch.


// First solution
function sakuraFall(v) {
    const branchHeight = 400
    return v > 0 ? 400 / v : 0
}

// Second solution
const sakuraFall2 = (velocity) => velocity > 0 ? 400 / velocity : 0

console.log(sakuraFall2(20))
console.log(sakuraFall(-1))