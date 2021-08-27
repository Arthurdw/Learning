<?php
include("data.php");
$tShirts = getTShirts();

session_start();

$card = unserialize($_SESSION['card']);
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Schrödingers Shop | Card</title>
    <link rel="stylesheet" href="style/general.css">
    <link rel="stylesheet" href="style/card.css">
</head>

<body>
    <header>
        <a href="./">Back to shop</a>
        <h1>Your shopping card</h1>
    </header>
    <main>
        <?php foreach ($card as $item) : ?>
            <div class="item">
                <img class="icon" src="images/<?php echo $tShirts[$item]["image"]; ?>" alt="">
                <a class="icon-card" href="./remove.php?id=<?php echo $item; ?>">
                    <img class="icon-card-icon" src="./images/remove.png" alt="">
                </a>
            </div>
        <?php endforeach; ?>
    </main>
</body>

</html>