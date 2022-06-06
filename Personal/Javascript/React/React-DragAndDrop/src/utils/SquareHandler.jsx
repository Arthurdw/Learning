import { BoardSquare } from "../components/BoardSquare";
import { Knight } from "../components/Knight";
import { moveKnight, canMoveKnight } from "../utils/GameHandler";

export const renderSquare = (i, knightPosition) => {
  const x = i % 8;
  const y = Math.floor(i / 8);

  return (
    <div
      key={i}
      style={{ width: `${100 / 8}%`, height: `${100 / 8}%` }}
      onClick={() => handleSquareClick(x, y)}
    >
      <BoardSquare x={x} y={y}>
        {renderPiece(x, y, knightPosition)}
      </BoardSquare>
    </div>
  );
};

const handleSquareClick = (x, y) => {
  if (canMoveKnight(x, y)) moveKnight(x, y);
};

const renderPiece = (x, y, [knightX, knightY]) => {
  if (x === knightX && y === knightY) return <Knight />;
};
