var a = 5, b = 6
console.log(a++)
console.log(++a)

console.log(a+b)
console.log(a>b)

function fib(a){
    if(a == 0){
        return(0)
    }
    else if(a == 1){
        return(1)
    }
    return fib(a-1) + fib(a-2)
}

for(let i = 0; i<10; i++){
    console.log(fib(i))
}

