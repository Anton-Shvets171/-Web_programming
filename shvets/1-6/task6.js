function sortByAge(arr) {
    arr.sort((a, b) => a.age > b.age ? 1 : -1);
}

let vasya = { name: "Вася", age: 25 };
let petya = { name: "Петя", age: 30 };
let masha = { name: "Маша", age: 28 };

let User = [ vasya, petya, masha ];

sortByAge(User);


console.log(User[0].name);
console.log(User[1].name);
console.log(User[2].name);
