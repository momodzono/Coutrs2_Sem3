// Расчет площади четырхугоьника, если это прямоугольник

// Values of A sides
let firstSide = 45;
let secondSide = 21;

// Values of B sides
let commonSide = 5;

function quadrangularArea(a, b) {
    return a * b; 
}

let areaA = quadrangularArea(firstSide, secondSide);
let areaB = quadrangularArea(commonSide, commonSide)

let numberOfBInA = Math.floor(areaA / areaB)

console.log(`Количество квадратов B, которое поместится в четырхугольник А, ровняется: ${numberOfBInA}`);


