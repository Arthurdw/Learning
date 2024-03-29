let knightPosition = [1, 7];
let observer = null;

export const emitChange = () => observer(knightPosition);

export const observe = (receiver) => {
  if (observer) throw new Error("Observer already exists.");

  observer = receiver;
  emitChange();
};

export const moveKnight = (toX, toY) => {
  knightPosition = [toX, toY];
  emitChange();
};

export const canMoveKnight = (toX, toY) => {
  const [x, y] = knightPosition;
  const dx = toX - x;
  const dy = toY - y;

  return (
    (Math.abs(dx) === 2 && Math.abs(dy) === 1) ||
    (Math.abs(dx) === 1 && Math.abs(dy) === 2)
  );
};
