function func1() {
    if(arguments.length <= 3) {
        let str = "";
        for(let i = 0; i < arguments.length; i++) {
            str = str + String(arguments[i]) + " ";
        }
        alert(str);
    }
    else if(arguments.length > 3 && arguments.length <= 5) {
        let str = "";
        for(let i = 0; i < arguments.length; i++) {
            str = str + String(typeof(arguments[i])) + " ";
        }
        alert(str);
    }
    else if(arguments.length > 5 && arguments.length <= 7) {
        alert(arguments.length);
    }
    else {
        alert(`Количество аргументов слишком большое`);
    }
    
}

function func2() {
    let pr = 1
    while(pr != 0) {
        pr = parseInt(prompt(`Введите номер задания`))
        switch(pr) {
            case 1:
                window.a;
                alert(a);//ничего
                break;
            case 2:
                alert(b);
                window.b = 2;//ничего
                break;
            case 3:
                alert(c);
                window.c = 2;//ничего
                let c;
                break;
            case 4:
                alert(d);
                window.d = 2;//undefined
                var d;
                break;
            case 5:
                alert(e);
                let e = 2;//ничего
                break;
            case 6:
                let f = 2;
                window.f = 3;//2
                alert(f);
                break;
            case 7:
                var g = 2;
                window.g = 3;//2
                alert(g);
                break;
            case 0:
                break;
        }
    }
}


function func3() {
    let s = 5;
    function sum() {
        alert(s);
    }
    sum();
}


let check = 1;
while(check != 0)
{
    check = prompt("Выберите задание(1-7)");
    switch(Number(check)) {
        case 1:  
            func1("fsfsdsd", true, 1);
            func1("fsfsdsd", true, 1, 2, 3);
            func1("fsfsdsd", true, 1, 2, 3, "dfsdf");
            func1("fsfsdsd", true, 1, 2, 3, "sfdsdf", 4, 7, 9);
            break;
        case 2:
            func2();
            break;
        case 3: 
            func3();
            break;
        case 4: 
            function makeCounter() {
                let currentCount = 1;
                return function() {
                    return currentCount++;
                }
            }
            let counter = makeCounter();
            alert(counter());
            alert(counter());
            alert(counter());
            let counter2 = makeCounter();
            alert(counter2());
            //2 вариант(лексическкое окружение в котором создано)
            Count = 1;
            function Counter() {
                return function() {
                    return Count++;
                }
            }
            let count = Counter();
            let count2 = Counter();

            alert(count());
            alert(count());

            alert(count2());
            alert(count2());
            break;
        case 5:
            alert(func1.name);
            alert(func2.name);
            alert(makeCounter.name);
            alert(Counter.name);
            break;
        case 6: //это преобразование функции с множеством аргументов в набор вложенных функций с одним аргументом
        function volume(l) {
            return (w) => {
                return l * w * 50;
                    
            }
        }
        alert(`Объем равен: ${volume(50)(20)}`);
        alert(`Объем равен: ${volume(50)(50)}`);
        alert(`Объем равен: ${volume(50)(100)}`);
            break;
        case 7: 
            
            
            function* gen() {
                var a;
                let x = 0;
                let y = 0;
                for(let i = 0; i < 10; i++) {
                    a = prompt(`Введите направление`);
                   
                if(a == "left")
                    x = x - 10;
                if(a == "right")
                    x = x + 10;
                if(a == "up")
                    y = y + 10;
                if(a == "down")
                    y = y - 10;
                yield [x, y];
                }
                }
                let generator = gen();
                for (let i = 0; i < 10; i++) {
                alert(generator.next().value);
                }

            break;
        case 0:  
            break;
    } 
}
