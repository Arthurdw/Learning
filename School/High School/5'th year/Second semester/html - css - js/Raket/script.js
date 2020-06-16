// ©Athurdw | GO-AO
let root = document.documentElement;
let rocketBeam = document.getElementsByClassName("beam-holder")[0];
let autoMove = document.getElementsByTagName("button")[1];

const getRotation = () => parseInt(getComputedStyle(root).getPropertyValue("--rocket-rotation").substring(0, getComputedStyle(root).getPropertyValue("--rocket-rotation").length - 3));
const getPropValue = (val) => parseInt(getComputedStyle(root).getPropertyValue(val).substring(0, getComputedStyle(root).getPropertyValue(val).length));

let moving = false;

async function move(automatic = false) {
    if (automatic && moving) { 
        moving = false; 
        autoMove.innerHTML = "Auto Move";
        rocketBeam.classList.remove("beam"); 
        return; 
    };
    if (automatic) {
        moving = true;
        autoMove.innerHTML = "Stop Auto Move"
        while (moving) {
            moveRocket();
            rocketBeam.classList.add("beam");
            await new Promise(r => setTimeout(r, 10));
        };
    } else {
        rocketBeam.classList.toggle("beam");
        for (let i = 0; i < 10; i++) {
            moveRocket();
            await new Promise(r => setTimeout(r, 10));
        };
        rocketBeam.classList.toggle("beam");
    };
};

function moveRocket() {
    const rotation = getRotation() % 360;
    root.style.setProperty("--rocket-pos-x", getPropValue("--rocket-pos-x") + (rotation === 0 || rotation === 180 ? 0 : rotation === 45 || rotation === 90 || rotation === 135 ? 1 : rotation === 225 || rotation === 270 || rotation == 315 ? -1 : 0) + 'px');
    root.style.setProperty("--rocket-pos-y", getPropValue("--rocket-pos-y") + (rotation === 90 || rotation === 270 ? 0 : rotation === 315 || rotation === 0 || rotation === 45 ? -1 : rotation === 135 || rotation === 180 || rotation == 225 ? 1 : 0) + 'px');
}

async function rotate(negative = false) {
    for (let i = 0; i < 45; i++) {
        root.style.setProperty("--rocket-rotation", (getRotation() + (negative ? getRotation() < 0 ? 359 : -1 : 1)) + 'deg');
        await new Promise(r => setTimeout(r, 1));
    };
};
