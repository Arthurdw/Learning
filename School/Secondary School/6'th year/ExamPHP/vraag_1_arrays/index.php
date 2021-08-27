<?php
include('./includes/data.php');
$huisdieren = getHuisdieren();

$current = isset($_GET['soort']) ? $_GET['soort'] : "0";

foreach ($huisdieren as $key => $dier) {
    if (strval($key) === $current) $selected = $dier;
}

?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Huisdieren</title>
    <link rel="stylesheet" href="style/main.css">
    <link rel="stylesheet" href="style/header.css">
    <link rel="stylesheet" href="style/content.css">
</head>

<body>
    <header>
        <?php foreach ($huisdieren as $key => $dier) : ?>
            <a <?php if (strval($key) === $current) : ?>class="menu-active" <?php endif; ?> href="?soort=<?php echo $key; ?>"><?php echo $dier["soort"]; ?></a>
        <?php endforeach; ?>
    </header>

    <main>
        <?php foreach ($selected["rassen"] as $ras) : ?>
            <div class="dier">
                <img src="images/<?php echo $ras["picture"] ?>" alt="">
                <p><?php echo $ras["naam"] ?></p>
            </div>
        <?php endforeach; ?>
    </main>
</body>

</html>