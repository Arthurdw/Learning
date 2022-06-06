import { NextApiRequest, NextApiResponse } from "next";

import jwt from "jsonwebtoken";

const KEY = "9e-whfp8hi Q12'DASMK";

export default (req: NextApiRequest, res: NextApiResponse) => {
  if (!req.body) {
    res.status(400).end("Error");
    return;
  }

  const { username, password } = req.body;

  res.json({
    token: jwt.sign(
      {
        username,
        admin: username === "admin" && password === "admin",
      },
      KEY
    ),
  });
};
