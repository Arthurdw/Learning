const frame = document.getElementById("frame");
const circles = document.getElementsByClassName("circle")[0];

const data = {
    canvas: {
        top: frame.offsetTop,
        bottom: frame.offsetTop + frame.offsetHeight,
        left: frame.offsetLeft,
        right: frame.offsetLeft + frame.offsetWidth
    },
    animation: {
        goX: -1,
        goY: -1
    }
}

setInterval(update, 5);

function update() {
    circles.style.top = circles.offsetTop + data.animation.goY;
    circles.style.left = circles.offsetLeft + data.animation.goX;
    if (circles.offsetTop <= data.canvas.top || circles.offsetHeight + circles.offsetTop >= data.canvas.bottom) data.animation.goY = -data.animation.goY;
    if (circles.offsetLeft <= data.canvas.left || circles.offsetLeft + circles.offsetWidth >= data.canvas.right) data.animation.goX = -data.animation.goX;
}