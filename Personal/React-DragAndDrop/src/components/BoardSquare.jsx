import React from "react";
import { useDrop } from "react-dnd";
import { ItemTypes } from "../settings/Constants";
import { canMoveKnight, moveKnight } from "../utils/GameHandler";
import { Square } from "./Square";

const Overlay = ({ color }) => (
  <div
    style={{
      position: "absolute",
      top: 0,
      left: 0,
      height: "100%",
      width: "100%",
      zIndex: 1,
      opacity: 0.5,
      backgroundColor: color,
    }}
  />
);

export const BoardSquare = ({ x, y, children }) => {
  const [{ isOver, canDrop }, drop] = useDrop({
    accept: ItemTypes.KNIGHT,
    canDrop: () => canMoveKnight(x, y),
    drop: () => moveKnight(x, y),
    collect: (monitor) => ({
      isOver: !!monitor.isOver(),
      canDrop: !!monitor.canDrop(),
    }),
  });

  const black = (x + y) % 2 === 1;
  return (
    <div
      ref={drop}
      style={{
        position: "relative",
        width: "100%",
        height: "100%",
      }}
    >
      <Square black={black}>{children}</Square>
      {isOver && !canDrop && <Overlay color="red" />}
      {!isOver && canDrop && <Overlay color="yellow" />}
      {isOver && canDrop && <Overlay color="green" />}
    </div>
  );
};
