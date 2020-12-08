<?php
include("data.php");
$tShirts = getTShirts();

session_start();

$card = isset($_SESSION['card']) ? unserialize($_SESSION['card']) : array();
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Schrödingers Shop</title>
    <link rel="stylesheet" href="style/index.css">
    <link rel="stylesheet" href="style/general.css">
</head>

<body>
    <header>
        <h1>Schrödingers Shop</h1>
        <?php if (count($card) > 0) : ?>
            <span>

                <a href="./card.php"><?php echo count($card); ?></a>
            </span>
        <?php endif; ?>
    </header>
    <main>
        <?php foreach ($tShirts as $id => $tShirt) : ?>
            <div class="item">
                <img class="icon" src="images/<?php echo $tShirt["image"]; ?>" alt="">
                <?php if (!in_array($id, $card)) : ?>
                    <a class="icon-card border" href="./add.php?id=<?php echo $id; ?>">
                        <img class="icon-card-icon" src="./images/add-shopping-cart.png" alt="">
                    </a>
                <?php endif; ?>
            </div>
        <?php endforeach; ?>
    </main>
</body>

</html>