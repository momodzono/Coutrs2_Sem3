//По номеру дня недели определить какой это день: 1 – пн, 2 – вт, … , 7 – вс. Номер дня вводит пользователь.

let day=prompt('Введите номер дня')
switch(day){
    case '1':
        alert( 'Понедельник' );
        break
    case '2':
        alert( 'Вторник' );
        break
    case '3':
        alert( 'Среда' );
        break
    case '4':
        alert( 'Четверг' );
        break
    case '5':
        alert('Пятница');
        break
    case '6':
        alert('Суббота');
        break
    case '7':
        alert('Воскресенье');
        break}


