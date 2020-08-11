import React, { useState, useEffect } from "react";
import socketIOClient from "socket.io-client";

const ENDPOINT = "http://127.0.0.1:4001";

function ClientComponent() {
  const [response, setResponse] = useState("");

  useEffect(() => {
    const socket = socketIOClient(ENDPOINT);
    socket.on("FromAPI", (data) => {
      setResponse(data);
    });

    return () => socket.disconnect();
  }, []);

  return (
    <p>
      It's <time dateTime={response}>{response}</time>
    </p>
  );
}

function App() {
  const [loadClient, setLoadClient] = useState(true);

  return (
    <React.Fragment>
      <button onClick={() => setLoadClient((prevState) => !prevState)}>
        {loadClient ? "STOP" : "START"} CLIENT
      </button>
      {loadClient && <ClientComponent />}
    </React.Fragment>
  );
}

export default App;
