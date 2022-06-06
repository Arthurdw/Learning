const image_element = document.getElementById("image");

function getJsonFromUrl(url) {
  if (!url) url = location.search;
  var query = url.substr(1);
  var result = {};
  query.split("&").forEach(function (part) {
    var item = part.split("=");
    result[item[0]] = decodeURIComponent(item[1]);
  });
  return result;
}

const params = getJsonFromUrl(window.location.href.split("?")[1])
const text = document.getElementById("generator-test");

image_element.style.backgroundColor = params.color || "red";
text.innerHTML = params.text || "Enter your own text in the url, and select a color! For example <code>?&text=Hello-World&color=green</code>"

domtoimage
  .toPng(image_element)
  .then((dataUrl) => {
    image_element.remove();
    const image = new Image();
    image.src = dataUrl;
    document.body.appendChild(image);
  })
  .catch((error) => {
    console.error(error);
  });
