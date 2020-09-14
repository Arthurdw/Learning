<?php 
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        foreach (explode(PHP_EOL, file_get_contents("./data/data.txt")) as $row) {
            if (explode(";", $row)[0] != $_POST["id"]) {
                $data[] = $row;
            }
        }
        file_put_contents("./data/data.txt", implode(PHP_EOL, $data));
        header("Location: ./index.php");
    }
?>