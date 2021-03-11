import jwt from "jsonwebtoken";
import { useState } from "react";

const LoginPage = () => {
  const [username, setUsername] = useState<string>("");
  const [password, setPassword] = useState<string>("");
  const [message, setMessage] = useState<string>("You are not logged in!");

  const submitForm = async () => {
    const res = await fetch("/api/login", {
      method: "POST",
      headers: {
          'Content-Type': 'application/json'
      },
      body: JSON.stringify({ username, password }),
    });

    const { token } = await res.json();

    if (token) {
      const json = jwt.decode(token) as { [key: string]: string };
      setMessage(
        `Welcome ${json.username} you are ${
          json.admin ? "an admin" : "a member"
        }`
      );
    } else setMessage("Something went wrong!");
  };

  return (
    <div>
      <h1>{message}</h1>
      <form>
        <input
          type="text"
          defaultValue={username}
          onChange={(e) => setUsername(e.target.value)}
        />
        <br />
        <input
          type="password"
          defaultValue={password}
          onChange={(e) => setPassword(e.target.value)}
        />
        <input type="button" onClick={submitForm} value="Login" />
      </form>
    </div>
  );
};

export default LoginPage;
