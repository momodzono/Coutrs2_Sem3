cube = {
    name: "cube",
    width: '40px',
    height: '40px',
    border: '4px solid black',
    background: 'yellow'
}
circle = {
    name: "circle",
    width: '45px',
    height: '40px',
    border: '4px solid black',
    borderRadius : '50%',
    background: 'white'
}
triangle = {
    name: "triangle",
    width: 0,
    height: 0,
    borderColor: 'transparent transparent #fff transparent',
    borderWidth: '0 30px 30px 30px',
    middleLine: true, 
}
smallCube = {
    name: "smallCube",
    width: '20px',
    height: '20px',
    border: '2px solid black',
    background: 'yellow'
}
smallCircle = {
    name: "smallCircle",
    width: '25px',
    height: '20px',
    border: '2px solid black',
    borderRadius : '50%',
    background: 'green'
}
smallTriangle = {
    name: "smallTriangle",
    width: 0,
    height: 0,
    borderColor: 'transparent transparent #fff transparent',
    borderWidth: '0 1px 1px 1px',
    threeMiddleLines: true, 
}

function GreenCircle(ObjOne, ObjTwo){


    first = Object.getOwnPropertyNames(ObjOne);//возвращает массив всех свойст
    second = Object.getOwnPropertyNames(ObjTwo);


    for(let counter = 0; counter < first.length; counter++)

            if(ObjOne[first[counter]] != ObjTwo[second[counter]])
                console.log("Отличия : " + ObjOne[first[counter]] + " - " + ObjTwo[second[counter]]);

}




function AllAreas(ObjOne){

    first = Object.getOwnPropertyNames(ObjOne);
    let result = 'Все поля треугольника :\n';

    for(let counter = 0; counter < first.length; counter++)
        result += first[counter] + " - " + ObjOne[first[counter]]+"\n";

    console.log(result);

}



function Color(ObjOne){
    first = Object.getOwnPropertyNames(ObjOne);

    for(let counter = 0; counter < first.length; counter++){
        if(first[counter] == 'color'){
            console.log("Есть собственное свойство отвечачющее за цвет")
            break
        }
        else if(counter = first.length - 1)
            console.log("Нету собственного свойство отвечачющего за цвет")
    }

}
GreenCircle(circle, smallCircle);
AllAreas(smallTriangle);
Color(smallCube);



////////////////////////////////////////////////////////////////////////////////////////////////////


class Product{
    static ID = 1
    constructor(price, name, img, background){
        this.id = Product.ID++
        this.price = price;
        this.name = name;
        this.img = img;
        this.background = background;
    }

    addOnPage(){
        let div = document.createElement('div');// позволяет создать новый элемент, передав в параметре имя тега
        div.className = "infoblock";
        div.style.width = '250px';
        div.style.height = '350px';
        div.style.textAlign = 'center';
        div.style.background = this.background;

        Products.append(div);//позволяет вставить в конец какого-либо элемента другой элемент.
        Products.style.width = '100%';
        Products.style.display = 'flex';
        Products.style.flexWrap = 'wrap';
        let img = document.createElement('img');
        img.src = this.img;
        img.style.width = '200px';
        img.style.height = '200px';
        div.prepend(img);// в начало

        let p = document.createElement('p');
        p.innerHTML = this.name;
        p.style.fontSize = '20px';
        p.style.fontWeight = 'bold';
        div.append(p);
        let p2 = p.cloneNode(true);//определяет, клонируется ли поддерево, содержащееся в узле
        p2.innerHTML = this.price + " $";
        p2.style.fontSize = '15px';
        div.append(p2);
        let button = new Button(150, 75, 'blue','В корзину');
        div.append(button.addButton()); 

        
    }

    Delete(){
        let massive = document.getElementsByClassName('infoblock');//возвращает массивоподобный объект всех дочерних элементов, которые имеют все заданные имена классов.
        massive[this.id-1].remove();
        let size = Object.getOwnPropertyNames(this);
        for(let i = 0; i < size.length; i++)
            delete this[size[i]];//удаляем свойство

    }
    
}

class Button{
    constructor(width, height, background, text){
        this.width = width;
        this.height = height;
        this.text = text;
        this.background = background;
    }

    addButton(){
        let button = document.createElement('button');
        button.innerHTML = this.text;
        button.style.width = this.width;
        button.style.height = this.height;
        button.style.background = this.background;
        button.style.color = 'white';
        button.style.border = '5px solid blue';
        button.style.borderRadius = '5px';
        button.style.float = 'right';
        button.style.margin='0 15px 0 0';
        return button;
    }
}



function bgChange(){

    let massive = document.getElementsByClassName('infoblock');
    for(let i = 0 ; i < massive.length; i++){

        if((i+1) % 2 == 1){
            massive[i].style.background = 'gray';
        }
        else massive[i].style.background = 'white';
    }
}
let cartButton = new Button(150, 75, 'blue','Корзина');
document.body.prepend(cartButton.addButton());


let one = new Product(500,'ПолуБук', "MacBook.jpg", 'white');
let two = new Product(1300,'MacBook Pro', "MacBook.jpg", 'white');
let third = new Product(1700,'MacBook Air', "MacBook.jpg", 'white');
let fourth = new Product(1800,'MacBook Pro 14', "MacBook.jpg", 'white');
let five = new Product(1200,'MacBook Pro 13', "MacBook.jpg", 'white');
let six = new Product(1000,'MacBook Pro 114', "MacBook.jpg", 'white');

one.addOnPage();
two.addOnPage();
third.addOnPage();
fourth.addOnPage();
five.addOnPage();
six.addOnPage();

bgChange();
fourth.Delete();
bgChange();