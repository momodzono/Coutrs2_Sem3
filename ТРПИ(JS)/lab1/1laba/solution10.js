let userName = prompt("Логин:", '');

if (userName === 'Admin') {

  let pass = prompt('Пароль:', '');

  if (pass === '12345') {
    alert( 'Добро пожаловать Admin!' );
  } else if (pass === '' || pass === null) {
    alert( 'Отменено' );
  } else {
    alert( 'Неверный пароль' );
  }

} else if (userName === '' || userName === null) {
  alert( 'Отменено' );
} else {
  alert( "Неверный логин" );
}