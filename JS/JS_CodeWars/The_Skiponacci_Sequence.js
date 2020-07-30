function skiponacci(n) {
    if (n <= 2){
        return '1'
    }else{
        let first = 1, second = 1, array = []
        for (let index = 2; index <= n + 1; ++index){
            if (index % 2 === 0){
                array[array.length] = first
            }
            let box = first
            first = second
            second += box
        }
        return array.join(' skip ')
    }
}
console.log(skiponacci(12))