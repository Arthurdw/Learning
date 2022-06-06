const express = require("express");
const bodyParser = require("body-parser");
const cors = require("cors");
const events = require("events");

const event = new events.EventEmitter();

const app = express();

function eventsHandler(req, res, next) {
  const headers = {
    "Content-Type": "text/event-stream",
    Connection: "keep-alive",
    "Cache-Control": "no-cache",
  };

  res.writeHead(200, headers);

  console.log("User connected!");
  res.write(
    `data: ${JSON.stringify({
      name: "Server",
      color: "#F00",
      message: "Connected to the server!",
    })}\n\n`
  );

  event.on("message", (msg) => {
    res.write(`data: ${msg}\n\n`);
  });

  req.on("close", () => console.log("User disconnected!"));
}

app.use(cors());
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: false }));

app.post("/ezchat/send", (req, res) => {
  req.on("data", (chunk) => event.emit("message", chunk.toString()));
});
app.get("/ezchat/connect", eventsHandler);

app.get("/ezchat/test", (req, res) => res.send("Working"));

app.listen(6172, () => {
  console.log("Running local server at http://127.0.0.1:6171/");
});
