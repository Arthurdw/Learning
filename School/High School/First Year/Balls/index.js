const CANVAS = {
  width: 400,
  height: 400,
  color: 220,
};

const NUMBER_OF_CREATURES = 10;
const MOVE_RANDOM_CHANCE = 25;
const CREATURE_MIN_SIZE = 10;

let creatures = [];

function getRandomNumber(limit) {
  return Math.floor(Math.random() * (limit + 1));
}

function createCreature() {
  return {
    x: getRandomNumber(CANVAS.width),
    y: getRandomNumber(CANVAS.height),
    diameter: CREATURE_MIN_SIZE,

    direction: {
      x: 1,
      y: 1,
    },

    handleCanvasCollision: function () {
      const RADUIS = this.diameter / 2;

      const COLLIDES_RIGHT = this.x + RADUIS > CANVAS.width;
      const COLLIDES_LEFT = this.x - RADUIS < 0;

      const COLLIDES_TOP = this.y - RADUIS < 0;
      const COLLIDES_BOTTOM = this.y + RADUIS > CANVAS.height;

      if (COLLIDES_RIGHT || COLLIDES_LEFT)
        this.x = COLLIDES_RIGHT ? CANVAS.width - RADUIS : RADUIS;

      if (COLLIDES_TOP || COLLIDES_BOTTOM)
        this.y = COLLIDES_TOP ? RADUIS : CANVAS.height - RADUIS;

      return COLLIDES_RIGHT || COLLIDES_LEFT || COLLIDES_TOP || COLLIDES_BOTTOM;
    },

    getRandomNumber: function (limit) {
      return Math.floor(Math.random() * (limit + 1));
    },

    randomizeDirection: function () {
      this.direction.x = getRandomNumber(1) ? 1 : -1;
      this.direction.y = getRandomNumber(1) ? 1 : -1;
    },

    handleCollisions: function () {
      const HAS_CHANGED = this.handleCanvasCollision();

      if (HAS_CHANGED) this.randomizeDirection();
    },

    move: function () {
      this.handleCollisions();

      if (getRandomNumber(MOVE_RANDOM_CHANCE) > getRandomNumber(100))
        this.randomizeDirection();

      this.x += this.direction.x;
      this.y += this.direction.y;
    },

    draw: function () {
      let creatureColor = color("gold");
      fill(creatureColor);
      noStroke();
      ellipse(this.x, this.y, this.diameter);
    },

    update: function () {
      this.move();
      this.draw();
    },
  };
}

function setup() {
  createCanvas(CANVAS.width, CANVAS.height);

  creatures = new Array(NUMBER_OF_CREATURES).fill(null).map(createCreature);
}

function draw() {
  background(CANVAS.color);

  creatures.forEach((c) => c.update());
}
