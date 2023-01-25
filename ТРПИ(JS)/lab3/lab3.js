function func1() {
    let n = prompt("Введите длину строки");
    if(!Number(n)) {
        alert(`Вы ввели не число`);
    }
    else {
            let str = prompt(`Введите комментарий для модерации не больше ${n}`);
        if(str.length > Number(n)) {
            alert(`Строка больше заданного значения`);
        }
        else {
            str = str.replace(/кот/g, "***");
            str = str.replace(/собак/g, "Собак");
            str = str.replace(/пес/g, "Многоуважаемый пес");
            alert(`Комментарий: ${str}`);
        }
    }
}

function func2() {
    let day = {
        1: "Понедельник",
        2: "Вторник",
        3: "Среда",
        4: "Четверг",
        5: "Пятница",
        6: "Суббота",
        7: "Воскресенье",
    }
    let num = parseInt(prompt(`Введите номер дня`));
    alert(`${num}: ${day[num]}`);
    let str = "";
    for(let key in day) {
        if(key % 2 == 1) {
            str = str + key + " " + day[key] + "\n";
        }
    }
    alert(str);
}

function func3() {
    let button = {
        backColor: "white",
        color: "red",
        width: "150px",
        height: "100px",
    }

    let link = {
        fontSize: "15px",
        font: "New Roman",
        fontColor: "white",
    }

    let accent = {
        backColor: "yellow",
    }

    Object.assign(button, accent);
    console.log(button);
    Object.assign(link, accent);
    console.log(link);  
    
}

function func4() {
    let pr = 1;
    let set = new Set();
    while(pr != 0)
    {
        pr = parseInt(prompt("Выберите задание\n1-Добавить\n2-Удалить\n3-Найти\n4-Все товары\n5-Количество"));
        switch(pr) {
            case 1:  
                pr = prompt(`Введите название товара`);
                set.add(pr);
                break;
            case 2:
                pr = prompt(`Введите название товара для удаления`);
                if(set.delete(pr)) {
                    alert(`Товар удален`);
                }
                else {
                    alert(`Товар не найден`);
                }
                break;
            case 3: 
                pr = prompt(`Введите название товара для поиска`);
                if(set.has(pr)) {
                    alert(`Товар ${pr} изменен`)
                } 
                else {
                    alert(`Товар ${pr} не найден`)
                }
                break;
            case 4: 
                let str = "";
                for(let item of set) {
                    str = str + item + " | ";
                }
                alert(str);
                break;
            case 5:
                alert(`Всего товаров: ${set.size}`);
                break;
            case 0:  
                break;
        } 
    }
}

function func5() {
    let pr = 1;
    let map = new Map();
    while(pr != 0)
    {
        pr = parseInt(prompt("Выберите задание\n1-Добавить\n2-Удалить\n3-Изменить количество товара\n4-Список\n5-Количество\n6-Сумма"));
        switch(pr) {
            case 1:  
                pr = prompt(`Введите название товара`);
                let kol = parseInt(prompt(`Количество`));
                let sum = parseInt(prompt(`Цена`));
                let info = {
                    count: kol,
                    cost: sum * kol,
                        
                }
                map.set(pr, info);
                break;
            case 2:
                pr = prompt(`Введите название товара для удаления`);
                if(map.delete(pr)) {
                    alert(`Товар удален`);
                }
                else {
                    alert(`Товар не найден`);
                }
                break;
            case 3: 
                pr = prompt(`Введите название товара для изменения`);
                if(map.has(pr)) {
                    let n = parseInt(prompt(`Введите количество`));
                    map.forEach( (value, key, map) => {//ценность, ключ, переработка
                        if(pr == key) {
                            let p = value.cost / value.count;
                            value.count = n;
                            value.cost = p * n;
                        }
                      });
                      
                    alert(`Товар ${pr} изменен`)
                } 
                else {
                    alert(`Товар ${pr} не найден`)
                }
                break;
            case 4: 
                str = "";
                map.forEach( (value, key, map) => {
                    str = str + "Товар: " + key + ", количество: " + value.count + ", цена: " + value.cost + "\n";
                  });
                  alert(str);
                break;
            case 5:
                let num = 0;
                for(let item of map.values()) {
                    num = num + item.count;
                }
                alert(`Количество товара: ${num}`);
                break;
            case 6:
                let num1 = 0;
                for(let item of map.values()) {
                    num1 = num1 + item.cost;
                }
                alert(`Количество товара: ${num1}`);
                break;
            case 0:  
                break;
        } 
    }
}

let check = 1;
while(check != 0)
{
    check = prompt("Выберите задание(1-5)");
    switch(Number(check)) {
        case 1:  
            func1();
            break;
        case 2:
            func2();
            break;
        case 3: 
            func3();
            break;
        case 4: 
            func4();
            break;
        case 5:
            func5();
            break;
        
    } 
}
