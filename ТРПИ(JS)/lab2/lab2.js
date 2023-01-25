// //1
// var radius=+prompt('Введите радиус круга');
// Diametrkruga(radius)

// //Function Declaration 
// function Diametrkruga(radius) {
//     var Diametr = radius + radius
//     alert (`Диаметр круга = ${Diametr}`)
// }
// //функции-стрелки
// var Ploshad = (radius) => 3.14 * 2 * radius;
// alert (`Площадь круга = ${Ploshad (radius)}`)

// Ploshad(radius)

// //Function Expression

// var Dlinaokr = function(radius){
//     var Dlinaokr= 3.14*radius*radius
//     alert(`Длина окружности = ${Dlinaokr}`)
// }

// Dlinaokr(radius)

//  //2 Реализуйте функцию с тремя параметрами. Первый параметр по умолчанию. Третий параметр вводит пользователь. Функция возвращает строку из трех параметров.
//     const threeParameter = (second, third, first = "default") => {
//     console.log(first + second + thirdParameter)
//     }
    
//     const thirdParameter = Number(prompt('Введите что-то =)'))
//     threeParameter(10);

//3	 Реализуйте функцию, которая рассчитывает количество присутствующих студентов.


// function NumberOfStudents(StudentValue = 0) {
//     var StudentName= prompt(`Введите имена студентов. При окончании записи нажмите OK`)
//     if(StudentName == ''){
//         alert(`Количесвто студентов ${StudentValue}`)
//         return;
//     }
//     else{
//         StudentValue++
//     }
//     NumberOfStudents(StudentValue)
// }


//  NumberOfStudents()

// //4	Вы забыли пароль от электронной почты. Вы помните, что он состоит из 8 символов нижнего регистра. Первые 5 – это буквы английского алфавита, последние 3 – цифры.  Один пароль вы успеваете ввести за 3 секунды. 
// let countLettersInEn = 26;
// let countNumbers = 10;
// let countPositionForLetters = 5;
// let countPositionForNumbers = 3;
// let propability = Math.pow(countLettersInEn, countPositionForLetters) * Math.pow(countNumbers, countPositionForNumbers);
// let averageTime = 3; // seconds
// let seconds = propability * averageTime;
// let minutes = seconds / 60;
// seconds = seconds % 60;
// let hours = minutes / 60;
// console.log("minutes1: " + minutes)
// minutes = minutes % 60;
// console.log("minutes: " + minutes)
// let days = hours / 24;
 //hours = hours % 24;
//let years = days / 365;
//days = days % 365;
// alert(`
//     Years: ${Math.floor(years)},
//     days: ${Math.floor(days)},
//     hours: ${Math.floor(hours)},
//     minutes: ${Math.floor(minutes)},
//     seconds: ${Math.floor(seconds)}
// `);
    

// //5	Пользователь вводит данные. Если он ввел число, то преобразуйте его в 16-ричную систему счисления (вывод в верхнем регистре). Если число дробное – округлите его до наибольшего, наименьшего и ближайшего целого. Если пользователь ввел текст, то преобразуйте его к верхнему и нижнему регистру.
 let StringOrNumber = prompt('Введите значение:','');
 let CheckStringOrNumber= + StringOrNumber;
 let Choice = 1;
 if(isNaN(CheckStringOrNumber) == false){
     Choice = 3;
     if(CheckStringOrNumber > Math.trunc(CheckStringOrNumber)){
         Choice = 2;
     }
 }
 switch(Choice){
     case 1:{
         alert(StringOrNumber.toUpperCase());
         alert(StringOrNumber.toLowerCase());
         break;
     };
     case 2:{
         StringOrNumber = + StringOrNumber;
         alert(Math.trunc(StringOrNumber+1));
         alert(Math.trunc(StringOrNumber));
         alert(Math.round(StringOrNumber));
         break;
     }
     case 3:{
         StringOrNumber = + StringOrNumber;
         alert(parseInt(StringOrNumber,16))
         break;
     } 
     case 4:{
        if (StringOrNumber % 2 == 0) {
            alert(`ok`)
        }
        else {
            alert(`no ok`)
        }
     }
 }

//  //6  Выпускник сдает ЦТ по русскому языку. Ему дано словарное слово, необходимо ввести в текстовое поле правильный вариант ответа. Проверьте его ответ и сообщите в каком символе он допустил ошибку, если она есть.
//  let Wort = prompt('Введите словарное слово: Д*р*га');
// let counter = 0;
// Wort[0].toUpperCase;
// let TrueWort = 'Дорога';
// for(let i = 0; i<TrueWort.length;i++ )
// if(Wort[i]!=TrueWort[i]){
//     alert(`Символ ${Wort[i]} неверный`);
//     break; //если убрать, показывает все неверные символы
// }

// else {
//     counter++;
//     if (counter == TrueWort.length)
//     alert('Всё введено верно!');
// }

// //7 Разработайте геометрический калькулятор для расчета параметров треугольника: площадь, периметр, высота, cos, sin, tg, ctg. Пользователь указывает длину катетов.
// var kat1 = +prompt("Введите первый катет: ");
// var kat2 = +prompt("Введите второй катет: ");
// if(kat1<=0 || kat2<=0){
//     alert('Катет не может быть отрицательным')
// }
// else{
// triangle(kat1, kat2);
// function triangle(kat1, kat2){
//     let hyp = (kat1*kat1+kat2*kat2)**(1/2);
//     let square = (kat1*kat2)/2;
//     alert (`площадь равна: ${square} `);
//     let perimeter = kat1+kat2+hyp;
//     alert (`Периметр равен: ${perimeter}`);
//     let height = (kat1*kat2*2)/hyp;
//     alert (`высота равна: ${height}`);
//     let sin = kat1/hyp;
//     alert (`sin b: ${sin}`);
//     let cos = kat2/hyp;
//     alert (`cos b: ${cos}`);
//     let tan = kat1/kat2;
//     alert (`tan b: ${tan}`);
//     let cot = kat2/hyp;
//     alert (`cot b: ${cot}`);
//     let sin2 = kat2/hyp;
//     alert (`sin a: ${sin2}`);
//     let cos2 = kat1/hyp;
//     alert (`cos a: ${cos2}`);
//     let tan2 = kat2/kat1;
//     alert (`tan a: ${tan2}`);
//     let cot2 = kat1/hyp;
//     alert (`cot a: ${cot2}`);
//     }
// }
























