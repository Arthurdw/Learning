<?php
include('include/Message.php');
include('include/MessageRepository.php');

$messageRepository = new MessageRepository();

const abbriviations = array("LOL", "ROTFLOL", "LMFAO", "YOLO", "WTF", "RTFM", "STFU", "SMH");

session_start();

if ($_SERVER['REQUEST_METHOD'] == "POST") {
    if (isset($_POST['login'])) {
        $_SESSION['user'] = $_POST['username'];
    }
}

if (isset($_POST['send']) || isset($_GET['msg'])) {
    if (isset($_SESSION['user'])) {
        $msg = new Message();

        $msg->setContent(isset($_POST['message']) ? $_POST['message'] : $_GET['msg']);
        $msg->setAuthor($_SESSION['user']);

        $messageRepository->add($msg);
    } else {
        echo "Je moet je eerst inloggen om een berichtje te kunnen vesturen!";
    }
}

if (isset($_GET['action'])) {
    if ($_GET['action'] === "logout") {
        unset($_SESSION['user']);
    }
}

if (isset($_SESSION['user'])) {
    $formDetails = array(
        "name" => "message",
        "placeholder" => "voer je bericht in",
        "submitName" => "send",
        "submitValue" => "Verzend"
    );
} else {
    $formDetails = array(
        "name" => "username",
        "placeholder" => "voer je geberuikersnaam in",
        "submitName" => "login",
        "submitValue" => "Login"
    );
}


?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Chatbox</title>
    <link rel="stylesheet" href="../css/bootstrap.min.css">
    <link rel="stylesheet" href="style.css">
</head>

<body>
    <div class="container">
        <?php if (isset($_SESSION['user'])) : ?>
            <p>
                <a class="btn btn-primary" href="?action=logout">Log out</a>
                (ingelogd als <?php echo $_SESSION['user']; ?>)
            </p>
        <?php endif; ?>
        <form action="index.php" method="post">
            <div class="row">
                <div class="col-xs-9">
                    <input id="width" name="<?php echo $formDetails["name"]; ?>" placeholder="<?php echo $formDetails["placeholder"]; ?>" type="text" class="form-control" required>
                    <br>
                </div>
                <div class="col-xs-3">
                    <input class="form-contrl btn btn-primary" type="submit" name="<?php echo $formDetails["submitName"]; ?>" value="<?php echo $formDetails["submitValue"]; ?>">
                </div>
            </div>
        </form>

        <?php if (isset($_SESSION['user'])) : ?>
            <p class="abbr">
                <?php foreach (abbriviations as $abbr) : ?>
                    <a href="?msg=<?php echo $abbr; ?>"><?php echo $abbr; ?></a>
                <?php endforeach; ?>
            </p>
        <?php endif; ?>

        <?php foreach ($messageRepository->getAll() as $message) : ?>
            <div class="message">
                <p class="content"><?php echo $message->getContent(); ?></p>
                <div class="about">
                    <p class="author"><?php echo $message->getAuthor(); ?></p>
                    <p class="time"><?php echo $message->getTime(); ?></p>
                </div>
            </div>
        <?php endforeach; ?>
    </div>
</body>

</html>