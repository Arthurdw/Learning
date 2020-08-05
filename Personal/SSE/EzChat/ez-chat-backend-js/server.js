const http = require("http");
const events = require("events");

const event = new events.EventEmitter();

http
  .createServer((req, res) => {
    console.log(`[${new Date().toUTCString()}] ${req.method} - ${res.statusCode}: ${req.url}`);

    if (req.url.toLowerCase() === "/ezchat/send") {
      res.writeHead(200, {
        Connection: "keep-alive",
        "Content-Type": "text/plain",
        "Cache-Control": "no-cache",
        "Access-Control-Allow-Origin": "*",
        "Access-Control-Allow-Methods": ["GET", "POST", "PATCH", "PUT", "DELETE", "OPTIONS"],
        "Access-Control-Allow-Headers": ["Origin", "Content-Type", "X-Auth-Token"]
      });

      req.on("data", (chunk) => event.emit("message", chunk.toString()));
    }

    if (req.url.toLowerCase() === "/ezchat/connect") {
      res.writeHead(200, {
        Connection: "keep-alive",
        "Content-Type": "text/event-stream",
        "Cache-Control": "no-cache",
        "Access-Control-Allow-Origin": "*",
        "Access-Control-Allow-Methods": ["GET", "POST", "PATCH", "PUT", "DELETE", "OPTIONS"],
        "Access-Control-Allow-Headers": ["Origin", "Content-Type", "X-Auth-Token"]
      });

      res.write(
        'data: {"name": "Server", "color": "#F00", "message": "Connected to the server!"}'
      );
      res.write("\n\n");

      event.on("message", (msg) => {
        res.write(`data: ${msg}`);
        res.write("\n\n");
      });
    } else {
      res.writeHead(404);
      res.end();
    }
  })
  .listen(6172, () => {
    console.log("Running local server at http://127.0.0.1:6172/");
  });
