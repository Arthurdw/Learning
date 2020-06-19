// ©Arthurdw - GO-AO //
let total = 0;

const items = [];
const data = getData();
const root = document.querySelector("#root");
const sumRed = document.querySelector("#sum-red");
const average = document.querySelector("#average");
const sumGreen = document.querySelector("#sum-green");
const LowestAndHighest = { lowest: [1000, [0, 0]], highest: [0, [0, 0]] };

for (let j = 0; j < data.length; j++) {
    let subItems = [];
    for (let i = 0; i < data[j].length; i++) {
        const item = document.createElement("div");
        if (LowestAndHighest.lowest[0] > data[j][i].getal) LowestAndHighest.lowest = [data[j][i].getal, [j, i]];
        if (LowestAndHighest.highest[0] < data[j][i].getal) LowestAndHighest.highest = [data[j][i].getal, [j, i]];
        item.innerHTML = data[j][i].getal;
        item.addEventListener("mouseover", showX);
        item.setAttribute("data-index", [j, i])
        subItems.push(item);
        root.appendChild(item);
        total += data[j][i].getal;
    }
    items.push(subItems);
}

function showX() {
    const indexes = [parseInt(this.getAttribute("data-index").substring(0, 1)), parseInt(this.getAttribute("data-index").substring(2, 3))]
    let offsets = [1, -1, -1, 1];
    let sumData = { red: 0, green: 0 };
    for (let y = indexes[0] - 1; y >= 0; y--) {
        changeBackground(indexes[1] - offsets[0], y, "red");
        offsets[0] += 1;
        changeBackground(indexes[1] - offsets[2], y, "green");
        offsets[2] -= 1;
        if (!Number.isNaN(getValue(indexes[1] - offsets[0], y))) sumData.red += getValue(indexes[1] - offsets[0], y);
        if (!Number.isNaN(getValue(indexes[1] - offsets[2], y))) sumData.red += getValue(indexes[1] - offsets[2], y);
        getValue(indexes[1] - offsets[0], y);
    }
    for (let y = 1; y < items.length; y++) {
        changeBackground(indexes[1] - offsets[1], indexes[0] + y, "red");
        offsets[1] -= 1;
        changeBackground(indexes[1] - offsets[3], indexes[0] + y, "green");
        offsets[3] += 1;
        if (!Number.isNaN(getValue(indexes[1] - offsets[1], indexes[0] + y))) sumData.green += getValue(indexes[1] - offsets[1], indexes[0] + y);
        if (!Number.isNaN(getValue(indexes[1] - offsets[3], indexes[0] + y))) sumData.green += getValue(indexes[1] - offsets[3], indexes[0] + y);
    }
    sumRed.innerHTML = `De som van de roode diagonaal ${sumData.red}!`;
    sumGreen.innerHTML = `De som van de groene diagonaal ${sumData.green}!`;
}

function getValue(x, y) {
    try {
        return parseInt(items[y][x].innerHTML);
    } catch (TypeError) {
        return Number.NaN;
    }
}

function changeBackground(x, y, color) {
    try {
        items[y][x].style.backgroundColor = color;
    } catch (TypeError) { }
}

function resetBoard() {
    for (let j = 0; j < items.length; j++) {
        for (let i = 0; i < items[j].length; i++) items[j][i].style.backgroundColor = "white";
    }
    items[LowestAndHighest.lowest[1][0]][LowestAndHighest.lowest[1][1]].style.backgroundColor = "yellow";
    items[LowestAndHighest.highest[1][0]][LowestAndHighest.highest[1][1]].style.backgroundColor = "blue";
}

resetBoard();
root.addEventListener("mouseout", resetBoard);
average.innerHTML = `Het gemiddelde is ${total / 100}!`;


// Code for a board with a single array: (not fully functional)
/*
let items = [];
let data = [[0, 0], [1000, 0], 0];

const root = document.querySelector("#root");
const average = document.querySelector("#average");

class Number {
    constructor(number, idx) {
        const object = document.createElement("div");
        object.innerHTML = number;
        object.addEventListener("mouseover", this.hover);
        this.number = number;
        this.obj = object;
        this.index = idx;
        root.appendChild(object);
        this.tempData = { red: [], green: [] };
    }

    update(color = null) {
        this.obj.style.backgroundColor = color;
    }

    hover = () => {
        items[data[0][1]].update("blue");
        items[data[1][1]].update("yellow");
        const indexes = this.getIndexes();
        for (let i = 0; i < items.length; i++) {
            if (indexes.red.includes(i)) this.getObj(i).obj.style.backgroundColor = "red";
            else if (indexes.green.includes(i)) this.getObj(i).obj.style.backgroundColor = "green";
            else if (i !== data[0][1] && i !== data[1][1]) this.getObj(i).obj.style.backgroundColor = "white";
        };
    };

    getIndexes() {
        console.log("---------------------")
        let returnValues = { red: [], green: [] };
        for (let i = 1; i <= 10; i++) {
            if (!((this.index + 11 * i) % 10 === 0)) returnValues.red.push(this.index + 11 * i);
            if (!((this.index - 11 * i) % 10 === 9)) returnValues.red.push(this.index - 11 * i);

            returnValues.green.push(this.index + 9 * i);
            returnValues.green.push(this.index - 9 * i);
        };
        return returnValues;
    }

    getObj(index) {
        try {
            return items[index];
        } catch (TypeError) {};
    }
}

for (let i = 0; i < 100; i++) {
    const number = Math.floor(Math.random() * 2001 - 1000);
    items.push(new Number(number, i));
    if (data[0][0] < number) data[0] = [number, i];
    if (data[1][0] > number) data[1] = [number, i];
    data[2] += number;
}

function resetBoard() {
    for (let i = 0; i < 100; i++) items[i].obj.style.backgroundColor = "white";
    items[data[0][1]].update("blue");
    items[data[1][1]].update("yellow");
}

root.addEventListener("mouseout", resetBoard);

average.innerHTML = `Het gemiddelde is ${data[2] / 100}!`;

resetBoard();
*/
