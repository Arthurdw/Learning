<?php $data = explode(";", explode(PHP_EOL, file_get_contents("./data/data.txt"))[$_GET["id"]]); ?>

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
    </style>
</head>

<body>
    <h1><?php echo $data[1] ?> information!</h1>
    <table>
        <tr>
            <th>Creator</th>
            <th>Icon</th>
        </tr>
        <tr>
            <td><?php echo $data[2] ?></td>
            <td>
                <img src="./images/<?php echo $data[3] ?>" alt="The <?php echo $data[1] ?> logo!">
            </td>
        </tr>
    </table>
    <a href="./index.php">Return to home page!</a>
</body>

</html>