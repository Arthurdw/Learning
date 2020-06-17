const htmlField = document.querySelector("#field");
let field;

class Pattern {
    constructor() {
        this.field = document.createElement("div");
        this.field.classList.add("field");
        htmlField.append(this.field);
    }

    generate() {
        for (let i = 0; i < 10100; i++) {
            const item = document.createElement("div");
            if (i % Math.floor(Math.random() * (99 - 2) + 2) == 0) item.classList.add("selected");
            this.field.append(item);
        }
    }
}

function generatePattern() {
    if (field) htmlField.innerHTML = null;
    field = new Pattern();
    field.generate();
}

generatePattern();