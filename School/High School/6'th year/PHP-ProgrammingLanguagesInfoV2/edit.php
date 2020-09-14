<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $dataString = implode(";", $_POST);
    $hasBeenInserted = false;

    foreach (explode(PHP_EOL, file_get_contents("./data/data.txt")) as $row) {
        $item = explode(";", $row);
        if ($item[0] != $_POST["id"] && $item[0] != $_POST["curId"]) $data[] = $row;
        else if ($item[0] == $_POST["curId"] && $_POST["id"] != $_POST["curId"]);
        else {
            $data[] = $dataString;
            $hasBeenInserted = true;
        }
    }

    if (!$hasBeenInserted) $data[] = $dataString;

    file_put_contents("./data/data.txt", implode(PHP_EOL, $data));
    header("Location: ./index.php");
}
foreach (explode(PHP_EOL, file_get_contents("./data/data.txt")) as $row) {
    $item = explode(";", $row);
    if ($item[0] == $_GET["id"]) $data = $item;
}
$formats = explode(";", file_get_contents("./data/format.txt"));
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Edit Database</title>
    <style>
        body {
            display: grid;
            justify-content: center;
            grid-gap: 15px;
            font-family: 'Courier New', Courier, monospace;
        }

        h1 {
            text-align: center;
        }

        form {
            width: fit-content;
            display: grid;
            grid-gap: 5px;
            grid-template-columns: min-content min-content;
        }

        button {
            padding: 10px;
            grid-column-start: 2;
        }

        img {
            margin: 0 0 0 20px;
            height: 150px;
            display: block;
        }

        a {
            display: block;
            text-align: center;
        }

        .wrapper {
            position: relative;
            display: flex;
        }
    </style>
</head>

<body>
    <h1>Edit Database</h1>
    <div class="wrapper">
        <form action="./edit.php" method="post">
            <?php foreach($formats as $index => $format) : ?>
                <label for="<?php echo $format ?>"><?php echo $format ?>:</label>
                <input type="text" name="<?php echo $format ?>" value="<?php echo $data[$index] ?>">
            <?php endforeach; ?>
            <label for="icon">Icon:</label>
            <input id="icon-url" onkeyup="updateImagePreview()" name="icon" type="text" value="<?php echo $data[3] ?>">
            <input name="curId" type="hidden" value="<?php echo $data[0] ?>">
            <button type="submit">Update</button>
        </form>
        <img id="image-preview" src="" alt="Image preview">
    </div>
    <a href="./index.php">Return to home page!</a>

    <script>
        const image = document.querySelector("#image-preview");
        const icon = document.querySelector("#icon-url");

        const updateImagePreview = () => image.src = icon.value;
        updateImagePreview();
    </script>
</body>

</html>