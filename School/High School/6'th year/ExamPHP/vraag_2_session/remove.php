<?php
include("data.php");
$tShirts = getTShirts();

session_start();

if (!isset($_GET['id'])) die("Oops, je moet een ID van een item mee geven!");
if (strval($_GET['id'] > count($tShirts))) die("het gegeven product id bestaat niet!");

if (isset($_SESSION['card'])) {
    $data = unserialize($_SESSION['card']);
    if (!in_array($_GET['id'], $data)) {
        die("Dit item bevind zich niet in het winkelmandje!");
    }
    foreach (array_keys($data, $_GET['id']) as $item) {
        unset($data[$item]);
    }
    $_SESSION['card'] = serialize($data);
} else {
    $_SESSION['card'] = serialize(array($_GET['id']));
}

header("Location: ./card.php");
