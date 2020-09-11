<?php
 foreach (explode(PHP_EOL, file_get_contents("./data/data.txt")) as $row) {
    $data = explode(";", $row);
    if ($data[0] !== "") {
        $languages[$data[0]] = $data[1];
    }
 }
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Stap 1</title>
</head>

<body>
    <h1>Some relevant programming languages!</h1>
        <?php foreach ($languages as $index => $language) : ?>
                <li>
                    <a href="./detail.php?id=<?php echo $index ?>">
                        <?php echo $language; ?>
                    </a>
                </li>
        <?php endforeach; ?>
    </ul>
</body>

</html>