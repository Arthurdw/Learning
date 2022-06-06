import { DndProvider } from "react-dnd";
import { HTML5Backend } from "react-dnd-html5-backend";
import { renderSquare } from "./utils/SquareHandler";

export const Board = ({ knightPosition }) => {
  const squares = [];
  for (let i = 0; i < 64; i++) squares.push(renderSquare(i, knightPosition));

  return (
    <DndProvider backend={HTML5Backend}>
      <main
        style={{
          width: "calc(100vh - 20px)",
          height: "calc(100vh - 20px)",

          margin: '10px auto',

          display: "flex",
          flexWrap: "wrap",
        }}
      >
        {squares}
      </main>
    </DndProvider>
  );
};

export default Board;
