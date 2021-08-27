const frame = document.getElementById("frame");
const circles = document.getElementsByClassName("circle")[0];

const data = {
    goX: -1,
    goY: -1
}

setInterval(update, 5);

function update() {
    circles.style.top = circles.offsetTop + data.goY;
    circles.style.left = circles.offsetLeft + data.goX;
    if (circles.offsetTop <= frame.offsetTop || circles.offsetHeight + circles.offsetTop >= frame.offsetTop + frame.offsetHeight) data.goY = -data.goY;
    if (circles.offsetLeft <= frame.offsetLeft || circles.offsetLeft + circles.offsetWidth >= frame.offsetLeft + frame.offsetWidth) data.goX = -data.goX;
}
