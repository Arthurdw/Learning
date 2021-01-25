import { PrismaClient } from "@prisma/client";

const prisma = new PrismaClient();

async function main() {
  await prisma.test_prisma.create({
    data: {
      value: new Date().toISOString(),
    },
  });

  const allData = await prisma.test_prisma.findMany();
  console.log(allData);
}

main()
  .catch((e) => {
    throw e;
  })
  .finally(async () => {
    await prisma.$disconnect();
  });
