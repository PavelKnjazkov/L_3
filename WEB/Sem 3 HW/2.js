// Необходимо создать html-страницу с названием 2.html, в которой подключить 
// файл 2.js (его тоже необходимо создать рядом с html-файлом). В js-файле необходимо создать следующий скрипт:
// Cоздать функцию greeting, которая принимает имя и выводит приветствие, используя переданное имя, в консоль.
// Необходимо у пользователя запросить имя и вызвать функцию greeting, передав туда данное значение.

// const n = prompt("Введите Ваше имя:"); //вывел не в консоль

// alert(`Приветствуем Вас, ${greeting(n)}!`);

// function greeting(n) {
//     return n;
// }


const userName = prompt("Введите Ваше имя: ");

greeting(userName);

function greeting(userName) {
   console.log(`Приветствуем Вас, ${userName}!`); 
}