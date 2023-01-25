let i = 2;
let a = ++i;
let b = i++;
console.log(i);
if (a > b) {
    console.log('a больше b!')
} else if (b > a) {
    console.log('b больше a!')
} else {
    console.log('a ровняется b!')
}

// Ответ: a ровняется b!
