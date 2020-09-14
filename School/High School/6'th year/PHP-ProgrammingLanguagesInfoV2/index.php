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
    <style>
        body {
            display: flex;
            justify-content: center;
            font-family: 'Courier New', Courier, monospace;
        }

        ul {
            margin: 0;
            padding: 0;
            display: grid;
            justify-content: center;
        }

        li {
            display: grid;
            grid-template-columns: 450px min-content;
            grid-template-rows: 1fr;
        }

        button {
            border: none;
            margin: 3px;
            padding: 5px 15px;
            border-radius: 3px;
            transition: all 0.1s ease-in-out;
        }

        button:hover {
            background-color: rgba(0, 0, 0, 0.25);
        }

        .add {
            margin: 5px;
            padding: 10px;
            background-color: greenyellow;
            border-radius: 5px;
            text-align: center;
            color: blue;
            text-decoration: none;
        }

        .wrapper {
            width: fit-content;
            display: grid;
            justify-content: center;
        }

    </style>
</head>

<body>
    <div class="wrapper">
        <h1>Some relevant programming languages!</h1>
        <ul>
            <?php foreach ($languages as $index => $language) : ?>
                <li>
                    <a href="./detail.php?id=<?php echo $index ?>">
                        <?php echo $language; ?>
                    </a>
                    <form action="./delete.php" method="post">
                        <input name="id" type="hidden" value="<?php echo $index ?>">
                        <button type="submit">DELETE</button>
                    </form>
                </li>
            <?php endforeach; ?>
        </ul>
        <a class="add" href="./edit.php">Add one!</a>
    </div>
</body>

</html>