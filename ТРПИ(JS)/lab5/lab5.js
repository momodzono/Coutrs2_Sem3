const products = {
    shoes: []
}

function Shoes(type, id, size, color, price, discount) {
    this.type = type,
        this.id = id,
        this.size = size,
        this.color = color,
        this.price = price,
        this.discount = discount,

        Object.defineProperty(this, "id", {
            writable: false,
            configurable: false
        }),
        Object.defineProperty(this, "color", {
            writable: false
        }),
        Object.defineProperty(this, "size", {
            writable: false
        }),
        Object.defineProperty(this, "discountPrice", {
            get() {
                return this.price - this.price * (this.discount / 100);
            }
        })
}
products.shoes.push(new Shoes("Ботинки", 10001, 42, "Синий", 25, 10));
products.shoes.push(new Shoes("Ботинки", 10002, 39, "Черный", 40, 0));
products.shoes.push(new Shoes("Ботинки", 10003, 41, "Белый", 65, 0));

products.shoes.push(new Shoes("Кроссовки", 10101, 41, "Черный", 30, 0));
products.shoes.push(new Shoes("Кроссовки", 10102, 40, "Желтый", 25, 50));
products.shoes.push(new Shoes("Кроссовки", 10103, 42, "Фиолетовый", 70, 0));

products.shoes.push(new Shoes("Сандалии", 10201, 40, "Красный", 10, 20));
products.shoes.push(new Shoes("Сандалии", 10202, 37, "Белый", 20, 30));
products.shoes.push(new Shoes("Сандалии", 10203, 39, "Зеленый", 13, 0));

products[Symbol.iterator] = function () {

    let counter = 0;
    return {
        next() {
            if (counter < products.shoes.length) {
                return {
                    done: false,
                    value: products.shoes[counter++]
                };
            } else {
                return {
                    done: true
                };
            };
        }
    };
};

let sortPrice = parseInt(prompt("Введите максимальную цену.", '45'));
for (let prod of products)
    if (prod.price < sortPrice)
        console.log(`Вид: ${prod.type}\t| ID: ${prod.id}\t| Размер: ${prod.size}\t| Цвет: ${prod.color}\t\t| Цена: ${prod.price}\t| Скидка: ${prod.discount}%\t| Конечная стоимость: ${prod.discountPrice}`);
console.log(`_________________________________________________________________________________`);

let sortColor = prompt("Введите нужный цвет.", 'Черный');
for (let prod of products)
    if (prod.color == sortColor)
        console.log(`Вид: ${prod.type}\t| ID: ${prod.id}\t| Размер: ${prod.size}\t| Цвет: ${prod.color}\t\t| Цена: ${prod.price}\t| Скидка: ${prod.discount}%\t| Конечная стоимость: ${prod.discountPrice}`);
console.log(`_________________________________________________________________________________`);


let sortSize = parseInt(prompt("Введите нужный размер.", '39'));
for (let prod of products)
    if (prod.size == sortSize)
        console.log(`Вид: ${prod.type}\t| ID: ${prod.id}\t| Размер: ${prod.size}\t| Цвет: ${prod.color}\t\t| Цена: ${prod.price}\t| Скидка: ${prod.discount}%\t| Конечная стоимость: ${prod.discountPrice}`);
console.log(`_________________________________________________________________________________`);