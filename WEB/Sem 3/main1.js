/*Получить от пользователя два числа и вывести в
диалоговое окно сумму значений, которые ввел пользователь, вывод должен
выглядеть так (пример): Результат сложения чисел 5 и 2 равен 7.*/

const a = Number.parseInt(prompt("введите первое число"));
const b = Number.parseInt(prompt("введите второе число"));
alert(`Результат сложения чисел ${a} и ${b} равен ${a + b}`);