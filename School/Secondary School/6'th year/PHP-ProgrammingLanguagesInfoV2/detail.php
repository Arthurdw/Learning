<?php
// $data = explode(";", explode(PHP_EOL, file_get_contents("./data/data.txt"))[$_GET["id"] - 1]);
foreach (explode(PHP_EOL, file_get_contents("./data/data.txt")) as $row) {
    $item = explode(";", $row);
    if ($item[0] == $_GET["id"]) $data = $item;
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Stap 1 - Details</title>
    <style>
        th {
            user-select: none;
        }

        img {
            width: 100px;
        }

        body {
            display: flex;
            justify-content: center;
            font-family: 'Courier New', Courier, monospace;
        }

        .inner-wrapper {
            width: 100%;
            display: flex;
            justify-content: center;
        }

        .inner-wrapper a {
            margin: 5px;
        }

        button {
            cursor: pointer;
        }
    </style>
</head>

<body>
    <div class="wrapper">
        <?php if ($data[0] != "") : ?>
            <h1><?php echo $data[1] ?> information!</h1>
            <div class="inner-wrapper">
                <table>
                    <tr>
                        <th>Creator</th>
                        <th>Icon</th>
                    </tr>
                    <tr>
                        <td><?php echo $data[2] ?></td>
                        <td>
                            <img src="<?php echo $data[3] ?>" alt="The <?php echo $data[1] ?> logo!">
                        </td>
                    </tr>
                </table>
            </div>
        <?php else : ?>
            <P>Oops, this language doesn't exist in our database!</P>
        <?php endif; ?>
        <div class="inner-wrapper">
            <a href="./index.php">Return to home page!</a>
            <a href="./edit.php<?php echo $data[0] != "" ? "?id=" . $data[0] : "" ?>">
                <?php echo $data[0] != "" ? "Bewerk dit!" : "Maak dit aan!" ?>
            </a>
            <?php if ($data[0] != "") : ?>
                <form action="./delete.php" method="post">
                    <input name="id" type="hidden" value="<?php echo $data[0] ?>">
                    <button type="submit">DELETE</button>
                </form>
            <?php endif; ?>
        </div>
    </div>
</body>

</html>