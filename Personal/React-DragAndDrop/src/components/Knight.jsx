import React, { Fragment } from "react";
import { DragPreviewImage, useDrag } from "react-dnd";
import { ItemTypes } from "../settings/Constants";
import KnightIcon from "../assets/knight.webp";

export const Knight = () => {
  const [{ isDragging }, drag, preview] = useDrag({
    item: { type: ItemTypes.KNIGHT },
    collect: (monitor) => ({
      isDragging: !!monitor.isDragging(),
    }),
  });

  return (
    <Fragment>
      <DragPreviewImage connect={preview} src={KnightIcon} />
      <div
        ref={drag}
        style={{
          fontSize: "60px",
          display: "block",
          height: "100%",
          width: "100%",
          textAlign: "center",
          opacity: isDragging ? 0.75 : 1,
          cursor: "move",
        }}
      >
        ♘
      </div>
    </Fragment>
  );
};
