import React from "react";
import ReactDOM from "react-dom";
import Board from "./Board";
import { observe } from "./utils/GameHandler";

const root = document.getElementById("root");

root.style.height = "100vh";
root.style.width = "100vw";
root.style.overflow = "hidden";
root.style.backgroundColor = "gray";

observe((knightPosition) =>
  ReactDOM.render(<Board knightPosition={knightPosition} />, root)
);
