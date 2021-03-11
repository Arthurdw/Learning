import { NextApiRequest, NextApiResponse } from "next";

// REST API endpoint
export default (req: NextApiRequest, res: NextApiResponse) => {
  res.json({ num: Math.floor(Math.random() * 100) });
};
